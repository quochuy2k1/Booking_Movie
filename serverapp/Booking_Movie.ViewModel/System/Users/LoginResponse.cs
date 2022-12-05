using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.System.Users
{
    public class LoginResponse
    {
        public string token { get; set; } = null!;
        public DateTime exp { get; set; }
        public string sessionId { get; set; } = null!;
        public LoginUserViewModel appUser { get; set; } = null!;
    }
}
