namespace Booking_Movie.ViewModel.Catalog.ScreeningVM
{
    public class ScreeningUpdateRequest
    {
        public int Id { get; set; }
        public List<string>? ShowTimeId { get; set; }
        public int? AuditoriumId { get; set; }
        public int? MovieId { get; set; }
        public int? ScreeningTypeId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}