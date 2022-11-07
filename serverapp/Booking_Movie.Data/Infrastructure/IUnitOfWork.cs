namespace Booking_Movie.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}