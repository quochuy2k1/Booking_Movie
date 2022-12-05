using Booking_Movie.ViewModel.Catalog.CategoryVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Categories
{
    public interface ICateroryService
    {
        Task<int?> Create(CategoryCreateRequest Request);

        Task<List<CategoryViewModel>?> GetAll();
        Task<bool> Delete(int id);

        Task<bool> Update(int id, CategoryUpdateRequest Request);
    }
}
