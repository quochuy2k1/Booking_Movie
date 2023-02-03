using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.BookingTicketVM
{
    public class CreateBookingTicketRequest
    {
        public int TicketId { get; set; } 
        public int Quantity { get; set; } 
        public decimal Total { get; set; }
    }
}
