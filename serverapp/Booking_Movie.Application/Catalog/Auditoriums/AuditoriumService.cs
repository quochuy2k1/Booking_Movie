using AutoMapper;
using Booking_Movie.Application.Common;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Models;
using Booking_Movie.Data.Repositories;
using Booking_Movie.ViewModel.Catalog.AuditoriumVM;
using Booking_Movie.ViewModel.Catalog.MovieVM;
using Booking_Movie.ViewModel.Catalog.SeatNoVM;
using Booking_Movie.ViewModel.Catalog.SeatVM;
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

namespace Booking_Movie.Application.Catalog.Auditoriums
{
    public class AuditoriumService : IAuditoriumService
    {
        private readonly AuditoriumRepository _auditoriumRepository;
        private readonly SeatNoRepository _seatNoRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AuditoriumService(AuditoriumRepository auditoriumRepository, SeatNoRepository seatNoRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _auditoriumRepository = auditoriumRepository;
            _seatNoRepository = seatNoRepository;
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

        public async Task<LoadResult> GetAuditoriumPagingAdmin(GetAuditoriumPagingAdminRequest pagingRequest, string host)
        {
            var query = _auditoriumRepository.GetAuditoriumPagingAdmin(pagingRequest);
            try
            {
                var pagedResult = await DataSourceLoader.LoadAsync<AuditoriumViewModel>(query, pagingRequest);
                return pagedResult;
            }
            catch (Exception)
            {
                throw;
            }
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

        public async Task<bool> SeatNoSaveChange(int auditoriumId, SeatNoSaveChangeRequest request)
        {
            if(request != null)
            {
                if(request.SeatNoActions != null)
                {
                    foreach (var seatNoAction in request.SeatNoActions)
                    {
                        if(seatNoAction.Action != null && seatNoAction.Action.ToLower() == "Insert".ToLower() && seatNoAction.SeatNos != null)
                        {
                            foreach(var seatNoRequest in seatNoAction.SeatNos)
                            {
                                if (seatNoRequest.SeatNoId == null)
                                {
                                    var seatNo = new SeatNo()
                                    {
                                        SeatId = seatNoRequest.SeatId,
                                        AuditoriumId = seatNoRequest.AuditoriumId ?? auditoriumId,
                                        ColumnIndex = seatNoRequest.ColumnIndex,
                                        RowIndex = seatNoRequest.RowIndex,
                                        SeatStyleId = 5,
                                        Status = seatNoRequest.Status ?? false,
                                    };

                                    await _seatNoRepository.AddAsync(seatNo);
                                }
                                else
                                {
                                    var seatNo = await _seatNoRepository.GetSingleByCondition(x => x.Id == seatNoRequest.SeatNoId.Value);
                                    if (seatNo != null)
                                    {
                                        seatNo.SeatId = seatNoRequest.SeatId;
                                        seatNo.AuditoriumId = auditoriumId;
                                        _seatNoRepository.Update(seatNo);

                                    }
                                }
                            }

                            
                        }
                        else if (seatNoAction.Action != null && seatNoAction.Action.ToLower() == "Update".ToLower() && seatNoAction.SeatNos != null)
                        {
                            foreach (var seatNoRequest in seatNoAction.SeatNos)
                            {
                                if (seatNoRequest.SeatNoId != null)
                                {
                                    var seatNo = await _seatNoRepository.GetSingleByCondition(x => x.Id == seatNoRequest.SeatNoId);
                                    if (seatNo != null)
                                    {
                                        seatNo.SeatId = seatNoRequest.SeatId;
                                        seatNo.ColumnIndex = seatNoRequest.ColumnIndex;
                                        _seatNoRepository.Update(seatNo);

                                    }

                                }
                                else
                                {
                                    var seatNo = new SeatNo()
                                    {
                                        SeatId = seatNoRequest.SeatId,
                                        AuditoriumId = seatNoRequest.AuditoriumId ?? auditoriumId,
                                        ColumnIndex = seatNoRequest.ColumnIndex,
                                        RowIndex = seatNoRequest.RowIndex,
                                        SeatStyleId = 5,
                                        Status = seatNoRequest.Status ?? false,
                                    };

                                    await _seatNoRepository.AddAsync(seatNo);
                                }

                            }
                        }
                         else if (seatNoAction.Action != null && seatNoAction.Action.ToLower() == "Delete".ToLower() && seatNoAction.SeatNos != null)
                        {
                            foreach (var seatNoRequest in seatNoAction.SeatNos)
                            {
                                if (seatNoRequest.SeatNoId != null)
                                {
                                    var seatNo = await _seatNoRepository.GetSingleByCondition(x => x.Id == seatNoRequest.SeatNoId);
                                    if (seatNo != null)
                                    {
                                        _seatNoRepository.Delete(seatNo);

                                    }

                                }
                                

                            }
                        }
                       
                    }
                    
                    if(await _unitOfWork.Commit())
                    {
                        return true;
                    }
                }
                
            }

            return false;
        }
    }
}
