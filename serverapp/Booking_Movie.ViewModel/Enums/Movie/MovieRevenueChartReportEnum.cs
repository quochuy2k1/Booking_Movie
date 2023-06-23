using Booking_Movie.ViewModel.Utils.Attributes;

namespace Booking_Movie.ViewModel.Enums.Movie
{
    public enum MovieRevenueChartReportEnum
    {
        [StringValue("none")]
        None,

        [StringValue("month")]
        Month,

        [StringValue("year")]
        Year,
    }
}