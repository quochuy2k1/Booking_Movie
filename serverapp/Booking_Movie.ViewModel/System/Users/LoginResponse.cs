using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.System.Users
{
    public class LoginResponse
    {
        public string? token { get; set; }
        public DateTime? exp { get; set; }
        public string? sessionId { get; set; }
        public LoginUserViewModel? appUser { get; set; }
        public LoginErrorResponse? error {get; set;}
    }
}
