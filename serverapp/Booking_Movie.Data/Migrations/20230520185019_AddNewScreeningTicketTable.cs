using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Booking_Movie.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewScreeningTicketTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_bookingticket_ticket",
                table: "BookingTickets");

            migrationBuilder.RenameColumn(
                name: "Stauts",
                table: "SeatReserveds",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Stauts",
                table: "SeatNos",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Stauts",
                table: "BookingTickets",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Stauts",
                table: "Bookings",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Stauts",
                table: "BookingCombos",
                newName: "Status");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFrom",
                table: "Screenings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTo",
                table: "Screenings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "CommingSoon",
                table: "Movies",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsShowing",
                table: "Movies",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieAgeRestriction",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "BookingTickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ScreeningTicketId",
                table: "BookingTickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ScreeningId",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppUserTokens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AppUserTokens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AppUserLogins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AppUserLogins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ScreeningTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScreeningId = table.Column<int>(type: "int", nullable: false),
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(12,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreeningTickets", x => x.Id);
                    table.ForeignKey(
                        name: "fk_screening_screeingticket",
                        column: x => x.ScreeningId,
                        principalTable: "Screenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_ticket_screeingticket",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9972), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9984), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9977), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9967), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9988), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ee86c163-8753-401c-a64c-5ca7e228faae", "AQAAAAIAAYagAAAAEHRkBYYpAcV3xixrj31hcM9pVSSa6EgnnZo/I/kfSqa+cSVgkmXcnnS5BDx8e/ZV7Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "455dff94-f12d-406f-8753-1571c5cf333c", "AQAAAAIAAYagAAAAEBfGKI5ev6g1tH60qGyYG2x4l9rXtjsbNpmi8UK2bToURhJCqh7Y1VLbrPARYdgEYg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "041eeeb9-6ff3-4d13-b9f1-3bc254715553", "AQAAAAIAAYagAAAAEDlwQC2u5IgIn6HWYy/sqGfJ3RcLlo3hCLxRTPkNj2yfdAVaZFfkJtef52dk8FFabg==" });

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ScreeningTicketId", "TicketId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ScreeningTicketId", "TicketId" },
                values: new object[] { 2, null });

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ScreeningTicketId", "TicketId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ScreeningTicketId", "TicketId" },
                values: new object[] { 2, null });

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ScreeningTicketId", "TicketId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ScreeningTicketId", "TicketId" },
                values: new object[] { 2, null });

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ScreeningTicketId", "TicketId" },
                values: new object[] { 2, null });

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ScreeningTicketId", "TicketId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ScreeningTicketId", "TicketId" },
                values: new object[] { 2, null });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                column: "ScreeningId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9715), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9749), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9772), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9743), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9754), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9763), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9777), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9767), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9758), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommingSoon", "CreatedDate", "IsShowing", "MovieAgeRestriction", "UpdatedDate" },
                values: new object[] { false, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(79), true, 16, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommingSoon", "CreatedDate", "IsShowing", "MovieAgeRestriction", "UpdatedDate" },
                values: new object[] { false, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(87), true, 16, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommingSoon", "CreatedDate", "IsShowing", "MovieAgeRestriction", "UpdatedDate" },
                values: new object[] { false, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(92), true, 16, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommingSoon", "CreatedDate", "IsShowing", "MovieAgeRestriction", "UpdatedDate" },
                values: new object[] { false, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(98), true, 16, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommingSoon", "CreatedDate", "IsShowing", "MovieAgeRestriction", "UpdatedDate" },
                values: new object[] { false, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(102), true, 16, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommingSoon", "CreatedDate", "IsShowing", "MovieAgeRestriction", "UpdatedDate" },
                values: new object[] { false, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(107), true, 16, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommingSoon", "CreatedDate", "IsShowing", "MovieAgeRestriction", "UpdatedDate" },
                values: new object[] { false, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(132), true, 16, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommingSoon", "CreatedDate", "IsShowing", "MovieAgeRestriction", "UpdatedDate" },
                values: new object[] { false, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(138), true, 16, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommingSoon", "CreatedDate", "IsShowing", "MovieAgeRestriction", "UpdatedDate" },
                values: new object[] { false, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(142), true, 16, new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(3449), new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(3459), new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(3467), new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(3470), new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(3472), new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9854), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9857), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9897), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9842), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9846), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9860), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9850), new DateTime(2023, 5, 21, 1, 50, 18, 887, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.InsertData(
                table: "ScreeningTickets",
                columns: new[] { "Id", "Price", "ScreeningId", "TicketId" },
                values: new object[,]
                {
                    { 1, 90000m, 1, 1 },
                    { 2, 75000m, 1, 2 },
                    { 3, 50000m, 15, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateFrom", "DateTo" },
                values: new object[] { new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_ScreeningTickets_ScreeningId",
                table: "ScreeningTickets",
                column: "ScreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_ScreeningTickets_TicketId",
                table: "ScreeningTickets",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTickets_Tickets_TicketId",
                table: "BookingTickets",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingTickets_Tickets_TicketId",
                table: "BookingTickets");

            migrationBuilder.DropTable(
                name: "ScreeningTickets");

            migrationBuilder.DropColumn(
                name: "DateFrom",
                table: "Screenings");

            migrationBuilder.DropColumn(
                name: "DateTo",
                table: "Screenings");

            migrationBuilder.DropColumn(
                name: "CommingSoon",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "IsShowing",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieAgeRestriction",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ScreeningTicketId",
                table: "BookingTickets");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "SeatReserveds",
                newName: "Stauts");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "SeatNos",
                newName: "Stauts");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "BookingTickets",
                newName: "Stauts");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Bookings",
                newName: "Stauts");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "BookingCombos",
                newName: "Stauts");

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "BookingTickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ScreeningId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppUserTokens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AppUserTokens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AppUserLogins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AppUserLogins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(447), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(457), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(449), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(444), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(459), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(452), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49f8fefb-b102-424e-93b9-5a957dff50af", "AQAAAAEAACcQAAAAEAwgnaX0fb0pCzX0L7FDwJaGLZuJZXrGJggvGzJqJmwfp10X+nOSRm5y1ghU80rQsg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0fcb97e-bfe9-4d9e-8827-25da20a86384", "AQAAAAEAACcQAAAAEDkKfhv3pgHoTJYPR/tOXaARodteNTfHoOtyU6W7BCVFuYrjINMbe1X9Icf7qg3ILw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a528c4a-23a2-43a5-8212-cff184042424", "AQAAAAEAACcQAAAAEAfBgD6qXDy8tVv3fjucrQ4neyJ5DsLbnuzfD1z5QjY0tbbYZB0kOkv8KWFU6XPNHQ==" });

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "TicketId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 2,
                column: "TicketId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 3,
                column: "TicketId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 4,
                column: "TicketId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 5,
                column: "TicketId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 6,
                column: "TicketId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 7,
                column: "TicketId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 8,
                column: "TicketId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 9,
                column: "TicketId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ScreeningId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "ScreeningId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                column: "ScreeningId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "ScreeningId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                column: "ScreeningId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                column: "ScreeningId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                column: "ScreeningId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(341), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(371), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(389), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(366), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(374), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(379), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(391), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(386), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(376), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(482), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(486), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(488), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(490), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(493), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(495), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(501), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(503), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(505), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(1121), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(1124), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(1126), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(1127), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(1129), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(419), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(421), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(425), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(412), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(414), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(423), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(417), new DateTime(2022, 12, 17, 12, 1, 25, 39, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.AddForeignKey(
                name: "fk_bookingticket_ticket",
                table: "BookingTickets",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
