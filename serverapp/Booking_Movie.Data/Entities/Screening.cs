namespace Booking_Movie.Data.Entities
{
    public class Screening
    {
        public int Id { get; set; }
        public string ShowTimeId { get; set; }

        public int AuditoriumId { get; set; }
        public int MovieId { get; set; }
        public int ScreeningTypeId { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }


        public Auditorium Auditorium { get; set; } = null!;
        public Movie Movie { get; set; } = null!;
        public ScreeningType ScreeningType { get; set; } = null!;
        public ShowTime ShowTime { get; set; } = null!;
        public ICollection<Booking> Bookings { get; set; } = null!;
        public ICollection<ScreeningTicket> ScreeningTickets { get; set; } = null!;
    }
}