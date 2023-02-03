using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.SeatNoVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.SeatNos
{
    public class SeatNoService : ISeatNoService
    {
        private readonly SeatNoRepository _seatNoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SeatNoService(SeatNoRepository seatNoRepository, IUnitOfWork unitOfWork)
        {
            _seatNoRepository = seatNoRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<SeatNoViewModel?> UpdateStatus(int id, bool status)
        {
            var SeatNo = await _seatNoRepository.UpdateStatus(id, status);
            if (SeatNo == null) throw new BookingMovieException("Không tìm thấy Ghế Trống có id là: " + id);

            var seatNoVM = await _seatNoRepository.GetSeatNoById(SeatNo.Id);
            return seatNoVM;
        }
    }
}
