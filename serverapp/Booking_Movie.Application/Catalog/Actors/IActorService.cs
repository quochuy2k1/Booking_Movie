using Booking_Movie.ViewModel.Catalog.ActorVM;
using Booking_Movie.ViewModel.Common;

namespace Booking_Movie.Application.Catalog.Actors
{
    public interface IActorService
    {
        Task<Guid> Create(ActorCreateRequest Request);

        Task<List<ActorViewModel>> GetAll(string host);

        Task<PagedResult<ActorViewModel>> GetAllPaging(GetActorPagingRequest pagingRequest, string host);

        Task<ActorViewModel> GetById(Guid id, string host);

        Task<bool> UpdateViewCount(Guid id);

        Task<List<Guid>?> Delete(Guid[] id);

        Task<Guid> Update(Guid id, ActorUpdateRequest Request);

        Task<int?> CreateActorImage(Guid id, ActorImageCreateRequest request);
        Task<int?> UpdateActorImage(int id, Guid actorId, ActorImageUpdateRequest request);
        Task<List<ActorImageViewModel>?> GetAllActorImage(Guid actorId, string host);

        Task<ActorImageViewModel?> GetActorImageDetail(int id, Guid actorId, string host);
    }
}