using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.ActorVM
{
    public class ActorImageUpdateRequest
    {
        public IFormFile? Image { get; set; }
        public bool? IsDefault { get; set; }
        public int? SortOrder { get; set; }
    }
}