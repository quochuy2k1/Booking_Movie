using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Booking_Movie.Data.Migrations
{
    /// <inheritdoc />
    public partial class addNewTicketTypeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TicketTypeId",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TicketTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3131), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3141), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3134), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3126), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3143), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3138), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92f21555-52be-4cf2-b5ba-4b22a21cda4e", "AQAAAAIAAYagAAAAEBPvcF4HIrreyv/qucxkoYbWBiz2iF7wgr9RhxSyrGtiJ7RU7RHQu9+FdQYFZTp1fQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9bc4f4bf-b3c3-4048-975d-61fd47bebc30", "AQAAAAIAAYagAAAAEPzjIr35kKkCZCf9RX0im19cl9nW5urctcRrz6Z3UZpnHD6H9/S4uPyzLK6D8jyN0A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a764892-9888-43ba-905f-e04bccedf157", "AQAAAAIAAYagAAAAEAYJj3cw4RU1NYbCPnsPBsRuQgPzdEKQWOZUIUBAanRgrX7Mt+cTCkIeTXset0AwVQ==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2936), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2962), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2980), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2958), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2966), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2973), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2983), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2976), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2969), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3197), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3203), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3207), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3210), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3214), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3218), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3233), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3238), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3241), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(4278), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(4282), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(4284), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(4286), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(4289), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3050), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3052), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3079), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3025), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3045), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3054), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3048), new DateTime(2023, 6, 21, 10, 50, 44, 639, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.InsertData(
                table: "TicketTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Người lớn" },
                    { 2, "Người trẻ em" },
                    { 3, "Sau 22h" }
                });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "TicketTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                column: "TicketTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                column: "TicketTypeId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TicketTypeId",
                table: "Tickets",
                column: "TicketTypeId");

            migrationBuilder.AddForeignKey(
                name: "fk_ticket_ticket_type",
                table: "Tickets",
                column: "TicketTypeId",
                principalTable: "TicketTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_ticket_ticket_type",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "TicketTypes");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_TicketTypeId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TicketTypeId",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7930), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7938), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7933), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7927), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7940), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7935), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aaa915f2-a5f8-41fc-8b68-b5e6085ba295", "AQAAAAIAAYagAAAAEBREaEMeFjfZnWaIDF7q4bE8D8c3RRZDXHEwsenCEXurk17MF1DvJjfyv0tDAekUyA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0103b781-8723-4715-99c5-84c9eb20599a", "AQAAAAIAAYagAAAAEIGekzaJkcQBbsH/TnLCsGADL5oVXvT5qKBYj/IleZIXU+9WH1qO/BHZs2w2OK2PdA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21e36e44-1869-440f-b073-f5749c23a73b", "AQAAAAIAAYagAAAAENXtRWzJVVD+eO4E7f1FdzYI+ltBKKrDRvnC6X9wf/0Pd2q0ohAZFLDMttf/dUPXHw==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7771), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7791), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7807), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7788), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7794), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7800), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7810), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7803), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7797), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7989), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7993), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7997), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(8000), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(8004), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(8007), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(8019), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(8027), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(8031), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 172, DateTimeKind.Local).AddTicks(313), new DateTime(2023, 6, 21, 8, 26, 57, 172, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 172, DateTimeKind.Local).AddTicks(319), new DateTime(2023, 6, 21, 8, 26, 57, 172, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 172, DateTimeKind.Local).AddTicks(321), new DateTime(2023, 6, 21, 8, 26, 57, 172, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 172, DateTimeKind.Local).AddTicks(329), new DateTime(2023, 6, 21, 8, 26, 57, 172, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 172, DateTimeKind.Local).AddTicks(331), new DateTime(2023, 6, 21, 8, 26, 57, 172, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7857), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7860), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7885), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7850), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7853), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7853) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7862), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7855), new DateTime(2023, 6, 21, 8, 26, 57, 171, DateTimeKind.Local).AddTicks(7856) });
        }
    }
}
