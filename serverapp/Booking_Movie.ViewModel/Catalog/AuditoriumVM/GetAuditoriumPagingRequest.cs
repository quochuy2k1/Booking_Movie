using Booking_Movie.ViewModel.Common;

namespace Booking_Movie.ViewModel.Catalog.AuditoriumVM
{
    public class GetAuditoriumPagingRequest : PagingRequestBase
    {
        public int? CinemaId { get; set; }
    }
}