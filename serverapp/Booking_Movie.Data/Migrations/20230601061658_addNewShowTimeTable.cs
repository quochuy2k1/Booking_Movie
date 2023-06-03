using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Booking_Movie.Data.Migrations
{
    /// <inheritdoc />
    public partial class addNewShowTimeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShowTime",
                table: "Screenings");

            migrationBuilder.RenameColumn(
                name: "MovieTypeId",
                table: "Screenings",
                newName: "ScreeningTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Screenings_MovieTypeId",
                table: "Screenings",
                newName: "IX_Screenings_ScreeningTypeId");

            migrationBuilder.AddColumn<string>(
                name: "ShowTimeId",
                table: "Screenings",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ShowTimes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowTimes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2828), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2837), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2831), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2824), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2840), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2834), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b43c91b9-8384-4279-8575-0a3dab51adf9", "AQAAAAIAAYagAAAAEIfXwD/2XG7QEWP4pB2S9c3u5ZvJ0NAYZOaya1wK1Ooh9ooSjhaIjzDmorGUaK2G6Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab7b90a8-f6da-41cf-a0de-92a6ecac603a", "AQAAAAIAAYagAAAAEJ0RJssFmq4Yz0j2OhdX5sVaVxatTUtXjkY1BfSCJw2LRtacZIjaBPJkhRBi2Bia1A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7de52def-f568-436f-b3fa-4440d487648a", "AQAAAAIAAYagAAAAELgAf9ftKtHML72L/LgodVLFYoL/hVETrrPl3FlVF1u8gfNMwGI5EY0lcgNq2GZTug==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2643), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2671), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2688), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2667), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2674), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2682), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2691), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2685), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2678), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2679) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2895), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2900), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2904), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2907), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2911), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2916), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2938), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2942), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2945), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(5677), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(5684), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(5686), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(5689), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(5691), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2742), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2744), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2734), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2737), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2746), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 6, 1, 13, 16, 57, 13, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShowTimeId",
                value: "08:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShowTimeId",
                value: "18:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "ShowTimeId",
                value: "08:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "ShowTimeId",
                value: "10:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 5,
                column: "ShowTimeId",
                value: "13:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 6,
                column: "ShowTimeId",
                value: "13:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 7,
                column: "ShowTimeId",
                value: "15:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 8,
                column: "ShowTimeId",
                value: "18:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 9,
                column: "ShowTimeId",
                value: "20:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 10,
                column: "ShowTimeId",
                value: "18:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 11,
                column: "ShowTimeId",
                value: "20:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 12,
                column: "ShowTimeId",
                value: "22:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 13,
                column: "ShowTimeId",
                value: "20:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 14,
                column: "ShowTimeId",
                value: "15:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 15,
                column: "ShowTimeId",
                value: "22:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 16,
                column: "ShowTimeId",
                value: "08:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 17,
                column: "ShowTimeId",
                value: "10:00");

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 18,
                column: "ShowTimeId",
                value: "15:00");

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "Id", "Time" },
                values: new object[,]
                {
                    { "08:00", new DateTime(2023, 6, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                    { "10:00", new DateTime(2023, 6, 1, 3, 0, 0, 0, DateTimeKind.Utc) },
                    { "13:00", new DateTime(2023, 6, 1, 6, 0, 0, 0, DateTimeKind.Utc) },
                    { "15:00", new DateTime(2023, 6, 1, 8, 0, 0, 0, DateTimeKind.Utc) },
                    { "18:00", new DateTime(2023, 6, 1, 11, 0, 0, 0, DateTimeKind.Utc) },
                    { "20:00", new DateTime(2023, 6, 1, 13, 0, 0, 0, DateTimeKind.Utc) },
                    { "22:00", new DateTime(2023, 6, 1, 15, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShowTimes");

            migrationBuilder.DropColumn(
                name: "ShowTimeId",
                table: "Screenings");

            migrationBuilder.RenameColumn(
                name: "ScreeningTypeId",
                table: "Screenings",
                newName: "MovieTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Screenings_ScreeningTypeId",
                table: "Screenings",
                newName: "IX_Screenings_MovieTypeId");

            migrationBuilder.AddColumn<DateTime>(
                name: "ShowTime",
                table: "Screenings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8896), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8905), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8899), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8891), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8908), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8902), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2bdeb37c-ee6f-4e44-8d0f-6a2aaf9edd7b", "AQAAAAIAAYagAAAAEBOhwKQnabI1+1SxAeln1aRgPAp3K2fF/Ywg5FxTHFMv69oIzP1/0PsPZfssD6PEXw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1fcad65b-b30e-4ad8-8db0-1dc79df765b0", "AQAAAAIAAYagAAAAEKPCqW8uRFxI4AdGrBFernjn8Rx1IJeRDw70Wks4YjS0h3PBDmWEGM8yRLBwQl4aaw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79735ce7-ee57-4121-b10d-5e0c372661bd", "AQAAAAIAAYagAAAAEFEZcb3TD4E/pI8eeFCh955H/63R1lyCOo3oaPHNnWoDm5/luH4HCkJFgeWWsNds8A==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8708), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8735), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8752), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8731), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8739), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8746), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8755), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8749), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8743), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8956), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8962), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8966), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8969), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8973), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8976), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8992), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8996), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9971), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9975), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9977), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8805), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8807), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8847), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8797), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8800), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8827), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8802), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShowTime",
                value: new DateTime(2022, 10, 29, 9, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShowTime",
                value: new DateTime(2022, 10, 29, 17, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "ShowTime",
                value: new DateTime(2022, 10, 30, 9, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "ShowTime",
                value: new DateTime(2022, 10, 31, 10, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 5,
                column: "ShowTime",
                value: new DateTime(2022, 11, 1, 11, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 6,
                column: "ShowTime",
                value: new DateTime(2022, 11, 2, 13, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 7,
                column: "ShowTime",
                value: new DateTime(2022, 11, 3, 14, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 8,
                column: "ShowTime",
                value: new DateTime(2022, 11, 4, 15, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 9,
                column: "ShowTime",
                value: new DateTime(2022, 11, 5, 16, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 10,
                column: "ShowTime",
                value: new DateTime(2022, 1, 6, 17, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 11,
                column: "ShowTime",
                value: new DateTime(2022, 1, 7, 18, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 12,
                column: "ShowTime",
                value: new DateTime(2022, 11, 8, 19, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 13,
                column: "ShowTime",
                value: new DateTime(2022, 11, 9, 20, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 14,
                column: "ShowTime",
                value: new DateTime(2022, 11, 10, 21, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 15,
                column: "ShowTime",
                value: new DateTime(2022, 11, 11, 22, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 16,
                column: "ShowTime",
                value: new DateTime(2022, 11, 12, 8, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 17,
                column: "ShowTime",
                value: new DateTime(2022, 11, 13, 9, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 18,
                column: "ShowTime",
                value: new DateTime(2022, 11, 14, 14, 29, 59, 0, DateTimeKind.Unspecified));
        }
    }
}
