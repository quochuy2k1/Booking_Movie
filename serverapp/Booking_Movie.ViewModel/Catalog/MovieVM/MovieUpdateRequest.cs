using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.MovieVM
{
    public class MovieUpdateRequest
    {
        public string Name { get; set; } = null!;
        public TimeSpan Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Content { get; set; } = null!;
        public IFormFile? VideoTrailer { get; set; } = null!;

        public Guid DirectorId { get; set; }
        public int MovieCategoryId { get; set; }
        public Guid ProducerId { get; set; }

    }
}