using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedDataGroupFormAndAccessForms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                schema: "Sec",
                table: "Form",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2106), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2108), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2110), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2112), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2113), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2115), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2118), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2120), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2122), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2067), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2069), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2071), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2072), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2074), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2076), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2077), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2079), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2080), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2082), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2083), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Code", "ModifiedDate" },
                values: new object[] { "OPDPatients", new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Code", "ModifiedDate" },
                values: new object[] { "OPDPatinetDefine", new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Code", "ModifiedDate" },
                values: new object[] { "IPDPatients", new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Code", "ModifiedDate" },
                values: new object[] { "IPDPatinetDefine", new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1111,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1112,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1113,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1114,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1115,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1116,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1117,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1118,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1119,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1120,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1121,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1122,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1123,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1124,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1125,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1126,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1127,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1128,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1129,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1130,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1131,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1132,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "Form",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "FormCategoryId", "ModifiedDate", "ModifiedUser", "Name", "Priority", "ShowInMenu", "Url" },
                values: new object[,]
                {
                    { 1204, "Groups", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 12, new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2277), null, "Group List", 4, true, "Groups" },
                    { 1205, "GroupDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 12, new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2277), null, "Group Define", 5, false, "GroupDefine" },
                    { 1206, "UserAccess", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 12, new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2278), null, "User Access", 6, true, "UserAccess" },
                    { 1207, "GroupAccess", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 12, new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2279), null, "Group Access", 7, false, "GroupAccess" }
                });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30307,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30406,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30407,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30503,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30504,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40406,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40407,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40408,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40409,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40410,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40411,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40412,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40413,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 732, DateTimeKind.Local).AddTicks(3060), new DateTime(2023, 5, 6, 8, 47, 1, 732, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 732, DateTimeKind.Local).AddTicks(3062), new DateTime(2023, 5, 6, 8, 47, 1, 732, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2141), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2138) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2142), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2143), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 733, DateTimeKind.Local).AddTicks(3239), new DateTime(2023, 5, 6, 8, 47, 1, 732, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(1993), new DateTime(2023, 5, 6, 8, 47, 1, 733, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2041), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2042), new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "FormAction",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "FormId", "ModifiedDate", "ModifiedUser", "Name", "Priority" },
                values: new object[,]
                {
                    { 120401, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1204, new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2482), null, "View", 1 },
                    { 120402, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1204, new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2483), null, "Add", 2 },
                    { 120403, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1204, new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2486), null, "Edit", 3 },
                    { 120404, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1204, new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2487), null, "Delete", 4 },
                    { 120501, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1205, new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2488), null, "View", 1 },
                    { 120502, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1205, new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2489), null, "Save", 2 },
                    { 120601, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1206, new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2490), null, "View", 1 },
                    { 120602, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1206, new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2491), null, "Save", 2 },
                    { 120701, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1207, new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2492), null, "View", 1 },
                    { 120702, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1207, new DateTime(2023, 5, 6, 8, 47, 1, 734, DateTimeKind.Local).AddTicks(2492), null, "Save", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120401);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120402);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120403);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120404);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120501);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120502);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120601);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120602);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120701);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120702);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1207);

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                schema: "Sec",
                table: "Form",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4853), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4855), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4857), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4860), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4858) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4862), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4864), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4866), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4865) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4868), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4871), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4796), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4799), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4800), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4802), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4801) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4803), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4802) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4805), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4806), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4811), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4821), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4812) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4827), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4829), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Code", "ModifiedDate" },
                values: new object[] { "Patients", new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Code", "ModifiedDate" },
                values: new object[] { "PatinetDefine", new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Code", "ModifiedDate" },
                values: new object[] { "Patients", new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Code", "ModifiedDate" },
                values: new object[] { "PatinetDefine", new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1111,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1112,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1113,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1114,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1115,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1116,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1117,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1118,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1119,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1120,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1121,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1122,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1123,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1124,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1125,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1126,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1127,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1128,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1129,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1130,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1131,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1132,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30307,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30406,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30407,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30503,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30504,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40406,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40407,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40408,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40409,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40410,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40411,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40412,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40413,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 688, DateTimeKind.Local).AddTicks(3427), new DateTime(2023, 5, 1, 13, 35, 4, 688, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 688, DateTimeKind.Local).AddTicks(3429), new DateTime(2023, 5, 1, 13, 35, 4, 688, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4891), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4893), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4894), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 689, DateTimeKind.Local).AddTicks(4241), new DateTime(2023, 5, 1, 13, 35, 4, 688, DateTimeKind.Local).AddTicks(3556) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4691), new DateTime(2023, 5, 1, 13, 35, 4, 689, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4766), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4764) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4768), new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4767) });
        }
    }
}
