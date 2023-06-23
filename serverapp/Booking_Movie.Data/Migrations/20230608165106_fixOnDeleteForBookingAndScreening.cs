using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixOnDeleteForBookingAndScreening : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_booking_screening",
                table: "Bookings");

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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2972), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2977), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2982), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2985), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2989), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2992), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(3009), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(3013), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(3017), new DateTime(2023, 6, 8, 23, 51, 5, 339, DateTimeKind.Local).AddTicks(3017) });

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

            migrationBuilder.AddForeignKey(
                name: "fk_booking_screening",
                table: "Bookings",
                column: "ScreeningId",
                principalTable: "Screenings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_booking_screening",
                table: "Bookings");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7478), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7488), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7482), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7474), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7491), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7485), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e85b90d0-f081-44a4-b8e7-1c91ea2ca5c2", "AQAAAAIAAYagAAAAEG1KYChhsV8wGwkUAXDyqhLEAQvn7yQrPavN98JBDwPGnHRfbzu5gCtm/JH3nc1OSw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53a66049-e0a3-46cf-bc2f-4e3d20a85298", "AQAAAAIAAYagAAAAENUSYQvGBfPvrizcGGCKSXP0soSqDJ0eS2KCqiTdEO9+6WK9+9viJNMQcs6arhOKCg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19400b72-dc98-4482-aac1-b76dafc2e548", "AQAAAAIAAYagAAAAEKNLdRORf95/NLwF+1xnvi4lEv5WBRAidw4HDTfjZQTWyFiZZ28QTWa/FGyPCaNmkg==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7291), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7318), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7334), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7315), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7321), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7328), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7338), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7331), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7324), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7548), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7553), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7558), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7561), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7565), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7569), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7586), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7590), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7594), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8779), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8783), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8786), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8792), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7396), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7427), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7385), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7399), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7391), new DateTime(2023, 6, 5, 0, 57, 35, 512, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.AddForeignKey(
                name: "fk_booking_screening",
                table: "Bookings",
                column: "ScreeningId",
                principalTable: "Screenings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
