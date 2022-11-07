namespace Booking_Movie.ViewModel.Common
{
    public class PagedResult<T>
    {
        public List<T> Result { get; set; } = null!;
        public int Total { get; set; }
    }
}