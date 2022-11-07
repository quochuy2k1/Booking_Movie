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
    public class DirectorImageConfiguration : IEntityTypeConfiguration<DirectorImage>
    {
        public void Configure(EntityTypeBuilder<DirectorImage> builder)
        {
            builder.ToTable("DirectorImages");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ImagePath).HasMaxLength(255).IsRequired(true);
            builder.Property(x => x.Caption).HasMaxLength(255);
            builder.HasOne(di => di.Director).WithMany(d => d.DirectorImages).HasForeignKey(x => x.DirectorId).HasConstraintName("fk_directorimage_director");

        }
    }
}
