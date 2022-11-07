using Booking_Movie.ViewModel.Catalog.DirectorVM;
using Booking_Movie.ViewModel.Common;

namespace Booking_Movie.Application.Catalog.Directors
{
    public interface IDirectorService
    {
        Task<Guid> Create(DirectorCreateRequest Request);

        Task<List<DirectorViewModel>> GetAll();

        Task<PagedResult<DirectorViewModel>> GetAllPaging(GetDirectorPagingRequest pagingRequest, string host);

        Task<DirectorViewModel> GetById(Guid id);

        Task<bool> UpdateViewCount(Guid id);

        Task<bool> Delete(Guid id);

        Task<bool> Update(Guid id, DirectorUpdateRequest Request);
    }
}