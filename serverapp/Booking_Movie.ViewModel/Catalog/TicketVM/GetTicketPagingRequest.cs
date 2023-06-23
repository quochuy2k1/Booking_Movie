using Booking_Movie.ViewModel.Common;

namespace Booking_Movie.ViewModel.Catalog.TicketVM
{
    public class GetTicketPagingRequest : PagingRequestBase
    {
        public int? MovieId { get; set; }
    }
}