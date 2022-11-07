namespace Booking_Movie.ViewModel.System.Users
{
    public class LoginRequest
    {
        public string UserName { get; set; } = null!;

        public string Password { get; set; } = null!;

        public bool? RememberMe { get; set; }
    }
}