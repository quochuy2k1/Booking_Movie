using Booking_Movie.Data.Abstract;

namespace Booking_Movie.Data.Entities
{
    public class PaymentMethod : Editable
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Alias { get; set; }
        public decimal? Cost { get; set; }
        public decimal? CostAdditional { get; set; }

        public bool Status { get; set; }

        public ICollection<Booking> Bookings { get; set; } = null!;
    }
}