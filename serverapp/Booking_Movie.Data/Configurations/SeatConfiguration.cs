using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Movie.Data.Configurations
{
    internal class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.ToTable("Seats");
            builder.HasKey(x => x.SeatId);
            builder.Property(x => x.SeatId).HasColumnType("varchar(5)");
            builder.Property(x => x.Number).HasColumnType("tinyint");
            builder.Property(x => x.Row).HasColumnType("varchar(1)");
        }
    }
}