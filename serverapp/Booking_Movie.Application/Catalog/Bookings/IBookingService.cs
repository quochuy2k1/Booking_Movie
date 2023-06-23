using Booking_Movie.ViewModel.Catalog.BookingVM;
using Booking_Movie.ViewModel.Catalog.ChartReportVM;
using Booking_Movie.ViewModel.Catalog.MomoPaymentVM;
using Booking_Movie.ViewModel.Catalog.ReportVM.BookingReportVM;
using DevExtreme.AspNet.Data.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Bookings
{
    public interface IBookingService
    {
        Task<List<BookingViewModel>?> GetAllBooking();
        Task<LoadResult> GetAllBookingAdminPaging(GetBookingPagingRequest? request);
        Task<List<BookingHistoryViewModel>?> GetBookingByUserId(Guid userId, string host);
        Task<BookingHistoryViewModel?> GetBookingDetailByUserId(int id, Guid userId, string host);
        Task<BookingHistoryViewModel?> GetBookingDetailByQrCode(string qrContent, string host);
        Task<string?> MomoPayment(CreateMomoPaymentRequest request);
        Task<int?> SavePayment(ResultMomoPaymentViewModel result);
        ResultMomoPaymentViewModel? ConfirmMomoPaymentClient(ResultMomoPaymentViewModel result);

        Task<bool> UpdatePaymentStatus(string orderId, bool status);

        #region ChartReport

        ScanningRateChartReportViewModel ScanningRateReportChart(ScanningRateChartReportRequest? request);

        #endregion
    }
}
