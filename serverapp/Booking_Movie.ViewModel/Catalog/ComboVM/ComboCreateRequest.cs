namespace Booking_Movie.ViewModel.Catalog.ComboVM
{
    public class ComboCreateRequest
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
    }

    public class DXComboCreateRequest
    {
        public ComboCreateRequest? Values { get; set; }
    }
}