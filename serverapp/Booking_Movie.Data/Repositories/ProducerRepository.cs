using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.ViewModel.Catalog.ProducerVM;
using Microsoft.EntityFrameworkCore;

namespace Booking_Movie.Data.Repositories
{
    public interface IProducerRepository : IRepository<Producer>
    {
        Task<IEnumerable<ProducerViewModel>> GetByNationality(string nationality);
    }

    public class ProducerRepository : RepositoryBase<Producer>, IProducerRepository
    {
        public ProducerRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }

        public async Task<IEnumerable<ProducerViewModel>> GetByNationality(string nationality)
        {
            var producers = await this.MovieContext.Set<Producer>().Include(x => x.Nationality).Where(producer => producer.NationalityId == nationality)
                .Select(producer => new ProducerViewModel()
                {
                    ID = producer.ID,
                    Name = producer.Name,
                    Image = producer.Image,
                    NationalityId = producer.Nationality.Id,
                }).ToListAsync();

            return producers;
        }
    }
}