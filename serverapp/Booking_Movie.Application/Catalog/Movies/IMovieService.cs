using Booking_Movie.Data.Entities;
using Booking_Movie.ViewModel.Catalog.ChartReportVM;
using Booking_Movie.ViewModel.Catalog.MovieVM;
using Booking_Movie.ViewModel.Catalog.ReportVM.MovieReportVM;
using Booking_Movie.ViewModel.Catalog.ReportVM.TicketComboReportVM;
using Booking_Movie.ViewModel.Catalog.ScreeningVM;
using Booking_Movie.ViewModel.Common;
using DevExtreme.AspNet.Data.ResponseModel;

namespace Booking_Movie.Application.Catalog.Movies
{
    public interface IMovieService
    {
        #region CRUD

        Task<int?> Create(MovieCreateRequest Request);

        Task<int?> Update(int id, MovieUpdateRequest Request);

        Task<List<int>?> Delete(int[] id);

        Task<bool?> AddMovieCategories(int Id, int[] CategotyId);

        Task<List<MovieCategory>> FindMovieCategoryByMovieId(int Id);

        Task<bool?> AddCast(int Id, Guid[] actorsId);

        Task<List<Cast>> FindCastByMovieId(int Id);

        Task<List<Guid>?> UpdateCast(int Id, Guid[] actorsId);

        Task<bool?> AddMovieDirector(int Id, Guid[] directorsId);

        Task<bool> UpdateImageVideo(int id, MovieUpdateImageVideoRequest request);

        #endregion CRUD

        //Task<List<MovieViewModel>> GetAll();
        //Task<List<MovieViewModel>> GetAllByJoin();

        #region get_and_filter

        Task<PagedResult<MovieViewModel>> GetAllPaging(GetMoviePagingRequest pagingRequest, string host);

        Task<LoadResult> GetAllPagingAdmin(GetMoviePagingAdminRequest pagingRequest, string host);

        Task<MovieDetailViewModel?> GetMovieDetails(int Id, string host);

        Task<MovieViewModel?> GetById(int id, string host);

        Task<List<ScreeningViewModel>> GetScreeningByMovieId(int Id, DateTime? ShowDate);

        Task<List<ScreeningViewModel>> GetAllScreening();

        Task<LoadResult> GetAllPagingScreening(GetScreeningPagingRequest pagingRequest, string host);

        Task<LoadResult> GetAllPagingScreeningAdmin(GetScreeningPagingRequest pagingRequest, string host);

        Task<List<MovieDirector>> FindMovieDirectorByMovieId(int Id);

        #endregion get_and_filter

        //Task<bool> Delete(Guid id);

        #region Report

        Task<LoadResult> MovieRevenueReport(MovieRevenueRequest request);

        Task<LoadResult> MovieTicketReport(MovieTicketReportRequest request);

        Task<LoadResult> MovieComboReport(MovieComboReportRequest request);

        Task<LoadResult> MovieTicketComboReport(TicketComboReportRequest request);

        #endregion Report

        #region ChartReport

        Task<List<MovieRevenueChartReportViewModel?>> MovieRevenueChartReport(MovieRevenueChartReportRequest? request);

        Task<List<TicketComboReportChartViewModel>?> TicketComboQuantityChartReport(TicketComboChartReportRequest? request);

        Task<List<TicketComboReportChartViewModel>?> TicketComboRevenueChartReport(TicketComboChartReportRequest? request);

        #endregion ChartReport
    }
}