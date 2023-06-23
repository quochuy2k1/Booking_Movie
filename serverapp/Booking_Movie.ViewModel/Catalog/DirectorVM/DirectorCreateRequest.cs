﻿using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.DirectorVM
{
    public class DirectorCreateRequest
    {
        public string Name { get; set; } = null!;
        public int ViewCount { get; set; }
        public string NationalityId { get; set; } = null!;
        public float Height { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public IFormFile? Image { get; set; }
    }
}