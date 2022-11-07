namespace Booking_Movie.Data.Entities
{
    public class Auditorium
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public int CinemaId { get; set; }

        public Cinema Cinema { get; set; } = null!;
        public ICollection<Screening> Screenings { get; set; } = null!;
        public ICollection<SeatNo> SeatNos { get; set; } = null!;
    }
}