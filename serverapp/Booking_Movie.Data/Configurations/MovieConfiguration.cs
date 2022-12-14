using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Movie.Data.Configurations
{
    internal class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movies");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Content).HasColumnType("nvarchar(max)");
            builder.Property(x => x.Duration).HasColumnType("smallint");
            builder.Property(x => x.ImagePreview).HasColumnType("nvarchar(255)").HasDefaultValue("duongdan.jpg");
            builder.Property(x => x.ImageBackground).HasColumnType("nvarchar(255)").HasDefaultValue("duongdan.jpg");
            builder.Property(x => x.VideoTrailer).HasColumnType("nvarchar(255)").IsRequired(false);

            builder.HasOne(d => d.Nationality).WithMany(n => n.Movies).HasForeignKey(x => x.NationalityId).HasConstraintName("fk_movie_nationality");
            builder.HasOne(d => d.Producer).WithMany(m => m.Movies).HasForeignKey(x => x.ProducerId).HasConstraintName("fk_movie_producer").OnDelete(DeleteBehavior.Restrict);
        }
    }
}