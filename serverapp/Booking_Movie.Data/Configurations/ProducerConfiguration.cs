using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Movie.Data.Configurations
{
    internal class ProducerConfiguration : IEntityTypeConfiguration<Producer>
    {
        public void Configure(EntityTypeBuilder<Producer> builder)
        {
            builder.ToTable("Producers");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).HasDefaultValueSql("NEWID()");
            builder.Property(x => x.Name).HasColumnType("nvarchar(255)");
            builder.HasOne(p => p.Nationality).WithMany(n => n.Producers).HasForeignKey(x => x.NationalityId).HasConstraintName("fk_producer_nationality");

        }
    }
}