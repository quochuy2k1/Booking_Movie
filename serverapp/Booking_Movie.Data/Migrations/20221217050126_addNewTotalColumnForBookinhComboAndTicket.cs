using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    public partial class addNewTotalColumnForBookinhComboAndTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "BookingTickets",
                type: "decimal(12,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "BookingCombos",
                type: "decimal(12,4)",
                nullable: false,
                defaultValue: 0m);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "BookingTickets");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "BookingCombos");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9205), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9214), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9207), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9202), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9217), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9212), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "daf342fa-d2ad-443b-9306-29b6fc07d8bd", "AQAAAAEAACcQAAAAEIGdIb0kMrie6/w2Y/Y6jrzDPt3jF6IossoNbK6nG2RhKZg5K9zSCoeruSveCpnPMA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aed5d436-3cc8-4166-8bc0-a86416f43bd3", "AQAAAAEAACcQAAAAEGfX/ROVMizWlnvTFTVzSCqJm+7o6Fv1cVKjxz5dc9T04ycv8tlrowIZqg2UCErD4A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bab7a5ca-2f8e-4af3-87c2-cad42e9f4257", "AQAAAAEAACcQAAAAEHRAR+IMyne0sPbuniT2k9jYyHmL80+2QTVUWJMgqNiQJvJoNo9OJfi40XzylxNw4g==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9100), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9118), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9135), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9115), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9121), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9130), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9138), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9132), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9124), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9243), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9245), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9248), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9250), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9252), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9254), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9257), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9260), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9262), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9867), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9870), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9871), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9873), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9876), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9168), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9170), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9174), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9162), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9164), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9172), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9166), new DateTime(2022, 12, 17, 11, 11, 43, 854, DateTimeKind.Local).AddTicks(9167) });
        }
    }
}
