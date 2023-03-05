using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addSettingOPDReceiptSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(317), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(311) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(320), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(322), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(324), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(326), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(328), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(330), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(286), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(283) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(288), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(290), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(291), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(292), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(294), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(295), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 128, DateTimeKind.Local).AddTicks(600), new DateTime(2023, 3, 5, 15, 8, 10, 128, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 128, DateTimeKind.Local).AddTicks(602), new DateTime(2023, 3, 5, 15, 8, 10, 128, DateTimeKind.Local).AddTicks(601) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 128, DateTimeKind.Local).AddTicks(604), new DateTime(2023, 3, 5, 15, 8, 10, 128, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(353), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(346) });

            migrationBuilder.InsertData(
                schema: "Gnr",
                table: "Setting",
                columns: new[] { "Id", "CreatedDate", "CreatedUser", "Description", "Key", "ModifiedDate", "ModifiedUser", "Name", "Value" },
                values: new object[] { 2, new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(355), "elias.sarband", null, "OPDReceiptNoPrefix", new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(354), null, "OPD Receipt Identifier Prefix", "OP" });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 129, DateTimeKind.Local).AddTicks(951), new DateTime(2023, 3, 5, 15, 8, 10, 128, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(210), new DateTime(2023, 3, 5, 15, 8, 10, 129, DateTimeKind.Local).AddTicks(954) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(259), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(258) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(261), new DateTime(2023, 3, 5, 15, 8, 10, 130, DateTimeKind.Local).AddTicks(260) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4187), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4190), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4193), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4195), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4198), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4201), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4204), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4150), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4152), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4154), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4153) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4156), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4158), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4160), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4161), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 924, DateTimeKind.Local).AddTicks(4198), new DateTime(2023, 3, 5, 11, 15, 58, 924, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 924, DateTimeKind.Local).AddTicks(4201), new DateTime(2023, 3, 5, 11, 15, 58, 924, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 924, DateTimeKind.Local).AddTicks(4203), new DateTime(2023, 3, 5, 11, 15, 58, 924, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4225), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 925, DateTimeKind.Local).AddTicks(4741), new DateTime(2023, 3, 5, 11, 15, 58, 924, DateTimeKind.Local).AddTicks(4421) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4051), new DateTime(2023, 3, 5, 11, 15, 58, 925, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4121), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4123), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4122) });
        }
    }
}
