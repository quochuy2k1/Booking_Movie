namespace Booking_Movie.ViewModel.System.Users
{
    public class LoginUserViewModel
    {
        public string UserName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public List<string> Roles { get; set; } = null!;
    }
}