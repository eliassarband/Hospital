using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addSeedDataForReportTemplatesSelect : Migration
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
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4241), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4236) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4244), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4247), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4250), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4252), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4255), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4258), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4260), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4264), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4192), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4194), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4197), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4199), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4201), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4203), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4205), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4208), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4210), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4212), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4214), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1111,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1112,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1113,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1114,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1115,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1116,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1117,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1118,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1119,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1120,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1121,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1122,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1123,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1124,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1125,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1126,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1127,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1128,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1129,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1130,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1131,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1132,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1205,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1206,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1207,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "Form",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "FormCategoryId", "ModifiedDate", "ModifiedUser", "Name", "Priority", "ShowInMenu", "Url" },
                values: new object[] { 1005, "ReportTemplatesSelect", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 10, new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4439), null, "Report Template Select", 5, false, "ReportTemplatesSelect" });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30307,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30406,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30407,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30503,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30504,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40406,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40407,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40408,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40409,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40410,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40411,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40412,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40413,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 736, DateTimeKind.Local).AddTicks(8322), new DateTime(2023, 5, 6, 16, 16, 5, 736, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 736, DateTimeKind.Local).AddTicks(8324), new DateTime(2023, 5, 6, 16, 16, 5, 736, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4288), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4290), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4292), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 738, DateTimeKind.Local).AddTicks(1712), new DateTime(2023, 5, 6, 16, 16, 5, 736, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4098), new DateTime(2023, 5, 6, 16, 16, 5, 738, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4163), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4165), new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "FormAction",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "FormId", "ModifiedDate", "ModifiedUser", "Name", "Priority" },
                values: new object[,]
                {
                    { 100501, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1005, new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4652), null, "View", 1 },
                    { 100502, "Select", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1005, new DateTime(2023, 5, 6, 16, 16, 5, 739, DateTimeKind.Local).AddTicks(4654), null, "Select", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100501);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100502);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4099), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4101), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4103), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4105), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4107), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4109), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4108) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4111), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4113), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4116), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4031), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4033), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4035), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4036), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4037), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4039), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4040), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4043), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4054), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4066), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4067), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1111,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1112,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1113,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1114,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1115,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1116,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1117,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1118,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1119,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1120,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1121,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1122,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1123,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1124,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1125,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1126,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1127,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1128,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1129,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1130,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1131,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1132,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1205,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1206,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1207,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30307,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30406,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30407,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30503,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30504,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40406,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40407,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40408,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40409,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40410,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40411,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40412,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 40413,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 917, DateTimeKind.Local).AddTicks(4124), new DateTime(2023, 5, 6, 15, 32, 24, 917, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 917, DateTimeKind.Local).AddTicks(4126), new DateTime(2023, 5, 6, 15, 32, 24, 917, DateTimeKind.Local).AddTicks(4125) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4141), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4139) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4143), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4144), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 918, DateTimeKind.Local).AddTicks(5384), new DateTime(2023, 5, 6, 15, 32, 24, 917, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(3914), new DateTime(2023, 5, 6, 15, 32, 24, 918, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(3992), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(3994), new DateTime(2023, 5, 6, 15, 32, 24, 919, DateTimeKind.Local).AddTicks(3993) });
        }
    }
}
