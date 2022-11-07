using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.ComboVM
{
    public class ComboCreateRequest
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }

    }
}