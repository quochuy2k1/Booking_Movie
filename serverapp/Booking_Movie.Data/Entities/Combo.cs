namespace Booking_Movie.Data.Entities
{
    public class Combo
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }

        public ICollection<BookingCombo> BookingCombos { get; set; } = null!;
    }
}