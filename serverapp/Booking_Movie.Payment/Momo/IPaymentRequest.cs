using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Payment.Momo
{
    public interface IPaymentRequest
    {
        Task<string> sendPaymentRequest(string endpoint, string postJsonString);
    }
}
