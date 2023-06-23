using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    /// <inheritdoc />
    public partial class adjustNullableFormultiablColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TicketTypes",
                type: "nvarchar(255)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6451), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6460), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6454), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6447), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6463), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6457), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70d8a78d-8346-44ee-8b81-0482aa87e6f4", "AQAAAAIAAYagAAAAEKtWn3EXOR4mJcRsK+tI/UgZgS1uxi04bl8NWU3mBtHGqG8KEcEq+FnNmbCswaewUA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d8520a70-2a22-4cf0-82b5-0c341a351d2a", "AQAAAAIAAYagAAAAEImcHPVYPYd/XLfo5RLHo9PR3SP8UkTO0aCI2RBrCmF1E2ligCx/BjaeycebeCVvyw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "224d83d4-356b-462b-9b66-a5754aeb3f87", "AQAAAAIAAYagAAAAEGat/4Nmx7QCZet2TVXw/D2+EnAavyxebbQGBh0BL45Cl3OQLngqczokXHwbbCdo9Q==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6262), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6288), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6306), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6283), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6291), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6298), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6309), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6302), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6295), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6533), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6538), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6542), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6547), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6551), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6556), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6559), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6575), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6584), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(9195), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(9206), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(9209), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(9211), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(9214), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6362), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6365), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6396), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6354), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6358), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6367), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6360), new DateTime(2023, 6, 21, 14, 51, 49, 248, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "TicketTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Vé 2D sử dụng từ 16 tuổi trở lên");

            migrationBuilder.UpdateData(
                table: "TicketTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Vé 2D sử dụng dưới 16");

            migrationBuilder.UpdateData(
                table: "TicketTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Vé 2D chỉ sử dụng cho suất chiếu sau 22h");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TicketTypes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
