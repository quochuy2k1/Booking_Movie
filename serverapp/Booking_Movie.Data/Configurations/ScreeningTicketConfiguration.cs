using Booking_Movie.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Data.Configurations
{
    public class ScreeningTicketConfiguration : IEntityTypeConfiguration<ScreeningTicket>
    {
        public void Configure(EntityTypeBuilder<ScreeningTicket> builder)
        {
            builder.ToTable("ScreeningTickets");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Price).HasColumnType("decimal(12,4)");

            builder.HasOne(x => x.Screening).WithMany(x => x.ScreeningTickets).HasForeignKey(x => x.ScreeningId).HasConstraintName("fk_screening_screeingticket");
            //builder.HasOne(x => x.Ticket).WithMany(x => x.ScreeningTickets).HasForeignKey(x => x.TicketId).HasConstraintName("fk_ticket_screeingticket");
        }
    }
}
