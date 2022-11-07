using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Movie.Data.Configurations
{
    public class CastConfiguration : IEntityTypeConfiguration<Cast>
    {
        public void Configure(EntityTypeBuilder<Cast> builder)
        {
            builder.ToTable("Casts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(a => a.Actor).WithMany(c => c.Casts).HasForeignKey(x => x.ActorId).HasConstraintName("fk_cast_actor");
            builder.HasOne(a => a.Movie).WithMany(c => c.Casts).HasForeignKey(x => x.MovieId).HasConstraintName("fk_cast_movie").OnDelete(DeleteBehavior.Restrict);
        }
    }
}