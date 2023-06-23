using Booking_Movie.ViewModel.Common;

namespace Booking_Movie.ViewModel.Catalog.MovieVM
{
    public class GetMoviePagingRequest : PagingRequestBase
    {
        public string? Nationality { get; set; }
        public bool? CommingSoon { get; set; }
        public bool? IsShowing { get; set; }
        //public Guid? DirectorId { get; set; }
        //public int? MovieCategoryId { get; set; }
        //public Guid? ProducerId { get; set; }
    }

    public class GetMoviePagingAdminRequest : DXPagingRequestBase
    {
        public string? MovieId { get; set; }
        //public Guid? DirectorId { get; set; }
        //public int? MovieCategoryId { get; set; }
        //public Guid? ProducerId { get; set; }
    }
}