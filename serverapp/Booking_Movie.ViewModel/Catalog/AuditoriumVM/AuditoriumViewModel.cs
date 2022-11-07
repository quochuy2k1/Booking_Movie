namespace Booking_Movie.ViewModel.Catalog.AuditoriumVM
{
    public class AuditoriumViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public int CinemaId { get; set; }
    }
}