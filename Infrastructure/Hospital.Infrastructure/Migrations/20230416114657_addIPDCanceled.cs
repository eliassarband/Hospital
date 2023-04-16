using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addIPDCanceled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Canceled",
                schema: "Med",
                table: "IPDRegisteration",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Canceled",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4916), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4919), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4922), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4924), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4926), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4928), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4930), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4932), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4939), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4861), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4863), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4865), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4866), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4868), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4869), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4875), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4879), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4876) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4887), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4886) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4889), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4891), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 371, DateTimeKind.Local).AddTicks(1379), new DateTime(2023, 3, 15, 13, 16, 1, 371, DateTimeKind.Local).AddTicks(1361) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 371, DateTimeKind.Local).AddTicks(1382), new DateTime(2023, 3, 15, 13, 16, 1, 371, DateTimeKind.Local).AddTicks(1381) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 371, DateTimeKind.Local).AddTicks(1384), new DateTime(2023, 3, 15, 13, 16, 1, 371, DateTimeKind.Local).AddTicks(1383) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4960), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4962), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4961) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4963), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 372, DateTimeKind.Local).AddTicks(5328), new DateTime(2023, 3, 15, 13, 16, 1, 371, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4623), new DateTime(2023, 3, 15, 13, 16, 1, 372, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4826), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4828), new DateTime(2023, 3, 15, 13, 16, 1, 373, DateTimeKind.Local).AddTicks(4827) });
        }
    }
}
