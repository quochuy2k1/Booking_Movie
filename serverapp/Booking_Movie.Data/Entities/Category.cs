using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public int? ParentId { get; set; }
        public int? DisplayOrder { get; set; }

        public string Image { get; set; } = null!;

        public bool HomeFlag { get; set; }

        public ICollection<MovieCategory> MovieCategories { get; set; } = null!;
    }
}
