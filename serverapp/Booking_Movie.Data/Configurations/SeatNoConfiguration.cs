using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Movie.Data.Configurations
{
    internal class SeatNoConfiguration : IEntityTypeConfiguration<SeatNo>
    {
        public void Configure(EntityTypeBuilder<SeatNo> builder)
        {
            builder.ToTable("SeatNos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.SeatId).HasColumnType("varchar(5)");
            builder.HasOne(s => s.Auditorium).WithMany(a => a.SeatNos).HasForeignKey(x => x.AuditoriumId).HasConstraintName("fk_seatno_auditorium");
            builder.HasOne(s => s.Seat).WithMany(s => s.SeatNos).HasForeignKey(x => x.SeatId).HasConstraintName("fk_seatno_seat");
        }
    }
}