using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressColumnForCinema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Cinemas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8896), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8905), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8899), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8891), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8908), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8902), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2bdeb37c-ee6f-4e44-8d0f-6a2aaf9edd7b", "AQAAAAIAAYagAAAAEBOhwKQnabI1+1SxAeln1aRgPAp3K2fF/Ywg5FxTHFMv69oIzP1/0PsPZfssD6PEXw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1fcad65b-b30e-4ad8-8db0-1dc79df765b0", "AQAAAAIAAYagAAAAEKPCqW8uRFxI4AdGrBFernjn8Rx1IJeRDw70Wks4YjS0h3PBDmWEGM8yRLBwQl4aaw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79735ce7-ee57-4121-b10d-5e0c372661bd", "AQAAAAIAAYagAAAAEFEZcb3TD4E/pI8eeFCh955H/63R1lyCOo3oaPHNnWoDm5/luH4HCkJFgeWWsNds8A==" });

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Name" },
                values: new object[] { "116 Đ. Nguyễn Du, Phường Bến Thành, Quận 1, Thành phố Hồ Chí Minh", "Berry Nguyễn Du" });

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Name" },
                values: new object[] { "Sense City, 9 Đ. Trần Hưng Đạo, Phường 5, Thành phố Cà Mau, Cà Mau", "Berry Cà Mau" });

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Name" },
                values: new object[] { "246 Đ. Nguyễn Hồng Đào, Phường 13, Tân Bình, Thành phố Hồ Chí Minh", "Berry Tân Bình" });

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Name" },
                values: new object[] { "718bis Đ. Kinh Dương Vương, Phường 13, Quận 6, Thành phố Hồ Chí Minh", "Berry Kinh Dương Vương" });

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Name" },
                values: new object[] { "304A Quang Trung, Phường 11, Gò Vấp, Thành phố Hồ Chí Minh", "Berry Quang Trung" });

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Name" },
                values: new object[] { "Lầu 1, TTTM Sense City, 26A Trần Quốc Tuấn, Phường 4, Bến Tre", "Berry Bến Tre" });

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Name" },
                values: new object[] { "Coop Mart, 478 Điện Biên Phủ, Thanh Khê Đông, Thanh Khê, Đà Nẵng", "Berry Đà Nẵng" });

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Name" },
                values: new object[] { "104 P. Lương Khánh Thiện, Lương Khá Thien, Ngô Quyền, Hải Phòng", "Berry Hải Phòng" });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "LocationId", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 9, "02 Đường 30.04, Phường 2, TP. Cao Lãnh, Đồng Tháp.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Berry Cao Lãnh", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8708), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8735), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8752), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8731), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8739), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8746), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8755), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8749), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8743), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8956), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8962), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8966), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8969), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8973), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8976), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8992), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8996), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9971), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9975), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9977), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8805), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8807), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8847), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8797), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8800), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8827), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8802), new DateTime(2023, 5, 31, 1, 21, 45, 618, DateTimeKind.Local).AddTicks(8803) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Cinemas");

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
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Galaxy Nguyễn Du");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Galaxy Cà Mau");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Galaxy Tân Bình");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Galaxy Kinh Dương Vương");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Galaxy Quang Trung");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Galaxy Bến Tre");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Galaxy Đà Nẵng");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Galaxy Hải Phòng");

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
        }
    }
}
