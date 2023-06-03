using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Booking_Movie.Data.Migrations
{
    /// <inheritdoc />
    public partial class seekScreeningTicketData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(435), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(445), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(438), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(439) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(431), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(448), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(442), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8f8a8cc-6945-4e93-bd5b-1202333720d5", "AQAAAAIAAYagAAAAEPQuXRLUK6yCZnqjhrJ4n/m8hx71TA1e8v4r35EJWTTcMm+iMm773SyA0Eqy7jvfsg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9b4c25b-5b83-4ca0-bb5c-934773885aa3", "AQAAAAIAAYagAAAAEFyZe7fRTlMp/dduOFzldBVmZT0PKEsrOoyrQEWyHvxliZTGmVFetWkwwf3E1B8OQg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63a52d14-4cbc-453f-be82-7db404e22802", "AQAAAAIAAYagAAAAEKb2qtV8HgYCTwgZc2MqxPfMYW2WX18Au/aGhwblvanxFbjrtxFH14SBhSkOXMb3kQ==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(244), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(273), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(290), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(268), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(277), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(283), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(293), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(287), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(280), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(510), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(516), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(520), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(523), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(527), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(531), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(534), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(561), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(566), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(1766), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(1771), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(1773), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(1775), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(1777), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(353), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(355), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(378), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(345), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(346) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(348), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(357), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(350), new DateTime(2023, 5, 23, 0, 16, 8, 87, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.InsertData(
                table: "ScreeningTickets",
                columns: new[] { "Id", "Price", "ScreeningId", "TicketId" },
                values: new object[,]
                {
                    { 4, 50000m, 6, 1 },
                    { 5, 75000m, 6, 2 },
                    { 6, 50000m, 16, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ScreeningTickets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ScreeningTickets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ScreeningTickets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1733), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1742), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1736), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1730), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1744), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1739), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "402cb1bd-8e7e-40eb-af3a-e6e18e9e7837", "AQAAAAIAAYagAAAAEKY7QmXXJT3/tO893UP00XVhmaAXkflAnKR3fBE0DynBwBh6h+anznETB/awuKcd2w==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c82d0f9c-3b8a-45c8-bb3f-26420d5f7bba", "AQAAAAIAAYagAAAAECTaZPRO72IQPVS+pXIYgYtTmF4Tl7sPm15O3ArsQGiqifbshtLFQjuXAR5sZhxitA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "295c4e79-cc5c-4ba1-ba10-6d10e7773b17", "AQAAAAIAAYagAAAAEI6RyJy3L7Px9z4tngo44ADylt1REDxKOzXcQmcaTzw6wkc3ZlqWYaUmuipxg27MgA==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1563), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1586), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1603), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1583), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1590), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1596), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1606), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1593), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1797), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1803), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1807), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1810), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1813), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1817), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1834), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1837), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1841), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(4107), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(4113), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(4116), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(4118), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(4120), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1651), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1653), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1683), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1644), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1646), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1655), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1649), new DateTime(2023, 5, 21, 1, 58, 53, 573, DateTimeKind.Local).AddTicks(1649) });
        }
    }
}
