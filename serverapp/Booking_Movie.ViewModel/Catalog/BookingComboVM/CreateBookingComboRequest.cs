using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.BookingComboVM
{
    public class CreateBookingComboRequest
    {
        public int ComboId { get; set; } 
        public int Quantity { get; set; } 
        public decimal Total { get; set; } 
    }
}
