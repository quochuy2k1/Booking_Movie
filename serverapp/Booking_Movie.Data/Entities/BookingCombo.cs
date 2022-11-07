using Booking_Movie.Data.Abstract;

namespace Booking_Movie.Data.Entities
{
    public class BookingCombo : Switchable
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public int ComboId { get; set; }
        public int BookingId { get; set; }

        public Combo Combo { get; set; } = null!;
        public Booking Booking { get; set; } = null!;
    }
}