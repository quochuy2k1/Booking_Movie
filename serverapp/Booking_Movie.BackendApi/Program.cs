using System.Security.Permissions;
using System;
using AutoMapper;
using Booking_Movie.Application.Catalog.Actors;
using Booking_Movie.Application.Catalog.Directors;
using Booking_Movie.Application.Catalog.Producers;
using Booking_Movie.Application.Common;
using Booking_Movie.Application.System.Users;
using Booking_Movie.BackendApi.Mapper;
using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Constants;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Cors;
using Booking_Movie.Application.Catalog.Movies;
using Booking_Movie.Application.Catalog.Tickets;
using Booking_Movie.Application.Catalog.Combos;
using Booking_Movie.Application.Catalog.Auditoriums;
using Booking_Movie.Application.Catalog.PaymentMethods;
using Booking_Movie.Application.Catalog.Categories;
using Booking_Movie.Application.Catalog.Nationalities;
using Booking_Movie.Application.Catalog.Bookings;
using Booking_Movie.Payment.Momo;
using Microsoft.AspNetCore.Authentication.Cookies;
using Booking_Movie.Application.Catalog.SeatNos;
using Booking_Movie.Application.Ngrok;
using Booking_Movie.Application.Catalog.Cinemas;
using Booking_Movie.Application.Catalog.ScreeningTypes;
using Booking_Movie.Application.Catalog.Screenings;
using System.Text.Json.Serialization;
using Booking_Movie.Application.Report.Booking;
using Booking_Movie.Application.Catalog.ShowTimes;
using Booking_Movie.Application.Catalog.TicketTypes;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration; // allows both to access and to set up the config
IWebHostEnvironment environment = builder.Environment;
// Add services to the container.
builder.Services.AddCors(option => option.AddPolicy("ApiCorsPolicy", builder =>
{
    builder.WithOrigins("http://localhost:3000")
                     .AllowAnyMethod()
                     .AllowAnyHeader()
                     .AllowCredentials()
                     .WithExposedHeaders("set-cookie");
}));
builder.Services.AddMvc();

builder.Services.AddControllersWithViews();


builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(3);
    //options.Cookie.Domain = configuration["domainClient"];
    options.Cookie.SameSite = SameSiteMode.None;
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.Cookie.Name = ".BookingMovie.Security.Session";
    options.Cookie.Path = "/";
    options.Cookie.MaxAge = new TimeSpan(86400);

});
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Cookie = new CookieBuilder
        {
            
            //Domain = configuration["domainClient"],
            HttpOnly = true,
            Name = ".BookingMovie.Security.Cookie",
            Path = "/",
            SameSite = SameSiteMode.None,
            SecurePolicy = CookieSecurePolicy.Always,
            MaxAge = new TimeSpan(86400),
            IsEssential = true
        };
        options.LoginPath = new PathString("/");
        options.AccessDeniedPath = new PathString("/User/Forbidden/");
        options.SlidingExpiration = true;
    });
    builder.Services.AddHttpClient();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDbContext<BookingMovieContext>(option =>
{
    var conn = configuration.GetConnectionString(SystemConstant.MainConnectionString);
    option.UseSqlServer(conn);
});
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddIdentity<AppUser, AppRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;

})
    .AddEntityFrameworkStores<BookingMovieContext>()
                .AddDefaultTokenProviders()
                .AddRoles<AppRole>();
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
 {
     options.SaveToken = true;
     options.RequireHttpsMetadata = false;
     options.TokenValidationParameters = new TokenValidationParameters()
     {
         ValidateIssuer = true,
         ValidateAudience = true,
         ValidAudience = configuration["JWT:Audience"],
         ValidIssuer = configuration["JWT:Issuer"],
         IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(configuration["JWT:Key"]))
     };

 })
 ;
// declare DI

builder.Services.AddTransient<IActorService, ActorService>();
builder.Services.AddTransient<IFileStorageService, FileStorageService>();
builder.Services.AddTransient<IDbFactory, DbFactory>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<INgrokHelper, NgrokHelper>();
//

builder.Services.AddTransient<IPaymentRequest, PaymentRequest>();
builder.Services.AddTransient<IMoMoSecurity, MoMoSecurity>();

//
builder.Services.AddTransient<ActorRepository>();
builder.Services.AddTransient<AuditoriumRepository>();
builder.Services.AddTransient<BookingRepository>();
builder.Services.AddTransient<CategoryRepository>();
builder.Services.AddTransient<ComboRepository>();
builder.Services.AddTransient<DirectorRepository>();
builder.Services.AddTransient<MovieRepository>();
builder.Services.AddTransient<NationalityRepository>();
builder.Services.AddTransient<PaymentMethodRepository>();
builder.Services.AddTransient<ProducerRepository>();
builder.Services.AddTransient<TicketRepository>();
builder.Services.AddTransient<TicketTypeRepository>();
builder.Services.AddTransient<SeatNoRepository>();
builder.Services.AddTransient<CimemaRepository>();
builder.Services.AddTransient<ScreeningTypeRepository>();
builder.Services.AddTransient<ScreeningRepository>();
builder.Services.AddTransient<ShowTimeRepository>();
//
builder.Services.AddTransient<IAuditoriumService, AuditoriumService>();
builder.Services.AddTransient<IBookingService, BookingService>();
builder.Services.AddTransient<IComboService, ComboService>();
builder.Services.AddTransient<ICateroryService, CategoryService>();
builder.Services.AddTransient<IDirectorService, DirectorService>();
builder.Services.AddTransient<IMovieService, MovieService>();
builder.Services.AddTransient<INationalityService, NationalityService>();
builder.Services.AddTransient<IProducerService, ProducerService>();
builder.Services.AddTransient<IPaymentMethodService, PaymentMethodService>();
builder.Services.AddTransient<ITicketService, TicketService>();
builder.Services.AddTransient<ITicketTypeService, TicketTypeService>();
builder.Services.AddTransient<ISeatNoService, SeatNoService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ICinemasService, CinemasService>();
builder.Services.AddTransient<IScreeningTypeService, ScreeningTypeService>();
builder.Services.AddTransient<IScreeningService, ScreeningService>();
builder.Services.AddTransient<IShowTimeService, ShowTimeService>();
builder.Services.AddTransient<IBookingReport, BookingReport>();

//



builder.Services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
builder.Services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
// Cấu hình AutoMapper - Cách 1
var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});
mappingConfig.AssertConfigurationIsValid();
IMapper mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);


// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
}); ;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Booking Movie Api", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                  {
                    {
                      new OpenApiSecurityScheme
                      {
                        Reference = new OpenApiReference
                          {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                          },
                          Scheme = "oauth2",
                          Name = "Bearer",
                          In = ParameterLocation.Header,
                        },
                        new List<string>()
                      }
                    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();

app.UseRouting();
app.UseCors("ApiCorsPolicy");
app.UseSession();

app.UseAuthorization();
app.MapControllers();

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.Run();
