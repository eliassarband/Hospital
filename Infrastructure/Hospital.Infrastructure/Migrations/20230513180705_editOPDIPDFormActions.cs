using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editOPDIPDFormActions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Form",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8021), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8016) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8025), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8027), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8030), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8033), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8035), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8038), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8041), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8044), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7853), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7856), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7858), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7860), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7865), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7868), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7877), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7883), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7902), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7904), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Code", "ModifiedDate", "Url" },
                values: new object[] { "Patients", new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8159), "Patients" });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Code", "ModifiedDate" },
                values: new object[] { "PatientDefine", new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1005,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1111,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1112,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1113,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1114,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1115,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1116,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1117,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1118,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1119,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1120,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1121,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1122,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1123,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1124,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1125,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1126,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1127,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1128,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1129,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1130,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1131,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1132,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1205,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1206,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1207,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "Form",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "FormCategoryId", "ModifiedDate", "ModifiedUser", "Name", "Priority", "ShowInMenu", "Url" },
                values: new object[,]
                {
                    { 307, "IPDRegisterations", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 3, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8169), null, "Admited Patinet List", 7, true, "IPDRegisterations" },
                    { 308, "IPDRegisterationDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 3, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8171), null, "IPD Registeration", 8, true, "IPDRegisterationDefine" }
                });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30307,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30406,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30407,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30503,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30504,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "ModifiedDate", "Name" },
                values: new object[] { "OPDIPD", new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8096), "OPD / IPD" });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 31, DateTimeKind.Local).AddTicks(462), new DateTime(2023, 5, 13, 21, 37, 4, 31, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 31, DateTimeKind.Local).AddTicks(464), new DateTime(2023, 5, 13, 21, 37, 4, 31, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8067), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8070), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8071), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 32, DateTimeKind.Local).AddTicks(4698), new DateTime(2023, 5, 13, 21, 37, 4, 31, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7711), new DateTime(2023, 5, 13, 21, 37, 4, 32, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7821), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7823), new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(7822) });

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "FormAction",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "FormId", "ModifiedDate", "ModifiedUser", "Name", "Priority" },
                values: new object[,]
                {
                    { 30701, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 307, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8387), null, "View", 1 },
                    { 30702, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 307, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8389), null, "Add", 2 },
                    { 30703, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 307, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8390), null, "Edit", 3 },
                    { 30704, "Cancel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 307, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8392), null, "Cancel", 4 },
                    { 30705, "Discharge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 307, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8393), null, "Discharge", 5 },
                    { 30706, "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 307, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8395), null, "Print", 6 },
                    { 30801, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 308, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8396), null, "View", 1 },
                    { 30802, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 308, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8398), null, "Save", 2 },
                    { 30803, "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 308, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8399), null, "Print", 3 },
                    { 30804, "AddPatient", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 308, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8401), null, "Add Patient", 4 },
                    { 30805, "SearchPatient", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 308, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8405), null, "Search Patient", 5 },
                    { 30806, "SearchOPD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 308, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8407), null, "Search OPD Billing", 6 },
                    { 30807, "AddRoom", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 308, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8408), null, "Add Room", 7 },
                    { 30808, "DeleteRoom", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 308, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8410), null, "Delete Room", 8 },
                    { 30809, "AddService", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 308, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8412), null, "Add Service", 9 },
                    { 30810, "DeleteService", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 308, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8413), null, "Delete Service", 10 },
                    { 30811, "AddPayment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 308, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8415), null, "Add Payment", 11 },
                    { 30812, "DeletePayment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 308, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8416), null, "Delete Payment", 12 },
                    { 30813, "PrintPayment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 308, new DateTime(2023, 5, 13, 21, 37, 4, 33, DateTimeKind.Local).AddTicks(8417), null, "Print Payment", 13 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30701);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30702);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30703);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30704);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30705);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30706);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30801);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30802);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30803);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30804);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30805);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30806);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30807);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30808);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30809);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30810);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30811);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30812);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30813);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6243), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6246), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6248), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6255), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6257), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6260), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6262), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6178), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6175) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6181), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6183), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6182) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6185), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6183) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6186), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6188), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6187) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6191), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6198), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6207), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6217), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6219), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Code", "ModifiedDate", "Url" },
                values: new object[] { "OPDPatients", new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6417), "Patients/OPD" });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Code", "ModifiedDate" },
                values: new object[] { "OPDPatientDefine", new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6418) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1005,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1111,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1112,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1113,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1114,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1115,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1116,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1117,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1118,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1119,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1120,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1121,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1122,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1123,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1124,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1125,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1126,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1127,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1128,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1129,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1130,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1131,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1132,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1205,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1206,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1207,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 10303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30307,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30406,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30407,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30503,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30504,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 30602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 100502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 110902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 111902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112204,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112603,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112604,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112801,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112802,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112803,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112804,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112901,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 112902,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 113202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120405,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120501,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120502,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120601,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120602,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120701,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormAction",
                keyColumn: "Id",
                keyValue: 120702,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "ModifiedDate", "Name" },
                values: new object[] { "OPD", new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6357), "OPD" });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "FormCategory",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "ModifiedDate", "ModifiedUser", "Name", "Priority", "ShowInDashboard" },
                values: new object[] { 4, "IPD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6358), null, "IPD", 4, true });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 605, DateTimeKind.Local).AddTicks(4554), new DateTime(2023, 5, 13, 20, 21, 51, 605, DateTimeKind.Local).AddTicks(4534) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 605, DateTimeKind.Local).AddTicks(4557), new DateTime(2023, 5, 13, 20, 21, 51, 605, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6328), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6330), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6332), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 606, DateTimeKind.Local).AddTicks(6042), new DateTime(2023, 5, 13, 20, 21, 51, 605, DateTimeKind.Local).AddTicks(4731) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6084), new DateTime(2023, 5, 13, 20, 21, 51, 606, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6148), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6150), new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "Form",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "FormCategoryId", "ModifiedDate", "ModifiedUser", "Name", "Priority", "ShowInMenu", "Url" },
                values: new object[,]
                {
                    { 401, "IPDPatients", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 4, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6424), null, "Patinet List", 1, true, "Patients/IPD" },
                    { 402, "IPDPatientDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 4, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6425), null, "Patinet Define", 2, false, "PatientDefine" },
                    { 403, "IPDRegisterations", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 4, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6428), null, "Admited Patinet List", 3, true, "IPDRegisterations" },
                    { 404, "IPDRegisterationDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 4, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6429), null, "IPD Registeration", 1, true, "IPDRegisterationDefine" }
                });

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "FormAction",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "FormId", "ModifiedDate", "ModifiedUser", "Name", "Priority" },
                values: new object[,]
                {
                    { 40101, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 401, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6568), null, "View", 1 },
                    { 40102, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 401, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6569), null, "Add", 2 },
                    { 40103, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 401, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6570), null, "Edit", 3 },
                    { 40104, "Delete", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 401, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6571), null, "Delete", 4 },
                    { 40105, "Select", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 401, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6572), null, "Select", 5 },
                    { 40201, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 402, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6573), null, "View", 1 },
                    { 40202, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 402, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6574), null, "Save", 2 },
                    { 40301, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 403, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6575), null, "View", 1 },
                    { 40302, "Add", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 403, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6576), null, "Add", 2 },
                    { 40303, "Edit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 403, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6577), null, "Edit", 3 },
                    { 40304, "Cancel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 403, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6579), null, "Cancel", 4 },
                    { 40305, "Discharge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 403, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6580), null, "Discharge", 5 },
                    { 40306, "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 403, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6581), null, "Print", 6 },
                    { 40401, "View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6582), null, "View", 1 },
                    { 40402, "Save", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6583), null, "Save", 2 },
                    { 40403, "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6584), null, "Print", 3 },
                    { 40404, "AddPatient", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6585), null, "Add Patient", 4 },
                    { 40405, "SearchPatient", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6594), null, "Search Patient", 5 },
                    { 40406, "SearchOPD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6595), null, "Search OPD Billing", 6 },
                    { 40407, "AddRoom", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6597), null, "Add Room", 7 },
                    { 40408, "DeleteRoom", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6598), null, "Delete Room", 8 },
                    { 40409, "AddService", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6599), null, "Add Service", 9 },
                    { 40410, "DeleteService", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6600), null, "Delete Service", 10 },
                    { 40411, "AddPayment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6601), null, "Add Payment", 11 },
                    { 40412, "DeletePayment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6602), null, "Delete Payment", 12 },
                    { 40413, "PrintPayment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 404, new DateTime(2023, 5, 13, 20, 21, 51, 607, DateTimeKind.Local).AddTicks(6603), null, "Print Payment", 13 }
                });
        }
    }
}
