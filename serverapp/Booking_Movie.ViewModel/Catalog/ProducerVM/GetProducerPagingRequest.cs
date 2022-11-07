using Booking_Movie.ViewModel.Common;
using Booking_Movie.ViewModel.Enums;

namespace Booking_Movie.ViewModel.Catalog.ProducerVM
{
    public class GetMovieCategoryPagingRequest : PagingRequestBase
    {
        public string? Nationality { get; set; }
        public SortByProducer SortBy { get; set; }
    }
}