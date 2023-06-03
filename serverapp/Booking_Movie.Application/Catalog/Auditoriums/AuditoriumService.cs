using AutoMapper;
using Booking_Movie.Application.Common;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Models;
using Booking_Movie.Data.Repositories;
using Booking_Movie.ViewModel.Catalog.AuditoriumVM;
using Booking_Movie.ViewModel.Catalog.SeatVM;
using Booking_Movie.ViewModel.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Auditoriums
{
    public class AuditoriumService : IAuditoriumService
    {
        private readonly AuditoriumRepository _auditoriumRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AuditoriumService(AuditoriumRepository auditoriumRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _auditoriumRepository = auditoriumRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<PagedResult<AuditoriumViewModel>> GetAllPaging(GetAuditoriumPagingRequest pagingRequest, string host)
        {
            //1. query
            int total = 0;
            IQueryable<Auditorium?> query = null!;
            Expression<Func<Auditorium, bool>> expression = null!;

            //2. filter
            if (pagingRequest.CinemaId.HasValue)
            {
                //query = query.Where();
                expression = q => q.CinemaId.Equals(pagingRequest.CinemaId);
            }

            query = _auditoriumRepository.GetMultiPaging(expression, out total, pagingRequest.PageIndex.Value, pagingRequest.PageSize, new string[] { "Cinema" });


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

            var dataMapper = _mapper.Map<List<AuditoriumViewModel>>(data);

            var pagedResult = new PagedResult<AuditoriumViewModel>()
            {
                Result = dataMapper,
                Total = total,
            };

            return pagedResult;
        }

        public async Task<List<string>> GetRowOfSeatsByAuditoriumId(int Id)
        {
            var query = await _auditoriumRepository.GetRowOfSeatsByAuditoriumId(Id);

            try
            {
                if (query.Count() > 0)
                {
                    return await query.ToListAsync();
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<SeatInAuditoriumViewModel>?> GetSeatByAuditoriumId(int id)
        {
            IQueryable<SeatInAuditoriumViewModel> query = await _auditoriumRepository.GetSeatsByAuditoriumId(id);

            try
            {
                if (query.Any())
                {
                    return await query.ToListAsync();
                }
                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
