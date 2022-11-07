using Booking_Movie.ViewModel.Catalog.ProducerVM;
using Booking_Movie.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Producers
{
    public interface IProducerService
    {
        Task<Guid> Create(ProducerCreateRequest Request);

        Task<List<ProducerViewModel>> GetAll();

        Task<PagedResult<ProducerViewModel>> GetAllPaging(GetMovieCategoryPagingRequest pagingRequest, string host);

        Task<ProducerViewModel> GetById(Guid id);

        Task<bool> Delete(Guid id);

        Task<bool> Update(Guid id, ProducerUpdateRequest Request);
    }
}
