using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    public partial class addCoolumnImageBackgroundMovieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageBackground",
                table: "Movies",
                type: "nvarchar(255)",
                nullable: false,
                defaultValue: "duongdan.jpg");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageBackground",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5128), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5135), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5131), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5126), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5137), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5133), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "effdb6d6-7339-43c3-bc2a-c2df1d72ab6c", "AQAAAAEAACcQAAAAEPARDKg9UdYcKj58+AY7hiz1kEDXhlYEun6ArvZCkD593A93z2XkbkiykFCk8CvA5g==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e23dcd96-df4c-45e2-b8a4-f1df511b6a71", "AQAAAAEAACcQAAAAECOjmn3+ddOILC94VJagssTo89QBWAVlGrHOpSdRJWodbbJBvp9ARExYDj2aFTo5/g==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa3694a0-bb9e-4c6f-a366-7c8973153d37", "AQAAAAEAACcQAAAAEFB3zjspVTjThlOn4il0lCvpQvUrTSvv39sH0/Z0SXu6yBd2TWP6+gpCNiR9Zl9pug==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5052), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5067), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5078), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5064), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5069), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5073), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5080), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5076), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5071), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5154), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5157), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5159), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5162), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5164), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5166), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5168), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5192), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5195), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5708), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5711), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5713), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5714), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5716), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5103), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5104), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5108), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5096), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5099), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5106), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5101), new DateTime(2022, 10, 31, 23, 9, 33, 432, DateTimeKind.Local).AddTicks(5101) });
        }
    }
}
