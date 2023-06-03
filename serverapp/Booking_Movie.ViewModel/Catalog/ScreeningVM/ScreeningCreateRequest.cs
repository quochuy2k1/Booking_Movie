﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.ScreeningVM
{
    public class ScreeningCreateRequest
    {
        public List<string>? ShowTimeId { get; set; }
        public int? AuditoriumId { get; set; }
        public int? MovieId { get; set; }
        public int? ScreeningTypeId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }

    public class DXScreeningCreateRequest
    {
        public ScreeningCreateRequest? Values { get; set; }
    }
}
