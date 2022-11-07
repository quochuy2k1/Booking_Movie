using Booking_Movie.Data.Abstract;

namespace Booking_Movie.Data.Entities
{
    public class SeatNo : Switchable
    {
        public int Id { get; set; }

        public string SeatId { get; set; } = null!;
        public int AuditoriumId { get; set; }

        public Seat Seat { get; set; } = null!;
        public Auditorium Auditorium { get; set; } = null!;
        public ICollection<SeatReserved> SeatReserveds { get; set; } = null!;
    }
}