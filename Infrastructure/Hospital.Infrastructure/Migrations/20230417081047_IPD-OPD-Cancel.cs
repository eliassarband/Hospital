using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IPDOPDCancel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CancelReason",
                schema: "Med",
                table: "OPDBill",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CancelReason",
                schema: "Med",
                table: "IPDRegisteration",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CancelReason",
                schema: "Med",
                table: "OPDBill");

            migrationBuilder.DropColumn(
                name: "CancelReason",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6767), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6773), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6776), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6780), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6782), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6785), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6788), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6792), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6799), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6546), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6551), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6553), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6557), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6559), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6565), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6586), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6605), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6589) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6692), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6695), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6697), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6696) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 696, DateTimeKind.Local).AddTicks(5881), new DateTime(2023, 4, 16, 15, 16, 56, 696, DateTimeKind.Local).AddTicks(5845) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 696, DateTimeKind.Local).AddTicks(5887), new DateTime(2023, 4, 16, 15, 16, 56, 696, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 696, DateTimeKind.Local).AddTicks(5890), new DateTime(2023, 4, 16, 15, 16, 56, 696, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6852), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6854), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 698, DateTimeKind.Local).AddTicks(7402), new DateTime(2023, 4, 16, 15, 16, 56, 696, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(5550), new DateTime(2023, 4, 16, 15, 16, 56, 698, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6457), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6461), new DateTime(2023, 4, 16, 15, 16, 56, 704, DateTimeKind.Local).AddTicks(6460) });
        }
    }
}
