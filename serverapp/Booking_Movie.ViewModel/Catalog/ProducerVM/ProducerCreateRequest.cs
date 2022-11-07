using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.ProducerVM
{
    public class ProducerCreateRequest
    {
        public Guid ID { get; set; }
        public string Name { get; set; } = null!;
        public string NationalityId { get; set; } = null!;

        public IFormFile? Image { get; set; }
    }
}