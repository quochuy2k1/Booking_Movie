using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Movie.Data.Configurations
{
    internal class BookingTicketConfiguration : IEntityTypeConfiguration<BookingTicket>
    {
        public void Configure(EntityTypeBuilder<BookingTicket> builder)
        {
            builder.ToTable("BookingTickets");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Total).HasColumnType("decimal(12,4)").HasDefaultValue(0);

            builder.HasOne(t => t.ScreeningTicket).WithMany(bt => bt.BookingTickets).HasForeignKey(x => x.ScreeningTicketId).OnDelete(DeleteBehavior.Restrict).HasConstraintName("fk_bookingticket_screeningticket");
            builder.HasOne(t => t.Booking).WithMany(bt => bt.BookingTickets).HasForeignKey(x => x.BookingId).HasConstraintName("fk_bookingticket_booking");
        }
    }
}