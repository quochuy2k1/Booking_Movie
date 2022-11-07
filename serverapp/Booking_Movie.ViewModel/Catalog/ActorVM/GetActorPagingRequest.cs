using Booking_Movie.ViewModel.Common;
using Booking_Movie.ViewModel.Enums;

namespace Booking_Movie.ViewModel.Catalog.ActorVM
{
    public class GetActorPagingRequest : PagingRequestBase
    {
        public string? Nationality { get; set; }
        public SortByActor SortBy { get; set; }
    }
}