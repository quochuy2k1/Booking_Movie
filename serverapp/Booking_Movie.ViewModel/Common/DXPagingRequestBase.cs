using DevExtreme.AspNet.Data;

namespace Booking_Movie.ViewModel.Common
{
    public class DXPagingRequestBase : DataSourceLoadOptionsBase
    {
        public string? Token { get; set; }
    }
}