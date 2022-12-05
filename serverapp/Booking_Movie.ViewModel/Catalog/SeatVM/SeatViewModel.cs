using Booking_Movie.ViewModel.Enums;

namespace Booking_Movie.ViewModel.Catalog.SeatVM
{
    public class SeatViewModel
    {
        public string Id { get; set; } = null!;
        public string Row { get; set; } = null!;
        public int Number { get; set; }
        public int? RowIndex { get; set; }
        public int? ColumnIndex { get; set; }
        public int? SeatStyle { get; set; }
        public bool? Status { get; set; }
    }
}