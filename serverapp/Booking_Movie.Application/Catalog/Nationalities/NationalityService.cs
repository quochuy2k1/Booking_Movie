using AutoMapper;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.NationalityVM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Nationalities
{
    public class NationalityService : INationalityService
    {
        private readonly NationalityRepository _nationalityRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public NationalityService(NationalityRepository nationalityRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _nationalityRepository = nationalityRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<string?> Create(NationalityCreateRequest Request)
        {
            try
            {
                var nationality = new Nationality()
                {
                    Id = Request.Id,
                    Code = Request.Code,
                    Name = Request.Name,
                    Description = Request.Description,
                    FlagActor = Request.FlagActor,
                    FlagDirector = Request.FlagDirector,
                    FlagMovie = Request.FlagMovie,
                    FlagProducer = Request.FlagProducer
                };

                _nationalityRepository.Add(nationality);
                await _unitOfWork.Commit();
                return nationality.Id;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public async Task<bool> Delete(string id)
        {
            var nationality = await _nationalityRepository.GetSingleById(id);

            if (nationality == null) throw new BookingMovieException("Can't find a nationality with id: " + id);

            _nationalityRepository.Delete(nationality);
            return await _unitOfWork.Commit();
        }

        public async Task<List<NationalityViewModel>?> GetAll()
        {
            var query = _nationalityRepository.GetAll();

            if (await query.AnyAsync())
            {
                var nationalities = await query.ToListAsync();
                var mapping = _mapper.Map<List<NationalityViewModel>>(nationalities);
                return mapping;
            }
            return null;
        }

        public async Task<bool> Update(string id, NationalityUpdateRequest Request)
        {
            var nationality = await _nationalityRepository.GetSingleById(id);

            if(nationality == null) throw new BookingMovieException("Can't find a nationality with id: " + Request.Id);

            nationality.Id = Request.Id;
            nationality.Name = Request.Name;
            nationality.Description = Request.Description;
            nationality.FlagDirector = Request.FlagDirector;
            nationality.FlagActor = Request.FlagActor;
            nationality.FlagMovie = Request.FlagMovie;
            nationality.FlagProducer = Request.FlagProducer;

            _nationalityRepository.Update(nationality);
            return await _unitOfWork.Commit();
        }
    }
}
