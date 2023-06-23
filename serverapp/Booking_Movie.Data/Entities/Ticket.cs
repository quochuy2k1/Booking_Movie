namespace Booking_Movie.Data.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public int? TicketTypeId { get; set; }
        public string? Name { get; set; }
        public int MovieId { get; set; }
        public string ValidityDateFromId { get; set; } = null!;
        public string ValidityDateToId { get; set; } = null!;
        public string? Description { get; set; }

        public decimal Price { get; set; }

        public Movie Movie { get; set; } = null!;
        public ShowTime ValidityDateFrom { get; set; } = null!;
        public ShowTime ValidityDateTo { get; set; } = null!;
        public TicketType TicketType { get; set; }
        public virtual ICollection<BookingTicket> BookingTickets { get; set; } = null!;
        //public virtual ICollection<ScreeningTicket> ScreeningTickets { get; set; } = null!;
    }
}