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
                    DateFrom = request.DateFrom.Value.ToLocalTime(),
                    DateTo = request.DateTo.Value.ToLocalTime(),
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

                    foreach (var screening in lstSrceening)
                    {
                        //screening.MovieId = request.MovieId ?? screening.MovieId;
                        //screening.AuditoriumId = request.AuditoriumId ?? screening.AuditoriumId;
                        screening.ScreeningTypeId = request.ScreeningTypeId ?? screening.ScreeningTypeId;
                        screening.DateFrom = request.DateFrom == null ? screening.DateFrom : request.DateFrom.Value.ToLocalTime();
                        screening.DateTo = request.DateTo == null ?  screening.DateTo : request.DateTo.Value.ToLocalTime();

                        _screeningRepository.Update(screening);
                    }


                    if (request.ShowTimeId != null)
                    {
                        //var screeningGrouped = await _screeningRepository.DeleteAllShowTimeScreening(screeningGroupedId);
                        var deletedScreenings = await _screeningRepository.GetDeletedShowTime(lstSrceening[0].MovieId, lstSrceening[0].AuditoriumId, request.ShowTimeId);

                        if (deletedScreenings.Count > 0)
                        {
                            foreach (var deletedScreening in deletedScreenings)
                            {
                                //var checkShowTime = await _screeningRepository.GetByShowTime(lstSrceening[0].MovieId, lstSrceening[0].AuditoriumId, showTime).FirstOrDefaultAsync();

                                await _screeningRepository.Delete(deletedScreening.Id);


                            }

                        }

                        var addedScreenings = request.ShowTimeId.Where(x => !lstSrceening.Select(x => x.ShowTimeId).Contains(x)).ToList();

                        if (addedScreenings.Count > 0)
                        {
                            foreach (var addedScreening in addedScreenings)
                            {
                                var screening = new Screening()
                                {
                                    AuditoriumId = request.AuditoriumId ?? lstSrceening[0].AuditoriumId,
                                    MovieId = request.MovieId ?? lstSrceening[0].MovieId,
                                    ScreeningTypeId = request.ScreeningTypeId ?? lstSrceening[0].ScreeningTypeId,
                                    DateFrom = request.DateFrom ?? lstSrceening[0].DateFrom,
                                    DateTo = request.DateTo ?? lstSrceening[0].DateTo,
                                    ShowTimeId = addedScreening

                                };
                                await _screeningRepository.AddAsync(screening);
                            }
                        }




                    }


                }



                if (await unitOfWork.Commit())
                {

                    return true;

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
