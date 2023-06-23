namespace Booking_Movie.ViewModel.Catalog.ReportVM.TicketComboReportVM
{
    public class TicketComboReportViewModel
    {
        public string? Id { get; set; }
        public int? CinemaId { get; set; }
        public string? CinemaName { get; set; }
        public int? MovieId { get; set; }
        public string? MovieName { get; set; }
        public int? AuditoriumId { get; set; }
        public string? AuditoriumName { get; set; }
        public int? TicketId { get; set; }
        public string? TicketName { get; set; }
        public decimal? TicketPrice { get; set; }
        public int? ComboId { get; set; }
        public string? ComboName { get; set; }
        public decimal? ComboPrice { get; set; }
        public decimal? TotalCombo { get; set; }
        public decimal? TotalTicket { get; set; }

        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public DateTime? BookingDate { get; set; }

        public int? TicketQuantity { get; set; }
        public int? ComboQuantity { get; set; }
        public int? TicketQuantityTotal { get; set; }
        public int? ComboQuantityTotal { get; set; }
        public decimal? TicketRevenueTotal { get; set; }
        public decimal? ComboRevenueTotal { get; set; }
    }
}