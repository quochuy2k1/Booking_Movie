using Booking_Movie.ViewModel.Common;
using Booking_Movie.ViewModel.Enums;

namespace Booking_Movie.ViewModel.Catalog.SeatVM
{
    public class GetSeatPagingRequest : PagingRequestBase
    {
        public string Row { get; set; } = null!;
        public int Number { get; set; }
    }
}