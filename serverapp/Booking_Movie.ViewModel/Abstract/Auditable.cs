namespace Booking_Movie.ViewModel.Abstract
{
    public class Auditable : IAuditable
    {
        public string Alias { get; set; } = null!;
        public string? MetaKeyword { get; set; }
        public string? MetaDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public bool Status { get; set; }
    }
}
