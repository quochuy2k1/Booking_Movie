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

        Task AddMovieCategories(int Id, int[] categoryId);
        Task<List<MovieCategory>> FindMovieCategoryByMovieId(int Id);
        Task<MovieCategory?> FindMovieCategoryByMovieId(int Id, int categoryId);
        Task UpdateMovieCategory(int Id, int[] categoriesId);
        Task AddCast(int Id, Guid[] actorsId);
        Task<List<Cast>> FindCastByMovieId(int Id);
        Task<Cast?> FindCastByMovieId(int Id, Guid actorId);
        Task UpdateCast(int Id, Guid[] actorsId);

        Task AddMovieDirector(int Id, Guid[] directorsId);
        Task<List<MovieDirector>> FindMovieDirectorByMovieId(int Id);
        Task<MovieDirector?> FindMovieDirectorByMovieId(int Id, Guid directorId);
        Task UpdateMovieDirector(int Id, Guid[] directorsId);

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
                    Id = g.Select(x => x.ScreeningId).FirstOrDefault(),
                    CinemaId = g.Select(x => x.CinemaId).FirstOrDefault(),
                    CinemaName = g.Key,
                    AuditoriumName = g.Select(x => x.AuditoriumName).FirstOrDefault(),
                    ScreeningTypeName = g.Select(x => x.ScreeningTypeName).FirstOrDefault(),
                    ShowTime = g.Select(x => x.sc.ShowTime).ToArray()
                });


            return await Task.FromResult(query);
        }

        public async Task<IQueryable<ScreeningViewModel>> GetAllScreening()
        {
            var query =
               (from m in this.MovieContext.Movies
                join sc in this.MovieContext.Screenings on m.Id equals sc.MovieId
                join st in this.MovieContext.ScreeningTypes on sc.MovieTypeId equals st.Id
                join au in this.MovieContext.Auditoriums on sc.AuditoriumId equals au.Id
                join c in this.MovieContext.Cinemas on au.CinemaId equals c.Id
                group new { ScreeningId = sc.Id, CinemaId = c.Id, CinemaName = c.Name, ScreeningTypeName = st.Name, sc = sc, AuditoriumName = au.Name } by m.Name into g

                select new ScreeningViewModel()
                {
                    Id = g.Select(x => x.ScreeningId).FirstOrDefault(),
                    CinemaId = g.Select(x => x.CinemaId).FirstOrDefault(),
                    CinemaName = g.Select(x => x.CinemaName).FirstOrDefault(),
                    MovieName = g.Key,
                    AuditoriumName = g.Select(x => x.AuditoriumName).FirstOrDefault(),
                    ScreeningTypeName = g.Select(x => x.ScreeningTypeName).FirstOrDefault(),
                    ShowTime = g.Select(x => x.sc.ShowTime).ToArray()
                });


            return await Task.FromResult(query);
        }

        public async Task AddMovieCategories(int Id, int[] categoriesId)
        {
            
            if(categoriesId.Length == 1)
            {
                var MovieCategory = new MovieCategory()
                {
                    MovieId = Id,
                    CategoryId = categoriesId[0]
                };
               await this.MovieContext.MovieCategories.AddAsync(MovieCategory);

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
                  await  this.MovieContext.MovieCategories.AddAsync(MovieCategory);
                }
            }


        }

        public async Task AddCast(int Id, Guid[] actorsId)
        {

            if (actorsId.Length == 1)
            {
                var Cast = new Cast()
                {
                    MovieId = Id,
                    ActorId = actorsId[0]
                };
              await this.MovieContext.Casts.AddAsync(Cast);

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
                   await this.MovieContext.Casts.AddAsync(Cast);
                }
            }

        }

        public async Task AddMovieDirector(int Id, Guid[] directorsId)
        {
            if (directorsId.Length == 1)
            {
                var MovieDirector = new MovieDirector()
                {
                    MovieId = Id,
                    DirectorId = directorsId[0]
                };
                await this.MovieContext.MovieDirectors.AddAsync(MovieDirector);

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
                   await this.MovieContext.MovieDirectors.AddAsync(MovieDirector);
                }
            }
        }

        public async Task<Cast?> FindCastByMovieId(int Id, Guid actorId)
        {
            return await this.MovieContext.Casts.Where(x => x.MovieId == Id && x.ActorId == actorId).FirstOrDefaultAsync();
        }

        public async Task<List<Cast>?> FindCastByMovieId(int Id)
        {
            return await this.MovieContext.Casts.Where(x => x.MovieId == Id).ToListAsync();
        }

        public async Task UpdateCast(int Id, Guid[] actorsId)
        {
           
            var oldActor = this.MovieContext.Casts.Where(c => c.MovieId ==Id && !actorsId.Contains(c.ActorId));
            if (oldActor != null)
            {
                this.MovieContext.Casts.RemoveRange(oldActor);
            }

            foreach (var actorId in actorsId)
            {
                var hasActor = await FindCastByMovieId(Id, actorId);

                if (hasActor == null)
                {
                    var cast = await this.MovieContext.Casts.AddAsync(new Cast()
                    {
                        MovieId = Id,
                        ActorId = actorId
                    });
                    

                }
            }

        }

        public async Task<List<MovieCategory>> FindMovieCategoryByMovieId(int Id)
        {
            return await this.MovieContext.MovieCategories.Where(x => x.MovieId == Id).ToListAsync();
        }
        
        public async Task<MovieCategory?> FindMovieCategoryByMovieId(int Id, int categoryId)
        {
            return await this.MovieContext.MovieCategories.Where(x => x.MovieId == Id && x.CategoryId == categoryId).FirstOrDefaultAsync();
        }

        public async Task UpdateMovieCategory(int Id, int[] categoriesId)
        {

            var oldMovieCategories = this.MovieContext.MovieCategories.Where(c => c.MovieId == Id && !categoriesId.Contains(c.CategoryId));
            if (oldMovieCategories != null)
            {
                this.MovieContext.MovieCategories.RemoveRange(oldMovieCategories);
            }

            foreach (var categoryId in categoriesId)
            {
                var hasCategory = await FindMovieCategoryByMovieId(Id, categoryId);

                if (hasCategory == null)
                {
                    var cast = await this.MovieContext.MovieCategories.AddAsync(new MovieCategory()
                    {
                        MovieId = Id,
                        CategoryId = categoryId
                    });


                }
            }



        }

        public async Task<List<MovieDirector>> FindMovieDirectorByMovieId(int Id)
        {
            return await this.MovieContext.MovieDirectors.Where(x => x.MovieId == Id).ToListAsync();
        }

        public async Task<MovieDirector?> FindMovieDirectorByMovieId(int Id, Guid directorId)
        {
            return await this.MovieContext.MovieDirectors.Where(x => x.MovieId == Id && x.DirectorId == directorId).FirstOrDefaultAsync();
        }

        public async Task UpdateMovieDirector(int Id, Guid[] directorsId)
        {

            var oldMovieDirector = this.MovieContext.MovieDirectors.Where(c => c.MovieId == Id && !directorsId.Contains(c.DirectorId));
            if (oldMovieDirector != null)
            {
                this.MovieContext.MovieDirectors.RemoveRange(oldMovieDirector);
            }

            foreach (var directorId in directorsId)
            {
                var hasMovieDirector = await FindMovieDirectorByMovieId(Id, directorId);
                       
                if (hasMovieDirector == null)
                {
                    await this.MovieContext.MovieDirectors.AddAsync(new MovieDirector()
                    {
                        MovieId = Id,
                        DirectorId = directorId
                    });


                }
            }

        }
    }
}