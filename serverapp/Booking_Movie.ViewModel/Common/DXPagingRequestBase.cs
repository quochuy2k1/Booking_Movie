using DevExtreme.AspNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Common
{
    public class DXPagingRequestBase : DataSourceLoadOptionsBase
    {
        public string? Token { get; set; }

    }
}
