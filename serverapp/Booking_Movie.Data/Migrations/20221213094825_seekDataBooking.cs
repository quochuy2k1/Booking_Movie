using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    public partial class seekDataBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "AppUserId", "CouponId", "CreatedDate", "PaymentMethodId", "ScreeningId", "Stauts", "Total" },
                values: new object[,]
                {
                    { 2, new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, true, 250000m },
                    { 3, new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, true, 15000m },
                    { 4, new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, true, 20000m },
                    { 5, new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, true, 560000m },
                    { 6, new Guid("dea78e4f-c2b7-451f-77d1-08dac47f52e7"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, true, 1000000m },
                    { 7, new Guid("dea78e4f-c2b7-451f-77d1-08dac47f52e7"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 10, true, 75000m }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(786), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(795), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(791), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(784), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(797), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(793), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa09d810-30cd-4bea-8bab-614e26ed448f", "AQAAAAEAACcQAAAAEMMeB/ANFnDBd4VT7DZk9GFV78gDpRTxXAuA+5MlMI2V8ibUKoe1OYIZ/pmm1dgTlw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "42dc259d-02e6-417a-b2b4-80db2181ff98", "AQAAAAEAACcQAAAAELjsUecdx66JhdGi28rhy/QeiTK3Efmj+GT2/I0e4ssALEqywON1JHKLdeijnXP+cA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5250c8f9-6c3a-4fc1-a740-440ab2c6f440", "AQAAAAEAACcQAAAAENululgk0EoePsSOmFPGrG5VcUE9WIkMo9WUTjZupyhh1bY933vIYGAiEOGtHCUrHA==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(695), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(717), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(729), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(706), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(720), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(724), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(736), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(726), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(722), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(820), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(823), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(825), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(827), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(832), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(834), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(836), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(838), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(840), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(1361), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(1364), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(1366), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(1367), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(1369), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(760), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(761), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(765), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(753), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(755), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(763), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(757), new DateTime(2022, 12, 10, 22, 38, 6, 677, DateTimeKind.Local).AddTicks(758) });
        }
    }
}
