using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Movie.Data.Migrations
{
    public partial class AllowNullForSomeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tickets",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "PaymentMethods",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "FlagProducer",
                table: "Nationalities",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "FlagMovie",
                table: "Nationalities",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "FlagDirector",
                table: "Nationalities",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "FlagActor",
                table: "Nationalities",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "VideoTrailer",
                table: "Movies",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePreview",
                table: "Movies",
                type: "nvarchar(255)",
                nullable: true,
                defaultValue: "duongdan.jpg",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldDefaultValue: "duongdan.jpg");

            migrationBuilder.AlterColumn<string>(
                name: "ImageBackground",
                table: "Movies",
                type: "nvarchar(255)",
                nullable: true,
                defaultValue: "duongdan.jpg",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldDefaultValue: "duongdan.jpg");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SortOrder",
                table: "DirectorImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDefault",
                table: "DirectorImages",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "DirectorImages",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "Caption",
                table: "DirectorImages",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ValidTo",
                table: "Coupons",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ValidFrom",
                table: "Coupons",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Coupons",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Coupons",
                type: "decimal(12,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)");

            migrationBuilder.AlterColumn<int>(
                name: "AvailableQuantity",
                table: "Coupons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Alias",
                table: "Coupons",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Combos",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<bool>(
                name: "HomeFlag",
                table: "Categories",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SortOrder",
                table: "ActorImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Caption",
                table: "ActorImages",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tickets",
                type: "nvarchar(255)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "PaymentMethods",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FlagProducer",
                table: "Nationalities",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FlagMovie",
                table: "Nationalities",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FlagDirector",
                table: "Nationalities",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FlagActor",
                table: "Nationalities",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VideoTrailer",
                table: "Movies",
                type: "nvarchar(255)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImagePreview",
                table: "Movies",
                type: "nvarchar(255)",
                nullable: false,
                defaultValue: "duongdan.jpg",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true,
                oldDefaultValue: "duongdan.jpg");

            migrationBuilder.AlterColumn<string>(
                name: "ImageBackground",
                table: "Movies",
                type: "nvarchar(255)",
                nullable: false,
                defaultValue: "duongdan.jpg",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true,
                oldDefaultValue: "duongdan.jpg");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SortOrder",
                table: "DirectorImages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDefault",
                table: "DirectorImages",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "DirectorImages",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Caption",
                table: "DirectorImages",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ValidTo",
                table: "Coupons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ValidFrom",
                table: "Coupons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Coupons",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Coupons",
                type: "decimal(12,4)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AvailableQuantity",
                table: "Coupons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Alias",
                table: "Coupons",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Combos",
                type: "nvarchar(255)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HomeFlag",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SortOrder",
                table: "ActorImages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Caption",
                table: "ActorImages",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("1fa1a35a-d969-4b44-8cc0-1f6fbff578fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4608), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("26340d49-35d2-4696-addf-e4fc97cd5300"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4615), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("343d4b37-c4f7-4d24-adb6-05abeda8aa41"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4610), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("354b3fae-02fc-482f-bf68-1cc40b04c34f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4605), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("376ef100-3a18-45dd-b83c-517d2cafc0dc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4616), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: new Guid("bf79e94c-2b38-4763-aacd-8161006e8347"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4613), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab778d64-0d3e-4ab6-bc7c-a50b93de737b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40e6ad9c-e4af-491d-9c5d-325283e96858", "AQAAAAEAACcQAAAAEODhqFu96D/9/B0ffUuU/U5D0Y+bTLgO9HD5q7MEhGjH0g270mW5kRmM3+1t96ghnA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8a04d06-2334-4806-92a6-6f6db3ed6692"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cb78997c-fe6e-461c-abbf-ba0b346f9a50", "AQAAAAEAACcQAAAAECL/nm5gZmRFxJ2YCrHeTVpZUDTi5DvpCL6vNBRkGYs/Gybn/FrPStIktOR8uAv1/w==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ac55f-ef97-468f-a493-e9a8eeec395e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b841d22-b93c-4c40-8efe-30ebc8112611", "AQAAAAEAACcQAAAAEEfvzzR1V+QojSusXjTbthduFMlZuDx5Hl/AR/xQ8IYp8tzf9Kc2A0vDRSrUJ9rFvw==" });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("01c9b39b-ad45-41fe-ace0-244b38254f99"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4514), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("55266710-251a-45a1-b11b-d2e2e7e104ea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4529), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("7e02a8db-94e7-4842-8b35-96c48d0e0c63"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4542), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("88034877-a697-472c-a2d8-3d133792c463"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4525), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("c089db2a-468a-4287-8b45-a832bb10fe93"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4531), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e37edc8f-48ff-40fe-bcfc-d37a689a5b04"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4538), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("e717c0c2-82f5-46a8-8e50-95999e661a67"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4544), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("eb504714-17f9-4aa3-8b5b-6360102f8453"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4540), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "ID",
                keyValue: new Guid("ff9a4cc9-3191-4da4-9bf8-6cd8bd129138"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4533), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4641), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4644), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4646), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4648), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4650), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4652), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4654), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4656), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4658), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5170), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5173), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5174), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5176), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5177), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("272d7cd7-6ed5-428d-9bd9-ddeb0f5affea"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4569), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("34652a25-e4ce-4994-a412-84ae013d775b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4571), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("3f8ba972-52da-4a37-b152-a92628e4b714"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4574), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("7935c4e4-a92a-401c-a994-7bcf420e00aa"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4563), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("8e82c641-c8f2-4ac9-820a-f59789bbd12f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4565), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("c6c6386c-78d9-4e32-b993-d7b660210437"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4572), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "ID",
                keyValue: new Guid("e8a07088-de72-4b6c-bdd8-14370ab2a3ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4567), new DateTime(2022, 11, 14, 18, 29, 46, 962, DateTimeKind.Local).AddTicks(4567) });
        }
    }
}
