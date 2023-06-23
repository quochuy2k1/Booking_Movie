using Booking_Movie.ViewModel.Common;

namespace Booking_Movie.ViewModel.Catalog.ComboVM
{
    public class GetComboPagingRequest : PagingRequestBase
    {
        public decimal Price { get; set; }
    }
}