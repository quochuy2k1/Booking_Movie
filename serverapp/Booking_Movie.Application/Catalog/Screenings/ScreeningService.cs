using AutoMapper;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.ScreeningVM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Screenings
{
    public class ScreeningService : IScreeningService
    {
        private readonly ScreeningRepository _screeningRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;

        public ScreeningService(ScreeningRepository screeningRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _screeningRepository = screeningRepository;
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool?> AddNew(ScreeningCreateRequest request)
        {
            //Screening? screening_entity = null;
            foreach (var showTime in request.ShowTimeId)
            {
                var screening = new Screening()
                {
                    AuditoriumId = request.AuditoriumId.Value,
                    MovieId = request.MovieId.Value,
                    ScreeningTypeId = request.ScreeningTypeId.Value,
                    DateFrom = request.DateFrom.Value,
                    DateTo = request.DateTo.Value,
                    ShowTimeId = showTime

                };
                await _screeningRepository.AddAsync(screening);

            }


            if (await unitOfWork.Commit())
            {

                return true;

            }

            return false;
        }

        public async Task<bool> Update(int screeningGroupedId, ScreeningUpdateRequest request)
        {
            if (request != null)
            {
                var lstSrceening = await _screeningRepository.GetByScreeningGrouped(screeningGroupedId);

                if (lstSrceening != null)
                {

                    if (request.ShowTimeId != null)
                    {
                        var screeningGrouped = await _screeningRepository.DeleteAllShowTimeScreening(screeningGroupedId);

                        foreach (var showTime in request.ShowTimeId)
                        {
                            var screening = new Screening()
                            {
                                AuditoriumId = request.AuditoriumId ?? screeningGrouped.AuditoriumId,
                                MovieId = request.MovieId ?? screeningGrouped.MovieId,
                                ScreeningTypeId = request.ScreeningTypeId ?? screeningGrouped.ScreeningTypeId,
                                DateFrom = request.DateFrom ?? screeningGrouped.DateFrom,
                                DateTo = request.DateTo ?? screeningGrouped.DateTo,
                                ShowTimeId = showTime

                            };
                            await _screeningRepository.AddAsync(screening);

                        }
                        


                    }
                    else
                    {

                        if (lstSrceening != null)
                        {
                            foreach (var screening in lstSrceening)
                            {
                                screening.MovieId = request.MovieId ?? screening.MovieId;
                                screening.AuditoriumId = request.AuditoriumId ?? screening.AuditoriumId;
                                screening.ScreeningTypeId = request.ScreeningTypeId ?? screening.ScreeningTypeId;
                                screening.DateFrom = request.DateFrom ?? screening.DateFrom;
                                screening.DateTo = request.DateTo ?? screening.DateTo;

                                _screeningRepository.Update(screening);
                            }
                        }
                    }



                    if (await unitOfWork.Commit())
                    {

                        return true;

                    }
                }



                return false;
            }

            return false;


        }

        public async Task<List<int>?> Delete(int[] id)
        {
            if (id.Length == 1)
            {
                var screening = await _screeningRepository.GetSingleByCondition(a => a.Id == id[0]);
                if (screening == null)
                    throw new BookingMovieException($"Cann't find a screening with id: {id}");


                _screeningRepository.Delete(screening);
                if (await unitOfWork.Commit())
                {
                    return new List<int>(){
                                    screening.Id,
                                };
                }

            }
            else if (id.Length > 1)
            {
                var screenings = await _screeningRepository.DeleteMulti(id);
                if (screenings == null)
                    throw new BookingMovieException($"can't delete much for some reason");

                if (await unitOfWork.Commit())
                {

                    return screenings.Select(x => x.Id).ToList();
                }

            }
            return null;
        }

        public async Task<ScreeningViewModel> GetById(int id)
        {
            var screening = await _screeningRepository.GetSingleByCondition(x => x.Id == id, new string[] { "ShowTime" });

            if (screening == null) throw new BookingMovieException("Không tìm thấy screening với id: " + id);

            var screening_mapper = new ScreeningViewModel()
            {
                Id = screening.Id,
                MovieId = screening.MovieId,
                AuditoriumId = screening.AuditoriumId,
                ScreeningTypeId = screening.ScreeningTypeId,
                MovieSchedule = new List<MovieSchedule>()
                {
                   new MovieSchedule() {
                   ShowTime =  screening.ShowTime.Time ,
                   Id = screening.Id
                   }
                }
            };

            return screening_mapper;
        }

        public async Task<ScreeningViewModel> GetByShowTime(int movieId, int auditoriumId, string showTimeId)
        {
            var query = _screeningRepository.GetByShowTime(movieId, auditoriumId, showTimeId);

            if (query == null) throw new BookingMovieException("Không tìm thấy screening với id: " + showTimeId);

            var screening_mapper = await query.Select(x => new ScreeningViewModel()
            {
                Id = x.Id,
                MovieId = x.MovieId,
                AuditoriumId = x.AuditoriumId,
                ScreeningTypeId = x.ScreeningTypeId,
                MovieSchedule = new List<MovieSchedule>()
                {
                   new MovieSchedule() {
                   ShowTime =  x.ShowTime.Time ,
                   Id = x.Id
                   }
                }
            }).FirstOrDefaultAsync();

            return screening_mapper;
        }
    }
}
