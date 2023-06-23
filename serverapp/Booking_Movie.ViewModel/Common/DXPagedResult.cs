namespace Booking_Movie.ViewModel.Common
{
    public class DXPagedResult<T>
    {
        public List<T> Data { get; set; }
        public int TotalCount { get; set; }
        public List<int>? Summary { get; set; }
        public int? GroupCount { get; set; }
    }
}