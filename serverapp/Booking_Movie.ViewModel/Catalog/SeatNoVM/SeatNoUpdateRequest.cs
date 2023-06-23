using Booking_Movie.ViewModel.Abstract;

namespace Booking_Movie.ViewModel.Catalog.SeatNoVM
{
    public class SeatNoUpdateRequest : Switchable
    {
        public string SeatId { get; set; } = null!;
        public int AuditoriumId { get; set; }
        public int? SeatStyleId { get; set; }

        public int? RowIndex { get; set; }
        public int? ColumnIndex { get; set; }
    }
}