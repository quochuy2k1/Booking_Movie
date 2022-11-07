namespace Booking_Movie.Data.Entities
{
    public class ScreeningType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public ICollection<Screening> Screenings { get; set; } = null!;
    }
}