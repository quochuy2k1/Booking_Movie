using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.CinemaVM
{
    public class CinemaCreateRequest
    {
        public string Name { get; set; } = null!;
        public string Location { get; set; } = null!;

    }
}