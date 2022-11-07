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
    public class MovieDirectorConfiguration : IEntityTypeConfiguration<MovieDirector>
    {
        public void Configure(EntityTypeBuilder<MovieDirector> builder)
        {
            builder.ToTable("MovieDireactors");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(md => md.Movie).WithMany(m => m.MovieDirectors).HasForeignKey(x => x.MovieId).HasConstraintName("fk_moviedirector_movie").OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(md => md.Director).WithMany(c => c.MovieDirectors).HasForeignKey(x => x.DirectorId).HasConstraintName("fk_moviedirector_director");
        }
    }
}
