using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.MovieTypeVM
{
    public class MovieTypeCreateRequest
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

    }
}