using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.MovieVM
{
    public class MovieUpdateRequest
    {
        public string? Name { get; set; }
        public string? Alias { get; set; }
        public int? Duration { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? Content { get; set; }
        public IFormFile? ImagePreview { get; set; }
        public IFormFile? ImageBackground { get; set; }
        public bool? Status { get; set; }
        public IFormFile? VideoTrailer { get; set; }

        public bool? CommingSoon { get; set; }
        public bool? IsShowing { get; set; }

        public string? NationalityId { get; set; }
        public Guid? ProducerId { get; set; }

        public Guid[]? ActorId { get; set; } = null!;
        public int[]? CategoryId { get; set; } = null!;
        public Guid[]? DirectorId { get; set; } = null!;
    }
}