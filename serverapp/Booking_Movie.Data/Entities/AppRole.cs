namespace Booking_Movie.Data.Entities
{
    public class AppRole : Microsoft.AspNetCore.Identity.IdentityRole<Guid>
    {
        public AppRole(string Name) : base(Name)
        {
        }

        public string Description { get; set; } = null!;
    }
}