using Booking_Movie.ViewModel.Catalog.BookingComboVM;
using Booking_Movie.ViewModel.Catalog.BookingTicketVM;
using Booking_Movie.ViewModel.Catalog.SeatReservedVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.BookingVM
{
    public class CreateBookingRequest
    {
        public decimal Total { get; set; }
        [JsonIgnore]
        public string? OrderId { get; set; }
        public int ScreeningId { get; set; }
        public Guid AppUserId { get; set; }
        public int PaymentMethodId { get; set; }
        public int? CouponId { get; set; }
        public CreateBookingComboRequest[] BookingCombo { get; set; } = null!;
        public CreateBookingTicketRequest[] BookingTicket { get; set; } = null!;
        public CreateSeatReservedRequest[] BookingSeatNo { get; set; } = null!;

    }


}
