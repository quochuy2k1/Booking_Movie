namespace Booking_Movie.ViewModel.Common
{
    public class PagingRequestBase : RequestBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}