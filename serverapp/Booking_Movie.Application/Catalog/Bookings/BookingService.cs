using Azure.Core;
using Booking_Movie.Application.Ngrok;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Payment.Momo;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.BookingVM;
using Booking_Movie.ViewModel.Catalog.ChartReportVM;
using Booking_Movie.ViewModel.Catalog.MomoPaymentVM;
using Booking_Movie.ViewModel.Catalog.ReportVM.BookingReportVM;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Booking_Movie.Application.Catalog.Bookings
{
    public class BookingService: IBookingService
    {
        private readonly BookingRepository _bookingRepository;
        private readonly SeatNoRepository _seatNoRepository;
        private readonly IConfiguration _configuration;
        private readonly INgrokHelper _ngrokHelper;
        private readonly IMoMoSecurity _moMoSecurity;
        private readonly IPaymentRequest _paymentRequest;
        private readonly IUnitOfWork unitOfWork;
        private const string MOVIE_CONTENT_FOLDER_NAME = "movie-content"; // new moviey (must first be created)

        public BookingService(BookingRepository actorRepository, SeatNoRepository seatNoRepository, INgrokHelper ngrokHelper, IUnitOfWork unitOfWork, IPaymentRequest paymentRequest, IMoMoSecurity moMoSecurity, IConfiguration configuration)
        {
            this._bookingRepository = actorRepository;
            this._seatNoRepository = seatNoRepository;
            this._ngrokHelper = ngrokHelper;
            this.unitOfWork = unitOfWork;
            this._moMoSecurity = moMoSecurity;
            this._paymentRequest = paymentRequest;
            _configuration = configuration;
        }

        public ResultMomoPaymentViewModel? ConfirmMomoPaymentClient(ResultMomoPaymentViewModel result)
        {
            return result;
        }

        public async Task<List<BookingViewModel>?> GetAllBooking()
        {
            var bookings = await _bookingRepository.GetAllBooking().ToListAsync();
            if (bookings == null) throw new BookingMovieException("Lấy danh sách đặt vé lỗi");

            return bookings;
        }
        
        public async Task<LoadResult> GetAllBookingAdminPaging(GetBookingPagingRequest? request)
        {
            var query =  _bookingRepository.GetAllPagingBookingAdmin(request);

            var bookings = await DataSourceLoader.LoadAsync(query, request);
            if (bookings == null) throw new BookingMovieException("Lấy danh sách đặt vé lỗi");

            return bookings;
        }

        public async Task<List<BookingHistoryViewModel>?> GetBookingByUserId(Guid userId, string host)
        {
            var bookings = await _bookingRepository.GetBookingByUserId(userId).ToListAsync(); 

            if (bookings == null) throw new BookingMovieException("Không tìm thấy đơn đặt vé");

            bookings.ForEach(booking =>
            {
                booking.MovieImage = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/{booking.MovieImage}";
            });

            return bookings;
        }

        public async Task<BookingHistoryViewModel?> GetBookingDetailByUserId(int id, Guid userId, string host)
        {
            var booking = await _bookingRepository.GetBookingDetailByUserId(id, userId).FirstOrDefaultAsync();


            if (booking == null) throw new BookingMovieException("Không tìm thấy đơn đặt vé");

            booking.MovieImage = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/{booking.MovieImage}";
            return booking;
        }

        public async Task<string?> MomoPayment(CreateMomoPaymentRequest request)
        {
            //request params need to request to MoMo system
            string endpoint = _configuration["MomoEndpoint"]!;
            string partnerCode = _configuration["PartnerCode"]!;
            string partnerName = "Berry Cinama";
            string accessKey = _configuration["AccessKey"]!;
            string serectkey = _configuration["Serectkey"]!;
            string orderInfo = request.OrderInfo;
            string redirectUrl = _configuration["RedirectUrl"]!; ;
            string ipnUrl = await _ngrokHelper.CreateEmbeddataWithPublicUrl("/api/bookings/save-payment"); //lưu ý: notifyurl không được sử dụng localhost, có thể sử dụng ngrok để public localhost trong quá trình test

            string amount = request.Amount.ToString();
            string orderId = DateTime.Now.Ticks.ToString(); //mã đơn hàng
            string requestId = DateTime.Now.Ticks.ToString();
            string requestType = "captureWallet";

            request.ExtraData!.OrderId = orderId;
            string extraData = Convert.ToBase64String(Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(request.ExtraData!)));
            string lang = "vi";

            //Before sign HMAC SHA256 signature
            string rawHash = $"accessKey={accessKey}&amount={amount}&extraData={extraData}&ipnUrl={ipnUrl}" +
                $"&orderId={orderId}&orderInfo={orderInfo}&partnerCode={partnerCode}&redirectUrl={redirectUrl}" +
                $"&requestId={requestId}&requestType={requestType}";

            //sign signature SHA256
            string signature = _moMoSecurity.signSHA256(rawHash, serectkey);

            //build body json request
            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "partnerName", partnerName },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderId },
                { "orderInfo", orderInfo },
                { "redirectUrl", redirectUrl },
                { "ipnUrl", ipnUrl },
                { "extraData", extraData },
                { "requestType", requestType },
                { "signature", signature },
                { "lang", lang }

            };
            string responseFromMomo = await _paymentRequest.sendPaymentRequest(endpoint, JsonConvert.SerializeObject(message));

            JObject jmessage = JObject.Parse(responseFromMomo);
            return jmessage.GetValue("payUrl")!.ToString();
        }

        public async Task<int?> SavePayment(ResultMomoPaymentViewModel result)
        {
            try
            {
                var extraData = Encoding.UTF8.GetString(Convert.FromBase64String(result.ExtraData));
                var bookingCreateRequest = JObject.Parse(extraData).ToObject<CreateBookingRequest>();
                var createdDate = DateTime.Now;
                var booking = new Booking()
                {
                    AppUserId = bookingCreateRequest.AppUserId,
                    CouponId = bookingCreateRequest.CouponId,
                    CreatedDate = createdDate,
                    BookingDate = createdDate,
                    ShowDate = bookingCreateRequest.ShowDate,
                    OrderId = bookingCreateRequest.OrderId,
                    PaymentMethodId = bookingCreateRequest.PaymentMethodId,
                    ScreeningId = bookingCreateRequest.ScreeningId,
                    Total = bookingCreateRequest.Total,
                    Status = false,

                };

                var addBooking = await _bookingRepository.SaveMomoPayment(booking);

                if (await unitOfWork.Commit())
                {
                    var addBookingCombo = _bookingRepository.AddBookingCombo(addBooking.Id, bookingCreateRequest.BookingCombo);
                    var addBookingTicket = _bookingRepository.AddBookingTicket(addBooking.Id, bookingCreateRequest.BookingTicket);
                    var addSeatReserved = await _bookingRepository.AddBookingSeatReserved(addBooking.Id, bookingCreateRequest.BookingSeatNo);

                    if (addSeatReserved != null)
                    {
                        foreach (var seatNoId in addSeatReserved)
                        {
                            await _seatNoRepository.UpdateStatus(seatNoId, true);
                        }
                    }

                    await unitOfWork.Commit();
                };
                return booking.Id;


            }
            catch (Exception ex)
            {
                throw new BookingMovieException(ex.Message, ex);
            }
            
        }

        public async Task<BookingHistoryViewModel?> GetBookingDetailByQrCode(string qrContent, string host)
        {
            var booking = await _bookingRepository.GetBookingDetailByQrCode(qrContent).FirstOrDefaultAsync();  

            if (booking == null) throw new BookingMovieException("Không tìm thấy đơn đặt vé");

            booking.MovieImage = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/{booking.MovieImage}";

            return booking;
        }

        public async Task<bool> UpdatePaymentStatus(string orderId, bool status)
        {
            var booking = await _bookingRepository.UpdatePaymentStatus(orderId, status);

            if (booking == null) throw new BookingMovieException("Không tìm thấy đơn đặt hàng với id: " + orderId);

            return await unitOfWork.Commit();
            
        }

        #region ChartReport
        public ScanningRateChartReportViewModel ScanningRateReportChart(ScanningRateChartReportRequest? request)
        {
            try
            {
                var result = _bookingRepository.ScanningRateReportChart(request);
                if (result == null) throw new BookingMovieException("Không thể lấy tỉ lệ quét");
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
