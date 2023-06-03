using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    /// <inheritdoc />
    public partial class addConstraintForShowTimeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_Screenings_ShowTimeId",
                table: "Screenings",
                column: "ShowTimeId");

            migrationBuilder.AddForeignKey(
                name: "fk_screening_showtime",
                table: "Screenings",
                column: "ShowTimeId",
                principalTable: "ShowTimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_screening_showtime",
                table: "Screenings");

            migrationBuilder.DropIndex(
                name: "IX_Screenings_ShowTimeId",
                table: "Screenings");

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
        }
    }
}
