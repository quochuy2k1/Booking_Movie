using AutoMapper;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.TicketTypeVM;
using Booking_Movie.ViewModel.Catalog.TicketVM;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.TicketTypes
{
    public class TicketTypeService : ITicketTypeService
    {
        private readonly TicketTypeRepository _ticketTypeRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TicketTypeService(TicketTypeRepository ticketTypeRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _ticketTypeRepository = ticketTypeRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<LoadResult> GetTicketTypePagingAdmin(GetTicketTypePagingAdminRequest request)
        {
            try
            {
                var query = _ticketTypeRepository.GetTicketTypePagingAdmin(request);
                if (query == null) throw new BookingMovieException("Không tìm thấy loại vé.");
                var ticketType = query.Select(x => _mapper.Map<TicketTypeViewModel>(x));
                var pagedResult = await DataSourceLoader.LoadAsync<TicketTypeViewModel>(ticketType, request);
                return pagedResult;
            }catch (Exception)
            {
                throw;
            }

            }
    }
}
