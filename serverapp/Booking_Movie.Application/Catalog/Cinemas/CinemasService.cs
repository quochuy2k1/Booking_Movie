using AutoMapper;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.ActorVM;
using Booking_Movie.ViewModel.Catalog.AuditoriumVM;
using Booking_Movie.ViewModel.Catalog.CinemaVM;
using Booking_Movie.ViewModel.Catalog.MovieVM;
using Booking_Movie.ViewModel.Common;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Cinemas
{
    public class CinemasService : ICinemasService
    {
        private readonly CimemaRepository _cimemaRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;

        public CinemasService(CimemaRepository cimemaRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _cimemaRepository = cimemaRepository;
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<CinemaViewModel>> GetAllCinema()
        {
            var cinemas = await _cimemaRepository.GetAll()
                .Select(x => _mapper.Map<CinemaViewModel>(x)).ToListAsync();

            return cinemas;
        }

        public async Task<PagedResult<CinemaViewModel>> GetAllPaging(GetCinemaPagingRequest pagingRequest, string host)
        {
            //1. query
            int total = 0;
            IQueryable<Cinema?> query = null!;
            Expression<Func<Cinema, bool>> expression = null!;

            //2. filter
            //if (!String.IsNullOrEmpty(pagingRequest.Nationality))
            //{
            //    //query = query.Where();
            //    expression = q => q.Nationality.Name.ToUpper().Contains(pagingRequest.Nationality.ToUpper());
            //}

            query = _cimemaRepository.GetMultiPaging(expression, out total, pagingRequest.PageIndex.Value, pagingRequest.PageSize, new string[] {"Location"});


            //3.paging

            //var totalRow = await query!.CountAsync();

            //query = query!.Skip((pagingRequest.PageIndex - 1) * pagingRequest.PageSize)
            //    .Take(pagingRequest.PageSize);

            //if (pagingRequest.SortBy == ViewModel.Enums.SortByActor.ViewCount)
            //{
            //    query = query.OrderBy(q => q!.ViewCount);
            //}

            //4. Get data

            var data = await query.ToListAsync();
           
            var dataMapper = _mapper.Map<List<CinemaViewModel>>(data);

            var pagedResult = new PagedResult<CinemaViewModel>()
            {
                Result = dataMapper,
                Total = total,
            };

            return pagedResult;
        }

        public async Task<LoadResult> GetAllPagingAdmin(GetCinemaPagingAdminRequest pagingRequest, string host)
        {
            var query = _cimemaRepository.GetCinemaPagingAdmin()
                .Select(x=> new CinemaViewModel()
                {
                    Id = x.Id,
                    Address = x.Address,
                    LocationName = x.Location.Name,
                    Name = x.Name,
                });

            try
            {

                var pagedResult = await DataSourceLoader.LoadAsync<CinemaViewModel>(query, pagingRequest);
                return pagedResult;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<AuditoriumViewModel>> GetAuditoriumByCinemaId(int cinemaId)
        {
            var auditoriums = await _cimemaRepository.GetAuditoriumByCinemaId(cinemaId)
                .Select(x => _mapper.Map<AuditoriumViewModel>(x)).ToListAsync();

            if (!auditoriums.Any()) throw new BookingMovieException("Không tìm thấy phòng với id rạp là " + cinemaId);

            return auditoriums;
        }
    }
}
