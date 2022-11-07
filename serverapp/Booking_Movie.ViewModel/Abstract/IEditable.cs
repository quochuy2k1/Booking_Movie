namespace Booking_Movie.ViewModel.Abstract
{
    public interface IEditable
    {
        DateTime CreatedDate { get; set; }
        string? CreatedBy { get; set; }
        DateTime UpdatedDate { get; set; }
        string? UpdatedBy { get; set; }
    }
}