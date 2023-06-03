using Booking_Movie.ViewModel.Common;
using Booking_Movie.ViewModel.Enums;

namespace Booking_Movie.ViewModel.Catalog.AuditoriumVM
{
    public class GetAuditoriumPagingRequest : PagingRequestBase
    {
        public int? CinemaId { get; set; }
    }
}