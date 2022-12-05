using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.PaymentMethodVM
{
    public class PaymentMethodViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Alias { get; set; }
         public decimal? Cost { get; set; }
        public decimal? CostAdditional { get; set; }

        public bool Status { get; set; }
    }
}
