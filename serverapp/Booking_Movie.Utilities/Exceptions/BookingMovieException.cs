namespace Booking_Movie.Utilities.Exceptions
{
    public class BookingMovieException : Exception
    {
        public BookingMovieException()
        { }

        public BookingMovieException(string message) : base(message)
        {
        }

        public BookingMovieException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}