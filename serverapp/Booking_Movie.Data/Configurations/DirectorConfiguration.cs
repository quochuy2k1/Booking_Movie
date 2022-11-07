using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Movie.Data.Configurations
{
    internal class DirectorConfiguration : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.ToTable("Directors");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).HasDefaultValueSql("NEWID()");
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)");
            builder.Property(x => x.Height).IsRequired().HasColumnType("decimal(3,2)");
            builder.HasOne(d => d.Nationality).WithMany(n => n.Directors).HasForeignKey(x => x.NationalityId).HasConstraintName("fk_director_nationality");

        }
    }
}