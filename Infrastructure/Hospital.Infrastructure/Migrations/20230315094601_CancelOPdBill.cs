using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CancelOPdBill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Canceled",
                schema: "Med",
                table: "OPDBill",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Canceled",
                schema: "Med",
                table: "OPDBill");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3161), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3163), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3165), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3212), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3214), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3213) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3216), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3218), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3220), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3222), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2562), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2565), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2566), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2568), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2569), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2568) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2571), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2572), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2573), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2575), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2578), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 92, DateTimeKind.Local).AddTicks(2191), new DateTime(2023, 3, 12, 15, 40, 2, 92, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 92, DateTimeKind.Local).AddTicks(2194), new DateTime(2023, 3, 12, 15, 40, 2, 92, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 92, DateTimeKind.Local).AddTicks(2195), new DateTime(2023, 3, 12, 15, 40, 2, 92, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3311), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3312), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3314), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 93, DateTimeKind.Local).AddTicks(2553), new DateTime(2023, 3, 12, 15, 40, 2, 92, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2436), new DateTime(2023, 3, 12, 15, 40, 2, 93, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2535), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2537), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2536) });
        }
    }
}
