﻿using Booking_Movie.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.TicketVM
{
    public class GetTicketPagingAdminRequest : DXPagingRequestBase
    {
        public int? MovieId { get; set; }
    }
}