namespace Booking_Movie.Data.Abstract
{
    public interface IEditable
    {
        DateTime CreatedDate { get; set; }
        string? CreatedBy { get; set; }
        DateTime UpdatedDate { get; set; }
        string? UpdatedBy { get; set; }
    }
}