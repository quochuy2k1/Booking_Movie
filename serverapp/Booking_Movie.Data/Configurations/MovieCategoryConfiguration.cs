using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Movie.Data.Configurations
{
    internal class MovieCategoryConfiguration : IEntityTypeConfiguration<MovieCategory>
    {
        public void Configure(EntityTypeBuilder<MovieCategory> builder)
        {
            builder.ToTable("MovieCategories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(mc => mc.Category).WithMany(c => c.MovieCategories).HasForeignKey(x => x.CategoryId).HasConstraintName("fk_moviecategory_category");
            builder.HasOne(mc => mc.Movie).WithMany(c => c.MovieCategories).HasForeignKey(x => x.MovieId).HasConstraintName("fk_moviecategory_movie");
        }
    }
}