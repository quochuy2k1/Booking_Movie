using AutoMapper;
using Booking_Movie.Application.Common;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.ViewModel.Catalog.TicketVM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Tickets
{
    public class TicketService : ITicketService
    {
        private readonly TicketRepository _ticketRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
       

        public TicketService(TicketRepository ticketRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<TicketViewModel>> GetTickets()
        {
            var query = _ticketRepository.GetAll();

            var movies = query.Select(ticket => _mapper.Map<TicketViewModel>(ticket));

            return await movies.ToListAsync();
        }
    }
}
