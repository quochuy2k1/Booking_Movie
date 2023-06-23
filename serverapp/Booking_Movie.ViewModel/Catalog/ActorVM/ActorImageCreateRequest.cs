using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.ActorVM
{
    public class ActorImageCreateRequest
    {
        public IFormFile Image { get; set; } = null!;
        public bool? IsDefault { get; set; }
        public int? SortOrder { get; set; }
    }
}