using Booking_Movie.Data.Configurations;
using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Models;
using Booking_Movie.Utilities.Common;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.ActorVM;
using Booking_Movie.ViewModel.Catalog.MovieVM;
using Booking_Movie.ViewModel.Catalog.ScreeningVM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace Booking_Movie.Data.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        #region Movie
        IQueryable<MovieVM> GetMoviePaging(List<Expression<Func<MovieVM, bool>>>? filter, out int total, int index = 0, int size = 50);
        IQueryable<MovieVM> GetMoviePagingAdmin();
        Task<IQueryable<MovieVM>> GetMovieDetails(params Expression<Func<MovieVM, bool>>[] expressions);
        Task<string> GetMovieCast(int Id);
        Task<Movie?> UpdateImageVideo(int Id, string? preview, string? background, string? video);

        Task AddMovieCategories(int Id, int[] categoryId);
        Task<List<MovieCategory>> FindMovieCategoryByMovieId(int Id);
        Task<MovieCategory?> FindMovieCategoryByMovieId(int Id, int categoryId);
        Task UpdateMovieCategory(int Id, int[] categoriesId);
        #endregion

        #region Cast
        Task AddCast(int Id, Guid[] actorsId);
        Task<List<Cast>> FindCastByMovieId(int Id);
        Task<Cast?> FindCastByMovieId(int Id, Guid actorId);
        Task UpdateCast(int Id, Guid[] actorsId);

        #endregion

        #region MovieDirector
        Task AddMovieDirector(int Id, Guid[] directorsId);
        Task<List<MovieDirector>> FindMovieDirectorByMovieId(int Id);
        Task<MovieDirector?> FindMovieDirectorByMovieId(int Id, Guid directorId);
        Task UpdateMovieDirector(int Id, Guid[] directorsId);

        #endregion

        #region Screening

        Task<IQueryable<ScreeningViewModel>> GetScreeningByMovieId(int Id);

        IQueryable<ScreeningViewModel> GetScreeningPaging(List<Expression<Func<ScreeningViewModel, bool>>>? filter, out int total, GetScreeningPagingRequest pagingRequest);
        IQueryable<ScreeningViewModel> GetScreeningPagingAdmin(GetScreeningPagingRequest pagingRequest);

        #endregion





    }
    public class MovieRepository : RepositoryBase<Movie>, IMovieRepository
    {
        public MovieRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }

        #region Movie

        public IQueryable<MovieVM> GetMoviePaging(List<Expression<Func<MovieVM, bool>>>? filter, out int total, int index = 0, int size = 50)
        {

            int skipCount = (index) * size;
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
            if (filter != null || filter?.Count > 0)
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

        public IQueryable<MovieVM> GetMoviePagingAdmin()
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







        public async Task AddMovieCategories(int Id, int[] categoriesId)
        {

            if (categoriesId.Length == 1)
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
                    await this.MovieContext.MovieCategories.AddAsync(MovieCategory);
                }
            }


        }

        #endregion

        #region Cast

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

            var oldActor = this.MovieContext.Casts.Where(c => c.MovieId == Id && !actorsId.Contains(c.ActorId));
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

        #endregion

        #region MovieCategory

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

        #endregion

        #region MovieDirector

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

        #endregion

        #region Screening

        public async Task<IQueryable<ScreeningViewModel>> GetScreeningByMovieId(int Id)
        {
            var query =
               (from m in this.MovieContext.Movies
                join sc in this.MovieContext.Screenings on m.Id equals sc.MovieId
                join stt in this.MovieContext.ShowTimes on sc.ShowTimeId equals stt.Id
                join st in this.MovieContext.ScreeningTypes on sc.ScreeningTypeId equals st.Id
                join au in this.MovieContext.Auditoriums on sc.AuditoriumId equals au.Id
                join c in this.MovieContext.Cinemas on au.CinemaId equals c.Id
                where m.Id == Id
                group new { ScreeningId = sc.Id, CinemaId = c.Id, ScreeningTypeName = st.Name, sc, stt, AuditoriumName = au.Name } by c.Name into g

                select new ScreeningViewModel()
                {
                    Id = g.Select(x => x.ScreeningId).FirstOrDefault(),
                    CinemaId = g.Select(x => x.CinemaId).FirstOrDefault(),
                    CinemaName = g.Key,
                    AuditoriumName = g.Select(x => x.AuditoriumName).FirstOrDefault(),
                    ScreeningTypeName = g.Select(x => x.ScreeningTypeName).FirstOrDefault(),
                    MovieSchedule = g.Select(x => new MovieSchedule()
                    {
                        Id = x.ScreeningId,
                        ShowTime = x.stt.Time,
                        ShowTimeId = x.stt.Id

                    }).ToList(),
                });


            return await Task.FromResult(query);
        }

        public async Task<IQueryable<ScreeningViewModel>> GetAllScreening()
        {
            var query =
               (from m in this.MovieContext.Movies
                join sc in this.MovieContext.Screenings on m.Id equals sc.MovieId
                join stt in this.MovieContext.ShowTimes on sc.ShowTimeId equals stt.Id

                join st in this.MovieContext.ScreeningTypes on sc.ScreeningTypeId equals st.Id
                join au in this.MovieContext.Auditoriums on sc.AuditoriumId equals au.Id
                join c in this.MovieContext.Cinemas on au.CinemaId equals c.Id
                group new { ScreeningId = sc.Id, CinemaId = c.Id, CinemaName = c.Name, ScreeningTypeName = st.Name, stt, sc, AuditoriumName = au.Name } by m.Name into g

                select new ScreeningViewModel()
                {
                    Id = g.Select(x => x.ScreeningId).FirstOrDefault(),
                    CinemaId = g.Select(x => x.CinemaId).FirstOrDefault(),
                    CinemaName = g.Select(x => x.CinemaName).FirstOrDefault(),
                    MovieName = g.Key,
                    AuditoriumName = g.Select(x => x.AuditoriumName).FirstOrDefault(),
                    ScreeningTypeName = g.Select(x => x.ScreeningTypeName).FirstOrDefault(),
                    MovieSchedule = g.Select(x => new MovieSchedule()
                    {
                        Id = x.ScreeningId,
                        ShowTime = x.stt.Time,
                                 ShowTimeId = x.stt.Id

                    }).ToList(),
                }); ;


            return await Task.FromResult(query);
        }

        public IQueryable<ScreeningViewModel> GetScreeningPaging(List<Expression<Func<ScreeningViewModel, bool>>>? filter, out int total, GetScreeningPagingRequest pagingRequest)
        {
            int skipCount = 0;
            //if (pagingRequest.PageIndex == null && pagingRequest.PageSkip != null)
            //{

            //    skipCount = pagingRequest.PageSkip.Value;
            //}
            //1. Truy vấn
            //var query =
            //  (from m in this.MovieContext.Movies
            //   join sc in this.MovieContext.Screenings on m.Id equals sc.MovieId
            //   join st in this.MovieContext.ScreeningTypes on sc.MovieTypeId equals st.Id
            //   join au in this.MovieContext.Auditoriums on sc.AuditoriumId equals au.Id
            //   join c in this.MovieContext.Cinemas on au.CinemaId equals c.Id
            //   group new { ScreeningId = sc.Id, CinemaId = c.Id, CinemaName = c.Name, ScreeningTypeName = st.Name, sc = sc, AuditoriumName = au.Name } by m.Name into g

            //   select new ScreeningViewModel()
            //   {
            //       Id = g.Select(x => x.ScreeningId).FirstOrDefault(),

            //       CinemaId = g.Select(x => x.CinemaId).FirstOrDefault(),
            //       CinemaName = g.Select(x => x.CinemaName).FirstOrDefault(),
            //       MovieId = 1,
            //       MovieName = g.Key,
            //       AuditoriumId = 1,
            //       AuditoriumName = g.Select(x => x.AuditoriumName).FirstOrDefault(),
            //       ScreeningTypeName = g.Select(x => x.ScreeningTypeName).FirstOrDefault(),
            //       ScreeningTypeId = 1,
            //       MovieSchedule = g.Select(x => new MovieSchedule()
            //       {
            //           Id = x.ScreeningId,
            //           ShowTime = x.sc.ShowTime
            //       }).ToList(),
            //   }); ;

            var query = (from m in this.MovieContext.Movies
                         join sc in this.MovieContext.Screenings on m.Id equals sc.MovieId
                         join stt in this.MovieContext.ShowTimes on sc.ShowTimeId equals stt.Id

                         join st in this.MovieContext.ScreeningTypes on sc.ScreeningTypeId equals st.Id
                         join au in this.MovieContext.Auditoriums on sc.AuditoriumId equals au.Id
                         join c in this.MovieContext.Cinemas on au.CinemaId equals c.Id
                         group new { ScreeningId = sc.Id, CinemaId = c.Id, CinemaName = c.Name, ScreeningTypeName = st.Name, stt, sc, ScreeingTypeId = st.Id, AuditoriumName = au.Name } by m.Name into g
                         select new ScreeningViewModel()
                         {
                             Id = g.Select(x => x.ScreeningId).FirstOrDefault(),
                             CinemaId = (int?)g.Select(x => x.CinemaId).FirstOrDefault(),
                             CinemaName = (string?)g.Select(x => x.CinemaName).FirstOrDefault(),
                             MovieId = (int?)g.Select(x => x.sc.MovieId).FirstOrDefault(),
                             MovieName = (string?)g.Key,
                             AuditoriumId = (int?)g.Select(x => x.sc.AuditoriumId).FirstOrDefault(),
                             AuditoriumName = (string?)g.Select(x => x.AuditoriumName).FirstOrDefault(),
                             ScreeningTypeName = (string?)g.Select(x => x.ScreeningTypeName).FirstOrDefault(),
                             ScreeningTypeId = (int?)g.Select(x => x.ScreeingTypeId).FirstOrDefault(),
                             MovieSchedule = (List<MovieSchedule>?)g.Select(x => new MovieSchedule()
                             {
                                 Id = x.sc.Id,
                                 ShowTime = x.stt.Time,
                                 ShowTimeId = x.stt.Id


                             }).ToList(),
                         });

            //2. lọc dữ liệu
            //if (filter != null || filter?.Count > 0)
            //{
            //    foreach (var expression in filter)
            //    {
            //        query = query.Where(expression);
            //    }
            //}

            //if (pagingRequest.Filter != null)
            //{
            //    var buildFilter = ParseHelper<ScreeningViewModel>.BuildPredicate(pagingRequest.Filter);

            //    query = query.Where(buildFilter);
            //}

            //    // Sắp xếp

            //    if (pagingRequest.Sort != null)
            //{
            //    foreach(var expression in pagingRequest.Sort)
            //    {
            //        if(expression.Desc == false)
            //        {
            //            string propertyName = expression.Selector;
            //            var parameter = Expression.Parameter(typeof(ScreeningViewModel), "x");
            //            var property = Expression.Property(parameter, propertyName);
            //            var lambda = Expression.Lambda(property, parameter);
            //            var orderByExpression = Expression.Call(
            //                typeof(Queryable),
            //                "OrderBy",
            //                new[] { typeof(ScreeningViewModel), property.Type },
            //                query.Expression,
            //                lambda
            //            );
            //            query = query.Provider.CreateQuery<ScreeningViewModel>(orderByExpression);
            //        }
            //        else if(expression.Desc == true)
            //        {
            //            string propertyName = expression.Selector;
            //            var parameter = Expression.Parameter(typeof(ScreeningViewModel), "x");
            //            var property = Expression.Property(parameter, propertyName);
            //            var lambda = Expression.Lambda(property, parameter);
            //            var orderByExpression = Expression.Call(
            //                typeof(Queryable),
            //                "OrderByDescending",
            //                new[] { typeof(ScreeningViewModel), property.Type },
            //                query.Expression,
            //                lambda
            //            );
            //            query = query.Provider.CreateQuery<ScreeningViewModel>(orderByExpression);

            //        }
            //    }
            //}

            // float totalPage = (float)query.Count() / size;
            // total = Convert.ToInt32(Math.Round(totalPage));
            total = query.Count(); // tổng dòng
            //3

            //query = query.Skip(skipCount)
            //    .Take(pagingRequest.PageSize);


            return query;
        }
        public IQueryable<ScreeningViewModel> GetScreeningPagingAdmin(GetScreeningPagingRequest pagingRequest)
        {

            var query = (from m in this.MovieContext.Movies
                         join sc in this.MovieContext.Screenings on m.Id equals sc.MovieId
                         join st in this.MovieContext.ScreeningTypes on sc.ScreeningTypeId equals st.Id
                         join stt in this.MovieContext.ShowTimes on sc.ShowTimeId equals stt.Id

                         join au in this.MovieContext.Auditoriums on sc.AuditoriumId equals au.Id
                         join c in this.MovieContext.Cinemas on au.CinemaId equals c.Id
                         // filter
                         where (pagingRequest.MovieId == null || sc.MovieId == pagingRequest.MovieId) &&
                                (pagingRequest.CinemaId == null || c.Id == pagingRequest.CinemaId)
                         group new { MovieName = m.Name, ScreeningId = sc.Id, CinemaId = c.Id, CinemaName = c.Name, ScreeningTypeName = st.Name, stt, sc, ScreeingTypeId = st.Id, AuditoriumName = au.Name } by new { auditoriumId = sc.AuditoriumId, movieId = sc.MovieId  } into g
                         select new ScreeningViewModel()
                         {
                             Id = g.Select(x => x.ScreeningId).FirstOrDefault(),
                             CinemaId = (int?)g.Select(x => x.CinemaId).FirstOrDefault(),
                             CinemaName = (string?)g.Select(x => x.CinemaName).FirstOrDefault(),
                             MovieId = (int?)g.Key.movieId,
                             MovieName = (string?)g.Select(x => x.MovieName).FirstOrDefault(),
                             AuditoriumId = (int?)g.Key.auditoriumId,
                             AuditoriumName = (string?)g.Select(x => x.AuditoriumName).FirstOrDefault(),
                             ScreeningTypeName = (string?)g.Select(x => x.ScreeningTypeName).FirstOrDefault(),
                             ScreeningTypeId = (int?)g.Select(x => x.ScreeingTypeId).FirstOrDefault(),
                             DateFrom = (DateTime?)g.Select(x => x.sc.DateFrom).FirstOrDefault(),
                             DateTo = (DateTime?)g.Select(x => x.sc.DateTo).FirstOrDefault(),
                             MovieSchedule = (List<MovieSchedule>?)g.Select(x => new MovieSchedule()
                             {
                                 Id = x.sc.Id,
                                 ShowTime = x.stt.Time,
                                 ShowTimeId = x.stt.Id


                             }).ToList(),
                             ShowTimeId = g.Select(x => x.stt.Id).ToList(),
                         });



            return query;
        }

        #endregion

    }
}