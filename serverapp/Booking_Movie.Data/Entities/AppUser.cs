namespace Booking_Movie.Data.Entities
{
    public class AppUser : Microsoft.AspNetCore.Identity.IdentityUser<Guid>
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public List<Booking> Bookings { get; set; } = null!;
    }
}