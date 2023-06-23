using Booking_Movie.Application.Catalog.Actors;
using Booking_Movie.Application.Catalog.Bookings;
using Booking_Movie.Utilities.Constants;
using Booking_Movie.ViewModel.Catalog.BookingVM;
using Booking_Movie.ViewModel.Catalog.MomoPaymentVM;
using Booking_Movie.ViewModel.Catalog.ReportVM.BookingReportVM;
using Booking_Movie.ViewModel.Catalog.ReportVM.MovieReportVM;
using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IWebHostEnvironment webHostEnvironment;


        public BookingsController(IBookingService bookingService, IWebHostEnvironment webHostEnvironment)
        {
            _bookingService = bookingService;
            this.webHostEnvironment = webHostEnvironment;

        }

        [HttpGet("get-all-booking")]
        public async Task<IActionResult> GetAllBooking()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var bookings = await _bookingService.GetAllBooking();
                return Ok(bookings);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        
        [HttpPost("get-all-booking-admin-paging")]
        public async Task<IActionResult> GetAllBookingAdminPaging([FromForm] GetBookingPagingRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                
                    var sort = Request.Form["sort"];
                    var filter = Request.Form["filter"];
                    var group = Request.Form["group"];

                    if (!String.IsNullOrEmpty(filter))
                    {
                        request.Filter = JsonConvert.DeserializeObject<IList>(filter);
                    }

                    if (!String.IsNullOrEmpty(sort))
                    {
                        request.Sort = JsonConvert.DeserializeObject<SortingInfo[]>(sort);
                    }
                    if (!String.IsNullOrEmpty(group))
                    {
                        request.Group = JsonConvert.DeserializeObject<GroupingInfo[]>(group);
                    }
                    var bookings = await _bookingService.GetAllBookingAdminPaging(request);
                return Ok(bookings);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("get-booking-history/user/{userId}")]
        public async Task<IActionResult> GetBookingHistory(Guid userId)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var host = $"{Request.Scheme}://{Request.Host}";
                var bookings = await _bookingService.GetBookingByUserId(userId, host);
                return Ok(bookings);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}/get-booking-detail/user/{userId}")]
        public async Task<IActionResult> GetBookingDetailByUserId(int id, Guid userId)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var host = $"{Request.Scheme}://{Request.Host}";
                var booking = await _bookingService.GetBookingDetailByUserId(id, userId, host);
                return Ok(booking);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("get-booking-qr-code/")]
        [Authorize]
        public async Task<IActionResult> GetBookingDetailByQrCode(string qrContent)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var host = $"{Request.Scheme}://{Request.Host}";
                var booking = await _bookingService.GetBookingDetailByQrCode(qrContent, host);
                return Ok(booking);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("momo-payment")]
        [Authorize]
        public async Task<IActionResult> MomoPayment(CreateMomoPaymentRequest request)
        {
            try
            {
                var session = HttpContext.Session.GetString("Token");
                var momo = await _bookingService.MomoPayment(request);
                if (momo == null) return BadRequest("Thanh toán không thành công.");
                return Ok(momo);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("comfirm-momo-payment")]
        public IActionResult ConfirmMomoPaymentClient([FromQuery] ResultMomoPaymentViewModel result)
        {
            try
            {
                var momo = _bookingService.ConfirmMomoPaymentClient(result);
                if (momo == null) return BadRequest("Thanh toán không thành công.");
                return Redirect("http://localhost:3000/user/history-booking/");

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("save-payment")]
        public async Task SavePayment([FromBody] object request)
        {
            //cập nhật dữ liệu vào db
            try
            {
                var restult = JObject.Parse(request.ToString()!).ToObject<ResultMomoPaymentViewModel>();
                var booking = await _bookingService.SavePayment(restult!);
            }
            catch (Exception)
            {
                

            }

        }

        [HttpPatch("{orderId}/update-payment-status")]
        [Authorize]
        public async Task<IActionResult> UpdatePaymentStatus(string orderId, [FromBody] BookingUpdateStatusPaymentViewModel request)
        {
            //cập nhật dữ liệu vào db
            if(!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var booking = await _bookingService.UpdatePaymentStatus(orderId, request.status);
                if (booking == false) return BadRequest("Cập nhật đơn đặt vé không thành công.");
                return Ok(booking);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        #region ChartReport

        [HttpPost("scanning-rate-chart-report")]
        public IActionResult ScanningRateReportChart([FromBody] ScanningRateChartReportRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                var result = _bookingService.ScanningRateReportChart(request);
                if (result == null) return BadRequest(new { Status = StatusResponseConstant.FAILED, Message = StatusMessageResponseConstant.GET_ERROR });
                return Ok(result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

    }

}
