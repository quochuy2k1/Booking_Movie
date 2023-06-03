using Booking_Movie.Data.Configurations;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Booking_Movie.Data.EF
{
    public class BookingMovieContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public BookingMovieContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ActorConfiguration());
            modelBuilder.ApplyConfiguration(new ActorImageConfiguration());
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AuditoriumConfiguration());
            modelBuilder.ApplyConfiguration(new BookingComboConfiguration());
            modelBuilder.ApplyConfiguration(new BookingConfiguration());
            modelBuilder.ApplyConfiguration(new BookingTicketConfiguration());
            modelBuilder.ApplyConfiguration(new CastConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CinemaConfiguration());
            modelBuilder.ApplyConfiguration(new ComboConfiguration());
            modelBuilder.ApplyConfiguration(new CouponConfiguration());
            modelBuilder.ApplyConfiguration(new DirectorConfiguration());
            modelBuilder.ApplyConfiguration(new DirectorImageConfiguration());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new MovieCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            modelBuilder.ApplyConfiguration(new MovieDirectorConfiguration());
            modelBuilder.ApplyConfiguration(new NationalityConfiguration());
            modelBuilder.ApplyConfiguration(new ScreeningTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentMethodConfiguration());
            modelBuilder.ApplyConfiguration(new ProducerConfiguration());
            modelBuilder.ApplyConfiguration(new ScreeningConfiguration());
            modelBuilder.ApplyConfiguration(new SeatConfiguration());
            modelBuilder.ApplyConfiguration(new SeatNoConfiguration());
            modelBuilder.ApplyConfiguration(new SeatStyleConfiguration());
            modelBuilder.ApplyConfiguration(new SeatReservedConfiguration());
            modelBuilder.ApplyConfiguration(new ShowTimeConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            modelBuilder.ApplyConfiguration(new ScreeningTicketConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            modelBuilder.Seed();
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorImage> ActorImages { get; set; }
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<Auditorium> Auditoriums { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingCombo> BookingCombos { get; set; }

        public DbSet<BookingTicket> BookingTickets { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Cinema> Cinemas { get; set; }

        public DbSet<Combo> Combos { get; set; }

        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<DirectorImage> DirectorImages { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<MovieDirector> MovieDirectors { get; set; }

        public DbSet<ScreeningType> ScreeningTypes { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }

        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        public DbSet<Producer> Producers { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<ShowTime> ShowTimes { get; set; }
        public DbSet<Seat> Seats { get; set; }

        public DbSet<SeatNo> SeatNos { get; set; }
        public DbSet<SeatStyle> SeatStyles { get; set; }

        public DbSet<SeatReserved> SeatReserveds { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<ScreeningTicket> ScreeningTickets { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString);
        //}
    }
}