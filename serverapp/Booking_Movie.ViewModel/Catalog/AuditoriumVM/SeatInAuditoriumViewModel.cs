using Booking_Movie.ViewModel.Catalog.SeatNoVM;

namespace Booking_Movie.ViewModel.Catalog.AuditoriumVM
{
    public class SeatInAuditoriumViewModel
    {
        public string PhysicalName { get; set; } = null!;
        public List<SeatNoClientViewModel> Seats { get; set; } = null!;
    }
}