using AutoMapper;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.AuditoriumVM;
using Booking_Movie.ViewModel.Catalog.CinemaVM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<List<AuditoriumViewModel>> GetAuditoriumByCinemaId(int cinemaId)
        {
            var auditoriums = await _cimemaRepository.GetAuditoriumByCinemaId(cinemaId)
                .Select(x => _mapper.Map<AuditoriumViewModel>(x)).ToListAsync();

            if (!auditoriums.Any()) throw new BookingMovieException("Không tìm thấy phòng với id rạp là " + cinemaId);

            return auditoriums;
        }
    }
}
