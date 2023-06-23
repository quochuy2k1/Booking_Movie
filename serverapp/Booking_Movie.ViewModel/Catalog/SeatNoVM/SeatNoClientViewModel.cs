namespace Booking_Movie.ViewModel.Catalog.SeatNoVM
{
    public class SeatNoClientViewModel
    {
        public string? Id { get; set; }
        public int? AuditoriumId { get; set; }
        public string? SeatId { get; set; }
        public int? SeatNoId { get; set; }
        public string Row { get; set; }
        public int Number { get; set; }
        public int? RowIndex { get; set; }
        public int? ColumnIndex { get; set; }
        public int? SeatStyle { get; set; }
        public bool? Status { get; set; }
    }
}