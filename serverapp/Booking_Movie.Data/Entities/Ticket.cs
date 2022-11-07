namespace Booking_Movie.Data.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public virtual ICollection<BookingTicket> BookingTickets { get; set; } = null!;
    }
}