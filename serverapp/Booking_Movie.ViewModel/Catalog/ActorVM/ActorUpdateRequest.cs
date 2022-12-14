using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.ActorVM
{
    public class ActorUpdateRequest
    {
        public string? Name { get; set; }
        public string? NationalityId { get; set; } 
        public float? Height { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public IFormFile? Image { get; set; }
    }
}