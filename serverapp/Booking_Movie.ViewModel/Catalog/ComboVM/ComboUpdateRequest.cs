using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.ComboVM
{
    public class ComboUpdateRequest
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }

    }
}