using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Movie.Data.Configurations
{
    internal class ComboConfiguration : IEntityTypeConfiguration<Combo>
    {
        public void Configure(EntityTypeBuilder<Combo> builder)
        {
            builder.ToTable("Combos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(12,4)");
            builder.Property(x => x.Description).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Name).IsUnicode().HasMaxLength(255);
        }
    }
}