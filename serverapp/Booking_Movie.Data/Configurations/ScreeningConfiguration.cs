using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Movie.Data.Configurations
{
    internal class ScreeningConfiguration : IEntityTypeConfiguration<Screening>
    {
        public void Configure(EntityTypeBuilder<Screening> builder)
        {
            builder.ToTable("Screenings");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(s => s.Auditorium).WithMany(a => a.Screenings).HasForeignKey(x => x.AuditoriumId).HasConstraintName("fk_screening_auditorium");
            builder.HasOne(s => s.Movie).WithMany(a => a.Screenings).HasForeignKey(x => x.MovieId).HasConstraintName("fk_screening_movie");
            builder.HasOne(s => s.MovieType).WithMany(a => a.Screenings).HasForeignKey(x => x.MovieTypeId).HasConstraintName("fk_screening_movietype");
        }
    }
}