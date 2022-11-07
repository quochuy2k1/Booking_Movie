using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.ProducerVM
{
    public class ProducerUpdateRequest
    {
        public string Name { get; set; } = null!;
        public string NationalityId { get; set; } = null!;

        public IFormFile? Image { get; set; }
    }
}