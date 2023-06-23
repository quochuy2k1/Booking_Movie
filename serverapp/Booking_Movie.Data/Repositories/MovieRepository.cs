using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Models;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.ChartReportVM;
using Booking_Movie.ViewModel.Catalog.ReportVM.MovieReportVM;
using Booking_Movie.ViewModel.Catalog.ReportVM.TicketComboReportVM;
using Booking_Movie.ViewModel.Catalog.ScreeningVM;
using Booking_Movie.ViewModel.Utils.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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

        #endregion Movie

        #region Cast

        Task AddCast(int Id, Guid[] actorsId);

        Task<List<Cast>> FindCastByMovieId(int Id);

        Task<Cast?> FindCastByMovieId(int Id, Guid actorId);

        Task UpdateCast(int Id, Guid[] actorsId);

        #endregion Cast

        #region MovieDirector

        Task AddMovieDirector(int Id, Guid[] directorsId);

        Task<List<MovieDirector>> FindMovieDirectorByMovieId(int Id);

        Task<MovieDirector?> FindMovieDirectorByMovieId(int Id, Guid directorId);

        Task UpdateMovieDirector(int Id, Guid[] directorsId);

        #endregion MovieDirector

        #region Screening

        Task<IQueryable<ScreeningViewModel>> GetScreeningByMovieId(int Id);

        IQueryable<ScreeningViewModel> GetScreeningPaging(List<Expression<Func<ScreeningViewModel, bool>>>? filter, out int total, GetScreeningPagingRequest pagingRequest);

        IQueryable<ScreeningViewModel> GetScreeningPagingAdmin(GetScreeningPagingRequest pagingRequest);

        #endregion Screening

        #region Report

        IQueryable<MovieRevenueViewModel> MovieRevenueReport(List<Expression<Func<MovieRevenueViewModel, bool>>>? expressions);

        IQueryable<TicketComboReportViewModel> TicketReport(List<Expression<Func<TicketComboReportViewModel, bool>>>? expression);

        IQueryable<TicketComboReportViewModel> ComboReport(List<Expression<Func<TicketComboReportViewModel, bool>>>? expression);

        IQueryable<TicketComboReportViewModel> TicketComboReport(List<Expression<Func<TicketComboReportViewModel, bool>>>? expression);

        #endregion Report

        #region ChartReport

        IQueryable<MovieRevenueChartReportViewModel?> MovieRevenueChartReport(MovieRevenueChartReportRequest request);

        IQueryable<TicketComboReportChartViewModel>? TicketComboQuantityChartReport(TicketComboChartReportRequest? request);

        IQueryable<TicketComboReportChartViewModel>? TicketComboRevenueChartReport(TicketComboChartReportRequest? request);

        #endregion ChartReport
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

        #endregion Movie

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

        #endregion Cast

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

        #endregion MovieCategory

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

        #endregion MovieDirector

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
                group new { ScreeningId = sc.Id, sc.DateFrom, sc.DateTo, CinemaId = c.Id, ScreeningTypeName = st.Name, sc, stt, AuditoriumId = au.Id, AuditoriumName = au.Name } by c.Name into g

                select new ScreeningViewModel()
                {
                    Id = g.Select(x => x.ScreeningId).FirstOrDefault(),
                    CinemaId = g.Select(x => x.CinemaId).FirstOrDefault(),
                    CinemaName = g.Key,
                    AuditoriumName = g.Select(x => x.AuditoriumName).FirstOrDefault(),
                    AuditoriumId = g.Select(x => x.AuditoriumId).FirstOrDefault(),
                    ScreeningTypeName = g.Select(x => x.ScreeningTypeName).FirstOrDefault(),
                    DateFrom = g.Select(x => x.DateFrom).FirstOrDefault(),
                    DateTo = g.Select(x => x.DateTo).FirstOrDefault(),
                    MovieSchedule = g.Select(x => new MovieSchedule()
                    {
                        Id = x.ScreeningId,
                        ShowTime = x.stt.Time,
                        ShowTimeId = x.stt.Id
                    }).ToList(),
                    AuditoriumScreenings = g.Select(x => new AuditoriumScreening()
                    {
                        AuditoriumName = x.AuditoriumName,
                        MovieSchedule = new MovieSchedule()
                        {
                            Id = x.ScreeningId,
                            ShowTime = x.stt.Time,
                            ShowTimeId = x.stt.Id
                        }
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
                         group new { MovieName = m.Name, ScreeningId = sc.Id, CinemaId = c.Id, CinemaName = c.Name, ScreeningTypeName = st.Name, stt, sc, ScreeingTypeId = st.Id, AuditoriumName = au.Name } by new { auditoriumId = sc.AuditoriumId, movieId = sc.MovieId } into g

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

        #endregion Screening

        #region Report

        public IQueryable<MovieRevenueViewModel> MovieRevenueReport(List<Expression<Func<MovieRevenueViewModel, bool>>>? expressions)
        {
            var query = (from m in this.MovieContext.Movies
                         join scr in this.MovieContext.Screenings on m.Id equals scr.MovieId
                         join au in this.MovieContext.Auditoriums on scr.AuditoriumId equals au.Id
                         join ci in this.MovieContext.Cinemas on au.CinemaId equals ci.Id
                         join bo in this.MovieContext.Bookings on scr.Id equals bo.ScreeningId
                         select new MovieRevenueViewModel()
                         {
                             MovieId = m.Id,
                             MovieName = m.Name,
                             CinemaId = ci.Id,
                             CinemaName = ci.Name,
                             AuditoriumId = au.Id,
                             AuditoriumName = au.Name,
                             BookingDate = bo.CreatedDate,
                             Total = bo.Total
                         });

            // filter
            if (expressions != null)
            {
                foreach (var filter in expressions)
                {
                    query = query.Where(filter);
                }
            }

            query = query.GroupBy(g => g.MovieId)
                         .Select(g => new MovieRevenueViewModel()
                         {
                             Id = Guid.NewGuid().ToString(),
                             MovieId = g.Key,
                             MovieName = g.FirstOrDefault()!.MovieName,
                             CinemaId = g.FirstOrDefault()!.CinemaId,
                             CinemaName = g.FirstOrDefault()!.CinemaName,
                             AuditoriumId = g.FirstOrDefault()!.AuditoriumId,
                             AuditoriumName = g.FirstOrDefault()!.AuditoriumName,
                             DateFrom = g.Min(x => x.BookingDate),
                             DateTo = g.Max(x => x.BookingDate),
                             Total = g.Sum(x => x.Total)
                         });

            return query;
        }

        public IQueryable<TicketComboReportViewModel> TicketReport(List<Expression<Func<TicketComboReportViewModel, bool>>>? expression)
        {
            var query = (from m in this.MovieContext.Movies
                         join scr in this.MovieContext.Screenings on m.Id equals scr.MovieId
                         join au in this.MovieContext.Auditoriums on scr.AuditoriumId equals au.Id
                         join ci in this.MovieContext.Cinemas on au.CinemaId equals ci.Id
                         join bo in this.MovieContext.Bookings on scr.Id equals bo.ScreeningId
                         join bt in this.MovieContext.BookingTickets on bo.Id equals bt.BookingId

                         join tc in this.MovieContext.Tickets on bt.TicketId equals tc.Id

                         //join bc in this.MovieContext.BookingCombos on bo.Id equals bc.BookingId
                         //join cb in  this.MovieContext.Combos on bc.ComboId equals cb.Id

                         select new TicketComboReportViewModel()
                         {
                             MovieId = m.Id,
                             MovieName = m.Name,
                             CinemaId = ci.Id,
                             CinemaName = ci.Name,
                             AuditoriumId = au.Id,
                             AuditoriumName = au.Name,
                             TicketId = tc.Id,
                             TicketName = tc.Name,
                             BookingDate = bo.CreatedDate,
                             TicketQuantity = bt.Quantity
                         });

            //filter

            if (expression != null)
            {
                foreach (var filter in expression)
                {
                    query = query.Where(filter);
                }
            }

            query = query.GroupBy(x => new { x.MovieId, x.TicketId })
                .Select(g => new TicketComboReportViewModel()
                {
                    Id = Guid.NewGuid().ToString(),
                    MovieId = g.Key.MovieId,
                    MovieName = g.FirstOrDefault()!.MovieName,
                    CinemaId = g.FirstOrDefault()!.CinemaId,
                    CinemaName = g.FirstOrDefault()!.CinemaName,
                    AuditoriumId = g.FirstOrDefault()!.AuditoriumId,
                    AuditoriumName = g.FirstOrDefault()!.AuditoriumName,
                    TicketId = g.Key!.TicketId,
                    TicketName = g.FirstOrDefault()!.TicketName,
                    DateFrom = g.Min(x => x.BookingDate),
                    DateTo = g.Max(x => x.BookingDate),
                    TicketQuantityTotal = g.Sum(x => x.TicketQuantity)
                });

            return query;
        }

        public IQueryable<TicketComboReportViewModel> ComboReport(List<Expression<Func<TicketComboReportViewModel, bool>>>? expression)
        {
            var query = (from m in this.MovieContext.Movies
                         join scr in this.MovieContext.Screenings on m.Id equals scr.MovieId
                         join au in this.MovieContext.Auditoriums on scr.AuditoriumId equals au.Id
                         join ci in this.MovieContext.Cinemas on au.CinemaId equals ci.Id

                         join bo in this.MovieContext.Bookings on scr.Id equals bo.ScreeningId
                         join bc in this.MovieContext.BookingCombos on bo.Id equals bc.BookingId
                         join cb in this.MovieContext.Combos on bc.ComboId equals cb.Id
                         //group new { m, au, ci, bo, bc, cb } by m.Id into g
                         select new TicketComboReportViewModel()
                         {
                             MovieId = m.Id,
                             MovieName = m.Name,
                             CinemaId = ci.Id,
                             CinemaName = ci.Name,
                             AuditoriumId = au.Id,
                             AuditoriumName = au.Name,
                             ComboId = cb.Id,
                             ComboName = cb.Name,
                             BookingDate = bo.CreatedDate,
                             ComboQuantity = bc.Quantity
                         });

            //filter

            if (expression != null)
            {
                foreach (var filter in expression)
                {
                    query = query.Where(filter);
                }
            }

            query = query.GroupBy(x => new { x.MovieId, x.ComboId })
                .Select(g => new TicketComboReportViewModel()
                {
                    Id = Guid.NewGuid().ToString(),
                    MovieId = g.Key.MovieId,
                    MovieName = g.FirstOrDefault()!.MovieName,
                    CinemaId = g.FirstOrDefault()!.CinemaId,
                    CinemaName = g.FirstOrDefault()!.CinemaName,
                    AuditoriumId = g.FirstOrDefault()!.AuditoriumId,
                    AuditoriumName = g.FirstOrDefault()!.AuditoriumName,
                    ComboId = g.Key.ComboId,
                    ComboName = g.FirstOrDefault()!.ComboName,
                    DateFrom = g.Min(x => x.BookingDate),
                    DateTo = g.Max(x => x.BookingDate),
                    ComboQuantityTotal = g.Sum(x => x.ComboQuantity)
                });

            return query;
        }

        public IQueryable<TicketComboReportViewModel> TicketComboReport(List<Expression<Func<TicketComboReportViewModel, bool>>>? expression)
        {
            var query = this.MovieContext.Movies
                            .Join(this.MovieContext.Screenings, m => m.Id, scr => scr.MovieId, (m, scr) => new { Movie = m, Screening = scr })
                            .Join(this.MovieContext.Auditoriums, temp => temp.Screening.AuditoriumId, au => au.Id, (temp, au) => new { temp.Movie, temp.Screening, Auditorium = au })
                            .Join(this.MovieContext.Cinemas, temp => temp.Auditorium.CinemaId, ci => ci.Id, (temp, ci) => new { temp.Movie, temp.Screening, temp.Auditorium, Cinema = ci })
                            .Join(this.MovieContext.Bookings, temp => temp.Screening.Id, bo => bo.ScreeningId, (temp, bo) => new { temp.Movie, temp.Screening, temp.Auditorium, temp.Cinema, Booking = bo })
                            .Join(this.MovieContext.BookingTickets, temp => temp.Booking.Id, bt => bt.BookingId, (temp, bt) => new { temp.Movie, temp.Screening, temp.Auditorium, temp.Cinema, temp.Booking, BookingTicket = bt })
                            .Join(this.MovieContext.BookingCombos, temp => temp.Booking.Id, bc => bc.BookingId, (temp, bc) => new { temp.Movie, temp.Screening, temp.Auditorium, temp.Cinema, temp.Booking, temp.BookingTicket, BookingCombo = bc })
                            .Join(this.MovieContext.Combos, temp => temp.BookingCombo.ComboId, cb => cb.Id, (temp, cb) => new { temp.Movie, temp.Screening, temp.Auditorium, temp.Cinema, temp.Booking, temp.BookingTicket, temp.BookingCombo, Combo = cb })
                            .Select(x => new TicketComboReportViewModel()
                            {
                                MovieId = x.Movie.Id,
                                MovieName = x.Movie.Name,
                                CinemaId = x.Cinema.Id,
                                CinemaName = x.Cinema.Name,
                                AuditoriumId = x.Auditorium.Id,
                                AuditoriumName = x.Auditorium.Name,
                                ComboId = x.Combo.Id,
                                ComboName = x.Combo.Name,
                                ComboPrice = x.Combo.Price,
                                TicketId = x.BookingTicket.Ticket.Id,
                                TicketName = x.BookingTicket.Ticket.Name,
                                TicketPrice = x.BookingTicket.Ticket.Price,
                                BookingDate = x.Booking.CreatedDate,
                                ComboQuantity = x.BookingCombo.Quantity,
                                TicketQuantity = x.BookingTicket.Quantity,
                                TotalCombo = x.BookingCombo.Total,
                                TotalTicket = x.BookingTicket.Total,
                            });
            //filter

            if (expression != null)
            {
                foreach (var filter in expression)
                {
                    query = query.Where(filter);
                }
            }
            query = query.GroupBy(temp => new { temp.MovieId, temp.TicketId, temp.ComboId })
                    .Select(g => new TicketComboReportViewModel()
                    {
                        Id = Guid.NewGuid().ToString(),
                        MovieId = g.Key.MovieId,
                        MovieName = g.FirstOrDefault().MovieName,
                        CinemaId = g.FirstOrDefault().CinemaId,
                        CinemaName = g.FirstOrDefault().CinemaName,
                        TicketId = g.Key.TicketId,
                        TicketName = g.FirstOrDefault().TicketName,
                        AuditoriumId = g.FirstOrDefault().AuditoriumId,
                        AuditoriumName = g.FirstOrDefault().AuditoriumName,
                        ComboId = g.Key.ComboId,
                        ComboName = g.FirstOrDefault().ComboName,
                        DateFrom = g.Min(x => x.BookingDate),
                        DateTo = g.Max(x => x.BookingDate),
                        ComboQuantityTotal = g.Sum(x => x.ComboQuantity),
                        TicketQuantityTotal = g.Sum(x => x.TicketQuantity),
                        TicketRevenueTotal = g.Sum(x => x.TotalTicket),
                        ComboRevenueTotal = g.Sum(x => x.TotalCombo),
                    });

            //filter

            return query;
        }

        #endregion Report

        #region ChartReport

        public IQueryable<MovieRevenueChartReportViewModel?> MovieRevenueChartReport(MovieRevenueChartReportRequest? request)
        {
            IQueryable<MovieRevenueChartReportViewModel>? queryResult = null;
            var query = (from m in this.MovieContext.Movies
                         join scr in this.MovieContext.Screenings on m.Id equals scr.MovieId
                         join au in this.MovieContext.Auditoriums on scr.AuditoriumId equals au.Id
                         join ci in this.MovieContext.Cinemas on au.CinemaId equals ci.Id
                         join bo in this.MovieContext.Bookings on scr.Id equals bo.ScreeningId
                         select new MovieRevenueViewModel()
                         {
                             MovieId = m.Id,
                             MovieName = m.Name,
                             CinemaId = ci.Id,
                             CinemaName = ci.Name,
                             AuditoriumId = au.Id,
                             AuditoriumName = au.Name,
                             BookingDate = bo.CreatedDate,
                             Total = bo.Total
                         });

            // filter

            if (request != null && request.Conditional != null && request.Conditional.Value.GetStringValue() == "year")
            {
                queryResult = query.GroupBy(g => g.BookingDate.Value.Year)
                        .Select(g => new MovieRevenueChartReportViewModel()
                        {
                            Month = g.Key,
                            Revenue = g.Sum(x => x.Total)
                        });
            }

            if (request != null && request.Conditional != null && request.Conditional.Value.GetStringValue() == "month")
            {
                queryResult = query.Where(x => x.BookingDate.Value.Year == 2023).GroupBy(g => new { Month = g.BookingDate.Value.Month, Year = g.BookingDate.Value.Year })
                         .Select(g => new MovieRevenueChartReportViewModel()
                         {
                             Month = g.Key.Month,
                             Revenue = g.Sum(x => x.Total)
                         });
            }

            return queryResult;
        }

        public IQueryable<TicketComboReportChartViewModel>? TicketComboQuantityChartReport(TicketComboChartReportRequest? request)
        {
            IQueryable<TicketComboReportChartViewModel>? queryResult = null;
            var query = this.MovieContext.Movies
                            .Join(this.MovieContext.Screenings, m => m.Id, scr => scr.MovieId, (m, scr) => new { Movie = m, Screening = scr })
                            .Join(this.MovieContext.Auditoriums, temp => temp.Screening.AuditoriumId, au => au.Id, (temp, au) => new { temp.Movie, temp.Screening, Auditorium = au })
                            .Join(this.MovieContext.Cinemas, temp => temp.Auditorium.CinemaId, ci => ci.Id, (temp, ci) => new { temp.Movie, temp.Screening, temp.Auditorium, Cinema = ci })
                            .Join(this.MovieContext.Bookings, temp => temp.Screening.Id, bo => bo.ScreeningId, (temp, bo) => new { temp.Movie, temp.Screening, temp.Auditorium, temp.Cinema, Booking = bo })
                            .Join(this.MovieContext.BookingTickets, temp => temp.Booking.Id, bt => bt.BookingId, (temp, bt) => new { temp.Movie, temp.Screening, temp.Auditorium, temp.Cinema, temp.Booking, BookingTicket = bt })
                            .Join(this.MovieContext.BookingCombos, temp => temp.Booking.Id, bc => bc.BookingId, (temp, bc) => new { temp.Movie, temp.Screening, temp.Auditorium, temp.Cinema, temp.Booking, temp.BookingTicket, BookingCombo = bc })
                            .Join(this.MovieContext.Combos, temp => temp.BookingCombo.ComboId, cb => cb.Id, (temp, cb) => new { temp.Movie, temp.Screening, temp.Auditorium, temp.Cinema, temp.Booking, temp.BookingTicket, temp.BookingCombo, Combo = cb })
                            .Select(x => new TicketComboReportViewModel()
                            {
                                MovieId = x.Movie.Id,
                                CinemaId = x.Cinema.Id,
                                AuditoriumId = x.Auditorium.Id,
                                ComboId = x.Combo.Id,
                                TicketId = x.BookingTicket.Ticket.Id,
                                BookingDate = x.Booking.CreatedDate,
                                ComboQuantity = x.BookingCombo.Quantity,
                                TicketQuantity = x.BookingTicket.Quantity,
                            });

            // filter

            if (request != null && request.Conditional != null && request.Conditional.Value.GetStringValue() == "year")
            {
                queryResult = query.GroupBy(g => g.BookingDate.Value.Year)
                        .Select(g => new TicketComboReportChartViewModel()
                        {
                            Month = g.Key,
                            TotalQuantityCombo = g.Sum(x => x.ComboQuantity),
                            TotalQuantityTicket = g.Sum(x => x.TicketQuantity)
                        });
            }

            if (request != null && request.Conditional != null && request.Conditional.Value.GetStringValue() == "month")
            {
                queryResult = query.Where(x => x.BookingDate.Value.Year == 2023).GroupBy(g => new { Month = g.BookingDate.Value.Month, Year = g.BookingDate.Value.Year })
                         .Select(g => new TicketComboReportChartViewModel()
                         {
                             Month = g.Key.Month,
                             TotalQuantityCombo = g.Sum(x => x.ComboQuantity),
                             TotalQuantityTicket = g.Sum(x => x.TicketQuantity)
                         });
            }

            return queryResult;
        }

        public IQueryable<TicketComboReportChartViewModel>? TicketComboRevenueChartReport(TicketComboChartReportRequest? request)
        {
            IQueryable<TicketComboReportChartViewModel>? queryResult = null;
            var query = this.MovieContext.Movies
                            .Join(this.MovieContext.Screenings, m => m.Id, scr => scr.MovieId, (m, scr) => new { Movie = m, Screening = scr })
                            .Join(this.MovieContext.Auditoriums, temp => temp.Screening.AuditoriumId, au => au.Id, (temp, au) => new { temp.Movie, temp.Screening, Auditorium = au })
                            .Join(this.MovieContext.Cinemas, temp => temp.Auditorium.CinemaId, ci => ci.Id, (temp, ci) => new { temp.Movie, temp.Screening, temp.Auditorium, Cinema = ci })
                            .Join(this.MovieContext.Bookings, temp => temp.Screening.Id, bo => bo.ScreeningId, (temp, bo) => new { temp.Movie, temp.Screening, temp.Auditorium, temp.Cinema, Booking = bo })
                            .Join(this.MovieContext.BookingTickets, temp => temp.Booking.Id, bt => bt.BookingId, (temp, bt) => new { temp.Movie, temp.Screening, temp.Auditorium, temp.Cinema, temp.Booking, BookingTicket = bt })
                            .Join(this.MovieContext.BookingCombos, temp => temp.Booking.Id, bc => bc.BookingId, (temp, bc) => new { temp.Movie, temp.Screening, temp.Auditorium, temp.Cinema, temp.Booking, temp.BookingTicket, BookingCombo = bc })
                            .Join(this.MovieContext.Combos, temp => temp.BookingCombo.ComboId, cb => cb.Id, (temp, cb) => new { temp.Movie, temp.Screening, temp.Auditorium, temp.Cinema, temp.Booking, temp.BookingTicket, temp.BookingCombo, Combo = cb })
                            .Select(x => new TicketComboReportViewModel()
                            {
                                MovieId = x.Movie.Id,
                                CinemaId = x.Cinema.Id,
                                AuditoriumId = x.Auditorium.Id,
                                ComboId = x.Combo.Id,
                                TicketId = x.BookingTicket.Ticket.Id,
                                BookingDate = x.Booking.CreatedDate,
                                TotalCombo = x.BookingCombo.Total,
                                TotalTicket = x.BookingTicket.Total,
                            });

            // filter

            if (request != null && request.Conditional != null && request.Conditional.Value.GetStringValue() == "year")
            {
                queryResult = query.GroupBy(g => g.BookingDate.Value.Year)
                        .Select(g => new TicketComboReportChartViewModel()
                        {
                            Month = g.Key,
                            RevenueCombo = g.Sum(x => x.TotalCombo),
                            RevenueTicket = g.Sum(x => x.TotalTicket)
                        });
            }

            if (request != null && request.Conditional != null && request.Conditional.Value.GetStringValue() == "month")
            {
                queryResult = query.Where(x => x.BookingDate.Value.Year == 2023).GroupBy(g => new { Month = g.BookingDate.Value.Month, Year = g.BookingDate.Value.Year })
                         .Select(g => new TicketComboReportChartViewModel()
                         {
                             Month = g.Key.Month,
                             RevenueCombo = g.Sum(x => x.TotalCombo),
                             RevenueTicket = g.Sum(x => x.TotalTicket)
                         });
            }

            return queryResult;
        }

        #endregion ChartReport
    }
}