using AutoMapper;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.ComboVM;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using Microsoft.EntityFrameworkCore;

namespace Booking_Movie.Application.Catalog.Combos
{
    public class ComboService : IComboService
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
            if (query.Count() > 0)
            {
                return await query.Select(combo => _mapper.Map<ComboViewModel>(combo)).ToListAsync();
            }
            return null;
        }

        public async Task<LoadResult> GetTicketPagingAdmin(GetComboPagingAdminRequest request)
        {
            try
            {
                var query = _comboRepository.GetComboPagingAdmin(request);
                var pagedResult = await DataSourceLoader.LoadAsync<ComboViewModel>(query, request);
                return pagedResult;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Combo?> Create(ComboCreateRequest request)
        {
            var combo = new Combo()
            {
                Name = request.Name,
                Price = request.Price,
                Description = request.Description,
            };

            var query = await _comboRepository.AddAsync(combo);
            if (await _unitOfWork.Commit())
            {
                return query;
            }
            return null;
        }

        public async Task<Combo?> Update(int id, ComboUpdateRequest request)
        {
            var combo = await _comboRepository.GetSingleById(id);
            if (combo == null) throw new BookingMovieException($"Cann't find a combo with id: {id}");

            if (request.Name != null) combo.Name = request.Name;
            if (request.Price != null) combo.Price = request.Price;
            if (request.Description != null) combo.Description = request.Description;

            _comboRepository.Update(combo);
            if (await _unitOfWork.Commit())
            {
                return combo;
            }
            return null;
        }
    }
}