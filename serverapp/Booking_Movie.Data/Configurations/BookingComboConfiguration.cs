using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Movie.Data.Configurations
{
    internal class BookingComboConfiguration : IEntityTypeConfiguration<BookingCombo>
    {
        public void Configure(EntityTypeBuilder<BookingCombo> builder)
        {
            builder.ToTable("BookingCombos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(c => c.Combo).WithMany(bc => bc.BookingCombos).HasForeignKey(bc => bc.ComboId).HasConstraintName("fk_bookingcombo_combo");
            builder.HasOne(b => b.Booking).WithMany(bc => bc.BookingCombos).HasForeignKey(b => b.BookingId).HasConstraintName("fk_bookingcombo_booking");
        }
    }
}