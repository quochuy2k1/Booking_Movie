using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.ViewModel.Catalog.ComboVM;

namespace Booking_Movie.Data.Repositories
{
    public interface IComboRepository : IRepository<Combo>
    {
        IQueryable<ComboViewModel> GetComboPagingAdmin(GetComboPagingAdminRequest request);
    }

    public class ComboRepository : RepositoryBase<Combo>, IComboRepository
    {
        public ComboRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }

        public IQueryable<ComboViewModel> GetComboPagingAdmin(GetComboPagingAdminRequest request)
        {
            var query = this.MovieContext.Combos.Select(c => new ComboViewModel()
            {
                Id = c.Id,
                Name = c.Name,
                Price = c.Price,
                Description = c.Description,

            });

            return query;
        }
    }
}