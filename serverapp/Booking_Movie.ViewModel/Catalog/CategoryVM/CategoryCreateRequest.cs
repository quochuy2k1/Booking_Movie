namespace Booking_Movie.ViewModel.Catalog.CategoryVM
{
    public class CategoryCreateRequest
    {
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public int? ParentId { get; set; }
        public int? DisplayOrder { get; set; }

        public Microsoft.AspNetCore.Http.IFormFile? Image { get; set; } = null!;

        public bool HomeFlag { get; set; }
    }
}