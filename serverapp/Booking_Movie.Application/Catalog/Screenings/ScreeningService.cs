using AutoMapper;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.ScreeningVM;
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

        public async Task<Screening?> AddNew(ScreeningCreateRequest request)
        {
            var screening = new Screening()
            {
                AuditoriumId = request.AuditoriumId,
                MovieId = request.MovieId,
                MovieTypeId = request.MovieTypeId,
                ShowTime = request.ShowTime,
            };

            var screening_entity = await _screeningRepository.AddAsync(screening);
            if (await unitOfWork.Commit())
            {
                return screening_entity;

            }

            return null;
        }

        public async Task<bool> Update(int id, ScreeningUpdateRequest request)
        {
            var screening = await _screeningRepository.GetSingleById(id);

            if (screening == null) throw new BookingMovieException("Không tìm thấy lịch chiếu có id: " + id);

            if (request.MovieId != null) screening.MovieId = request.MovieId.Value;
            if (request.MovieTypeId != null) screening.MovieTypeId = request.MovieTypeId.Value;
            if (request.AuditoriumId != null) screening.AuditoriumId = request.AuditoriumId.Value;
            if (request.ShowTime != null) screening.ShowTime = request.ShowTime.Value;

            _screeningRepository.Update(screening);

            return await unitOfWork.Commit();


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
            var screening = await _screeningRepository.GetSingleById(id);

            if(screening == null) throw new BookingMovieException("Không tìm thấy screening với id: " + id);

            var screening_mapper = new ScreeningViewModel()
            {
                Id = screening.Id,
                MovieId = screening.MovieId,
                AuditoriumId = screening.AuditoriumId,
                ScreeningTypeId = screening.MovieTypeId,
                ShowTime = new DateTime[] { screening.ShowTime }
            };

            return screening_mapper;
        }
    }
}
