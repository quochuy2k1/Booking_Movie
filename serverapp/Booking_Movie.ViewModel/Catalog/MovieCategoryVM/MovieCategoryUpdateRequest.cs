using Booking_Movie.ViewModel.Abstract;
using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.MovieCategoryVM
{
    public class MovieCategoryUpdateRequest : Editable
    {
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public int? ParentId { get; set; }
        public int? DisplayOrder { get; set; }

        public IFormFile? Image { get; set; } = null!;

        public bool HomeFlag { get; set; }
    }
}