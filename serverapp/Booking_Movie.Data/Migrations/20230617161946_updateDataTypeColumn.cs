using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateDataTypeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Row",
                table: "Seats",
                type: "varchar(5)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1)");

            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "Seats",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Movies",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7767), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7778), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7771), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7763), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7781), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7774), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7fef9dca-bb02-45c4-b473-12a287b18d80", "AQAAAAIAAYagAAAAEJbeIqzIwvQUczJRy1PGsxTXPqTDqv3aswYDeebBeXm2Uw7PTXUSpJCZIXfzWEuSMA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0ec044a-49be-497f-a25b-7f3af9d27d92", "AQAAAAIAAYagAAAAEL+UbOV6FXE+nK2Q82cdjeWVV+VyOFzKjZeLjF1stqCd2fE4P6aACp1o4MxbWbgBZw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74a73c58-0a70-4489-a78d-d6976ca81073", "AQAAAAIAAYagAAAAEJf4ICxPe0/o1VAB5iV7NOqT+AaJqmNBPx77xFPPAvHYU3JMex0486XPpIesfo82Qw==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7560), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7584), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7600), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7580), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7587), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7593), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7604), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7597), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7590), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7828), 105, new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7834), 105, new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7838), 105, new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7842), 105, new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7845), 105, new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7849), 105, new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7869), 105, new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7873), 105, new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7878), 105, new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 242, DateTimeKind.Local).AddTicks(167), new DateTime(2023, 6, 17, 23, 19, 45, 242, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 242, DateTimeKind.Local).AddTicks(174), new DateTime(2023, 6, 17, 23, 19, 45, 242, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 242, DateTimeKind.Local).AddTicks(176), new DateTime(2023, 6, 17, 23, 19, 45, 242, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 242, DateTimeKind.Local).AddTicks(178), new DateTime(2023, 6, 17, 23, 19, 45, 242, DateTimeKind.Local).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 242, DateTimeKind.Local).AddTicks(181), new DateTime(2023, 6, 17, 23, 19, 45, 242, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7677), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7680), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7709), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7651), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7654), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7682), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7657), new DateTime(2023, 6, 17, 23, 19, 45, 241, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "00",
                column: "Number",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A1",
                column: "Number",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A10",
                column: "Number",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A11",
                column: "Number",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A12",
                column: "Number",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A2",
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A3",
                column: "Number",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A4",
                column: "Number",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A5",
                column: "Number",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A6",
                column: "Number",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A7",
                column: "Number",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A8",
                column: "Number",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A9",
                column: "Number",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B1",
                column: "Number",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B10",
                column: "Number",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B11",
                column: "Number",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B12",
                column: "Number",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B2",
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B3",
                column: "Number",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B4",
                column: "Number",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B5",
                column: "Number",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B6",
                column: "Number",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B7",
                column: "Number",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B8",
                column: "Number",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B9",
                column: "Number",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C1",
                column: "Number",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C10",
                column: "Number",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C11",
                column: "Number",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C12",
                column: "Number",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C2",
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C3",
                column: "Number",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C4",
                column: "Number",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C5",
                column: "Number",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C6",
                column: "Number",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C7",
                column: "Number",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C8",
                column: "Number",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C9",
                column: "Number",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D1",
                column: "Number",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D10",
                column: "Number",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D11",
                column: "Number",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D12",
                column: "Number",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D2",
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D3",
                column: "Number",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D4",
                column: "Number",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D5",
                column: "Number",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D6",
                column: "Number",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D7",
                column: "Number",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D8",
                column: "Number",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D9",
                column: "Number",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E1",
                column: "Number",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E10",
                column: "Number",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E11",
                column: "Number",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E12",
                column: "Number",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E2",
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E3",
                column: "Number",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E4",
                column: "Number",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E5",
                column: "Number",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E6",
                column: "Number",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E7",
                column: "Number",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E8",
                column: "Number",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E9",
                column: "Number",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F1",
                column: "Number",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F10",
                column: "Number",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F11",
                column: "Number",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F12",
                column: "Number",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F2",
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F3",
                column: "Number",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F4",
                column: "Number",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F5",
                column: "Number",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F6",
                column: "Number",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F7",
                column: "Number",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F8",
                column: "Number",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F9",
                column: "Number",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G1",
                column: "Number",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G10",
                column: "Number",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G11",
                column: "Number",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G12",
                column: "Number",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G2",
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G3",
                column: "Number",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G4",
                column: "Number",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G5",
                column: "Number",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G6",
                column: "Number",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G7",
                column: "Number",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G8",
                column: "Number",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G9",
                column: "Number",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H1",
                column: "Number",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H10",
                column: "Number",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H11",
                column: "Number",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H12",
                column: "Number",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H2",
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H3",
                column: "Number",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H4",
                column: "Number",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H5",
                column: "Number",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H6",
                column: "Number",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H7",
                column: "Number",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H8",
                column: "Number",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H9",
                column: "Number",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I1",
                column: "Number",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I10",
                column: "Number",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I11",
                column: "Number",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I12",
                column: "Number",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I2",
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I3",
                column: "Number",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I4",
                column: "Number",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I5",
                column: "Number",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I6",
                column: "Number",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I7",
                column: "Number",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I8",
                column: "Number",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I9",
                column: "Number",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J1",
                column: "Number",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J10",
                column: "Number",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J11",
                column: "Number",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J12",
                column: "Number",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J13",
                column: "Number",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J14",
                column: "Number",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J2",
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J3",
                column: "Number",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J4",
                column: "Number",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J5",
                column: "Number",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J6",
                column: "Number",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J7",
                column: "Number",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J8",
                column: "Number",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J9",
                column: "Number",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K1",
                column: "Number",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K10",
                column: "Number",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K11",
                column: "Number",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K12",
                column: "Number",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K13",
                column: "Number",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K14",
                column: "Number",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K2",
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K3",
                column: "Number",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K4",
                column: "Number",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K5",
                column: "Number",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K6",
                column: "Number",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K7",
                column: "Number",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K8",
                column: "Number",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K9",
                column: "Number",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L1",
                column: "Number",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L10",
                column: "Number",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L11",
                column: "Number",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L12",
                column: "Number",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L13",
                column: "Number",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L14",
                column: "Number",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L15",
                column: "Number",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L16",
                column: "Number",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L2",
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L3",
                column: "Number",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L4",
                column: "Number",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L5",
                column: "Number",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L6",
                column: "Number",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L7",
                column: "Number",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L8",
                column: "Number",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L9",
                column: "Number",
                value: 9);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Row",
                table: "Seats",
                type: "varchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)");

            migrationBuilder.AlterColumn<byte>(
                name: "Number",
                table: "Seats",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<short>(
                name: "Duration",
                table: "Movies",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2906), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2916), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2910), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2902), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2919), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2913), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "33dc704e-4c46-4db7-9b8f-5d12e82b2b95", "AQAAAAIAAYagAAAAEFGsRfOTrbu+z6/445yzXvOusNXy41Ge5rJM6u4GX2VH7AnjRzPqX0VXQycpjtTxlg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b62f4bd5-c5e5-4252-9644-377bc4a9bdf0", "AQAAAAIAAYagAAAAED8bznvmdSl9CiYvYhXliiUyTiySna9gESh4mByV9NwYv9caI+6Ez3M6ln7kemM69A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4896d976-4a7b-4c3f-855b-da5a1bf010b9", "AQAAAAIAAYagAAAAEN+RmYRkx+KLd1iawKjd+qXLgRQMUnLi4sPBCc1XyIWRtdck6TS7wYBFdb/ReJVTKQ==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2712), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2738), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2754), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2734), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2741), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2748), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2774), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2751), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2745), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2972), (short)105, new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2977), (short)105, new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2982), (short)105, new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2985), (short)105, new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2989), (short)105, new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2992), (short)105, new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(3009), (short)105, new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(3013), (short)105, new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Duration", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(3017), (short)105, new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(4968), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(4975), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(4978), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(4981), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(4983), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2823), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2825), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2857), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2814), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2817), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2828), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2820), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "00",
                column: "Number",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A1",
                column: "Number",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A10",
                column: "Number",
                value: (byte)10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A11",
                column: "Number",
                value: (byte)11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A12",
                column: "Number",
                value: (byte)12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A2",
                column: "Number",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A3",
                column: "Number",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A4",
                column: "Number",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A5",
                column: "Number",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A6",
                column: "Number",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A7",
                column: "Number",
                value: (byte)7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A8",
                column: "Number",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "A9",
                column: "Number",
                value: (byte)9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B1",
                column: "Number",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B10",
                column: "Number",
                value: (byte)10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B11",
                column: "Number",
                value: (byte)11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B12",
                column: "Number",
                value: (byte)12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B2",
                column: "Number",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B3",
                column: "Number",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B4",
                column: "Number",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B5",
                column: "Number",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B6",
                column: "Number",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B7",
                column: "Number",
                value: (byte)7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B8",
                column: "Number",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "B9",
                column: "Number",
                value: (byte)9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C1",
                column: "Number",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C10",
                column: "Number",
                value: (byte)10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C11",
                column: "Number",
                value: (byte)11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C12",
                column: "Number",
                value: (byte)12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C2",
                column: "Number",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C3",
                column: "Number",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C4",
                column: "Number",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C5",
                column: "Number",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C6",
                column: "Number",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C7",
                column: "Number",
                value: (byte)7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C8",
                column: "Number",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "C9",
                column: "Number",
                value: (byte)9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D1",
                column: "Number",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D10",
                column: "Number",
                value: (byte)10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D11",
                column: "Number",
                value: (byte)11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D12",
                column: "Number",
                value: (byte)12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D2",
                column: "Number",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D3",
                column: "Number",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D4",
                column: "Number",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D5",
                column: "Number",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D6",
                column: "Number",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D7",
                column: "Number",
                value: (byte)7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D8",
                column: "Number",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "D9",
                column: "Number",
                value: (byte)9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E1",
                column: "Number",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E10",
                column: "Number",
                value: (byte)10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E11",
                column: "Number",
                value: (byte)11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E12",
                column: "Number",
                value: (byte)12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E2",
                column: "Number",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E3",
                column: "Number",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E4",
                column: "Number",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E5",
                column: "Number",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E6",
                column: "Number",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E7",
                column: "Number",
                value: (byte)7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E8",
                column: "Number",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "E9",
                column: "Number",
                value: (byte)9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F1",
                column: "Number",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F10",
                column: "Number",
                value: (byte)10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F11",
                column: "Number",
                value: (byte)11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F12",
                column: "Number",
                value: (byte)12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F2",
                column: "Number",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F3",
                column: "Number",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F4",
                column: "Number",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F5",
                column: "Number",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F6",
                column: "Number",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F7",
                column: "Number",
                value: (byte)7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F8",
                column: "Number",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "F9",
                column: "Number",
                value: (byte)9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G1",
                column: "Number",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G10",
                column: "Number",
                value: (byte)10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G11",
                column: "Number",
                value: (byte)11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G12",
                column: "Number",
                value: (byte)12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G2",
                column: "Number",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G3",
                column: "Number",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G4",
                column: "Number",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G5",
                column: "Number",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G6",
                column: "Number",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G7",
                column: "Number",
                value: (byte)7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G8",
                column: "Number",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "G9",
                column: "Number",
                value: (byte)9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H1",
                column: "Number",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H10",
                column: "Number",
                value: (byte)10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H11",
                column: "Number",
                value: (byte)11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H12",
                column: "Number",
                value: (byte)12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H2",
                column: "Number",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H3",
                column: "Number",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H4",
                column: "Number",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H5",
                column: "Number",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H6",
                column: "Number",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H7",
                column: "Number",
                value: (byte)7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H8",
                column: "Number",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "H9",
                column: "Number",
                value: (byte)9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I1",
                column: "Number",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I10",
                column: "Number",
                value: (byte)10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I11",
                column: "Number",
                value: (byte)11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I12",
                column: "Number",
                value: (byte)12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I2",
                column: "Number",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I3",
                column: "Number",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I4",
                column: "Number",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I5",
                column: "Number",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I6",
                column: "Number",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I7",
                column: "Number",
                value: (byte)7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I8",
                column: "Number",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "I9",
                column: "Number",
                value: (byte)9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J1",
                column: "Number",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J10",
                column: "Number",
                value: (byte)10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J11",
                column: "Number",
                value: (byte)11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J12",
                column: "Number",
                value: (byte)12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J13",
                column: "Number",
                value: (byte)13);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J14",
                column: "Number",
                value: (byte)14);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J2",
                column: "Number",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J3",
                column: "Number",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J4",
                column: "Number",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J5",
                column: "Number",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J6",
                column: "Number",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J7",
                column: "Number",
                value: (byte)7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J8",
                column: "Number",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "J9",
                column: "Number",
                value: (byte)9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K1",
                column: "Number",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K10",
                column: "Number",
                value: (byte)10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K11",
                column: "Number",
                value: (byte)11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K12",
                column: "Number",
                value: (byte)12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K13",
                column: "Number",
                value: (byte)13);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K14",
                column: "Number",
                value: (byte)14);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K2",
                column: "Number",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K3",
                column: "Number",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K4",
                column: "Number",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K5",
                column: "Number",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K6",
                column: "Number",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K7",
                column: "Number",
                value: (byte)7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K8",
                column: "Number",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "K9",
                column: "Number",
                value: (byte)9);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L1",
                column: "Number",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L10",
                column: "Number",
                value: (byte)10);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L11",
                column: "Number",
                value: (byte)11);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L12",
                column: "Number",
                value: (byte)12);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L13",
                column: "Number",
                value: (byte)13);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L14",
                column: "Number",
                value: (byte)14);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L15",
                column: "Number",
                value: (byte)15);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L16",
                column: "Number",
                value: (byte)16);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L2",
                column: "Number",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L3",
                column: "Number",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L4",
                column: "Number",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L5",
                column: "Number",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L6",
                column: "Number",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L7",
                column: "Number",
                value: (byte)7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L8",
                column: "Number",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "L9",
                column: "Number",
                value: (byte)9);
        }
    }
}
