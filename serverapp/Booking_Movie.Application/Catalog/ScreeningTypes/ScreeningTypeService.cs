using AutoMapper;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.ViewModel.Catalog.ScreeningTypeVM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.ScreeningTypes
{
    public class ScreeningTypeService : IScreeningTypeService
    {
        private readonly ScreeningTypeRepository _screeningTypeRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;

        public ScreeningTypeService(ScreeningTypeRepository screeningTypeRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _screeningTypeRepository = screeningTypeRepository;
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<List<ScreeningTypeViewModel>?> GetAllScreeningType()
        {
            var screeningTypes = _screeningTypeRepository.GetAll()
                .Select(x => _mapper.Map<ScreeningTypeViewModel>(x)).ToListAsync();

            return screeningTypes;
        }
    }
}
