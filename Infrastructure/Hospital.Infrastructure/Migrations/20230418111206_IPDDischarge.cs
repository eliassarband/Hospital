using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IPDDischarge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DischargeDate",
                schema: "Med",
                table: "IPDRegisteration",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DischargeDescription",
                schema: "Med",
                table: "IPDRegisteration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Discharged",
                schema: "Med",
                table: "IPDRegisteration",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4018), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4020), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4024), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4026), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4028), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4030), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4032), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4034), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4036), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3977), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3979), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3982), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3981) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3983), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3985), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3987), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3989), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3990), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3991), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3993), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 288, DateTimeKind.Local).AddTicks(7334), new DateTime(2023, 4, 18, 14, 42, 5, 288, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 288, DateTimeKind.Local).AddTicks(7357), new DateTime(2023, 4, 18, 14, 42, 5, 288, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 288, DateTimeKind.Local).AddTicks(7374), new DateTime(2023, 4, 18, 14, 42, 5, 288, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4053), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4055), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4056), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 290, DateTimeKind.Local).AddTicks(2268), new DateTime(2023, 4, 18, 14, 42, 5, 288, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3854), new DateTime(2023, 4, 18, 14, 42, 5, 290, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3951), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3953), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3952) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DischargeDate",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropColumn(
                name: "DischargeDescription",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropColumn(
                name: "Discharged",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9333), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9336), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9334) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9338), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9340), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9342), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9344), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9346), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9348), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9468), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9466) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9291), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9293), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9291) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9294), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9296), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9298), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9300), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9299) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9301), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9303), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9304), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9306), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9307), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 150, DateTimeKind.Local).AddTicks(7569), new DateTime(2023, 4, 17, 11, 40, 47, 150, DateTimeKind.Local).AddTicks(7552) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 150, DateTimeKind.Local).AddTicks(7572), new DateTime(2023, 4, 17, 11, 40, 47, 150, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 150, DateTimeKind.Local).AddTicks(7573), new DateTime(2023, 4, 17, 11, 40, 47, 150, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9491), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9489) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9493), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9494), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 151, DateTimeKind.Local).AddTicks(9281), new DateTime(2023, 4, 17, 11, 40, 47, 150, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9195), new DateTime(2023, 4, 17, 11, 40, 47, 151, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9262), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9263), new DateTime(2023, 4, 17, 11, 40, 47, 152, DateTimeKind.Local).AddTicks(9263) });
        }
    }
}
