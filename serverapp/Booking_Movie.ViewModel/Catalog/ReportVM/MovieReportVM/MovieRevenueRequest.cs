using Booking_Movie.ViewModel.Common;

namespace Booking_Movie.ViewModel.Catalog.ReportVM.MovieReportVM
{
    public class MovieRevenueRequest : DXPagingRequestBase
    {
        public int? MovieId { get; set; }
        public int? CinemaId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}