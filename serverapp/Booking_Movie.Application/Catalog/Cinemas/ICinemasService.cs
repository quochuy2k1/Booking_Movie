using Booking_Movie.ViewModel.Catalog.AuditoriumVM;
using Booking_Movie.ViewModel.Catalog.CinemaVM;
using Booking_Movie.ViewModel.Common;
using DevExtreme.AspNet.Data.ResponseModel;

namespace Booking_Movie.Application.Catalog.Cinemas
{
    public interface ICinemasService
    {
        Task<List<AuditoriumViewModel>> GetAuditoriumByCinemaId(int cinemaId);
        Task<List<CinemaViewModel>> GetAllCinema();
        Task<PagedResult<CinemaViewModel>> GetAllPaging(GetCinemaPagingRequest pagingRequest, string host);
        Task<LoadResult> GetAllPagingAdmin(GetCinemaPagingAdminRequest pagingRequest, string host);
    }
}
