using Booking_Movie.Application.Catalog.Movies;
using Microsoft.Extensions.DependencyInjection;

namespace BookingMovie.UnitTest.ServiceTest
{
    public class MovieServiceTest : IClassFixture<StartupFixture>
    {
        private readonly IMovieService _movieService;

        public MovieServiceTest(StartupFixture fixture)
        {
            _movieService = fixture.ServiceProvider.GetService<IMovieService>();
        }

        [Fact]
        public async Task MovieRevenueReport()
        {
            //var mockMovieRepository = new Mock<IMovieService>();
            //Task<List<MovieRevenueViewModel>>? query = null;
            //mockMovieRepository.Setup(m => m.MovieRevenueReport(null)).Returns(query);

            //var object1 = mockMovieRepository.Object;
            //var result = await object1.MovieRevenueReport(null);

            var result = await _movieService.MovieRevenueReport(null);
        }
    }
}