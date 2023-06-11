using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MergeOPDIPDDashboard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10104);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1885), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1890), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1888) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1893), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1897), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1900), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1904), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1908), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1911), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1914), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1712), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1715), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1714) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1717), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1720), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1723), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1785), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1788), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1787) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1801), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1809), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1835), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1838), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Code", "ModifiedDate", "Name", "Url" },
                values: new object[] { "OPDIPD", new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2058), "OPD/IPD", "OPDIPDDashboard" });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1005,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1111,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1112,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1113,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1114,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1115,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1116,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1117,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1118,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1119,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1120,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1121,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1122,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1123,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1124,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1125,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1126,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1127,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1128,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1129,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1130,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1131,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1132,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1205,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1206,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1207,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30307,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30406,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30407,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30503,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30504,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40406,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40407,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40408,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40409,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40410,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40411,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40412,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40413,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 72, DateTimeKind.Local).AddTicks(4331), new DateTime(2023, 5, 13, 11, 23, 13, 72, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 72, DateTimeKind.Local).AddTicks(4333), new DateTime(2023, 5, 13, 11, 23, 13, 72, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1961), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1964), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1966), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 74, DateTimeKind.Local).AddTicks(5048), new DateTime(2023, 5, 13, 11, 23, 13, 72, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1310), new DateTime(2023, 5, 13, 11, 23, 13, 74, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1617), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1659), new DateTime(2023, 5, 13, 11, 23, 13, 76, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisteration_OPDBillId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "OPDBillId");

            migrationBuilder.AddForeignKey(
                name: "FK_IPDRegisteration_OPDBill_OPDBillId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "OPDBillId",
                principalSchema: "Med",
                principalTable: "OPDBill",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IPDRegisteration_OPDBill_OPDBillId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropIndex(
                name: "IX_IPDRegisteration_OPDBillId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3734), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3727) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3736), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3734) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3739), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3742), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3744), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3743) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3747), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3750), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3752), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3754), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3657), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3659), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3657) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3661), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3663), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3668), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3670), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3672), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3671) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3692), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3691) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3693), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3695), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3694) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3696), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Code", "ModifiedDate", "Name", "Url" },
                values: new object[] { "OPD", new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3874), "OPD", "OPDDashboard" });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1005,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1111,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1112,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1113,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1114,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1115,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1116,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1117,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1118,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1119,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1120,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1121,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1122,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1123,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1124,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1125,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1126,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1127,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1128,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1129,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1130,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1131,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1132,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1205,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1206,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1207,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "Form",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "FormCategoryId", "ModifiedDate", "ModifiedUser", "Name", "Priority", "ShowInMenu", "Url" },
                values: new object[] { 104, "IPD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3876), null, "IPD", 4, true, "IPDDashboard" });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30307,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30406,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30407,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30503,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30504,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40406,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40407,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40408,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40409,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40410,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40411,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40412,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40413,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 373, DateTimeKind.Local).AddTicks(4984), new DateTime(2023, 5, 7, 9, 46, 40, 373, DateTimeKind.Local).AddTicks(4956) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 373, DateTimeKind.Local).AddTicks(4988), new DateTime(2023, 5, 7, 9, 46, 40, 373, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3786), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3788), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3787) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3789), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 375, DateTimeKind.Local).AddTicks(509), new DateTime(2023, 5, 7, 9, 46, 40, 373, DateTimeKind.Local).AddTicks(5316) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3387), new DateTime(2023, 5, 7, 9, 46, 40, 375, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3605), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3608), new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "FormAction",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "FormId", "ModifiedDate", "ModifiedUser", "Name", "Priority" },
                values: new object[] { 10104, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 104, new DateTime(2023, 5, 7, 9, 46, 40, 376, DateTimeKind.Local).AddTicks(4042), null, "View", 1 });
        }
    }
}
