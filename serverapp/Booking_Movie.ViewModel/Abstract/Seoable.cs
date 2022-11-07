namespace Booking_Movie.ViewModel.Abstract
{
    public class Seoable : ISeoable
    {
        public string Alias { get; set; } = null!;
        public string? MetaKeyword { get; set; }
        public string? MetaDescription { get; set; }
    }
}