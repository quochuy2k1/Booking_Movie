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

        //public async Task<Guid> Create(MovieCreateRequest Request)
        //{
        //    var movie = new Movie()
        //    {
        //        Name = Request.Name,
        //        Height = Request.Height,
        //        ViewCount = 0,
        //        DateOfBirth = Request.DateOfBirth,
        //        NationalityId = Request.Nationality,
        //        CreatedDate = DateTime.Now,
        //        UpdatedDate = DateTime.Now,
        //    };

        //    if (Request.Image != null)
        //    {
        //        movie.Image = await SaveFile(Request.Image);
        //    }

        //    //_Context.Actors.Add(actor);
        //    //await _Context.SaveChangesAsync();
        //    var query = _movieRepository.Add(movie);
        //    await _unitOfWork.Commit();
        //    return await Task.Run(() => movie.ID);
        //}

        //public async Task<bool> Delete(Guid id)
        //{
        //    var movie = await _movieRepository.GetSingleByCondition(a => a.ID == id);
        //    if (movie == null)
        //        throw new BookingMovieException($"Cann't find a movie with id: {id}");

        //    await _fileStorage.DeleteFileAsync(movie.Image!, MOVIE_CONTENT_FOLDER_NAME);
        //    _movieRepository.Delete(movie);
        //    return await _unitOfWork.Commit();
        //}

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
            Expression<Func<Movie, bool>>? expression = null;
            IQueryable<Movie> query = null!;


            //2. filter
            if (!String.IsNullOrEmpty(pagingRequest.Nationality))
            {
                //query = query.Where();
                expression = q => q.Nationality.Name.ToUpper().Contains(pagingRequest.Nationality.ToUpper());
            }

            //3.paging
            query = _movieRepository.GetMultiPaging(expression, out total, pagingRequest.PageIndex, pagingRequest.PageSize);


            //4. Get data

            var data = await query.ToListAsync();
            var dataMapper = _mapper.Map<List<MovieViewModel>>(data);


            dataMapper.ForEach((movie) => {
                movie.ImageBackground = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/{movie.ImageBackground}";
                movie.ImagePreview = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/{movie.ImagePreview}";
                movie.VideoTrailer = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/video-trailer/{movie.VideoTrailer}";
            });

            var pagedResult = new PagedResult<MovieViewModel>()
            {
                Result = dataMapper,
                Total = total,
            };

            return pagedResult;
        }

        public async Task<MovieDetailViewModel?> GetMovieDetails(int Id, string host)
        {
            Expression<Func<MovieDetailsVM, bool>> expression = m => m.movie.Id == Id;
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
                    Actors = String.Join(", ", an.actors),
                    Producer = an.movie.Producer.Name,
                    Directors = String.Join(", ", an.directors),
                    Categories = String.Join(", ", an.categories),
                    Nationality = an.nationality


                }).SingleOrDefaultAsync();

                return movie!;
            }
            catch(Exception ex)
            {

            }
            return null;
           

        }

        //public async Task<MovieViewModel> GetById(Guid id)
        //{
        //    var movie = await _movieRepository.GetSingleByCondition(a => a.ID == id);
        //    var movieVm = _mapper.Map<MovieViewModel>(movie);
        //    return movieVm!;
        //}

        //public async Task<bool> Update(Guid id, MovieUpdateRequest Request)
        //{
        //    var movie = await _movieRepository.GetSingleByCondition(a => a.ID == id);
        //    if (movie == null)
        //        throw new BookingMovieException($"Cann't find a movie with id: {id}");

        //    movie.Name = Request.Name;
        //    movie.Height = Request.Height;
        //    movie.DateOfBirth = Request.DateOfBirth;
        //    movie.NationalityId = Request.Nationality;
        //    movie.UpdatedDate = DateTime.Now;

        //    if (Request.Image != null)
        //    {
        //        movie.Image = await SaveFile(Request.Image);
        //    }
        //    _movieRepository.Update(movie);
        //    return await _unitOfWork.Commit();
        //}

        public async Task<bool> UpdateImageVideo(int id, MovieUpdateImageVideoRequest request)
        {
            string? preview = null;
            string? video = null;
            string? background = null;
            if (request.preview != null)
            {

                preview = await this.SaveFile(request.preview, null);
            } 
            if (request.background != null)
            {

                background = await this.SaveFile(request.background, null);
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
                if(screenings == null) throw new BookingMovieException("Cannt find a movie with id: " + Id);

                return await screenings.ToListAsync();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        private async Task<string> SaveFile(IFormFile file, string? folder)
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

       
    }
}