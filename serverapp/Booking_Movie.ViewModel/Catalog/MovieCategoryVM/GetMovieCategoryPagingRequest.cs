using Booking_Movie.ViewModel.Common;
using Booking_Movie.ViewModel.Enums;

namespace Booking_Movie.ViewModel.Catalog.MovieCategoryVM
{
    public class GetMovieCategoryPagingRequest : PagingRequestBase
    {
        public SortByMovieCategory SortBy { get; set; }
    }
}