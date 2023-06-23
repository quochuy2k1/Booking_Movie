﻿namespace Booking_Movie.ViewModel.Catalog.ComboVM
{
    public class ComboViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? Price { get; set; }
    }
}