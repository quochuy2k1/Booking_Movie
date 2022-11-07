using Booking_Movie.ViewModel.Common;
using Booking_Movie.ViewModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.DirectorVM
{
    public class GetDirectorPagingRequest:PagingRequestBase
    {
        public string? Nationality { get; set; }
        public SortByDirector SortBy { get; set; }

    }
}
