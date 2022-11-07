namespace Booking_Movie.Data.Entities
{
    public class Screening
    {
        public int Id { get; set; }
        public DateTime ShowTime { get; set; }

        public int AuditoriumId { get; set; }
        public int MovieId { get; set; }
        public int MovieTypeId { get; set; }

        public Auditorium Auditorium { get; set; } = null!;
        public Movie Movie { get; set; } = null!;
        public ScreeningType MovieType { get; set; } = null!;
        public ICollection<Booking> Bookings { get; set; } = null!;
    }
}