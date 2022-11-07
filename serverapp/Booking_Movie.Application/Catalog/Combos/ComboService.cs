using AutoMapper;
using Booking_Movie.Application.Common;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.ViewModel.Catalog.ComboVM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Combos
{
    public class ComboService: IComboService
    {
        private readonly ComboRepository _comboRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ComboService(ComboRepository comboRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _comboRepository = comboRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ComboViewModel>?> GetCombos()
        {
            var query = _comboRepository.GetAll();
            if(query.Count() > 0)
            {
                return await query.Select(combo => _mapper.Map<ComboViewModel>(combo)).ToListAsync();

            }
            return null;
        }
    }
}
