namespace Booking_Movie.ViewModel.Catalog.ActorVM
{
    public class ActorImageViewModel
    {
        public int Id { get; set; }
        public Guid ActorId { get; set; }
        public string ImagePath { get; set; } = null!;
        public string? Caption { get; set; }
        public bool IsDefault { get; set; }
        public DateTime DateCreated { get; set; }
        public int? SortOrder { get; set; }
        public long FileSize { get; set; }
    }
}