using Booking_Movie.ViewModel.Catalog.ActorVM;
using Booking_Movie.ViewModel.Common;

namespace Booking_Movie.Application.Catalog.Actors
{
    public interface IActorService
    {
        Task<Guid> Create(ActorCreateRequest Request);

        Task<List<ActorViewModel>> GetAll();

        Task<PagedResult<ActorViewModel>> GetAllPaging(GetActorPagingRequest pagingRequest, string host);

        Task<ActorViewModel> GetById(Guid id, string host);

        Task<bool> UpdateViewCount(Guid id);

        Task<bool> Delete(Guid id);

        Task<bool> Update(Guid id, ActorUpdateRequest Request);
    }
}