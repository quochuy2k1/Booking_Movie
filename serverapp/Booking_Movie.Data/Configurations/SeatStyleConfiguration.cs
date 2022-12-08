using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Data.Configurations
{
    public class SeatStyleConfiguration : IEntityTypeConfiguration<SeatStyle>
    {
        public void Configure(EntityTypeBuilder<SeatStyle> builder)
        {
            builder.ToTable("SeatStyles");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsUnicode().HasMaxLength(255);
            builder.Property(x => x.Description).IsUnicode().HasMaxLength(255);
        }
    }
}
