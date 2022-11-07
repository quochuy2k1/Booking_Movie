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
    public class NationalityConfiguration : IEntityTypeConfiguration<Nationality>
    {
        public void Configure(EntityTypeBuilder<Nationality> builder)
        {
            builder.ToTable("Nationalities");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnType("varchar").HasMaxLength(8).IsRequired();

            builder.Property(x => x.Name).HasColumnType("nvarchar").HasMaxLength(100).IsRequired(true);
            builder.Property(x => x.Code).HasColumnType("varchar").HasMaxLength(8);

        }
    }
}
