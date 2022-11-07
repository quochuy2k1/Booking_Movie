using Booking_Movie.ViewModel.Common;
using Booking_Movie.ViewModel.Enums;

namespace Booking_Movie.ViewModel.Catalog.TicketVM
{
    public class GetTicketPagingRequest : PagingRequestBase
    {
        public decimal Price { get; set; }

    }
}