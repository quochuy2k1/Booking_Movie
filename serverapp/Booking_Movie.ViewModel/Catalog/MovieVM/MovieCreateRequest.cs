using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.MovieVM
{
    public class MovieCreateRequest
    {
        public string Name { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Content { get; set; } = null!;
        public IFormFile? ImageReview { get; set; }
        public IFormFile? ImageBackground { get; set; }
        public bool Status { get; set; }
        public IFormFile? VideoTrailer { get; set; } = null!;

        //public Guid DirectorId { get; set; }
        public int MovieCategoryId { get; set; }
        public string NationalityId { get; set; }
        public Guid ProducerId { get; set; }

    }
}