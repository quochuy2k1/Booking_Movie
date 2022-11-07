namespace Booking_Movie.Data.Entities
{
    public class Coupon
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public decimal Discount { get; set; }
        public int AvailableQuantity { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public bool Status { get; set; }

        public ICollection<Booking> Bookings { get; set; } = null!;
    }
}