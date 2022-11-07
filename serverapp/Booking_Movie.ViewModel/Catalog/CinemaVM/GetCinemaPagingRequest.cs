using Booking_Movie.ViewModel.Common;
using Booking_Movie.ViewModel.Enums;

namespace Booking_Movie.ViewModel.Catalog.CinemaVM
{
    public class GetCinemaPagingRequest : PagingRequestBase
    {
        public string Location { get; set; } = null!;
    }
}