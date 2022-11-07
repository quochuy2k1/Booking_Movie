using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Movie.Data.Configurations
{
    internal class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.ToTable("Actors");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).HasDefaultValueSql("NEWID()");
            builder.Property(x => x.Name).IsRequired().HasColumnType("nvarchar").HasMaxLength(255);
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)");
            builder.Property(x => x.Height).IsRequired().HasColumnType("decimal(3,2)");
            builder.HasOne(a => a.Nationality).WithMany(n => n.Actors).HasForeignKey(x => x.NationalityId).HasConstraintName("fk_actor_nationality");

        }
    }
}