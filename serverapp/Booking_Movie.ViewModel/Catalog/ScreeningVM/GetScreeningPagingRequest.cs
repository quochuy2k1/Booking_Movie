using Booking_Movie.ViewModel.Common;

namespace Booking_Movie.ViewModel.Catalog.ScreeningVM
{
    public class GetScreeningPagingRequest : DXPagingRequestBase
    {
        public int? MovieId { get; set; }
        public int? CinemaId { get; set; }
    }
}