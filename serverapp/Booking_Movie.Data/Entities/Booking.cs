using Booking_Movie.Data.Abstract;

namespace Booking_Movie.Data.Entities
{
    public class Booking : Switchable
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public string? OrderId { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ScreeningId { get; set; }
        public Guid AppUserId { get; set; }
        public int PaymentMethodId { get; set; }
        public int? CouponId { get; set; }

        public Screening Screening { get; set; } = null!;
        public AppUser AppUser { get; set; } = null!;

        public PaymentMethod PaymentMethod { get; set; } = null!;
        public Coupon Coupon { get; set; } = null!;
        public ICollection<SeatReserved> SeatReserveds { get; set; } = null!;
        public ICollection<BookingCombo> BookingCombos { get; set; } = null!;
        public ICollection<BookingTicket> BookingTickets { get; set; } = null!;
    }
}