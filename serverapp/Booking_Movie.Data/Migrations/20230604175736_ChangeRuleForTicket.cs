using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRuleForTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingTickets_Tickets_TicketId",
                table: "BookingTickets");

            migrationBuilder.DropForeignKey(
                name: "fk_bookingticket_screeningticket",
                table: "BookingTickets");

            migrationBuilder.DropForeignKey(
                name: "fk_ticket_screeingticket",
                table: "ScreeningTickets");

            migrationBuilder.DropIndex(
                name: "IX_BookingTickets_ScreeningTicketId",
                table: "BookingTickets");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ValidityDateFromId",
                table: "Tickets",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ValidityDateToId",
                table: "Tickets",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "BookingTickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7478), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7488), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7482), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7474), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7491), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7485), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e85b90d0-f081-44a4-b8e7-1c91ea2ca5c2", "AQAAAAIAAYagAAAAEG1KYChhsV8wGwkUAXDyqhLEAQvn7yQrPavN98JBDwPGnHRfbzu5gCtm/JH3nc1OSw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53a66049-e0a3-46cf-bc2f-4e3d20a85298", "AQAAAAIAAYagAAAAENUSYQvGBfPvrizcGGCKSXP0soSqDJ0eS2KCqiTdEO9+6WK9+9viJNMQcs6arhOKCg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19400b72-dc98-4482-aac1-b76dafc2e548", "AQAAAAIAAYagAAAAEKNLdRORf95/NLwF+1xnvi4lEv5WBRAidw4HDTfjZQTWyFiZZ28QTWa/FGyPCaNmkg==" });

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
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7291), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7318), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7334), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7315), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7321), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7328), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7338), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7331), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7324), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7548), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7553), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7558), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7561), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7565), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7569), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7586), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7590), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7594), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8779), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8783), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8786), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8792), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7396), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7427), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7385), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7399), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7391), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MovieId", "ValidityDateFromId", "ValidityDateToId" },
                values: new object[] { 1, "08:00", "20:00" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MovieId", "ValidityDateFromId", "ValidityDateToId" },
                values: new object[] { 1, "08:00", "20:00" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MovieId", "ValidityDateFromId", "ValidityDateToId" },
                values: new object[] { 1, "22:00", "22:00" });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_MovieId",
                table: "Tickets",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ValidityDateFromId",
                table: "Tickets",
                column: "ValidityDateFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ValidityDateToId",
                table: "Tickets",
                column: "ValidityDateToId");

            migrationBuilder.AddForeignKey(
                name: "fk_bookingticket_ticket",
                table: "BookingTickets",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScreeningTickets_Tickets_TicketId",
                table: "ScreeningTickets",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_ticket_movie",
                table: "Tickets",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_ticket_validityDateFrom",
                table: "Tickets",
                column: "ValidityDateFromId",
                principalTable: "ShowTimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_ticket_validityDateTo",
                table: "Tickets",
                column: "ValidityDateToId",
                principalTable: "ShowTimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_bookingticket_ticket",
                table: "BookingTickets");

            migrationBuilder.DropForeignKey(
                name: "FK_ScreeningTickets_Tickets_TicketId",
                table: "ScreeningTickets");

            migrationBuilder.DropForeignKey(
                name: "fk_ticket_movie",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "fk_ticket_validityDateFrom",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "fk_ticket_validityDateTo",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_MovieId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ValidityDateFromId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ValidityDateToId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ValidityDateFromId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ValidityDateToId",
                table: "Tickets");

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "BookingTickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6871), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6882), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6875), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6866), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6885), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6878), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e0c51ed-c314-4cdf-a568-36686a369813", "AQAAAAIAAYagAAAAEO7H22Bja31uNq2dovWEb0VLe9bv0Zxa8c0HNrTmGS2KmW0zLlI5STvfRbsscA/onA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0d54859e-4116-48d2-a638-ec5c9dc5699c", "AQAAAAIAAYagAAAAEHs/OZBTt8bMuh8oQ1GTmtdQSRs/QBmhLivkxqbq3jsdKLihI6V/t2RkmT5CAcPBtA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc33b4ae-de11-4368-8939-70542cf58990", "AQAAAAIAAYagAAAAEEtCTwvbWqLXgo8XMKVaZF8FPHgt7/qPZTHaqizZO5gBADmxdA1FX9QzXU/zYOtJyA==" });

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "TicketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 2,
                column: "TicketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 3,
                column: "TicketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 4,
                column: "TicketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 5,
                column: "TicketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 6,
                column: "TicketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 7,
                column: "TicketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 8,
                column: "TicketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 9,
                column: "TicketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4839), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4876), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4903), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4868), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4882), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4892), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4908), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4898), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4887), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6959), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6964), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6968), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6972), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6978), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6982), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(7013), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(7017), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(7021), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(8352), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(8359), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(8361), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(8364), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(8366), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6561), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6564), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6595), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6533), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6553), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6567), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6556), new DateTime(2023, 6, 1, 13, 19, 14, 569, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.CreateIndex(
                name: "IX_BookingTickets_ScreeningTicketId",
                table: "BookingTickets",
                column: "ScreeningTicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTickets_Tickets_TicketId",
                table: "BookingTickets",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "fk_bookingticket_screeningticket",
                table: "BookingTickets",
                column: "ScreeningTicketId",
                principalTable: "ScreeningTickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_ticket_screeingticket",
                table: "ScreeningTickets",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
