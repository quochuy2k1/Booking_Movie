using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Combos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(12,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(12,4)", nullable: false),
                    AvailableQuantity = table.Column<int>(type: "int", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlagActor = table.Column<bool>(type: "bit", nullable: false),
                    FlagDirector = table.Column<bool>(type: "bit", nullable: false),
                    FlagProducer = table.Column<bool>(type: "bit", nullable: false),
                    FlagMovie = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(12,4)", nullable: true),
                    CostAdditional = table.Column<decimal>(type: "decimal(12,4)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScreeningTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreeningTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    SeatId = table.Column<string>(type: "varchar(5)", nullable: false),
                    Row = table.Column<string>(type: "varchar(1)", nullable: false),
                    Number = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.SeatId);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(12,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.Id);
                    table.ForeignKey(
                        name: "fk_cinema_location",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    NationalityId = table.Column<string>(type: "varchar(8)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ID);
                    table.ForeignKey(
                        name: "fk_actor_nationality",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    NationalityId = table.Column<string>(type: "varchar(8)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.ID);
                    table.ForeignKey(
                        name: "fk_director_nationality",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    NationalityId = table.Column<string>(type: "varchar(8)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.ID);
                    table.ForeignKey(
                        name: "fk_producer_nationality",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Auditoriums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CinemaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditoriums", x => x.Id);
                    table.ForeignKey(
                        name: "fk_auditorium_cinema",
                        column: x => x.CinemaId,
                        principalTable: "Cinemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorImages", x => x.Id);
                    table.ForeignKey(
                        name: "fk_actorimage_actor",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DirectorImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectorImages", x => x.Id);
                    table.ForeignKey(
                        name: "fk_directorimage_director",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<short>(type: "smallint", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoTrailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalityId = table.Column<string>(type: "varchar(8)", nullable: false),
                    ProducerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaKeyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "fk_movie_nationality",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_movie_producer",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeatNos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatId = table.Column<string>(type: "varchar(5)", nullable: false),
                    AuditoriumId = table.Column<int>(type: "int", nullable: false),
                    Stauts = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatNos", x => x.Id);
                    table.ForeignKey(
                        name: "fk_seatno_auditorium",
                        column: x => x.AuditoriumId,
                        principalTable: "Auditoriums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_seatno_seat",
                        column: x => x.SeatId,
                        principalTable: "Seats",
                        principalColumn: "SeatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Casts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casts", x => x.Id);
                    table.ForeignKey(
                        name: "fk_cast_actor",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cast_movie",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCategories", x => x.Id);
                    table.ForeignKey(
                        name: "fk_moviecategory_category",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_moviecategory_movie",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieDireactors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    DirectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDireactors", x => x.Id);
                    table.ForeignKey(
                        name: "fk_moviedirector_director",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_moviedirector_movie",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Screenings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuditoriumId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    MovieTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.Id);
                    table.ForeignKey(
                        name: "fk_screening_auditorium",
                        column: x => x.AuditoriumId,
                        principalTable: "Auditoriums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_screening_movie",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_screening_movietype",
                        column: x => x.MovieTypeId,
                        principalTable: "ScreeningTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<decimal>(type: "decimal(12,4)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScreeningId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    CouponId = table.Column<int>(type: "int", nullable: false),
                    Stauts = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "fk_booking_appuser",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_booking_coupon",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_booking_paymentmethod",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_booking_screening",
                        column: x => x.ScreeningId,
                        principalTable: "Screenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingCombos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ComboId = table.Column<int>(type: "int", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    Stauts = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingCombos", x => x.Id);
                    table.ForeignKey(
                        name: "fk_bookingcombo_booking",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_bookingcombo_combo",
                        column: x => x.ComboId,
                        principalTable: "Combos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    Stauts = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingTickets", x => x.Id);
                    table.ForeignKey(
                        name: "fk_bookingticket_booking",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_bookingticket_ticket",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeatReserveds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatNoId = table.Column<int>(type: "int", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    Stauts = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatReserveds", x => x.Id);
                    table.ForeignKey(
                        name: "fk_seatreserved_booking",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_seatreserved_seatno",
                        column: x => x.SeatNoId,
                        principalTable: "SeatNos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"), 0, "35299fa7-d2be-4138-9057-470c4fbe0cd5", "dangit19@gmail.com", false, "Đăng", "Nguyễn Minh", false, null, null, null, "AQAAAAEAACcQAAAAELlPqZ89PPMter0Nqd3VLFQkrQO9M3cb2rcer7lPqLhE9hWKn+689/czvO9QlXiaVw==", "0364125410", false, null, false, "dangnhinho" },
                    { new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"), 0, "08ef5bb9-95f4-4d4a-910f-5a7602cad0d5", "thaoit19@gmail.com", false, "Thảo", "Nguyễn Hoàng", false, null, null, null, "AQAAAAEAACcQAAAAEM9WbQeqtyhWP7D8yM89L40iB62hVBIcEO1fAIl5bmM9kkLFa4/Ex3Os0YGUQAsTxg==", "0364125430", false, null, false, "thaoit" },
                    { new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"), 0, "9e845431-53f3-4954-93d5-e9461199dcd9", "khanhit19@gmail.com", false, "Khánh", "Nguyễn", false, null, null, null, "AQAAAAEAACcQAAAAEExqhjhtFovQp9YKgMRTV49zNIOjXwXZ1vBXcfrJQyHdhr35XKSNyAwXsReKHBhW6Q==", "0364125420", false, null, false, "khanhalone" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayOrder", "HomeFlag", "Image", "Name", "ParentId" },
                values: new object[,]
                {
                    { 1, null, null, false, "", "Hành động", null },
                    { 2, null, null, false, "", "Hình sự", null },
                    { 3, null, null, false, "", "Chiến tranh", null },
                    { 4, null, null, false, "", "Hoạt hình", null },
                    { 5, null, null, false, "", "Kinh dị", null },
                    { 6, null, null, false, "", "Lãnh mạng", null },
                    { 7, null, null, false, "", "Lịch sử", null },
                    { 8, null, null, false, "", "Phiêu lưu", null },
                    { 9, null, null, false, "", "Tâm lý", null },
                    { 10, null, null, false, "", "Ly kì", null },
                    { 11, null, null, false, "", "Thần thoại", null }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "1 BẮP + 1 NƯỚC 32 Oz (LIPTON/SUỐI/DIET PEPSI) + 1 SNACK", "iCombo 1 Big Extra", 99000m },
                    { 2, "1 BẮP + 3 NƯỚC 32 Oz (LIPTON/SUỐI/DIET PEPSI) + 1 SNACK", "iCombo Friends 1 Big", 139000m },
                    { 3, "1 BẮP + 2 NƯỚC 32 Oz (LIPTON/SUỐI/DIET PEPSI) + 1 SNACK", "iCombo 2 BIG Extra", 120000m }
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "Alias", "AvailableQuantity", "Discount", "Name", "Status", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 1, "GEKIJFNF785MAJ", 10, 5000m, "GEKIJFNFCCMAJ", true, new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "KJMNNVDD452YTR", 5, 2000m, "GEKIJFNFCCMAJ", true, new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "TP Hồ Chí Minh" },
                    { 2, "TP Hà Nội" },
                    { 3, "Cà Mau" },
                    { 4, "Đồng Tháp" },
                    { 5, "Cần Thơ" },
                    { 6, "Đà Nẵng" },
                    { 7, "Ang Giang" },
                    { 8, "Nghệ An" },
                    { 9, "Bến Tre" },
                    { 10, "Hải Phòng" }
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "Id", "Code", "Description", "FlagActor", "FlagDirector", "FlagMovie", "FlagProducer", "Name" },
                values: new object[,]
                {
                    { "au", "au", "Quốc gia Úc", true, true, true, true, "Úc" },
                    { "en", "en", "Quốc gia Mỹ", true, true, true, true, "Mỹ" },
                    { "es", "es", "Quốc gia Tây Ban Nha", true, true, true, true, "Tây Ban Nha" },
                    { "ko", "ko", "Quốc gia Hàn Quốc", true, true, true, true, "Hàn Quốc" },
                    { "vi", "vi", "Quốc gia Việt Nam", true, true, true, true, "Việt Nam" },
                    { "zh", "zh", "Quốc gia Trung Quốc", true, true, true, true, "Trung Quốc" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "Alias", "Cost", "CostAdditional", "CreatedBy", "CreatedDate", "Name", "Status", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Vi_dien_tu_momo", 0m, 0m, null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5490), "Ví điện tử momo", true, null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5491) },
                    { 2, "Vi_Zalo", 0m, 0m, null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5493), "Ví Zalo", true, null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5493) },
                    { 3, "VNPAY", 0m, 0m, null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5494), "VNPAY", true, null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5495) },
                    { 4, "HSBC/Payoo-ATM/VISA/MASTER/JCB/QRCODE", 0m, 0m, null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5496), "HSBC/Payoo - ATM/VISA/MASTER/JCB/QRCODE", true, null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5496) },
                    { 5, "Vi_ShoppePay", 0m, 0m, null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5497), "Ví ShopeePay", true, null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5498) }
                });

            migrationBuilder.InsertData(
                table: "ScreeningTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "2D - Phụ đề" },
                    { 2, null, "3D - Phụ đề" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "SeatId", "Number", "Row" },
                values: new object[,]
                {
                    { "A1", (byte)1, "A" },
                    { "A10", (byte)10, "A" },
                    { "A11", (byte)11, "A" },
                    { "A12", (byte)12, "A" },
                    { "A2", (byte)2, "A" },
                    { "A3", (byte)3, "A" },
                    { "A4", (byte)4, "A" },
                    { "A5", (byte)5, "A" },
                    { "A6", (byte)6, "A" },
                    { "A7", (byte)7, "A" },
                    { "A8", (byte)8, "A" },
                    { "A9", (byte)9, "A" },
                    { "B1", (byte)1, "B" },
                    { "B10", (byte)10, "B" },
                    { "B11", (byte)11, "B" },
                    { "B12", (byte)12, "B" },
                    { "B2", (byte)2, "B" },
                    { "B3", (byte)3, "B" },
                    { "B4", (byte)4, "B" },
                    { "B5", (byte)5, "B" },
                    { "B6", (byte)6, "B" },
                    { "B7", (byte)7, "B" },
                    { "B8", (byte)8, "B" },
                    { "B9", (byte)9, "B" },
                    { "C1", (byte)1, "C" },
                    { "C10", (byte)10, "C" },
                    { "C11", (byte)11, "C" },
                    { "C12", (byte)12, "C" },
                    { "C2", (byte)2, "C" },
                    { "C3", (byte)3, "C" },
                    { "C4", (byte)4, "C" },
                    { "C5", (byte)5, "C" },
                    { "C6", (byte)6, "C" },
                    { "C7", (byte)7, "C" },
                    { "C8", (byte)8, "C" },
                    { "C9", (byte)9, "C" },
                    { "D1", (byte)1, "D" },
                    { "D10", (byte)10, "D" },
                    { "D11", (byte)11, "D" },
                    { "D12", (byte)12, "D" },
                    { "D2", (byte)2, "D" },
                    { "D3", (byte)3, "D" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "SeatId", "Number", "Row" },
                values: new object[,]
                {
                    { "D4", (byte)4, "D" },
                    { "D5", (byte)5, "D" },
                    { "D6", (byte)6, "D" },
                    { "D7", (byte)7, "D" },
                    { "D8", (byte)8, "D" },
                    { "D9", (byte)9, "D" },
                    { "E1", (byte)1, "E" },
                    { "E10", (byte)10, "E" },
                    { "E11", (byte)11, "E" },
                    { "E12", (byte)12, "E" },
                    { "E2", (byte)2, "E" },
                    { "E3", (byte)3, "E" },
                    { "E4", (byte)4, "E" },
                    { "E5", (byte)5, "E" },
                    { "E6", (byte)6, "E" },
                    { "E7", (byte)7, "E" },
                    { "E8", (byte)8, "E" },
                    { "E9", (byte)9, "E" },
                    { "F1", (byte)1, "F" },
                    { "F10", (byte)10, "F" },
                    { "F11", (byte)11, "F" },
                    { "F12", (byte)12, "F" },
                    { "F2", (byte)2, "F" },
                    { "F3", (byte)3, "F" },
                    { "F4", (byte)4, "F" },
                    { "F5", (byte)5, "F" },
                    { "F6", (byte)6, "F" },
                    { "F7", (byte)7, "F" },
                    { "F8", (byte)8, "F" },
                    { "F9", (byte)9, "F" },
                    { "G1", (byte)1, "G" },
                    { "G10", (byte)10, "G" },
                    { "G11", (byte)11, "G" },
                    { "G12", (byte)12, "G" },
                    { "G2", (byte)2, "G" },
                    { "G3", (byte)3, "G" },
                    { "G4", (byte)4, "G" },
                    { "G5", (byte)5, "G" },
                    { "G6", (byte)6, "G" },
                    { "G7", (byte)7, "G" },
                    { "G8", (byte)8, "G" },
                    { "G9", (byte)9, "G" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "SeatId", "Number", "Row" },
                values: new object[,]
                {
                    { "H1", (byte)1, "H" },
                    { "H10", (byte)10, "H" },
                    { "H11", (byte)11, "H" },
                    { "H12", (byte)12, "H" },
                    { "H2", (byte)2, "H" },
                    { "H3", (byte)3, "H" },
                    { "H4", (byte)4, "H" },
                    { "H5", (byte)5, "H" },
                    { "H6", (byte)6, "H" },
                    { "H7", (byte)7, "H" },
                    { "H8", (byte)8, "H" },
                    { "H9", (byte)9, "H" },
                    { "I1", (byte)1, "I" },
                    { "I10", (byte)10, "I" },
                    { "I11", (byte)11, "I" },
                    { "I12", (byte)12, "I" },
                    { "I2", (byte)2, "I" },
                    { "I3", (byte)3, "I" },
                    { "I4", (byte)4, "I" },
                    { "I5", (byte)5, "I" },
                    { "I6", (byte)6, "I" },
                    { "I7", (byte)7, "I" },
                    { "I8", (byte)8, "I" },
                    { "I9", (byte)9, "I" },
                    { "J1", (byte)1, "J" },
                    { "J10", (byte)10, "J" },
                    { "J11", (byte)11, "J" },
                    { "J12", (byte)12, "J" },
                    { "J13", (byte)13, "J" },
                    { "J14", (byte)14, "J" },
                    { "J2", (byte)2, "J" },
                    { "J3", (byte)3, "J" },
                    { "J4", (byte)4, "J" },
                    { "J5", (byte)5, "J" },
                    { "J6", (byte)6, "J" },
                    { "J7", (byte)7, "J" },
                    { "J8", (byte)8, "J" },
                    { "J9", (byte)9, "J" },
                    { "K1", (byte)1, "K" },
                    { "K10", (byte)10, "K" },
                    { "K11", (byte)11, "K" },
                    { "K12", (byte)12, "K" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "SeatId", "Number", "Row" },
                values: new object[,]
                {
                    { "K13", (byte)13, "K" },
                    { "K14", (byte)14, "K" },
                    { "K2", (byte)2, "K" },
                    { "K3", (byte)3, "K" },
                    { "K4", (byte)4, "K" },
                    { "K5", (byte)5, "K" },
                    { "K6", (byte)6, "K" },
                    { "K7", (byte)7, "K" },
                    { "K8", (byte)8, "K" },
                    { "K9", (byte)9, "K" },
                    { "L1", (byte)1, "L" },
                    { "L10", (byte)10, "L" },
                    { "L11", (byte)11, "L" },
                    { "L12", (byte)12, "L" },
                    { "L13", (byte)13, "L" },
                    { "L14", (byte)14, "L" },
                    { "L15", (byte)15, "L" },
                    { "L16", (byte)16, "L" },
                    { "L2", (byte)2, "L" },
                    { "L3", (byte)3, "L" },
                    { "L4", (byte)4, "L" },
                    { "L5", (byte)5, "L" },
                    { "L6", (byte)6, "L" },
                    { "L7", (byte)7, "L" },
                    { "L8", (byte)8, "L" },
                    { "L9", (byte)9, "L" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Vé 2D sử dụng từ 16 tuổi trở lên", "Người lớn", 90000m },
                    { 2, "Vé 2D sử dụng dưới 16", "Người trẻ em", 75000m },
                    { 3, "Vé 2D chỉ sử dụng cho suất chiếu sau 22h", "Sau 22h", 50000m }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "DateOfBirth", "Description", "Height", "Image", "Name", "NationalityId", "UpdatedBy", "UpdatedDate", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"), null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5012), new DateTime(1991, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1.67m, "", "Katy Nguyễn", "vi", null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5012), 0 },
                    { new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"), null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5018), new DateTime(1987, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1.81m, "", "Lãnh Thanh", "vi", null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5018), 0 },
                    { new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"), null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5014), new DateTime(1989, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1.7m, "", "NSƯT Lê Khanh", "vi", null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5014), 0 },
                    { new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"), null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5009), new DateTime(1990, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1.64m, "", "Ninh Dương Lan Ngọc", "vi", null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5010), 0 },
                    { new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"), null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5020), new DateTime(1986, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1.76m, "", "Lê Xuân Tiền", "vi", null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5020), 0 },
                    { new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"), null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5016), new DateTime(1988, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1.65m, "", "Hữu Châu", "vi", null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5016), 0 }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LocationId", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Galaxy Nguyễn Du", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Galaxy Cà Mau", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Galaxy Tân Bình", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Galaxy Kinh Dương Vương", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Galaxy Quang Trung", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Galaxy Bến Tre", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Galaxy Đà Nẵng", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Galaxy Hải Phòng", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "DateOfBirth", "Description", "Height", "Image", "Name", "NationalityId", "UpdatedBy", "UpdatedDate", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"), null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4951), new DateTime(1974, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1.75m, "", "Jaume Collet-Serra", "es", null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4960), 0 },
                    { new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"), null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4967), new DateTime(1985, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1.65m, "", "Nam Cito", "vi", null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4967), 0 },
                    { new Guid("88034877-a697-472c-a2d8-3d133792c463"), null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4964), new DateTime(1986, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1.85m, "", "Bảo Nhân", "vi", null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4965), 0 },
                    { new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"), null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4970), new DateTime(1974, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1.75m, "", "Jaume Collet-Serra ", "es", null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4971), 0 },
                    { new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"), null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4974), new DateTime(1974, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1.75m, "", "Jaume Collet-Serra ", "es", null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4975), 0 },
                    { new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"), null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4972), new DateTime(1974, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1.75m, "", "Jaume Collet-Serra ", "es", null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4973), 0 }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "Image", "Name", "NationalityId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"), null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4989), "", "MAR6 Pictures", "vi", null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.InsertData(
                table: "Auditoriums",
                columns: new[] { "Id", "CinemaId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Phong-01" },
                    { 2, 1, "Phong-02" },
                    { 3, 2, "Phong-01" },
                    { 4, 3, "Phong-01" },
                    { 5, 4, "Phong-01" },
                    { 6, 5, "Phong-01" },
                    { 7, 6, "Phong-01" },
                    { 8, 6, "Phong-02" },
                    { 9, 6, "Phong-03" },
                    { 10, 7, "Phong-01" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Alias", "Content", "CreatedBy", "CreatedDate", "Duration", "MetaDescription", "MetaKeyword", "Name", "NationalityId", "ProducerId", "ReleaseDate", "Status", "UpdatedBy", "UpdatedDate", "VideoTrailer" },
                values: new object[] { 1, "Co_Gai_Den_Tu_Qua_Khu", "", null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5037), (short)105, null, null, "Cô Gái Từ Quá Khứ", "vi", new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5037), "duongdan.mp4" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"), 1 },
                    { 2, new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"), 1 },
                    { 3, new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"), 1 },
                    { 4, new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"), 1 },
                    { 5, new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"), 1 },
                    { 6, new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"), 1 }
                });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "Id", "CategoryId", "MovieId" },
                values: new object[,]
                {
                    { 1, 9, 1 },
                    { 2, 10, 1 }
                });

            migrationBuilder.InsertData(
                table: "MovieDireactors",
                columns: new[] { "Id", "DirectorId", "MovieId" },
                values: new object[,]
                {
                    { 1, new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"), 1 },
                    { 2, new Guid("88034877-a697-472c-a2d8-3d133792c463"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "AuditoriumId", "MovieId", "MovieTypeId", "ShowTime" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, new DateTime(2022, 10, 29, 9, 29, 59, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 1, 1, new DateTime(2022, 10, 29, 17, 29, 59, 0, DateTimeKind.Unspecified) },
                    { 3, 5, 1, 1, new DateTime(2022, 10, 29, 17, 29, 59, 0, DateTimeKind.Unspecified) },
                    { 4, 6, 1, 1, new DateTime(2022, 10, 29, 17, 29, 59, 0, DateTimeKind.Unspecified) },
                    { 5, 7, 1, 1, new DateTime(2022, 10, 29, 17, 29, 59, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "SeatNos",
                columns: new[] { "Id", "AuditoriumId", "SeatId", "Stauts" },
                values: new object[,]
                {
                    { 1, 1, "A1", false },
                    { 2, 1, "A2", false },
                    { 3, 1, "A3", false },
                    { 4, 1, "A4", false },
                    { 5, 1, "A5", false },
                    { 6, 1, "A6", false },
                    { 7, 1, "A7", false },
                    { 8, 1, "A8", false },
                    { 9, 1, "A9", false },
                    { 10, 1, "A10", false },
                    { 11, 1, "A11", false },
                    { 12, 1, "A12", false },
                    { 13, 1, "B1", false },
                    { 14, 1, "B2", false },
                    { 15, 1, "B3", false },
                    { 16, 1, "B4", false },
                    { 17, 1, "B5", false },
                    { 18, 1, "B6", false },
                    { 19, 1, "B7", false },
                    { 20, 1, "B8", false },
                    { 21, 1, "B9", false },
                    { 22, 1, "B10", false },
                    { 23, 1, "B11", false },
                    { 24, 1, "B12", false },
                    { 25, 1, "C1", false },
                    { 26, 1, "C2", false },
                    { 27, 1, "C3", false }
                });

            migrationBuilder.InsertData(
                table: "SeatNos",
                columns: new[] { "Id", "AuditoriumId", "SeatId", "Stauts" },
                values: new object[,]
                {
                    { 28, 1, "C4", false },
                    { 29, 1, "C5", false },
                    { 30, 1, "C6", false },
                    { 31, 1, "C7", false },
                    { 32, 1, "C8", false },
                    { 33, 1, "C9", false },
                    { 34, 1, "C10", false },
                    { 35, 1, "C11", false },
                    { 36, 1, "C12", false },
                    { 37, 1, "D1", false },
                    { 38, 1, "D2", false },
                    { 39, 1, "D3", false },
                    { 40, 1, "D4", false },
                    { 41, 1, "D5", false },
                    { 42, 1, "D6", false },
                    { 43, 1, "D7", false },
                    { 44, 1, "D8", false },
                    { 45, 1, "D9", false },
                    { 46, 1, "D10", false },
                    { 47, 1, "D11", false },
                    { 48, 1, "D12", false },
                    { 49, 1, "E1", false },
                    { 50, 1, "E2", false },
                    { 51, 1, "E3", false },
                    { 52, 1, "E4", false },
                    { 53, 1, "E5", false },
                    { 54, 1, "E6", false },
                    { 55, 1, "E7", false },
                    { 56, 1, "E8", false },
                    { 57, 1, "E9", false },
                    { 58, 1, "E10", false },
                    { 59, 1, "E11", false },
                    { 60, 1, "E12", false },
                    { 61, 1, "F1", false },
                    { 62, 1, "F2", false },
                    { 63, 1, "F3", false },
                    { 64, 1, "F4", false },
                    { 65, 1, "F5", false },
                    { 66, 1, "F6", false },
                    { 67, 1, "F7", false },
                    { 68, 1, "F8", false },
                    { 69, 1, "F9", false }
                });

            migrationBuilder.InsertData(
                table: "SeatNos",
                columns: new[] { "Id", "AuditoriumId", "SeatId", "Stauts" },
                values: new object[,]
                {
                    { 70, 1, "F10", false },
                    { 71, 1, "F11", false },
                    { 72, 1, "F12", false },
                    { 73, 1, "G1", false },
                    { 74, 1, "G2", false },
                    { 75, 1, "G3", false },
                    { 76, 1, "G4", false },
                    { 77, 1, "G5", false },
                    { 78, 1, "G6", false },
                    { 79, 1, "G7", false },
                    { 80, 1, "G8", false },
                    { 81, 1, "G9", false },
                    { 82, 1, "G10", false },
                    { 83, 1, "G11", false },
                    { 84, 1, "G12", false },
                    { 85, 1, "H1", false },
                    { 86, 1, "H2", false },
                    { 87, 1, "H3", false },
                    { 88, 1, "H4", false },
                    { 89, 1, "H5", false },
                    { 90, 1, "H6", false },
                    { 91, 1, "H7", false },
                    { 92, 1, "H8", false },
                    { 93, 1, "H9", false },
                    { 94, 1, "H10", false },
                    { 95, 1, "H11", false },
                    { 96, 1, "H12", false },
                    { 97, 1, "I1", false },
                    { 98, 1, "I2", false },
                    { 99, 1, "I3", false },
                    { 100, 1, "I4", false },
                    { 101, 1, "I5", false },
                    { 102, 1, "I6", false },
                    { 103, 1, "I7", false },
                    { 104, 1, "I8", false },
                    { 105, 1, "I9", false },
                    { 106, 1, "I10", false },
                    { 107, 1, "I11", false },
                    { 108, 1, "I12", false },
                    { 109, 1, "J1", false },
                    { 110, 1, "J2", false },
                    { 111, 1, "J3", false }
                });

            migrationBuilder.InsertData(
                table: "SeatNos",
                columns: new[] { "Id", "AuditoriumId", "SeatId", "Stauts" },
                values: new object[,]
                {
                    { 112, 1, "J4", false },
                    { 113, 1, "J5", false },
                    { 114, 1, "J6", false },
                    { 115, 1, "J7", false },
                    { 116, 1, "J8", false },
                    { 117, 1, "J9", false },
                    { 118, 1, "J10", false },
                    { 119, 1, "J11", false },
                    { 120, 1, "J12", false },
                    { 121, 1, "J13", false },
                    { 122, 1, "J14", false },
                    { 123, 1, "K1", false },
                    { 124, 1, "K2", false },
                    { 125, 1, "K3", false },
                    { 126, 1, "K4", false },
                    { 127, 1, "K5", false },
                    { 128, 1, "K6", false },
                    { 129, 1, "K7", false },
                    { 130, 1, "K8", false },
                    { 131, 1, "K9", false },
                    { 132, 1, "K10", false },
                    { 133, 1, "K11", false },
                    { 134, 1, "K12", false },
                    { 135, 1, "K13", false },
                    { 136, 1, "K14", false },
                    { 137, 1, "L1", false },
                    { 138, 1, "L2", false },
                    { 139, 1, "L3", false },
                    { 140, 1, "L4", false },
                    { 141, 1, "L5", false },
                    { 142, 1, "L6", false },
                    { 143, 1, "L7", false },
                    { 144, 1, "L8", false },
                    { 145, 1, "L9", false },
                    { 146, 1, "L10", false },
                    { 147, 1, "L11", false },
                    { 148, 1, "L12", false },
                    { 149, 1, "L13", false },
                    { 150, 1, "L14", false },
                    { 151, 1, "L15", false },
                    { 152, 1, "L16", false }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "AppUserId", "CouponId", "CreatedDate", "PaymentMethodId", "ScreeningId", "Stauts", "Total" },
                values: new object[] { 1, new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, true, 420000m });

            migrationBuilder.InsertData(
                table: "BookingCombos",
                columns: new[] { "Id", "BookingId", "ComboId", "Quantity", "Stauts" },
                values: new object[,]
                {
                    { 1, 1, 1, 2, true },
                    { 2, 1, 2, 1, true },
                    { 3, 1, 3, 1, true }
                });

            migrationBuilder.InsertData(
                table: "BookingTickets",
                columns: new[] { "Id", "BookingId", "Quantity", "Stauts", "TicketId" },
                values: new object[,]
                {
                    { 1, 1, 2, true, 1 },
                    { 2, 1, 1, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "SeatReserveds",
                columns: new[] { "Id", "BookingId", "SeatNoId", "Stauts" },
                values: new object[,]
                {
                    { 1, 1, 2, true },
                    { 2, 1, 3, true },
                    { 3, 1, 4, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorImages_ActorId",
                table: "ActorImages",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Actors_NationalityId",
                table: "Actors",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Auditoriums_CinemaId",
                table: "Auditoriums",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingCombos_BookingId",
                table: "BookingCombos",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingCombos_ComboId",
                table: "BookingCombos",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_AppUserId",
                table: "Bookings",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CouponId",
                table: "Bookings",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PaymentMethodId",
                table: "Bookings",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ScreeningId",
                table: "Bookings",
                column: "ScreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTickets_BookingId",
                table: "BookingTickets",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTickets_TicketId",
                table: "BookingTickets",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Casts_ActorId",
                table: "Casts",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Casts_MovieId",
                table: "Casts",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_LocationId",
                table: "Cinemas",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectorImages_DirectorId",
                table: "DirectorImages",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Directors_NationalityId",
                table: "Directors",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCategories_CategoryId",
                table: "MovieCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCategories_MovieId",
                table: "MovieCategories",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieDireactors_DirectorId",
                table: "MovieDireactors",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieDireactors_MovieId",
                table: "MovieDireactors",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_NationalityId",
                table: "Movies",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_Producers_NationalityId",
                table: "Producers",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_AuditoriumId",
                table: "Screenings",
                column: "AuditoriumId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_MovieId",
                table: "Screenings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_MovieTypeId",
                table: "Screenings",
                column: "MovieTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatNos_AuditoriumId",
                table: "SeatNos",
                column: "AuditoriumId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatNos_SeatId",
                table: "SeatNos",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatReserveds_BookingId",
                table: "SeatReserveds",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatReserveds_SeatNoId",
                table: "SeatReserveds",
                column: "SeatNoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorImages");

            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "BookingCombos");

            migrationBuilder.DropTable(
                name: "BookingTickets");

            migrationBuilder.DropTable(
                name: "Casts");

            migrationBuilder.DropTable(
                name: "DirectorImages");

            migrationBuilder.DropTable(
                name: "MovieCategories");

            migrationBuilder.DropTable(
                name: "MovieDireactors");

            migrationBuilder.DropTable(
                name: "SeatReserveds");

            migrationBuilder.DropTable(
                name: "Combos");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "SeatNos");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Auditoriums");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "ScreeningTypes");

            migrationBuilder.DropTable(
                name: "Cinemas");

            migrationBuilder.DropTable(
                name: "Producers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Nationalities");
        }
    }
}
