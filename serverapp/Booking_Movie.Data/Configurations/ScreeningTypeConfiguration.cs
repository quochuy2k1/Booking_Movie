using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Movie.Data.Configurations
{
    internal class ScreeningTypeConfiguration : IEntityTypeConfiguration<ScreeningType>
    {
        public void Configure(EntityTypeBuilder<ScreeningType> builder)
        {
            builder.ToTable("ScreeningTypes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Description).IsUnicode().HasMaxLength(512);
        }
    }
}