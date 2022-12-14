using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.BookingVM
{
    public class BookingViewModel
    {
        public int Id { get; set; }
        public decimal Total { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ShowTime { get; set; }
        public bool flagScanner { get; set; }
        public string UserFullName { get; set; }
        public string PaymentMethod { get; set; }
        public int? CouponId { get; set; }
        public string[]? Combos { get; set; }
        public string[]? Tickets { get; set; }
        public string[]? SeatRevered { get; set; }
    }
}
