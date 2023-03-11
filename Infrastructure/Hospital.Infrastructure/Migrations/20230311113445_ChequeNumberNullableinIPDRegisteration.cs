using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChequeNumberNullableinIPDRegisteration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ChequeNumber",
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
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8608), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8610), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8612), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8614), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8616), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8618), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8620), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8622), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8623), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8506), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8508), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8507) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8509), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8569), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8570), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8572), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8573), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8573) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8575), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8576), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8579), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8580), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 279, DateTimeKind.Local).AddTicks(9279), new DateTime(2023, 3, 11, 15, 4, 45, 279, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 279, DateTimeKind.Local).AddTicks(9282), new DateTime(2023, 3, 11, 15, 4, 45, 279, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 279, DateTimeKind.Local).AddTicks(9283), new DateTime(2023, 3, 11, 15, 4, 45, 279, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8642), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8644), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8645), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 280, DateTimeKind.Local).AddTicks(9429), new DateTime(2023, 3, 11, 15, 4, 45, 279, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8427), new DateTime(2023, 3, 11, 15, 4, 45, 280, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8481), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8483), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8482) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ChequeNumber",
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
    }
}
