using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editReportTemplate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "Gnr",
                table: "ReportTemplate",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(649), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(644) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(651), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(653), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(655), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(657), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(659), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(661), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(663), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(665), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(608), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(605) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(610), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(612), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(611) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(613), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(613) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(615), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(614) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(616), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(618), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(619), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(620), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(623), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(624), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 125, DateTimeKind.Local).AddTicks(1321), new DateTime(2023, 3, 11, 13, 42, 34, 125, DateTimeKind.Local).AddTicks(1309) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 125, DateTimeKind.Local).AddTicks(1323), new DateTime(2023, 3, 11, 13, 42, 34, 125, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 125, DateTimeKind.Local).AddTicks(1324), new DateTime(2023, 3, 11, 13, 42, 34, 125, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(681), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(682), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(682) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(684), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 126, DateTimeKind.Local).AddTicks(1484), new DateTime(2023, 3, 11, 13, 42, 34, 125, DateTimeKind.Local).AddTicks(1461) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(494), new DateTime(2023, 3, 11, 13, 42, 34, 126, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(552), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(553), new DateTime(2023, 3, 11, 13, 42, 34, 127, DateTimeKind.Local).AddTicks(553) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "Gnr",
                table: "ReportTemplate",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8047), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8049), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8051), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8053), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8055), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8057), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8056) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8059), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8061), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8063), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8003), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8005), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8007), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8006) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8008), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8008) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8010), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8011), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8013), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8012) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8014), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8015), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8018), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8017) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8019), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 597, DateTimeKind.Local).AddTicks(8192), new DateTime(2023, 3, 6, 15, 9, 43, 597, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 597, DateTimeKind.Local).AddTicks(8195), new DateTime(2023, 3, 6, 15, 9, 43, 597, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 597, DateTimeKind.Local).AddTicks(8197), new DateTime(2023, 3, 6, 15, 9, 43, 597, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8095), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8097), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8098), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8097) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 598, DateTimeKind.Local).AddTicks(8678), new DateTime(2023, 3, 6, 15, 9, 43, 597, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(7889), new DateTime(2023, 3, 6, 15, 9, 43, 598, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(7970), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(7972), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(7971) });
        }
    }
}
