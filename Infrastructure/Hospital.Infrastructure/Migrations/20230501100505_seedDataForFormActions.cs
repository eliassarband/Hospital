using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedDataForFormActions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormAccess",
                schema: "Sec");

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
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4967));

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
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(4974));

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

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "FormAction",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "FormId", "ModifiedDate", "ModifiedUser", "Name", "Priority" },
                values: new object[,]
                {
                    { 10101, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 101, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5060), null, "View", 1 },
                    { 10102, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 102, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5061), null, "View", 1 },
                    { 10103, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 103, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5063), null, "View", 1 },
                    { 10104, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 104, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5063), null, "View", 1 },
                    { 10105, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 105, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5064), null, "View", 1 },
                    { 10106, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 106, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5065), null, "View", 1 },
                    { 10107, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 107, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5066), null, "View", 1 },
                    { 10108, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 108, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5067), null, "View", 1 },
                    { 10109, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 109, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5068), null, "View", 1 },
                    { 10110, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 110, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5069), null, "View", 1 },
                    { 30101, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 301, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5070), null, "View", 1 },
                    { 30102, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 301, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5071), null, "Add", 2 },
                    { 30103, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 301, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5073), null, "Edit", 3 },
                    { 30104, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 301, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5074), null, "Delete", 4 },
                    { 30105, "Select", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 301, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5075), null, "Select", 5 },
                    { 30201, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 302, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5076), null, "View", 1 },
                    { 30202, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 302, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5077), null, "Save", 2 },
                    { 30301, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 303, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5078), null, "View", 1 },
                    { 30302, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 303, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5079), null, "Add", 2 },
                    { 30303, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 303, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5080), null, "Edit", 3 },
                    { 30304, "Cancel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 303, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5080), null, "Cancel", 4 },
                    { 30305, "Select", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 303, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5081), null, "Select", 5 },
                    { 30306, "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 303, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5082), null, "Print", 6 },
                    { 30307, "Payment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 303, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5083), null, "Payment", 7 },
                    { 30401, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 304, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5084), null, "View", 1 },
                    { 30402, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 304, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5085), null, "Save", 2 },
                    { 30403, "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 304, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5086), null, "Print", 3 },
                    { 30404, "AddPatient", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 304, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5087), null, "Add Patient", 4 },
                    { 30405, "SearchPatient", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 304, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5088), null, "Search Patient", 5 },
                    { 30406, "AddService", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 304, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5088), null, "Add Service", 6 },
                    { 30407, "DeleteService", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 304, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5089), null, "Delete Service", 7 },
                    { 30501, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 305, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5092), null, "View", 1 },
                    { 30502, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 305, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5092), null, "Add", 2 },
                    { 30503, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 305, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5093), null, "Delete", 3 },
                    { 30504, "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 305, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5094), null, "Print", 4 },
                    { 30601, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 306, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5095), null, "View", 1 },
                    { 30602, "Payment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 306, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5096), null, "Payment", 2 },
                    { 40101, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 401, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5097), null, "View", 1 },
                    { 40102, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 401, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5098), null, "Add", 2 },
                    { 40103, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 401, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5099), null, "Edit", 3 },
                    { 40104, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 401, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5099), null, "Delete", 4 },
                    { 40105, "Select", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 401, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5100), null, "Select", 5 },
                    { 40201, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 402, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5101), null, "View", 1 },
                    { 40202, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 402, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5102), null, "Save", 2 },
                    { 40301, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 403, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5103), null, "View", 1 },
                    { 40302, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 403, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5104), null, "Add", 2 },
                    { 40303, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 403, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5105), null, "Edit", 3 },
                    { 40304, "Cancel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 403, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5106), null, "Cancel", 4 },
                    { 40305, "Discharge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 403, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5107), null, "Discharge", 5 },
                    { 40306, "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 403, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5107), null, "Print", 6 },
                    { 40401, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5108), null, "View", 1 },
                    { 40402, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5109), null, "Save", 2 },
                    { 40403, "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5110), null, "Print", 3 },
                    { 40404, "AddPatient", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5111), null, "Add Patient", 4 },
                    { 40405, "SearchPatient", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5112), null, "Search Patient", 5 },
                    { 40406, "SearchOPD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5114), null, "Search OPD Billing", 6 },
                    { 40407, "AddRoom", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5115), null, "Add Room", 7 },
                    { 40408, "DeleteRoom", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5115), null, "Delete Room", 8 },
                    { 40409, "AddService", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5116), null, "Add Service", 9 },
                    { 40410, "DeleteService", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5117), null, "Delete Service", 10 },
                    { 40411, "AddPayment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5118), null, "Add Payment", 11 },
                    { 40412, "DeletePayment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5119), null, "Delete Payment", 12 },
                    { 40413, "PrintPayment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5120), null, "Print Payment", 13 },
                    { 100101, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1001, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5121), null, "View", 1 },
                    { 100102, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1001, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5122), null, "Add", 2 },
                    { 100103, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1001, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5122), null, "Edit", 3 },
                    { 100104, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1001, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5123), null, "Delete", 4 },
                    { 100105, "Design", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1001, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5124), null, "Design", 5 },
                    { 100201, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1002, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5125), null, "View", 1 },
                    { 100202, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1002, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5126), null, "Save", 2 },
                    { 100301, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1003, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5127), null, "View", 1 },
                    { 100401, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1004, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5128), null, "View", 1 },
                    { 110101, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1101, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5129), null, "View", 1 },
                    { 110102, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1101, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5131), null, "Save", 2 },
                    { 110201, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1102, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5132), null, "View", 1 },
                    { 110202, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1102, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5133), null, "Add", 2 },
                    { 110203, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1102, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5133), null, "Edit", 3 },
                    { 110204, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1102, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5134), null, "Delete", 4 },
                    { 110301, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1103, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5135), null, "View", 1 },
                    { 110302, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1103, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5140), null, "Save", 2 },
                    { 110401, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1104, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5142), null, "View", 1 },
                    { 110402, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1104, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5143), null, "Add", 2 },
                    { 110403, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1104, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5144), null, "Edit", 3 },
                    { 110404, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1104, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5144), null, "Delete", 4 },
                    { 110501, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1105, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5145), null, "View", 1 },
                    { 110502, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1105, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5146), null, "Save", 2 },
                    { 110601, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1106, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5147), null, "View", 1 },
                    { 110602, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1106, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5148), null, "Add", 2 },
                    { 110603, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1106, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5149), null, "Edit", 3 },
                    { 110604, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1106, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5150), null, "Delete", 4 },
                    { 110701, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1107, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5151), null, "View", 1 },
                    { 110702, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1107, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5152), null, "Save", 2 },
                    { 110801, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1108, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5153), null, "View", 1 },
                    { 110802, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1108, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5154), null, "Add", 2 },
                    { 110803, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1108, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5154), null, "Edit", 3 },
                    { 110804, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1108, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5155), null, "Delete", 4 },
                    { 110901, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1109, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5156), null, "View", 1 },
                    { 110902, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1109, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5158), null, "Save", 2 },
                    { 111001, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1110, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5159), null, "View", 1 },
                    { 111002, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1110, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5160), null, "Add", 2 },
                    { 111003, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1110, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5161), null, "Edit", 3 },
                    { 111004, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1110, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5162), null, "Delete", 4 },
                    { 111101, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1111, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5163), null, "View", 1 },
                    { 111102, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1111, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5164), null, "Save", 2 },
                    { 111201, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1112, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5165), null, "View", 1 },
                    { 111202, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1112, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5166), null, "Add", 2 },
                    { 111203, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1112, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5167), null, "Edit", 3 },
                    { 111204, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1112, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5168), null, "Delete", 4 },
                    { 111301, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1113, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5169), null, "View", 1 },
                    { 111302, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1113, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5170), null, "Save", 2 },
                    { 111401, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1114, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5171), null, "View", 1 },
                    { 111402, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1114, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5172), null, "Add", 2 },
                    { 111403, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1114, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5173), null, "Edit", 3 },
                    { 111404, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1114, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5174), null, "Delete", 4 },
                    { 111501, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1115, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5175), null, "View", 1 },
                    { 111502, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1115, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5175), null, "Save", 2 },
                    { 111601, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1116, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5176), null, "View", 1 },
                    { 111602, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1116, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5177), null, "Add", 2 },
                    { 111603, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1116, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5179), null, "Edit", 3 },
                    { 111604, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1116, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5180), null, "Delete", 4 },
                    { 111701, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1117, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5181), null, "View", 1 },
                    { 111702, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1117, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5182), null, "Save", 2 },
                    { 111801, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1118, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5183), null, "View", 1 },
                    { 111802, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1118, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5184), null, "Add", 2 },
                    { 111803, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1118, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5185), null, "Edit", 3 },
                    { 111804, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1118, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5186), null, "Delete", 4 },
                    { 111901, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1119, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5187), null, "View", 1 },
                    { 111902, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1119, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5188), null, "Save", 2 },
                    { 112001, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1120, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5189), null, "View", 1 },
                    { 112002, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1120, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5190), null, "Add", 2 },
                    { 112003, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1120, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5191), null, "Edit", 3 },
                    { 112004, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1120, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5192), null, "Delete", 4 },
                    { 112101, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1121, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5193), null, "View", 1 },
                    { 112102, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1121, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5194), null, "Save", 2 },
                    { 112201, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1122, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5195), null, "View", 1 },
                    { 112202, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1122, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5196), null, "Add", 2 },
                    { 112203, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1122, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5197), null, "Edit", 3 },
                    { 112204, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1122, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5198), null, "Delete", 4 },
                    { 112301, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1123, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5199), null, "View", 1 },
                    { 112302, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1123, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5200), null, "Save", 2 },
                    { 112401, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1124, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5201), null, "View", 1 },
                    { 112402, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1124, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5202), null, "Add", 2 },
                    { 112403, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1124, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5203), null, "Edit", 3 },
                    { 112404, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1124, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5204), null, "Delete", 4 },
                    { 112501, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1125, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5205), null, "View", 1 },
                    { 112502, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1125, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5206), null, "Save", 2 },
                    { 112601, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1126, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5207), null, "View", 1 },
                    { 112602, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1126, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5208), null, "Add", 2 },
                    { 112603, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1126, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5210), null, "Edit", 3 },
                    { 112604, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1126, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5211), null, "Delete", 4 },
                    { 112701, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1127, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5212), null, "View", 1 },
                    { 112702, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1127, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5213), null, "Save", 2 },
                    { 112801, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1128, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5214), null, "View", 1 },
                    { 112802, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1128, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5215), null, "Add", 2 },
                    { 112803, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1128, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5216), null, "Edit", 3 },
                    { 112804, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1128, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5217), null, "Delete", 4 },
                    { 112901, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1129, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5218), null, "View", 1 },
                    { 112902, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1129, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5219), null, "Save", 2 },
                    { 113001, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1130, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5220), null, "View", 1 },
                    { 113002, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1130, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5221), null, "Add", 2 },
                    { 113003, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1130, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5222), null, "Edit", 3 },
                    { 113004, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1130, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5223), null, "Delete", 4 },
                    { 113101, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1131, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5224), null, "View", 1 },
                    { 113102, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1131, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5225), null, "Save", 2 },
                    { 113201, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1132, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5230), null, "View", 1 },
                    { 113202, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1132, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5232), null, "Save", 2 },
                    { 120101, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1201, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5233), null, "View", 1 },
                    { 120102, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1201, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5234), null, "Add", 2 },
                    { 120103, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1201, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5235), null, "Edit", 3 },
                    { 120104, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1201, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5236), null, "Delete", 4 },
                    { 120105, "Reset", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1201, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5237), null, "Reset Password", 5 },
                    { 120201, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1202, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5238), null, "View", 1 },
                    { 120202, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1202, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5239), null, "Save", 2 },
                    { 120301, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1203, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5240), null, "View", 1 },
                    { 120302, "Change", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1203, new DateTime(2023, 5, 1, 13, 35, 4, 690, DateTimeKind.Local).AddTicks(5241), null, "Change Password", 2 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10101);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10102);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10103);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10104);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10105);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10106);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10107);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10108);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10109);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10110);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30101);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30102);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30103);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30104);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30105);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30201);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30202);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30301);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30302);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30303);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30304);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30305);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30306);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30307);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30401);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30402);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30403);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30404);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30405);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30406);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30407);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30501);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30502);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30503);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30504);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30601);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30602);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40101);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40102);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40103);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40104);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40105);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40201);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40202);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40301);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40302);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40303);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40304);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40305);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40306);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40401);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40402);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40403);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40404);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40405);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40406);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40407);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40408);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40409);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40410);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40411);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40412);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40413);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100101);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100102);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100103);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100104);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100105);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100201);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100202);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100301);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100401);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110101);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110102);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110201);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110202);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110203);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110204);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110301);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110302);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110401);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110402);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110403);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110404);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110501);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110502);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110601);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110602);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110603);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110604);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110701);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110702);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110801);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110802);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110803);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110804);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110901);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110902);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111001);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111002);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111003);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111004);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111101);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111102);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111201);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111202);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111203);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111204);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111301);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111302);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111401);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111402);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111403);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111404);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111501);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111502);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111601);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111602);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111603);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111604);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111701);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111702);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111801);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111802);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111803);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111804);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111901);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111902);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112001);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112002);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112003);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112004);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112101);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112102);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112201);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112202);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112203);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112204);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112301);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112302);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112401);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112402);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112403);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112404);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112501);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112502);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112601);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112602);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112603);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112604);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112701);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112702);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112801);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112802);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112803);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112804);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112901);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112902);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113001);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113002);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113003);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113004);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113101);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113102);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113201);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113202);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120101);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120102);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120103);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120104);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120105);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120201);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120202);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120301);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120302);

            migrationBuilder.CreateTable(
                name: "FormAccess",
                schema: "Sec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormAccess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormAccess_Form_FormId",
                        column: x => x.FormId,
                        principalSchema: "Sec",
                        principalTable: "Form",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormAccess_Group_GroupId",
                        column: x => x.GroupId,
                        principalSchema: "Sec",
                        principalTable: "Group",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormAccess_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Sec",
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3503), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3505), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3508), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3510), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3508) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3512), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3514), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3517), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3519), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3522), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3432), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3435), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3446), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3448), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3449), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3451), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3453), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3459), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3464), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3474), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3476), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1111,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1112,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1113,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1114,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1115,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1116,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1117,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1118,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1119,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1120,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1121,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1122,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1123,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1124,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1125,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1126,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1127,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1128,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1129,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1130,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1131,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1132,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 360, DateTimeKind.Local).AddTicks(850), new DateTime(2023, 5, 1, 12, 37, 23, 360, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 360, DateTimeKind.Local).AddTicks(853), new DateTime(2023, 5, 1, 12, 37, 23, 360, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3547), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3549), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3550), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 361, DateTimeKind.Local).AddTicks(2845), new DateTime(2023, 5, 1, 12, 37, 23, 360, DateTimeKind.Local).AddTicks(1068) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3340), new DateTime(2023, 5, 1, 12, 37, 23, 361, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3405), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3407), new DateTime(2023, 5, 1, 12, 37, 23, 362, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.CreateIndex(
                name: "IX_FormAccess_FormId",
                schema: "Sec",
                table: "FormAccess",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormAccess_GroupId",
                schema: "Sec",
                table: "FormAccess",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_FormAccess_UserId",
                schema: "Sec",
                table: "FormAccess",
                column: "UserId");
        }
    }
}
