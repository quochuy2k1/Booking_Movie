using Booking_Movie.ViewModel.Catalog.NationalityVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Nationalities
{
    public interface INationalityService
    {
        Task<string?> Create(NationalityCreateRequest Request);

        Task<List<NationalityViewModel>?> GetAll();
        Task<bool> Delete(string id);

        Task<bool> Update(string id, NationalityUpdateRequest Request);
    }
}
