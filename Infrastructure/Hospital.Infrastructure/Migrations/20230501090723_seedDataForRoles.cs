using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedDataForRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3);

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
                columns: new[] { "Code", "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { "User", new DateTime(2023, 5, 1, 12, 37, 23, 360, DateTimeKind.Local).AddTicks(853), new DateTime(2023, 5, 1, 12, 37, 23, 360, DateTimeKind.Local).AddTicks(851), "User" });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6726), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6729), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6731), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6733), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6735), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6737), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6740), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6743), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6745), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6613), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6615), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6617), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6619), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6620), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6622), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6628), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6635), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6643), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6645), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6647), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 301,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 302,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 303,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 304,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 305,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 306,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 401,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 402,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 403,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 404,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1001,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1002,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1003,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1004,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1101,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1102,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1103,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1104,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1105,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1106,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1107,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1108,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1109,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1110,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1111,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1112,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1113,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1114,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1115,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1116,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1117,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1118,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1119,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1120,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1121,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1122,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1123,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1124,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1125,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1126,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1127,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1128,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1129,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1130,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1131,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1132,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1201,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1202,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1203,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "ModifiedDate",
                value: new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 761, DateTimeKind.Local).AddTicks(5654), new DateTime(2023, 5, 1, 12, 35, 3, 761, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { "Admin", new DateTime(2023, 5, 1, 12, 35, 3, 761, DateTimeKind.Local).AddTicks(5657), new DateTime(2023, 5, 1, 12, 35, 3, 761, DateTimeKind.Local).AddTicks(5656), "Administrator" });

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "Role",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "ModifiedDate", "ModifiedUser", "Name" },
                values: new object[] { 3, "Operator", new DateTime(2023, 5, 1, 12, 35, 3, 761, DateTimeKind.Local).AddTicks(5658), "elias.sarband", "", new DateTime(2023, 5, 1, 12, 35, 3, 761, DateTimeKind.Local).AddTicks(5658), null, "Operator" });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6767), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6769), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6770), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 762, DateTimeKind.Local).AddTicks(6943), new DateTime(2023, 5, 1, 12, 35, 3, 761, DateTimeKind.Local).AddTicks(5783) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6495), new DateTime(2023, 5, 1, 12, 35, 3, 762, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6585), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6586) });
        }
    }
}
