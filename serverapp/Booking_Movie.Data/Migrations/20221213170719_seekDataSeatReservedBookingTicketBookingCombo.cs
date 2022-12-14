using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    public partial class seekDataSeatReservedBookingTicketBookingCombo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3340), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3355), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3343), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3335), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3359), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3352), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "acfc8024-c597-4aa2-b0cf-da2483c6874e", "AQAAAAEAACcQAAAAEMiBmII1fT09zZu8Fk/XtiAZ6zQZZpaP5txyBaPPa4b3BxeJ3WkMGxItHUVqR9u1ow==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b204710-fb3e-4854-b472-d1c4dc64083d", "AQAAAAEAACcQAAAAEAqwr6EyCGUbsMTZnu/uRqC2sN908x6xEvbPDo/GUoxtxTSqaTreq2CUREQ4WeSQ4g==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "124d57d3-824b-4433-816a-9558425c4c0f", "AQAAAAEAACcQAAAAELltuuK3GdLqUvR5ma/XU6TxSTWr4TXAha9JCU2r6s13h7Mer6ppyI+xCzwYOikVxA==" });

            migrationBuilder.InsertData(
                table: "BookingCombos",
                columns: new[] { "Id", "BookingId", "ComboId", "Quantity", "Stauts" },
                values: new object[,]
                {
                    { 4, 3, 3, 1, true },
                    { 5, 4, 1, 1, true },
                    { 6, 4, 2, 1, true },
                    { 7, 5, 3, 1, true },
                    { 8, 6, 1, 3, true },
                    { 9, 7, 2, 3, true },
                    { 10, 7, 1, 1, true }
                });

            migrationBuilder.InsertData(
                table: "BookingTickets",
                columns: new[] { "Id", "BookingId", "Quantity", "Stauts", "TicketId" },
                values: new object[,]
                {
                    { 3, 2, 1, true, 1 },
                    { 4, 2, 1, true, 2 },
                    { 5, 3, 1, true, 1 },
                    { 6, 4, 3, true, 2 },
                    { 7, 5, 2, true, 2 },
                    { 8, 6, 3, true, 1 },
                    { 9, 7, 1, true, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3193), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3220), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3238), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3215), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3223), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3231), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3241), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3234), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3228), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3397), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3401), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3405), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3408), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3412), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3415), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3420), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3423), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3427), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(4255), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(4259), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(4262), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(4265), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(4270), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3288), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3292), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3297), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3275), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3283), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3294), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3286), new DateTime(2022, 12, 14, 0, 7, 17, 294, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.InsertData(
                table: "SeatReserveds",
                columns: new[] { "Id", "BookingId", "SeatNoId", "Stauts" },
                values: new object[,]
                {
                    { 4, 2, 5, true },
                    { 5, 2, 6, true },
                    { 6, 3, 7, true },
                    { 7, 4, 8, true },
                    { 8, 4, 9, true },
                    { 9, 4, 10, true },
                    { 10, 5, 25, true },
                    { 11, 5, 26, true },
                    { 12, 6, 36, true },
                    { 13, 6, 37, true },
                    { 14, 6, 38, true },
                    { 15, 7, 40, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookingCombos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookingCombos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookingCombos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookingCombos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BookingCombos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BookingCombos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BookingCombos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BookingTickets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SeatReserveds",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SeatReserveds",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SeatReserveds",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SeatReserveds",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SeatReserveds",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SeatReserveds",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SeatReserveds",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SeatReserveds",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SeatReserveds",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SeatReserveds",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SeatReserveds",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SeatReserveds",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3447), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3454), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3449), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3444), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3456), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3452), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cea3ba5d-7400-4196-8697-d7467310d292", "AQAAAAEAACcQAAAAEMWDo96JDiYLDM8FOHXSzcCEezbmSyiz6pWtuTXku4i7+wVA6yjZ6G6dZ3snb5dyDQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71e0de2d-47c4-48bb-99a0-861fb214a253", "AQAAAAEAACcQAAAAEAQYYMlI8N1fVMODnTNkTxzPCg7h1S6vwdObHhSoxoCB4iDoRuoQNJ+Sf9m7k+vMCw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "904bf22d-b975-47c8-8fc1-033033914b12", "AQAAAAEAACcQAAAAEJofKJjQ63RIPRer2V9nyUoZFMkl6PblHlr5gbzOZmHpR/WpIfFz8t3ZCVyD8aLYFQ==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3355), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3373), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3385), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3370), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3376), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3380), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3388), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3383), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3378), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3486), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3489), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3491), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3494), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3496), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3498), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3501), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3503), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3505), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(4096), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(4099), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(4101), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(4102), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(4104), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3415), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3417), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3420), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3409), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3411), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3418), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3413), new DateTime(2022, 12, 13, 16, 48, 23, 705, DateTimeKind.Local).AddTicks(3414) });
        }
    }
}
