namespace Booking_Movie.ViewModel.Catalog.SeatNoVM
{
    public class SeatNoViewModel
    {
        public int Id { get; set; }

        public string SeatId { get; set; } = null!;
        public string AuditoriumName { get; set; }
        public string? SeatStyleName { get; set; }

        public int? RowIndex { get; set; }
        public int? ColumnIndex { get; set; }
    }
}