using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Movie.Data.Configurations
{
    internal class SeatReservedConfiguration : IEntityTypeConfiguration<SeatReserved>
    {
        public void Configure(EntityTypeBuilder<SeatReserved> builder)
        {
            builder.ToTable("SeatReserveds");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.SeatNoId).IsRequired();

            builder.HasOne(s => s.Booking).WithMany(a => a.SeatReserveds).HasForeignKey(x => x.BookingId).HasConstraintName("fk_seatreserved_booking");
            builder.HasOne(s => s.SeatNo).WithMany(a => a.SeatReserveds).HasForeignKey(x => x.SeatNoId).OnDelete(DeleteBehavior.Restrict).HasConstraintName("fk_seatreserved_seatno");
        }
    }
}