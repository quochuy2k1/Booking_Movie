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
    public class ActorImageConfiguration : IEntityTypeConfiguration<ActorImage>
    {
        public void Configure(EntityTypeBuilder<ActorImage> builder)
        {
            builder.ToTable("ActorImages");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ImagePath).HasMaxLength(255).IsRequired(true);
            builder.Property(x => x.Caption).HasMaxLength(255);
            builder.HasOne(ai => ai.Actor).WithMany(a => a.ActorImages).HasForeignKey(x => x.ActorId).HasConstraintName("fk_actorimage_actor");
        }
    }
}
