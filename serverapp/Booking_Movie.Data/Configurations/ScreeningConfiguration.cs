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
            builder.Property(x => x.ShowTimeId).HasMaxLength(8);

            builder.HasOne(s => s.Auditorium).WithMany(a => a.Screenings).HasForeignKey(x => x.AuditoriumId).HasConstraintName("fk_screening_auditorium");
            builder.HasOne(s => s.Movie).WithMany(a => a.Screenings).HasForeignKey(x => x.MovieId).HasConstraintName("fk_screening_movie");
            builder.HasOne(s => s.ScreeningType).WithMany(a => a.Screenings).HasForeignKey(x => x.ScreeningTypeId).HasConstraintName("fk_screening_movietype");
            builder.HasOne(s => s.ShowTime).WithMany(a => a.Screenings).HasForeignKey(x => x.ShowTimeId).HasConstraintName("fk_screening_showtime");
        }
    }
}