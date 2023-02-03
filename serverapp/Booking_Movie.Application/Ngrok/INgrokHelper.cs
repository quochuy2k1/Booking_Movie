using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Ngrok
{
    public interface INgrokHelper
    {
        Task Init();
        Task<string?> CreateEmbeddataWithPublicUrl(string url);
    }
}
