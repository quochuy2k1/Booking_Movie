using Booking_Movie.ViewModel.Catalog.ScreeningTypeVM;

namespace Booking_Movie.Application.Catalog.ScreeningTypes
{
    public interface IScreeningTypeService
    {
        Task<List<ScreeningTypeViewModel>?> GetAllScreeningType();
    }
}