using AutoMapper;
using Booking_Movie.Application.Common;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.MovieVM;
using Booking_Movie.ViewModel.Catalog.TicketVM;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

        public async Task<LoadResult> GetTicketPagingAdmin(GetTicketPagingAdminRequest request)
        {
            try
            {
                var query = _ticketRepository.GetTicketPagingAdmin(request);
                var pagedResult = await DataSourceLoader.LoadAsync<TicketViewModel>(query, request);
                return pagedResult;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<ScreeningTicketViewModel>> GetTicketByMovieId(string id, DateTime dateTo)
        {
            var query = _ticketRepository.GetTicketByMovieId(id, dateTo);
            return await query.ToListAsync();
        }

        public async Task<List<ScreeningTicketViewModel>> GetTicketByScreeningId(string id)
        {
            var query = _ticketRepository.GetTicketByScreeningId(id);
            return await query.ToListAsync();
        }

        public async Task<List<TicketViewModel>> GetTickets()
        {
            var query = _ticketRepository.GetAll();

            var movies = query.Select(ticket => _mapper.Map<TicketViewModel>(ticket));

            return await movies.ToListAsync();
        }

        public async Task<Ticket?> Create(TicketCreateRequest request)
        {
            var ticket = new Ticket()
            {
                Name = request.Name,
                Price = request.Price,
                Description = request.Description,
                TicketTypeId = request.TicketTypeId,
                MovieId = request.MovieId,
                ValidityDateFromId = request.ValidityDateFromId,
                ValidityDateToId = request.ValidityDateToId,
            };

            var query = await _ticketRepository.AddAsync(ticket);
            if (await _unitOfWork.Commit())
            {
                return query;

            }
            return null;

        } 
        public async Task<Ticket?> Update(int id, TicketUpdateRequest request)
        {
            var ticket = await _ticketRepository.GetSingleById(id);
            if(ticket == null) throw new BookingMovieException($"Cann't find a ticket with id: {id}");

            if (request.Name != null) ticket.Name = request.Name;
            if(request.Price != null) ticket.Price = request.Price.Value;
            if(request.Description != null) ticket.Description = request.Description;
            if(request.MovieId != null) ticket.MovieId = request.MovieId.Value;
            if(request.TicketTypeId != null) ticket.TicketTypeId = request.TicketTypeId.Value;
            if(request.ValidityDateFromId != null) ticket.ValidityDateFromId = request.ValidityDateFromId;
            if(request.ValidityDateToId != null) ticket.ValidityDateToId = request.ValidityDateToId;

            _ticketRepository.Update(ticket);
            if(await _unitOfWork.Commit())
            {
                return ticket;

            }
            return null;
        }
    }
}
