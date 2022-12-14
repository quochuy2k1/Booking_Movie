using Booking_Movie.ViewModel.System.Users;

namespace Booking_Movie.Application.System.Users
{
    public interface IUserService
    {
        Task<LoginResponse> Authenticate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
        Task<bool> RegisterAdmin(RegisterRequest request);

    }
}