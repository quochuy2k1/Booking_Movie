using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.MovieVM
{
    public class MovieUpdateImageVideoRequest
    {
        public IFormFile? preview { get; set; }
        public IFormFile? video { get; set; }
        public IFormFile? background { get; set; }
    }
}