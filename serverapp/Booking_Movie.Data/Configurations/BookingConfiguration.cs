using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Movie.Data.Configurations
{
    internal class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable("Bookings");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Total).HasColumnType("decimal(12,4)");
            builder.Property(x => x.OrderId).HasColumnType("varchar(50)").IsRequired(false);
            builder.Property(x => x.CouponId).IsRequired(false);
            builder.Property(x => x.ScreeningId).IsRequired(false);

            builder.HasOne(p => p.PaymentMethod).WithMany(b => b.Bookings).HasForeignKey(x => x.PaymentMethodId).HasConstraintName("fk_booking_paymentmethod");
            builder.HasOne(p => p.Coupon).WithMany(b => b.Bookings).HasForeignKey(c => c.CouponId).OnDelete(DeleteBehavior.Restrict).HasConstraintName("fk_booking_coupon");
            builder.HasOne(p => p.Screening).WithMany(b => b.Bookings).HasForeignKey(c => c.ScreeningId).OnDelete(DeleteBehavior.Restrict).HasConstraintName("fk_booking_screening");
            builder.HasOne(p => p.AppUser).WithMany(b => b.Bookings).HasForeignKey(c => c.AppUserId).HasConstraintName("fk_booking_appuser");
        }
    }
}