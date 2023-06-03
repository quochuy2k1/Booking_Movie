using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Data.Entities
{
    public class ScreeningTicket
    {
        public int Id { get; set; }
        public int ScreeningId { get; set; }
        public int TicketId { get; set; }
        public decimal Price { get; set; }

        public Screening Screening { get; set; } = null!;
        public Ticket Ticket { get; set; } = null!;

        public ICollection<BookingTicket> BookingTickets { get; set; } = null!;
    }
}
