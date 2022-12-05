using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    public partial class addSeatStyleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SeatStyle",
                table: "SeatNos",
                newName: "SeatStyleId");

            migrationBuilder.CreateTable(
                name: "SeatStyles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatStyles", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4608), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4615), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4610), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4605), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4616), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4613), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40e6ad9c-e4af-491d-9c5d-325283e96858", "AQAAAAEAACcQAAAAEODhqFu96D/9/B0ffUuU/U5D0Y+bTLgO9HD5q7MEhGjH0g270mW5kRmM3+1t96ghnA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cb78997c-fe6e-461c-abbf-ba0b346f9a50", "AQAAAAEAACcQAAAAECL/nm5gZmRFxJ2YCrHeTVpZUDTi5DvpCL6vNBRkGYs/Gybn/FrPStIktOR8uAv1/w==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b841d22-b93c-4c40-8efe-30ebc8112611", "AQAAAAEAACcQAAAAEEfvzzR1V+QojSusXjTbthduFMlZuDx5Hl/AR/xQ8IYp8tzf9Kc2A0vDRSrUJ9rFvw==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4514), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4529), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4542), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4525), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4531), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4538), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4544), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4540), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4533), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4641), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4644), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4646), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4648), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4650), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4652), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4654), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4656), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4658), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5170), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5173), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5174), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5176), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5177), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4569), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4571), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4574), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4563), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4565), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4572), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4567), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.InsertData(
                table: "SeatStyles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Ghế VIP" },
                    { 2, null, "Ghế Couple" },
                    { 3, null, "Ghế Cao cấp" }
                });

            migrationBuilder.InsertData(
                table: "SeatStyles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 4, null, "Ghế Không thể chọn" });

            migrationBuilder.InsertData(
                table: "SeatStyles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 5, null, "Ghế Thường" });

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 1,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 2,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 3,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 4,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 5,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 6,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 7,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 8,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 9,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 10,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 11,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 12,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 13,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 14,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 15,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 16,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 17,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 18,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 19,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 20,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 21,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 22,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 23,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 24,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 25,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 26,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 27,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 28,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 29,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 30,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 31,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 32,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 33,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 34,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 35,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 36,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 37,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 38,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 39,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 40,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 41,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 42,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 43,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 44,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 45,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 46,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 47,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 48,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 49,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 50,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 51,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 52,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 53,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 54,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 55,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 56,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 57,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 58,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 59,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 60,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 61,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 62,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 63,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 64,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 65,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 66,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 67,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 68,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 69,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 70,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 71,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 72,
                column: "SeatStyleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 73,
                column: "SeatStyleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 74,
                column: "SeatStyleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 75,
                column: "SeatStyleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 76,
                column: "SeatStyleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 77,
                column: "SeatStyleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 78,
                column: "SeatStyleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 79,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 80,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 81,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 82,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 83,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 84,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 85,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 86,
                column: "SeatStyleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 87,
                column: "SeatStyleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 88,
                column: "SeatStyleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 89,
                column: "SeatStyleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 90,
                column: "SeatStyleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 91,
                column: "SeatStyleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 92,
                column: "SeatStyleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 93,
                column: "SeatStyleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 94,
                column: "SeatStyleId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 95,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 96,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 97,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 98,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 99,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 100,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 101,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 102,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 103,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 104,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 105,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 106,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 107,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 108,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 110,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 111,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 112,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 113,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 114,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 115,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 116,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 117,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 118,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 119,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 120,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 121,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 122,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 123,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 124,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 125,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 126,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 127,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 128,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 129,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 130,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 131,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 132,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 133,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 134,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 135,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 136,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 137,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 138,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 139,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 140,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 141,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 142,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 143,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 144,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 145,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 146,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 147,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 148,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 149,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 150,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 151,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 152,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 153,
                column: "SeatStyleId",
                value: 4);

            migrationBuilder.CreateIndex(
                name: "IX_SeatNos_SeatStyleId",
                table: "SeatNos",
                column: "SeatStyleId");

            migrationBuilder.AddForeignKey(
                name: "fk_seatno_seatstyle",
                table: "SeatNos",
                column: "SeatStyleId",
                principalTable: "SeatStyles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_seatno_seatstyle",
                table: "SeatNos");

            migrationBuilder.DropTable(
                name: "SeatStyles");

            migrationBuilder.DropIndex(
                name: "IX_SeatNos_SeatStyleId",
                table: "SeatNos");

            migrationBuilder.RenameColumn(
                name: "SeatStyleId",
                table: "SeatNos",
                newName: "SeatStyle");

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
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 2,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 3,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 4,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 5,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 6,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 7,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 8,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 9,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 10,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 11,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 12,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 13,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 14,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 15,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 16,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 17,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 18,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 19,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 20,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 21,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 22,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 23,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 24,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 25,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 26,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 27,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 28,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 29,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 30,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 31,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 32,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 33,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 34,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 35,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 36,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 37,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 38,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 39,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 40,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 41,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 42,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 43,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 44,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 45,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 46,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 47,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 48,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 49,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 50,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 51,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 52,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 53,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 54,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 55,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 56,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 57,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 58,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 59,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 60,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 61,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 62,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 63,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 64,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 65,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 66,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 67,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 68,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 69,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 70,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 71,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 72,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 73,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 74,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 75,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 76,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 77,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 78,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 79,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 80,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 81,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 82,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 83,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 84,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 85,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 86,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 87,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 88,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 89,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 90,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 91,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 92,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 93,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 94,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 95,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 96,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 97,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 98,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 99,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 100,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 101,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 102,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 103,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 104,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 105,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 106,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 107,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 108,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 110,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 111,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 112,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 113,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 114,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 115,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 116,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 117,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 118,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 119,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 120,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 121,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 122,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 123,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 124,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 125,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 126,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 127,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 128,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 129,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 130,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 131,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 132,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 133,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 134,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 135,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 136,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 137,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 138,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 139,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 140,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 141,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 142,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 143,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 144,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 145,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 146,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 147,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 148,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 149,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 150,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 151,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 152,
                column: "SeatStyle",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SeatNos",
                keyColumn: "Id",
                keyValue: 153,
                column: "SeatStyle",
                value: 0);
        }
    }
}
