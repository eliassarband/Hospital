using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DescriptionNullableinIPDRegisteration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Med",
                table: "IPDRegisterationService",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Med",
                table: "IPDRegisterationRoom",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Med",
                table: "IPDRegisterationPayment",
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
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9762), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9764), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9766), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9764) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9770), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9772), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9774), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9776), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9778), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9779), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9721), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9723), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9724), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9726), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9727), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9728), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9728) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9730), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9732), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9731) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9734), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9736), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9738), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9737) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 567, DateTimeKind.Local).AddTicks(75), new DateTime(2023, 3, 11, 15, 2, 56, 567, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 567, DateTimeKind.Local).AddTicks(78), new DateTime(2023, 3, 11, 15, 2, 56, 567, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 567, DateTimeKind.Local).AddTicks(79), new DateTime(2023, 3, 11, 15, 2, 56, 567, DateTimeKind.Local).AddTicks(78) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9799), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9800), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9801), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(457), new DateTime(2023, 3, 11, 15, 2, 56, 567, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9650), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9700), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9701), new DateTime(2023, 3, 11, 15, 2, 56, 568, DateTimeKind.Local).AddTicks(9700) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Med",
                table: "IPDRegisterationService",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Med",
                table: "IPDRegisterationRoom",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Med",
                table: "IPDRegisterationPayment",
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
    }
}
