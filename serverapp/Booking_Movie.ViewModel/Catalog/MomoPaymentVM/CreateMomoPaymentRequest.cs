using Booking_Movie.ViewModel.Catalog.BookingVM;

namespace Booking_Movie.ViewModel.Catalog.MomoPaymentVM
{
    public class CreateMomoPaymentRequest
    {
        public string? OrderInfo { get; set; }
        public decimal Amount { get; set; }
        public CreateBookingRequest? ExtraData { get; set; }
    }
}