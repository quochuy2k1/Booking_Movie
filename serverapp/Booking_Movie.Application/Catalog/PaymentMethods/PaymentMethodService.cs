using AutoMapper;
using Booking_Movie.Application.Common;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.PaymentMethodVM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.PaymentMethods
{
  
    public class PaymentMethodService: IPaymentMethodService
    {
        private readonly PaymentMethodRepository _paymentMethodRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileStorageService _fileStorage;
        private readonly IMapper _mapper;

        public PaymentMethodService(PaymentMethodRepository paymentMothodRepository, IUnitOfWork unitOfWork, IFileStorageService fileStorage, IMapper mapper)
        {
            _paymentMethodRepository = paymentMothodRepository;
            _unitOfWork = unitOfWork;
            _fileStorage = fileStorage;
            _mapper = mapper;
        }

        public async Task<List<PaymentMethodViewModel>> GetAll()
        {
            var paymentMethod = await _paymentMethodRepository.GetAll().Select(x => _mapper.Map<PaymentMethodViewModel>(x)).ToListAsync();

            if (paymentMethod == null) throw new BookingMovieException("Payment method list is empty");

            return paymentMethod;
        }
    }
}
