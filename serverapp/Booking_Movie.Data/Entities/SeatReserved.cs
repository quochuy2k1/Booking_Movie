using Booking_Movie.Data.Abstract;

namespace Booking_Movie.Data.Entities
{
    public class SeatReserved : Switchable
    {
        public int Id { get; set; }
        public int? SeatNoId { get; set; }
        public int BookingId { get; set; }

        public SeatNo SeatNo { get; set; } = null!;
        public Booking Booking { get; set; } = null!;
    }
}