using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Data.Repositories
{
    public interface IScreeningTypeRepository: IRepository<ScreeningType>
    {

    }
    public class ScreeningTypeRepository : RepositoryBase<ScreeningType>, IScreeningTypeRepository
    {
        public ScreeningTypeRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }
    }
}
