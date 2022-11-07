using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.TicketVM
{
    public class TicketUpdateRequest
    {
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }


    }
}