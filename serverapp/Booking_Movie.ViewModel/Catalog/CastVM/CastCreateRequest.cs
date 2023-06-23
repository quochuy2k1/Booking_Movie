namespace Booking_Movie.ViewModel.Catalog.CastVM
{
    public class CastCreateRequest
    {
        public int Id { get; set; }
        public Guid ActorId { get; set; }
        public int MovieId { get; set; }
    }
}