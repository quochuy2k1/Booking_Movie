namespace Booking_Movie.ViewModel.Catalog.ProducerVM
{
    public class ProducerViewModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; } = null!;
        public string NationalityId { get; set; } = null!;

        public string? Image { get; set; }
    }
}