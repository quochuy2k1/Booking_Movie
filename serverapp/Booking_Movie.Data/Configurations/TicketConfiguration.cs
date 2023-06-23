using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking_Movie.Data.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Tickets");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.TicketTypeId).IsRequired(false);
            builder.Property(x => x.Name).IsRequired(false);
            builder.Property(x => x.ValidityDateFromId).HasMaxLength(8);
            builder.Property(x => x.ValidityDateToId).HasMaxLength(8);
            builder.Property(x => x.Price).HasColumnType("decimal(12,4)");
            builder.Property(x => x.Description).HasColumnType("nvarchar(255)").IsRequired(false);

            builder.HasOne(t => t.Movie).WithMany(m=>m.Tickets).HasForeignKey(t => t.MovieId).OnDelete(DeleteBehavior.Restrict).HasConstraintName("fk_ticket_movie");
            builder.HasOne(t => t.ValidityDateFrom).WithMany(sh=>sh.ValidityDateFroms).HasForeignKey(t => t.ValidityDateFromId).OnDelete(DeleteBehavior.Restrict).HasConstraintName("fk_ticket_validityDateFrom");
            builder.HasOne(t => t.ValidityDateTo).WithMany(sh=>sh.ValidityDateTos).HasForeignKey(t => t.ValidityDateToId).OnDelete(DeleteBehavior.Restrict).HasConstraintName("fk_ticket_validityDateTo");
            builder.HasOne(t => t.TicketType).WithMany(sh=>sh.Tickets).HasForeignKey(t => t.TicketTypeId).OnDelete(DeleteBehavior.Restrict).HasConstraintName("fk_ticket_ticket_type");
        }
    }
}