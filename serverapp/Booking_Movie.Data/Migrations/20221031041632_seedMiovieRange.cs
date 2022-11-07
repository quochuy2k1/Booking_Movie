using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    public partial class seedMiovieRange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5223), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5229), "Jaume Collet-Serra", new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "Name", "NationalityId", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5231), "Ilya Maksimov", "en", new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "DateOfBirth", "Description", "Height", "Image", "Name", "NationalityId", "UpdatedBy", "UpdatedDate", "ViewCount" },
                values: new object[] { new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"), null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5236), new DateTime(1974, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1.75m, "", "Brando Lee", "en", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5236), 0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5337), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Alias", "Content", "CreatedBy", "CreatedDate", "Duration", "MetaDescription", "MetaKeyword", "Name", "NationalityId", "ProducerId", "ReleaseDate", "Status", "UpdatedBy", "UpdatedDate", "VideoTrailer" },
                values: new object[,]
                {
                    { 3, "Confidential_Assignment_2_:_International", "", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5343), (short)105, null, null, "Confidential Assignment 2: International", "vi", new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5343), "duongdan.mp4" },
                    { 9, "Love_Destiny_The_Movie", "", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5358), (short)105, null, null, "Love Destiny The Movie", "vi", new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5358), "duongdan.mp4" }
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "Id", "Code", "Description", "FlagActor", "FlagDirector", "FlagMovie", "FlagProducer", "Name" },
                values: new object[,]
                {
                    { "ms", "ms", "Quốc gia Malaysia", true, true, true, true, "MaLaysia" },
                    { "tha", "tha", "Quốc gia Thái Lan", true, true, true, true, "Thái Lan" },
                    { "ukr", "ukr", "Quốc gia Ukraina", true, true, true, true, "Ukraina" }
                });

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
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5264), new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "Image", "Name", "NationalityId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"), null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5272), "", "CJ Entertainment", "ko", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5272) },
                    { new Guid("34652a25-e4ce-4994-a412-84ae013d775b"), null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5274), "", "Lionsgate", "en", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5275) },
                    { new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"), null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5270), "", "Warner Bros", "en", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5270) }
                });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "ShowTime",
                value: new DateTime(2022, 10, 30, 9, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "ShowTime",
                value: new DateTime(2022, 10, 31, 10, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 5,
                column: "ShowTime",
                value: new DateTime(2022, 11, 1, 11, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 9, new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"), 3 },
                    { 10, new Guid("bdef1607-3be2-4613-b6db-eef50a851237"), 3 },
                    { 17, new Guid("a9886af6-ede6-422b-a808-a6dcce2d18e6"), 9 }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "Name", "NationalityId", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5234), "Lee Seok Hoon", "ukr", new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "DateOfBirth", "Description", "Height", "Image", "Name", "NationalityId", "UpdatedBy", "UpdatedDate", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"), null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5238), new DateTime(1974, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1.75m, "", "Parker Finn", "ms", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5238), 0 },
                    { new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"), null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5240), new DateTime(1974, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1.75m, "", "Park Gyu Tae", "tha", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5241), 0 }
                });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "Id", "CategoryId", "MovieId" },
                values: new object[,]
                {
                    { 5, 4, 3 },
                    { 6, 5, 3 },
                    { 15, 4, 9 },
                    { 16, 5, 9 }
                });

            migrationBuilder.InsertData(
                table: "MovieDireactors",
                columns: new[] { "Id", "DirectorId", "MovieId" },
                values: new object[] { 10, new Guid("88034877-a697-472c-a2d8-3d133792c463"), 9 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Alias", "Content", "CreatedBy", "CreatedDate", "Duration", "MetaDescription", "MetaKeyword", "Name", "NationalityId", "ProducerId", "ReleaseDate", "Status", "UpdatedBy", "UpdatedDate", "VideoTrailer" },
                values: new object[,]
                {
                    { 5, "Don't_Look_At_The_Demon", "", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5349), (short)105, null, null, "Don't Look At The Demon", "tha", new Guid("34652a25-e4ce-4994-a412-84ae013d775b"), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5349), "duongdan.mp4" },
                    { 6, "Gulliver_Returns", "", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5351), (short)105, null, null, "Gulliver Returns", "ms", new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5351), "duongdan.mp4" },
                    { 7, "Life_Is_Beautiful", "", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5353), (short)105, null, null, "Life Is Beautiful", "ko", new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5354), "duongdan.mp4" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "Image", "Name", "NationalityId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"), null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5278), "", "95 Animation Studio", "ukr", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5279) },
                    { new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"), null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5267), "", "GDH 559", "tha", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5267) },
                    { new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"), null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5276), "", "Bliss Pictures", "ms", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5277) }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "AuditoriumId", "MovieId", "MovieTypeId", "ShowTime" },
                values: new object[,]
                {
                    { 7, 3, 3, 1, new DateTime(2022, 11, 3, 14, 29, 59, 0, DateTimeKind.Unspecified) },
                    { 15, 3, 9, 1, new DateTime(2022, 11, 11, 22, 29, 59, 0, DateTimeKind.Unspecified) },
                    { 17, 1, 3, 1, new DateTime(2022, 11, 13, 9, 29, 59, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 13, new Guid("a9886af6-ede6-422b-a808-a6dcce2d18e6"), 5 },
                    { 14, new Guid("a9886af6-ede6-422b-a808-a6dcce2d18e6"), 6 },
                    { 15, new Guid("a9886af6-ede6-422b-a808-a6dcce2d18e6"), 7 },
                    { 18, new Guid("a9886af6-ede6-422b-a808-a6dcce2d18e6"), 7 }
                });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "Id", "CategoryId", "MovieId" },
                values: new object[,]
                {
                    { 8, 6, 5 },
                    { 9, 7, 6 },
                    { 10, 8, 6 },
                    { 11, 9, 7 },
                    { 12, 10, 7 }
                });

            migrationBuilder.InsertData(
                table: "MovieDireactors",
                columns: new[] { "Id", "DirectorId", "MovieId" },
                values: new object[,]
                {
                    { 4, new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"), 3 },
                    { 6, new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"), 5 },
                    { 7, new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"), 6 },
                    { 8, new Guid("88034877-a697-472c-a2d8-3d133792c463"), 7 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Alias", "Content", "CreatedBy", "CreatedDate", "Duration", "MetaDescription", "MetaKeyword", "Name", "NationalityId", "ProducerId", "ReleaseDate", "Status", "UpdatedBy", "UpdatedDate", "VideoTrailer" },
                values: new object[,]
                {
                    { 2, "Black_Adam", "", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5340), (short)105, null, null, "Black Adam", "en", new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5341), "duongdan.mp4" },
                    { 4, "Prey_For_The_Devil", "", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5346), (short)105, null, null, "Prey For The Devil", "ukr", new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5347), "duongdan.mp4" },
                    { 8, "Smile", "", null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5356), (short)105, null, null, "Smile", "es", new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2022, 10, 31, 11, 16, 30, 713, DateTimeKind.Local).AddTicks(5356), "duongdan.mp4" }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "AuditoriumId", "MovieId", "MovieTypeId", "ShowTime" },
                values: new object[,]
                {
                    { 10, 6, 5, 1, new DateTime(2022, 1, 6, 17, 29, 59, 0, DateTimeKind.Unspecified) },
                    { 11, 7, 5, 1, new DateTime(2022, 1, 7, 18, 29, 59, 0, DateTimeKind.Unspecified) },
                    { 12, 6, 6, 1, new DateTime(2022, 11, 8, 19, 29, 59, 0, DateTimeKind.Unspecified) },
                    { 13, 5, 7, 1, new DateTime(2022, 11, 9, 20, 29, 59, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 7, new Guid("bdef1607-3be2-4613-b6db-eef50a851237"), 2 },
                    { 8, new Guid("a9886af6-ede6-422b-a808-a6dcce2d18e6"), 2 },
                    { 11, new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"), 4 },
                    { 12, new Guid("a9886af6-ede6-422b-a808-a6dcce2d18e6"), 4 },
                    { 16, new Guid("a9886af6-ede6-422b-a808-a6dcce2d18e6"), 8 },
                    { 19, new Guid("a9886af6-ede6-422b-a808-a6dcce2d18e6"), 8 }
                });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "Id", "CategoryId", "MovieId" },
                values: new object[,]
                {
                    { 3, 2, 2 },
                    { 4, 3, 2 },
                    { 7, 6, 4 },
                    { 13, 1, 8 },
                    { 14, 3, 8 }
                });

            migrationBuilder.InsertData(
                table: "MovieDireactors",
                columns: new[] { "Id", "DirectorId", "MovieId" },
                values: new object[,]
                {
                    { 3, new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"), 2 },
                    { 5, new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"), 4 },
                    { 9, new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"), 8 }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "AuditoriumId", "MovieId", "MovieTypeId", "ShowTime" },
                values: new object[,]
                {
                    { 6, 2, 2, 1, new DateTime(2022, 11, 2, 13, 29, 59, 0, DateTimeKind.Unspecified) },
                    { 8, 4, 4, 1, new DateTime(2022, 11, 4, 15, 29, 59, 0, DateTimeKind.Unspecified) },
                    { 9, 5, 4, 1, new DateTime(2022, 11, 5, 16, 29, 59, 0, DateTimeKind.Unspecified) },
                    { 14, 4, 8, 1, new DateTime(2022, 11, 10, 21, 29, 59, 0, DateTimeKind.Unspecified) },
                    { 16, 2, 2, 1, new DateTime(2022, 11, 12, 8, 29, 59, 0, DateTimeKind.Unspecified) },
                    { 18, 2, 4, 1, new DateTime(2022, 11, 14, 14, 29, 59, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MovieDireactors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MovieDireactors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MovieDireactors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MovieDireactors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MovieDireactors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MovieDireactors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MovieDireactors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MovieDireactors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"));

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: "ms");

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: "tha");

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: "ukr");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5012), new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5018), new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5014), new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5009), new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5020), new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5016), new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "35299fa7-d2be-4138-9057-470c4fbe0cd5", "AQAAAAEAACcQAAAAELlPqZ89PPMter0Nqd3VLFQkrQO9M3cb2rcer7lPqLhE9hWKn+689/czvO9QlXiaVw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "08ef5bb9-95f4-4d4a-910f-5a7602cad0d5", "AQAAAAEAACcQAAAAEM9WbQeqtyhWP7D8yM89L40iB62hVBIcEO1fAIl5bmM9kkLFa4/Ex3Os0YGUQAsTxg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9e845431-53f3-4954-93d5-e9461199dcd9", "AQAAAAEAACcQAAAAEExqhjhtFovQp9YKgMRTV49zNIOjXwXZ1vBXcfrJQyHdhr35XKSNyAwXsReKHBhW6Q==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4951), new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4967), new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4964), new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4970), "Jaume Collet-Serra ", new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "Name", "NationalityId", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4974), "Jaume Collet-Serra ", "es", new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "Name", "NationalityId", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4972), "Jaume Collet-Serra ", "es", new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5037), new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5493), new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5494), new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5496), new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5497), new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4989), new DateTime(2022, 10, 30, 12, 2, 57, 481, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "ShowTime",
                value: new DateTime(2022, 10, 29, 17, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "ShowTime",
                value: new DateTime(2022, 10, 29, 17, 29, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 5,
                column: "ShowTime",
                value: new DateTime(2022, 10, 29, 17, 29, 59, 0, DateTimeKind.Unspecified));
        }
    }
}
