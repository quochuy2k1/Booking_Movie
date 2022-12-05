
namespace Booking_Movie.ViewModel.Catalog.CategoryVM
{
    public class CategoryViewModel
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