using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Models;
using Booking_Movie.ViewModel.Catalog.MovieVM;
using Booking_Movie.ViewModel.Catalog.ScreeningVM;
using Booking_Movie.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using System.Linq.Expressions;

namespace Booking_Movie.Application.Catalog.Movies
{
    public interface IMovieService
    {
        Task<int?> Create(MovieCreateRequest Request);
        Task<int?> Update(int id, MovieUpdateRequest Request);
        Task<List<int>?> Delete(int[] id);
        Task<bool?> AddMovieCategories(int Id, int[] CategotyId);
        Task<List<MovieCategory>> FindMovieCategoryByMovieId(int Id);

        Task<bool?> AddCast(int Id, Guid[] actorsId);
        Task<List<Cast>> FindCastByMovieId(int Id);

        Task<List<Guid>?> UpdateCast(int Id, Guid[] actorsId);
        Task<bool?> AddMovieDirector(int Id, Guid[] directorsId);
        Task<List<MovieDirector>> FindMovieDirectorByMovieId(int Id);

        //Task<List<MovieViewModel>> GetAll();
        //Task<List<MovieViewModel>> GetAllByJoin();


        Task<PagedResult<MovieViewModel>> GetAllPaging(GetMoviePagingRequest pagingRequest, string host);
        Task<MovieDetailViewModel?> GetMovieDetails(int Id, string host);
        Task<MovieViewModel?> GetById(int id, string host);
        Task<List<ScreeningViewModel>> GetScreeningByMovieId(int Id);
        Task<List<ScreeningViewModel>> GetAllScreening();
        Task<bool> UpdateImageVideo(int id, MovieUpdateImageVideoRequest request);

        //Task<bool> Delete(Guid id);

    }
}