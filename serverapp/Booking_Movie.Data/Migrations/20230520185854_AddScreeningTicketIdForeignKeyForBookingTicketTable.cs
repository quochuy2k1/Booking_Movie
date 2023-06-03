using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddScreeningTicketIdForeignKeyForBookingTicketTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_BookingTickets_ScreeningTicketId",
                table: "BookingTickets",
                column: "ScreeningTicketId");

            migrationBuilder.AddForeignKey(
                name: "fk_bookingticket_screeningticket",
                table: "BookingTickets",
                column: "ScreeningTicketId",
                principalTable: "ScreeningTickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_bookingticket_screeningticket",
                table: "BookingTickets");

            migrationBuilder.DropIndex(
                name: "IX_BookingTickets_ScreeningTicketId",
                table: "BookingTickets");

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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(79), new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(87), new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(92), new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(98), new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(102), new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(107), new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(132), new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(138), new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(142), new DateTime(2023, 5, 21, 1, 50, 18, 888, DateTimeKind.Local).AddTicks(143) });

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
        }
    }
}
