namespace Booking_Movie.Data.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<BookingTicket> BookingTickets { get; set; } = null!;
        public virtual ICollection<ScreeningTicket> ScreeningTickets { get; set; } = null!;
    }
}