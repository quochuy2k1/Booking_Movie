namespace Booking_Movie.ViewModel.Catalog.ReportVM.MovieReportVM
{
    public class MovieRevenueViewModel
    {
        public string? Id { get; set; }
        public int? MovieId { get; set; }
        public string? MovieName { get; set; }
        public int? CinemaId { get; set; }
        public string? CinemaName { get; set; }
        public int? AuditoriumId { get; set; }
        public string? AuditoriumName { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public DateTime? BookingDate { get; set; }
        public decimal? Total { get; set; }
    }
}