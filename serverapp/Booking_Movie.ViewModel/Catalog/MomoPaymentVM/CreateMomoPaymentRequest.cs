using Booking_Movie.ViewModel.Catalog.BookingVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.MomoPaymentVM
{
    public class CreateMomoPaymentRequest
    {
        public string? OrderInfo { get; set; }
        public decimal Amount { get; set; }
        public CreateBookingRequest? ExtraData { get; set; }
    }
}
