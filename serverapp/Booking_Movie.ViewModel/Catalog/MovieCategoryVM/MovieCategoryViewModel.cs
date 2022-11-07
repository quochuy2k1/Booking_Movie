using Booking_Movie.ViewModel.Abstract;

namespace Booking_Movie.ViewModel.Catalog.MovieCategoryVM
{
    public class MovieCategoryViewModel : Editable
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public int? ParentId { get; set; }
        public int? DisplayOrder { get; set; }

        public string Image { get; set; } = null!;

        public bool HomeFlag { get; set; }

       
    }
}