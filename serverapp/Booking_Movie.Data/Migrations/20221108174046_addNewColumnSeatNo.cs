using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    public partial class addNewColumnSeatNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Stauts",
                table: "SeatReserveds",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Stauts",
                table: "SeatNos",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "ColumnIndex",
                table: "SeatNos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RowIndex",
                table: "SeatNos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeatStyle",
                table: "SeatNos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Stauts",
                table: "BookingTickets",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Stauts",
                table: "Bookings",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Stauts",
                table: "BookingCombos",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8188), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8194), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8190), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8185), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8196), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8192), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8193) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5c70dce6-fef4-4c72-88db-85559436933c", "AQAAAAEAACcQAAAAEM7L3MoaoP/83KLIbNcRjQPV5Yo0Bb03y76cUgEOQbuG1Epsd2VM38IiuRyunNbuNQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16ccbd09-fa78-4eac-96e7-e034fb69268d", "AQAAAAEAACcQAAAAEKw9aSkxGbF4NX91lLUOCFO81AT+/VKDq/MGO11gQ7tQN7agdpdcRIU2OFtDTx+uUg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "60693b17-547a-41f6-9f6a-845213b274eb", "AQAAAAEAACcQAAAAEE4qLH90q7JobOYisK4YWDhmJqjhyffPDPKmrEglzrfIFbHTTljOFaTcWvqiUMEqNg==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8091), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8109), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8119), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8105), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8111), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8115), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8121), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8117), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8113), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8222), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8225), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8227), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8231), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8233), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8235), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8240), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8243), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8245), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8978), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8981), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8983), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8984), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8986), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8153), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8154), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8158), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8147), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8149), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8156), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8151), new DateTime(2022, 11, 9, 0, 40, 45, 263, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 1, 1, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 2, 1, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 5, 1, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 5, 1, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 7, 1, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 8, 1, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 9, 1, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 10, 1, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 11, 1, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 12, 1, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 13, 1, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 14, 1, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 1, 2, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 2, 2, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 5, 2, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 6, 2, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 7, 2, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 8, 2, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 9, 2, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 10, 2, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 11, 2, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 12, 2, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 13, 2, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 14, 2, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 1, 3, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 2, 3, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 5, 3, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 6, 3, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 7, 3, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 8, 3, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 9, 3, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 10, 3, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 11, 3, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 12, 3, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 13, 3, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 14, 3, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 1, 4, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 2, 4, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 5, 4, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 6, 4, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 7, 4, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 8, 4, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 9, 4, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 10, 4, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 11, 4, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 12, 4, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 13, 4, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 14, 4, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 1, 5, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 2, 5, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 5, 5, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 6, 5, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 7, 5, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 8, 5, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 9, 5, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 10, 5, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 11, 5, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 12, 5, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 13, 5, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 14, 5, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 1, 6, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 2, 6, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 5, 6, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 6, 6, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 7, 6, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 8, 6, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 9, 6, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 10, 6, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 11, 6, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 12, 6, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 13, 6, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 14, 6, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 1, 7, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 2, 7, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 5, 7, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 6, 7, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 7, 7, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 8, 7, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 9, 7, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 10, 7, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 11, 7, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 12, 7, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 13, 7, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 14, 7, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 1, 8, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 2, 8, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 5, 8, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 6, 8, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 7, 8, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 8, 8, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 9, 8, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 10, 8, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 11, 8, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 12, 8, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 13, 8, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 14, 8, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 1, 9, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 2, 9, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 5, 9, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 6, 9, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 7, 9, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 8, 9, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 9, 9, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 10, 9, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 11, 9, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 12, 9, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 13, 9, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatStyle" },
                values: new object[] { 14, 9, 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 1, 11, "J1", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 2, 11, "J2", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 3, 11, "J3", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 4, 11, "J4", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 5, 11, "J5", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 6, 11, "J6", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 7, 11, "J7", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 8, 11, "J8", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 9, 11, "J9", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 10, 11, "J10", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 11, 11, "J11", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 12, 11, "J12", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 13, 11, "J13", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 14, 11, "J14", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 1, 12, "K1", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 2, 12, "K2", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 3, 12, "K3", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 4, 12, "K4", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 5, 12, "K5", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 6, 12, "K6", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 7, 12, "K7", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 8, 12, "K8", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 9, 12, "K9", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 10, 12, "K10", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 11, 12, "K11", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 12, 12, "K12", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 13, 12, "K13", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 14, 12, "K14", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 1, 13, "L1", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 2, 13, "L2", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 3, 13, "L3", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 4, 13, "L4", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 5, 13, "L5", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 6, 13, "L6", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 7, 13, "L7", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 8, 13, "L8", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 9, 13, "L9", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 10, 13, "L10", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 11, 13, "L11", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 12, 13, "L12", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 13, 13, "L13", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 14, 13, "L14", 0 });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ColumnIndex", "RowIndex", "SeatId", "SeatStyle" },
                values: new object[] { 15, 13, "L15", 0 });

            migrationBuilder.InsertData(
                table: "SeatNos",
                columns: new[] { "Id", "AuditoriumId", "ColumnIndex", "RowIndex", "SeatId", "SeatStyle", "Stauts" },
                values: new object[] { 153, 1, 16, 13, "L16", 0, false });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "SeatId", "Number", "Row" },
                values: new object[] { "00", (byte)0, "0" });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "SeatId", "Stauts" },
                values: new object[] { "00", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "00");

            migrationBuilder.DropColumn(
                name: "ColumnIndex",
                table: "SeatNos");

            migrationBuilder.DropColumn(
                name: "RowIndex",
                table: "SeatNos");

            migrationBuilder.DropColumn(
                name: "SeatStyle",
                table: "SeatNos");

            migrationBuilder.AlterColumn<bool>(
                name: "Stauts",
                table: "SeatReserveds",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Stauts",
                table: "SeatNos",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Stauts",
                table: "BookingTickets",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Stauts",
                table: "Bookings",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Stauts",
                table: "BookingCombos",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1692), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1699), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1694), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1689), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1701), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1696), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dacace37-2b55-4f61-bb95-125e792d8aa0", "AQAAAAEAACcQAAAAENlJ8anXBH+JCxhPVNDIWcN4s2PLwZ1pbh90HFmMIggfS4F5mZhIq7QC5tNW/ealHA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "beb71e1d-56e2-4622-b823-08ae0e3206dd", "AQAAAAEAACcQAAAAEC0dPTiwjDrcEluCbEVahksZDX0VZD9XEkA5/MqWUN36NIJ9m64ZzLDT85tgnWy4jg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40124d97-04b8-47b8-bfa7-2bd837a87770", "AQAAAAEAACcQAAAAEFeywE1BCV2m1szcZMJIwdmZncTYbJSyb99n1t0KiHpdlXtYKF4zp2lLjz0cHYQmcw==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1594), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1616), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1627), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1613), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1618), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1622), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1629), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1624), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1620), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1726), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1730), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1732), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1737), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1739), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1742), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1744), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1746), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1749), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(2218), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(2221), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(2226), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(2228), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(2230), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1658), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1660), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1664), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1652), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1654), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1662), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1656), new DateTime(2022, 11, 1, 21, 12, 57, 107, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "SeatId", "Stauts" },
                values: new object[] { "J1", false });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 110,
                column: "SeatId",
                value: "J2");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 111,
                column: "SeatId",
                value: "J3");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 112,
                column: "SeatId",
                value: "J4");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 113,
                column: "SeatId",
                value: "J5");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 114,
                column: "SeatId",
                value: "J6");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 115,
                column: "SeatId",
                value: "J7");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 116,
                column: "SeatId",
                value: "J8");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 117,
                column: "SeatId",
                value: "J9");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 118,
                column: "SeatId",
                value: "J10");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 119,
                column: "SeatId",
                value: "J11");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 120,
                column: "SeatId",
                value: "J12");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 121,
                column: "SeatId",
                value: "J13");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 122,
                column: "SeatId",
                value: "J14");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 123,
                column: "SeatId",
                value: "K1");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 124,
                column: "SeatId",
                value: "K2");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 125,
                column: "SeatId",
                value: "K3");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 126,
                column: "SeatId",
                value: "K4");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 127,
                column: "SeatId",
                value: "K5");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 128,
                column: "SeatId",
                value: "K6");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 129,
                column: "SeatId",
                value: "K7");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 130,
                column: "SeatId",
                value: "K8");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 131,
                column: "SeatId",
                value: "K9");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 132,
                column: "SeatId",
                value: "K10");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 133,
                column: "SeatId",
                value: "K11");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 134,
                column: "SeatId",
                value: "K12");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 135,
                column: "SeatId",
                value: "K13");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 136,
                column: "SeatId",
                value: "K14");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 137,
                column: "SeatId",
                value: "L1");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 138,
                column: "SeatId",
                value: "L2");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 139,
                column: "SeatId",
                value: "L3");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 140,
                column: "SeatId",
                value: "L4");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 141,
                column: "SeatId",
                value: "L5");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 142,
                column: "SeatId",
                value: "L6");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 143,
                column: "SeatId",
                value: "L7");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 144,
                column: "SeatId",
                value: "L8");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 145,
                column: "SeatId",
                value: "L9");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 146,
                column: "SeatId",
                value: "L10");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 147,
                column: "SeatId",
                value: "L11");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 148,
                column: "SeatId",
                value: "L12");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 149,
                column: "SeatId",
                value: "L13");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 150,
                column: "SeatId",
                value: "L14");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 151,
                column: "SeatId",
                value: "L15");

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 152,
                column: "SeatId",
                value: "L16");
        }
    }
}
