namespace Booking_Movie.ViewModel.Catalog.ActorVM
{
    public class ActorViewModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; } = null!;
        public int ViewCount { get; set; }
        public string NationalityId { get; set; } = null!;
        public float Height { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? Image { get; set; }
    }
}