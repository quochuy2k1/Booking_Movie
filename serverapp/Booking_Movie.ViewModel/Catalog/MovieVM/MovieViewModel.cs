namespace Booking_Movie.ViewModel.Catalog.MovieVM
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string ImagePreview { get; set; } = null!;
        public string ImageBackground { get; set; } = null!;
        public string VideoTrailer { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Duration { get; set; } 
    }
}