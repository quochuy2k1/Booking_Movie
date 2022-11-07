using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.SeatVM
{
    public class SeatCreateRequest
    {
        public int Id { get; set; }
        public string Row { get; set; } = null!;
        public int Number { get; set; }

    }
}