using Booking_Movie.ViewModel.Common;
using Booking_Movie.ViewModel.Enums;

namespace Booking_Movie.ViewModel.Catalog.DirectorVM
{
    public class GetDirectorPagingRequest : PagingRequestBase
    {
        public string? Nationality { get; set; }
        public SortByDirector SortBy { get; set; }
    }
}