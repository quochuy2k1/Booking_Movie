using Booking_Movie.Data.Configurations;
using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Models;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.ActorVM;
using Booking_Movie.ViewModel.Catalog.MovieVM;
using Booking_Movie.ViewModel.Catalog.ScreeningVM;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace Booking_Movie.Data.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        IQueryable<MovieVM> GetMoviePaging(List<Expression<Func<MovieVM, bool>>>? filter, out int total, int index = 0, int size = 50);
        Task<IQueryable<MovieVM>> GetMovieDetails(params Expression<Func<MovieVM, bool>>[] expressions);
        Task<IQueryable<ScreeningViewModel>> GetScreeningByMovieId(int Id);
        Task<string> GetMovieCast(int Id);
        Task<Movie?> UpdateImageVideo(int Id, string? preview, string? background, string? video);

        void AddMovieCategories(int Id, int[] categoryId);
        void AddCast(int Id, Guid[] actorsId);
        void AddMovieDirector(int Id, Guid[] directorsId);

    }
    public class MovieRepository : RepositoryBase<Movie>, IMovieRepository
    {
        public MovieRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }

        public IQueryable<MovieVM> GetMoviePaging(List<Expression<Func<MovieVM, bool>>>? filter, out int total,  int index = 0, int size = 50)
        {

            int skipCount =( index) * size;
            //1. Truy vấn
            var query = from m in this.MovieContext.Movies
                        join p in this.MovieContext.Producers on m.ProducerId equals p.ID
                        join n in this.MovieContext.Nationalities on m.NationalityId equals n.Id
                        select new MovieVM()
                        {
                            directors = (from md in this.MovieContext.MovieDirectors
                                         join d in this.MovieContext.Directors on md.DirectorId equals d.ID
                                         where md.MovieId == m.Id
                                         select d.Name).ToArray(),
                            movie = m,
                            actors = (from c in this.MovieContext.Casts
                                      join a in this.MovieContext.Actors on c.ActorId equals a.ID
                                      where c.MovieId == m.Id
                                      select a.Name).ToArray(),
                            nationality = n,
                            categories = (from mc in this.MovieContext.MovieCategories
                                          join ct in this.MovieContext.Categories on mc.CategoryId equals ct.Id
                                          where mc.MovieId == m.Id
                                          select ct.Name).ToArray()
                        };
            //2. lọc dữ liệu
            if(filter != null || filter?.Count > 0)
            {
                foreach (var expression in filter)
                {
                    query = query.Where(expression);
                }
            }
            
            // float totalPage = (float)query.Count() / size;
            // total = Convert.ToInt32(Math.Round(totalPage));
            total = query.Count(); // tổng dòng
            //3

            query = query.Skip(skipCount)
                .Take(size);


            return query;
        }

        public async Task<IQueryable<MovieVM>> GetMovieDetails(params Expression<Func<MovieVM, bool>>[] expressions)
        {
            var query = from m in this.MovieContext.Movies
                        join p in this.MovieContext.Producers on m.ProducerId equals p.ID
                        join n in this.MovieContext.Nationalities on m.NationalityId equals n.Id
                        select new MovieVM()
                        {
                            directors = (from md in this.MovieContext.MovieDirectors
                                         join d in this.MovieContext.Directors on md.DirectorId equals d.ID
                                         where md.MovieId == m.Id
                                         select d.Name).ToArray(),
                            movie = m,
                            actors = (from c in this.MovieContext.Casts
                                      join a in this.MovieContext.Actors on c.ActorId equals a.ID
                                      where c.MovieId == m.Id
                                      select a.Name).ToArray(),
                            nationality = n,
                            categories = (from mc in this.MovieContext.MovieCategories
                                          join ct in this.MovieContext.Categories on mc.CategoryId equals ct.Id
                                          where mc.MovieId == m.Id
                                          select ct.Name).ToArray()
                        };

            foreach (var expression in expressions)
            {
                query = query.Where(expression);
            }
            ;

            return await Task.FromResult(query);
        }

        public async Task<string> GetMovieCast(int Id)
        {
            var query = await (from m in MovieContext.Movies
                               join c in MovieContext.Casts on m.Id equals c.MovieId
                               join a in MovieContext.Actors on c.ActorId equals a.ID
                               where m.Id == Id
                               select new { a }).ToListAsync();

            var cast = query.Select(x => String.Join(", ", x.a.Name)).ToString();
            return await Task.Run(() => cast!);
        }

        public async Task<Movie?> UpdateImageVideo(int Id, string? preview, string? background, string? video)
        {
            var movie = await this.MovieContext.Movies.FindAsync(Id);

            if (movie == null) throw new BookingMovieException("cannt find a movie with id: " + Id);
            this.MovieContext.Movies.Attach(movie);

            if (preview != null)
            {
                movie.ImagePreview = preview;
                this.MovieContext.Entry(movie).Property(x => x.ImagePreview).IsModified = true;

            }
            if (background != null)
            {
                movie.ImageBackground = background;
                this.MovieContext.Entry(movie).Property(x => x.ImageBackground).IsModified = true;

            }
            if (video != null)
            {
                movie.VideoTrailer = video;
                this.MovieContext.Entry(movie).Property(x => x.VideoTrailer).IsModified = true;

            }
            return movie;
        }

        public async Task<Movie?> UpdateVideoTrailer(int Id, string video)
        {
            var movie = await this.MovieContext.Movies.FindAsync(Id);

            if (movie == null) throw new BookingMovieException("cannt find a movie with id: " + Id);
            if (video != null)
            {
                movie.VideoTrailer = video;
                this.MovieContext.Movies.Attach(movie);
                this.MovieContext.Entry(movie).Property(x => x.VideoTrailer).IsModified = true;
                return movie;
            }
            return null;
        }

        public async Task<IQueryable<ScreeningViewModel>> GetScreeningByMovieId(int Id)
        {
            var query =
               (from m in this.MovieContext.Movies
                join sc in this.MovieContext.Screenings on m.Id equals sc.MovieId
                join st in this.MovieContext.ScreeningTypes on sc.MovieTypeId equals st.Id
                join au in this.MovieContext.Auditoriums on sc.AuditoriumId equals au.Id
                join c in this.MovieContext.Cinemas on au.CinemaId equals c.Id
                where m.Id == Id
                group new { ScreeningId = sc.Id, CinemaId = c.Id, ScreeningTypeName = st.Name, sc = sc, AuditoriumName = au.Name} by c.Name into g
               
                select new ScreeningViewModel()
                {
                    ScreeningId = g.Select(x => x.ScreeningId).FirstOrDefault(),
                    CinemaId = g.Select(x => x.CinemaId).FirstOrDefault(),
                    CinemaName = g.Key,
                    AuditoriumName = g.Select(x => x.AuditoriumName).FirstOrDefault(),
                    ScreeningTypeName = g.Select(x => x.ScreeningTypeName).FirstOrDefault(),
                    ShowTime = g.Select(x => x.sc.ShowTime).ToArray()
                });


            return await Task.FromResult(query);
        }

        public void AddMovieCategories(int Id, int[] categoriesId)
        {
            
            if(categoriesId.Length == 1)
            {
                var MovieCategory = new MovieCategory()
                {
                    MovieId = Id,
                    CategoryId = categoriesId[0]
                };
                this.MovieContext.MovieCategories.Add(MovieCategory);

            }
            else
            {
                foreach (var category in categoriesId)
                {
                    var MovieCategory = new MovieCategory()
                    {
                        MovieId = Id,
                        CategoryId = category
                    };
                    this.MovieContext.MovieCategories.Add(MovieCategory);
                }
            }


        }

        public void AddCast(int Id, Guid[] actorsId)
        {

            if (actorsId.Length == 1)
            {
                var Cast = new Cast()
                {
                    MovieId = Id,
                    ActorId = actorsId[0]
                };
                this.MovieContext.Casts.Add(Cast);

            }
            else
            {
                foreach (var actorId in actorsId)
                {
                    var Cast = new Cast()
                    {
                        MovieId = Id,
                        ActorId = actorId
                    };
                    this.MovieContext.Casts.Add(Cast);
                }
            }


        }

        public void AddMovieDirector(int Id, Guid[] directorsId)
        {
            if (directorsId.Length == 1)
            {
                var MovieDirector = new MovieDirector()
                {
                    MovieId = Id,
                    DirectorId = directorsId[0]
                };
                this.MovieContext.MovieDirectors.Add(MovieDirector);

            }
            else
            {
                foreach (var directorId in directorsId)
                {
                    var MovieDirector = new MovieDirector()
                    {
                        MovieId = Id,
                        DirectorId = directorId
                    };
                    this.MovieContext.MovieDirectors.Add(MovieDirector);
                }
            }
        }
    }
}