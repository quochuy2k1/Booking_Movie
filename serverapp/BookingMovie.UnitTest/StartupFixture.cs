using AutoMapper;
using Booking_Movie.Application.Catalog.Movies;
using Booking_Movie.Application.Common;
using Booking_Movie.Application.Ngrok;
using Booking_Movie.BackendApi.Mapper;
using Booking_Movie.Data.EF;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Constants;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookingMovie.UnitTest
{
    public class StartupFixture
    {
        public ServiceProvider ServiceProvider { get; private set; }

        public StartupFixture()
        {
            var services = new ServiceCollection();

            // Đăng ký DbContext
            //var mockWebHostEnvironment = new Mock<IWebHostEnvironment>();

            //// Cấu hình mock IWebHostEnvironment theo nhu cầu
            //mockWebHostEnvironment.Setup(m => m.EnvironmentName).Returns("Development");

            services.AddDbContext<BookingMovieContext>(option =>
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
                var conn = configuration.GetConnectionString(SystemConstant.MainConnectionString);
                option.UseSqlServer(conn);
            });

            var builder = WebApplication.CreateBuilder();
            IWebHostEnvironment webHostEnvironment = builder.Environment;
            services.AddSingleton<IWebHostEnvironment>(webHostEnvironment);
            services.AddSingleton<IConfiguration>(builder.Configuration);

            // Đăng ký các dịch vụ
            //

            services.AddTransient<IFileStorageService, FileStorageService>();
            services.AddTransient<INgrokHelper, NgrokHelper>();
            services.AddTransient<IDbFactory, DbFactory>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<MovieRepository>();
            services.AddTransient<BookingRepository>();
            services.AddTransient<IMovieService, MovieService>();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            mappingConfig.AssertConfigurationIsValid();
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}