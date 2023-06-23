using Booking_Movie.Data.Repositories;
using Booking_Movie.ViewModel.Catalog.ReportVM.TicketComboReportVM;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookingMovie.UnitTest.RepositoryTest
{
    public class MovieRepositoryTest : IClassFixture<StartupFixture>
    {
        private readonly MovieRepository _movieRepository;

        public MovieRepositoryTest(StartupFixture fixture)
        {
            _movieRepository = fixture.ServiceProvider.GetService<MovieRepository>();
        }

        [Fact]
        public async Task TicketReport()
        {
            var result = await _movieRepository.TicketReport(null).ToListAsync();
        }

        [Fact]
        public async Task ComboReport()
        {
            var result = await _movieRepository.ComboReport(null).ToListAsync();
        }

        [Fact]
        public async Task TicketComboReport()
        {
            try
            {
                var result = await _movieRepository.TicketComboReport(null).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [Fact]
        public async Task MovieRevenueChartReport()
        {
            var result = await _movieRepository.MovieRevenueChartReport(null).ToListAsync();
        }

        [Fact]
        public async Task MovieTicketQuantityChartReport()
        {
            TicketComboChartReportRequest request = new TicketComboChartReportRequest();
            request.Conditional = Booking_Movie.ViewModel.Enums.Movie.MovieRevenueChartReportEnum.Month;
            var result = await _movieRepository.TicketComboQuantityChartReport(request).ToListAsync();
        }
    }
}