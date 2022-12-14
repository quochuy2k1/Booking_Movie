using AutoMapper;
using Booking_Movie.Application.Common;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Models;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.MovieVM;
using Booking_Movie.ViewModel.Catalog.ScreeningVM;
using Booking_Movie.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting;
using System.Drawing;
using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace Booking_Movie.Application.Catalog.Movies
{
    public class MovieService : IMovieService
    {
        private readonly MovieRepository _movieRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileStorageService _fileStorage;
        private readonly IMapper _mapper;
        private const string MOVIE_CONTENT_FOLDER_NAME = "movie-content"; // new moviey (must first be created)

        public MovieService(MovieRepository movieRepository, IUnitOfWork unitOfWork, IFileStorageService fileStorageService, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _unitOfWork = unitOfWork;
            _fileStorage = fileStorageService;
            _mapper = mapper;
        }

        public async Task<int?> Create(MovieCreateRequest Request)
        {
            var movie = new Movie()
            {
                Name = Request.Name,
                Alias = Request.Alias,
                Duration = Request.Duration,
                ReleaseDate = Request.ReleaseDate,
                Content = Request.Content,
                Status = Request.Status,
                ProducerId = Request.ProducerId,
                NationalityId = Request.NationalityId,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };

            if (Request.ImageBackground != null)
            {
                movie.ImageBackground = await SaveFile(Request.ImageBackground);
            }

            if (Request.ImagePreview != null)
            {
                movie.ImagePreview = await SaveFile(Request.ImagePreview);
            }


            if (Request.VideoTrailer != null)
            {
                movie.VideoTrailer = await SaveFile(Request.VideoTrailer, "video-trailer");
            }


            var query = _movieRepository.Add(movie);
            await _unitOfWork.Commit();

            if (query != null)
            {
                if (Request.ActorId != null) await _movieRepository.AddCast(movie.Id, Request.ActorId);
                if (Request.CategoryId != null) await _movieRepository.AddMovieCategories(movie.Id, Request.CategoryId);
                if (Request.DirectorId != null) await _movieRepository.AddMovieDirector(movie.Id, Request.DirectorId);
                await _unitOfWork.Commit();

            }
            return await Task.Run(() => movie.Id);
        }

        public async Task<int?> Update(int id, MovieUpdateRequest Request)
        {
            var movie = await _movieRepository.GetSingleByCondition(a => a.Id == id);
            if (movie == null)
                throw new BookingMovieException($"Cann't find a movie with id: {id}");
            if (Request.Name != null) movie.Name = Request.Name;
            if (Request.Alias != null) movie.Alias = Request.Alias;
            if (Request.Duration != null) movie.Duration = Request.Duration.Value;
            if (Request.ReleaseDate != null) movie.ReleaseDate = Request.ReleaseDate.Value;
            if (Request.Content != null) movie.Content = Request.Content;
            if (Request.Status != null) movie.Status = Request.Status.Value;
            if (Request.NationalityId != null) movie.NationalityId = Request.NationalityId;
            if (Request.ProducerId != null) movie.ProducerId = Request.ProducerId.Value;

            if (Request.ActorId != null)
            {
                await _movieRepository.UpdateCast(id, Request.ActorId);
            }

            if (Request.DirectorId != null)
            {
                await _movieRepository.UpdateMovieDirector(id, Request.DirectorId);
            };
            if (Request.CategoryId != null)
            {
                await _movieRepository.UpdateMovieCategory(id, Request.CategoryId);
            }


            movie.UpdatedDate = DateTime.Now;

            if (Request.ImagePreview != null)
            {
                await _fileStorage.DeleteFileAsync(movie.ImagePreview!, MOVIE_CONTENT_FOLDER_NAME);
                movie.ImagePreview = await SaveFile(Request.ImagePreview);
            }
            if (Request.ImageBackground != null)
            {
                await _fileStorage.DeleteFileAsync(movie.ImageBackground!, MOVIE_CONTENT_FOLDER_NAME);
                movie.ImageBackground = await SaveFile(Request.ImageBackground);
            }
            if (Request.VideoTrailer != null)
            {
                await _fileStorage.DeleteFileAsync(movie.VideoTrailer!, $"{MOVIE_CONTENT_FOLDER_NAME}/video-trailer");
                movie.VideoTrailer = await SaveFile(Request.VideoTrailer, "video-trailer");
            }

            _movieRepository.Update(movie);
            if (await _unitOfWork.Commit())
            {
                return movie.Id;

            }
            return null;
        }

        public async Task<List<int>?> Delete(int[] id)
        {
            if (id.Length == 1)
            {
                var movie = await _movieRepository.GetSingleByCondition(a => a.Id == id[0]);
                if (movie == null)
                    throw new BookingMovieException($"Cann't find a movie with id: {id[0]}");

                var movie_deleted = _movieRepository.Delete(movie);
                if (await _unitOfWork.Commit())
                {
                    await _fileStorage.DeleteFileAsync(movie.ImagePreview!, MOVIE_CONTENT_FOLDER_NAME);
                    await _fileStorage.DeleteFileAsync(movie.ImageBackground!, MOVIE_CONTENT_FOLDER_NAME);
                    await _fileStorage.DeleteFileAsync(movie.VideoTrailer!, $"{MOVIE_CONTENT_FOLDER_NAME}/video-trailer");
                }
                return new List<int>() { movie_deleted.Entity.Id };
            }
            else if (id.Length > 1)
            {
                var movies = await _movieRepository.DeleteMulti(id);
                if (movies == null)
                    throw new BookingMovieException($"can't delete much for some reason");


                if (await _unitOfWork.Commit())
                {
                    foreach (var movie in movies)
                    {
                        await _fileStorage.DeleteFileAsync(movie.ImagePreview!, MOVIE_CONTENT_FOLDER_NAME);
                        await _fileStorage.DeleteFileAsync(movie.ImageBackground!, MOVIE_CONTENT_FOLDER_NAME);
                        await _fileStorage.DeleteFileAsync(movie.VideoTrailer!, $"{MOVIE_CONTENT_FOLDER_NAME}/video-trailer");
                    }
                }

                return movies.Select(x => x.Id).ToList();
            }

            return null;

        }

        //public async Task<List<MovieViewModel>> GetAll()
        //{
        //    var movies = await _movieRepository.GetAll(new string[] { "Nationality", "Screenings" })
        //        .Select(movie => new MovieViewModel()
        //        {
        //            Id = movie.Id,
        //            Name = movie.Name,
        //            Content = movie.Content,
        //            Duration = movie.Duration,
        //            ReleaseDate = movie.ReleaseDate,
        //            VideoTrailer = movie.VideoTrailer,
        //            Producer = movie.Producer.Name,
        //            Natinality = movie.Nationality.Name
        //        }).ToListAsync();

        //    return movies;
        //}

        //public async Task<List<MoviePagingVM>> GetAllByJoin()
        //{
        //    var movies = await _movieRepository.GetAllByJoin();
        //    return movies;
        //}

        public async Task<PagedResult<MovieViewModel>> GetAllPaging(GetMoviePagingRequest pagingRequest, string host)
        {
            //1. query
            int total = 0;
            List<Expression<Func<MovieVM, bool>>>? expression = new List<Expression<Func<MovieVM, bool>>>();
            IQueryable<MovieVM> query = null!;


            //2. filter
            if (!String.IsNullOrEmpty(pagingRequest.Nationality) && pagingRequest.Nationality != "all")
            {
                //query = query.Where();
                Expression<Func<MovieVM, bool>> nationalityFilter = m => m.nationality.Id.ToUpper().Contains(pagingRequest.Nationality.ToUpper()); ;
                expression!.Add(nationalityFilter);
            }

            //3.paging
            query = _movieRepository.GetMoviePaging(expression, out total, pagingRequest.PageIndex, pagingRequest.PageSize);


            //4. Get data


            var data = await query.Select(an => new MovieViewModel()
            {

                Id = an.movie.Id,
                Name = an.movie.Name,
                Content = an.movie.Content,
                Duration = an.movie.Duration,
                ReleaseDate = an.movie.ReleaseDate,
                VideoTrailer = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/video-trailer/{an.movie.VideoTrailer}",
                ImagePreview = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/{an.movie.ImagePreview}",
                ImageBackground = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/{an.movie.ImageBackground}",
                Status = an.movie.Status,
                Actors = String.Join(", ", an.actors),
                Producer = an.movie.Producer.Name,
                Directors = String.Join(", ", an.directors),
                Categories = String.Join(", ", an.categories),
                Nationality = an.nationality.Name


            }).ToListAsync();
            //var dataMapper = _mapper.Map<List<MovieViewModel>>(data);


            //dataMapper.ForEach((movie) => {
            //    movie.ImageBackground = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/{movie.ImageBackground}";
            //    movie.ImagePreview = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/{movie.ImagePreview}";
            //    movie.VideoTrailer = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/video-trailer/{movie.VideoTrailer}";
            //});

            var pagedResult = new PagedResult<MovieViewModel>()
            {
                Result = data,
                Total = total,
            };

            return pagedResult;
        }

        public async Task<MovieDetailViewModel?> GetMovieDetails(int Id, string host)
        {
            Expression<Func<MovieVM, bool>> expression = m => m.movie.Id == Id;
            try
            {
                var query = await _movieRepository.GetMovieDetails(expression);
                if (query == null) throw new BookingMovieException("Cannot find a movie with id = " + Id);

                var movie = await query.Select(an => new MovieDetailViewModel()
                {

                    Id = an.movie.Id,
                    Name = an.movie.Name,
                    Content = an.movie.Content,
                    Duration = an.movie.Duration,
                    ReleaseDate = an.movie.ReleaseDate,
                    VideoTrailer = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/video-trailer/{an.movie.VideoTrailer}",
                    ImagePreview = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/{an.movie.ImagePreview}",
                    ImageBackground = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/{an.movie.ImageBackground}",
                    Status = an.movie.Status,
                    Actors = String.Join(", ", an.actors),
                    Producer = an.movie.Producer.Name,
                    Directors = String.Join(", ", an.directors),
                    Categories = String.Join(", ", an.categories),
                    Nationality = an.nationality.Name


                }).SingleOrDefaultAsync();

                return movie!;
            }
            catch (Exception ex)
            {

            }
            return null;


        }

        public async Task<MovieViewModel?> GetById(int id, string host)
        {
            var movie = await _movieRepository.GetSingleByCondition(m => m.Id == id);

            movie!.ImageBackground = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/{movie!.ImageBackground}";
            movie!.ImagePreview = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/{movie!.ImagePreview}";
            movie!.VideoTrailer = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/video-trailer/{movie!.VideoTrailer}";

            var movieVm = _mapper.Map<MovieViewModel>(movie);
            return movieVm;
        }



        public async Task<bool> UpdateImageVideo(int id, MovieUpdateImageVideoRequest request)
        {
            string? preview = null;
            string? video = null;
            string? background = null;
            if (request.preview != null)
            {

                preview = await this.SaveFile(request.preview);
            }
            if (request.background != null)
            {

                background = await this.SaveFile(request.background);
            }
            if (request.video != null)
            {

                video = await this.SaveFile(request.video, "video-trailer");
            }

            var movie = await _movieRepository.UpdateImageVideo(id, preview, background, video);
            if (movie == null)
                throw new BookingMovieException($"Cann't find a movie with id: {id}");
            return await _unitOfWork.Commit();

        }

        public async Task<List<ScreeningViewModel>> GetScreeningByMovieId(int Id)
        {
            try
            {
                var screenings = await _movieRepository.GetScreeningByMovieId(Id);
                if (screenings == null) throw new BookingMovieException("Cannt find a movie with id: " + Id);

                return await screenings.ToListAsync();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ScreeningViewModel>> GetAllScreening()
        {
            try
            {
                var screenings = await _movieRepository.GetAllScreening();
                if (screenings == null) throw new BookingMovieException("Không thể tìm thấy lịch chiếu: ");

                return await screenings.ToListAsync();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        private async Task<string> SaveFile(IFormFile file, string? folder = null)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName!.Trim('"'); // get original file name from Content Disposition Header
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}"; // create file name with Guid is the name of the file
            if (!String.IsNullOrEmpty(folder))
            {
                await _fileStorage.SaveFileAsync(file.OpenReadStream(), fileName, $"{MOVIE_CONTENT_FOLDER_NAME}/{folder}"); // save file

            }
            else await _fileStorage.SaveFileAsync(file.OpenReadStream(), fileName, MOVIE_CONTENT_FOLDER_NAME); // save file
            return fileName;
        }

        public async Task<bool?> AddMovieCategories(int Id, int[] CategoriesId)
        {
            if (CategoriesId.Length > 0)
            {
                await _movieRepository.AddMovieCategories(Id, CategoriesId);
                return await _unitOfWork.Commit();
            }

            return false;
        }

        public async Task<List<MovieCategory>> FindMovieCategoryByMovieId(int Id)
        {
            var movieCategory = await _movieRepository.FindMovieCategoryByMovieId(Id);
            if (movieCategory == null) throw new BookingMovieException("Can't find a movie category with id: " + Id);

            return movieCategory;
        }


        public async Task<bool?> AddCast(int Id, Guid[] actorsId)
        {
            if (actorsId.Length > 0)
            {
                await _movieRepository.AddCast(Id, actorsId);
                return await _unitOfWork.Commit();
            }

            return false;
        }

        public async Task<List<Cast>> FindCastByMovieId(int Id)
        {
            var cast = await _movieRepository.FindCastByMovieId(Id);
            if (cast == null) throw new BookingMovieException("Can't find a cast with id: " + Id);

            return cast;
        }

        public async Task<List<Guid>?> UpdateCast(int Id, Guid[] actorsId)
        {
            if (actorsId.Length > 0)
            {
                await _movieRepository.UpdateCast(Id, actorsId);
                if (await _unitOfWork.Commit())
                {
                    return actorsId.ToList();
                }
            }

            return null;
        }

        public async Task<bool?> AddMovieDirector(int Id, Guid[] directorsId)
        {
            if (directorsId.Length > 0)
            {
                _movieRepository.AddMovieDirector(Id, directorsId);
                return await _unitOfWork.Commit();
            }

            return false;
        }

        public async Task<List<MovieDirector>> FindMovieDirectorByMovieId(int Id)
        {
            var movieDirector = await _movieRepository.FindMovieDirectorByMovieId(Id);
            if (movieDirector == null) throw new BookingMovieException("Can't find a movie director with id: " + Id);

            return movieDirector;
        }
    }
}