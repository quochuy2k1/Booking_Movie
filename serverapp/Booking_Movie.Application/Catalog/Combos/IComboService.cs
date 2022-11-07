using Booking_Movie.ViewModel.Catalog.ComboVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Combos
{
    public interface IComboService
    {
        Task<List<ComboViewModel>?> GetCombos();
    }
}
