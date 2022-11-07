using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.MovieVM
{
    public class MovieUpdateImageVideoRequest
    {
        public IFormFile? preview { get; set; } 
        public IFormFile? video { get; set; } 
        public IFormFile? background { get; set; } 
    }
}
