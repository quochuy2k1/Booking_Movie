using Booking_Movie.Utilities.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Booking_Movie.Data.EF
{
    public class BookingMovieContextFactory : IDesignTimeDbContextFactory<BookingMovieContext>
    {
        public BookingMovieContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var ConnectString = configuration.GetConnectionString(SystemConstant.MainConnectionString);
            var optionsBuilder = new DbContextOptionsBuilder<BookingMovieContext>();
            optionsBuilder.UseSqlServer(connectionString: ConnectString);

            return new BookingMovieContext(optionsBuilder.Options);
        }
    }
}