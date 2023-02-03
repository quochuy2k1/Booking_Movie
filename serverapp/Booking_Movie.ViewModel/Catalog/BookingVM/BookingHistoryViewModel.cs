using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.BookingVM
{
    public class BookingHistoryViewModel
    {
        public string QrContent { get; set; } = null!;
        public string OrderId { get; set; } = null!;
        public string MovieName { get; set; } = null!;
        public string MovieImage { get; set; } = null!;
        public string CinemaName { get; set; } = null!;
        public string AuditoriumName { get; set; } = null!;
        public decimal Total { get; set; }
        
        [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
        public bool Status { get; set; }
        public DateTime ShowTime { get; set; }
        public DateTime BookingDate { get; set; }
        public List<BookingComboViewModel> BookingCombo { get; set; } = null!;
        public List<BookingTicketViewModel>BookingTicket { get; set; } = null!;
        public List<string> BookingSeats { get; set; } = null!;
    }

    public class BookingComboViewModel
    {
        public string Name { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class BookingTicketViewModel
    {
        public string Name { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
