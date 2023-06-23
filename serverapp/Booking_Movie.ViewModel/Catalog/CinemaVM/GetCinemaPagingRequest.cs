using Booking_Movie.ViewModel.Common;

namespace Booking_Movie.ViewModel.Catalog.CinemaVM
{
    public class GetCinemaPagingRequest : PagingRequestBase
    {
        public string? Name { get; set; }
    }

    public class GetCinemaPagingAdminRequest : DXPagingRequestBase
    {
        public string? LocationId { get; set; }
        //public Guid? DirectorId { get; set; }
        //public int? MovieCategoryId { get; set; }
        //public Guid? ProducerId { get; set; }
    }
}