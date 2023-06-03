using Booking_Movie.Data.Abstract;

namespace Booking_Movie.Data.Entities
{
    public class Cinema : Editable
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int LocationId { get; set; }
        public string? Address { get; set; }

        public Location Location { get; set; } = null!;
        public ICollection<Auditorium> Auditoriums { get; set; } = null!;
    }
}