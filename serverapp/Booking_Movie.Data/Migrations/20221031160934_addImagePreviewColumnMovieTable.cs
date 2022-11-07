using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    public partial class addImagePreviewColumnMovieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VideoTrailer",
                table: "Movies",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ImagePreview",
                table: "Movies",
                type: "nvarchar(255)",
                nullable: false,
                defaultValue: "duongdan.jpg");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePreview",
                table: "Movies");

            migrationBuilder.AlterColumn<string>(
                name: "VideoTrailer",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5304), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5311), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5306), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5301), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5313), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5309), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d476d3d1-9045-4220-a593-abf3d52d6f0c", "AQAAAAEAACcQAAAAEJrdd8eXhWlboIjEVJgBHJEOQ12GCrtnQsUVRGnS5ffEZAUzDoOgGIF6N7cObj57SA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69aac4aa-5dcc-4b5d-b1dd-0333539fe759", "AQAAAAEAACcQAAAAEIUWiUb6j5zSldpLQVmzas7ZGXQHKI0KIO0ztiSbPw8+dadpugtBu69PPLdKuDcy8A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d3cdedf-af91-49da-9704-93ec1fa153eb", "AQAAAAEAACcQAAAAEPALw1fMHavO1KncYF2wqt8WjnNvk1c3UljE72KWhAzMkSXvT+ThlmlDF2UHpD5leA==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5208), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5227), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5238), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5223), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5229), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5234), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5240), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5236), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5231), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5337), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5340), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5343), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5346), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5349), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5351), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5353), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5356), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5358), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5900), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5903), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5905), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5907), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5909), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5272), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5274), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5278), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5264), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5267), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5276), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5270), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5270) });
        }
    }
}
