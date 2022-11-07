namespace Booking_Movie.Data.Abstract
{
    public interface IAuditable
    {
#nullable enable

        string Alias { get; set; }
        string? MetaKeyword { get; set; }
        string? MetaDescription { get; set; }

        DateTime CreatedDate { get; set; }
        string? CreatedBy { get; set; }
        DateTime UpdatedDate { get; set; }
        string? UpdatedBy { get; set; }

        bool Status { get; set; }
    }
}