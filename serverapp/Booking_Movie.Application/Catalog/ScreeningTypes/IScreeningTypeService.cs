using Booking_Movie.ViewModel.Catalog.MovieTypeVM;
using Booking_Movie.ViewModel.Catalog.ScreeningTypeVM;
using Booking_Movie.ViewModel.Common;

namespace Booking_Movie.Application.Catalog.ScreeningTypes
{
    public interface IScreeningTypeService
    {
        Task<List<ScreeningTypeViewModel>?> GetAllScreeningType();
        Task<PagedResult<ScreeningTypeViewModel>> GetAllPaging(GetScreeningTypePagingRequest pagingRequest);

    }
}