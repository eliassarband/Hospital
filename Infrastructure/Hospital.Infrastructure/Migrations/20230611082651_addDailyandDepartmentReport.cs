using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addDailyandDepartmentReport : Migration
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
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8983), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8986), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8984) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8989), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8991), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8994), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8996), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8998), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9001), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9003), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8923), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8926), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8927), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8929), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8932), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8935), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8936), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8943), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8954), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8956), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 101,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 102,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 103,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 105,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 106,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 107,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 108,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 109,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 110,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 301,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 302,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 303,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 304,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 305,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 306,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 307,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 308,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1001,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1002,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1003,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1004,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1005,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1101,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1102,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1103,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1104,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1105,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1106,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1107,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1108,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1109,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1110,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1111,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1112,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1113,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1114,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1115,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1116,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1117,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1118,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1119,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1120,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1121,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1122,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1123,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1124,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1125,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1126,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1127,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1128,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1129,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1130,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1131,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1132,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1133,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1201,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1202,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1203,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1204,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1205,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1206,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1207,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "Form",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "FormCategoryId", "ModifiedDate", "ModifiedUser", "Name", "Priority", "ShowInMenu", "Url" },
                values: new object[,]
                {
                    { 1006, "DailyReport", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 10, new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9123), null, "Daily Report", 6, true, "DailyReport" },
                    { 1007, "DepartmentWiseReport", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 10, new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9124), null, "Department Wise Report", 7, true, "DepartmentWiseReport" }
                });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10101,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10102,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10103,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10105,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10106,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10107,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10108,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10109,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10110,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10302,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10303,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10304,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10305,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10306,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10307,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30101,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30102,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30103,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30104,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30105,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30201,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30202,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30301,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30302,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30303,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30304,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30305,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30306,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30307,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30401,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30402,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30403,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30404,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30405,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30406,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30407,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30501,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30502,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30503,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30504,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30601,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30602,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30701,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30702,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30703,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30704,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30705,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30706,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30801,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30802,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30803,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30804,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30805,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30806,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30807,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30808,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30809,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30810,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30811,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30812,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30813,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30814,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100101,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100102,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100103,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100104,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100105,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100201,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100202,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100301,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100401,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100501,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100502,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110101,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110102,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110201,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110202,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110203,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110204,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110301,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110302,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110401,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110402,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110403,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110404,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110501,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110502,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110601,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110602,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110603,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110604,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110701,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110702,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110801,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110802,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110803,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110804,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110901,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110902,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111001,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111002,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111003,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111004,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111101,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111102,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111201,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111202,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111203,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111204,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111301,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111302,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111401,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111402,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111403,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111404,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111501,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111502,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111601,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111602,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111603,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111604,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111701,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111702,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111801,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111802,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111803,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111804,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111901,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111902,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112001,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112002,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112003,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112004,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112101,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112102,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112201,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112202,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112203,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112204,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112301,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112302,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112401,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112402,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112403,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112404,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112501,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112502,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112601,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112602,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112603,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112604,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112701,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112702,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112801,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112802,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112803,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112804,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112901,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112902,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113001,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113002,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113003,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113004,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113101,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113102,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113201,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113202,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113301,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120101,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120102,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120103,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120104,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120105,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120106,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120201,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120202,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120301,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120302,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120401,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120402,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120403,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120404,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120405,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120501,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120502,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120601,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120602,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120701,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120702,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "ModifiedDate",
                value: new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 410, DateTimeKind.Local).AddTicks(6542), new DateTime(2023, 6, 11, 11, 56, 50, 410, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 410, DateTimeKind.Local).AddTicks(6544), new DateTime(2023, 6, 11, 11, 56, 50, 410, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9027), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9029), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9031), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 411, DateTimeKind.Local).AddTicks(8530), new DateTime(2023, 6, 11, 11, 56, 50, 410, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8795), new DateTime(2023, 6, 11, 11, 56, 50, 411, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8895), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8896), new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "FormAction",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "FormId", "ModifiedDate", "ModifiedUser", "Name", "Priority" },
                values: new object[,]
                {
                    { 100601, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1006, new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9302), null, "View", 1 },
                    { 100701, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1007, new DateTime(2023, 6, 11, 11, 56, 50, 412, DateTimeKind.Local).AddTicks(9303), null, "View", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100601);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100701);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6258), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6261), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6264), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6267), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6278), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6281), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6279) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6283), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6286), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6288), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6189), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6186) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6192), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6191) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6194), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6193) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6196), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6195) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6198), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6200), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6202), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6209), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6214), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6230), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6232), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 307,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 308,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1005,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1111,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1112,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1113,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1114,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1115,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1116,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1117,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1118,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1119,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1120,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1121,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1122,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1123,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1124,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1125,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1126,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1127,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1128,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1129,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1130,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1131,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1132,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1133,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1205,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1206,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1207,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10307,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30307,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30406,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30407,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30503,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30504,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30703,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30704,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30705,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30706,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30805,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30806,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30807,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30808,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30809,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30810,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30811,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30812,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30813,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30814,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6354));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 619, DateTimeKind.Local).AddTicks(9333), new DateTime(2023, 5, 20, 11, 47, 19, 619, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 619, DateTimeKind.Local).AddTicks(9337), new DateTime(2023, 5, 20, 11, 47, 19, 619, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6316), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6318), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6320), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6319) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 621, DateTimeKind.Local).AddTicks(3256), new DateTime(2023, 5, 20, 11, 47, 19, 619, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6081), new DateTime(2023, 5, 20, 11, 47, 19, 621, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6157), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6154) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6159), new DateTime(2023, 5, 20, 11, 47, 19, 622, DateTimeKind.Local).AddTicks(6158) });
        }
    }
}
