using Booking_Movie.ViewModel.Catalog.PaymentMethodVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.PaymentMethods
{
    public interface IPaymentMethodService
    {
        Task<List<PaymentMethodViewModel>> GetAll();
    }
}
