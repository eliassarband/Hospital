using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addOPDBillDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sec",
                table: "OPDBill",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3757), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3761), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3758) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3765), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3762) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3768), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3771), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3775), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3778), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3650), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3646) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3654), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3652) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3657), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3660), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3658) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3663), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3666), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3669), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 953, DateTimeKind.Local).AddTicks(3050), new DateTime(2023, 2, 18, 21, 49, 1, 953, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 953, DateTimeKind.Local).AddTicks(3054), new DateTime(2023, 2, 18, 21, 49, 1, 953, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 953, DateTimeKind.Local).AddTicks(3057), new DateTime(2023, 2, 18, 21, 49, 1, 953, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 954, DateTimeKind.Local).AddTicks(3970), new DateTime(2023, 2, 18, 21, 49, 1, 953, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3570), new DateTime(2023, 2, 18, 21, 49, 1, 954, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3617), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3620), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3619) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sec",
                table: "OPDBill",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(259), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(251) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(269), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(276), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(284), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(291), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(301), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(309), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(173), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(180), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(186), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(183) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(194), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(200), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(197) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(208), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(214), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 349, DateTimeKind.Local).AddTicks(3683), new DateTime(2023, 2, 18, 21, 4, 11, 349, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 349, DateTimeKind.Local).AddTicks(3692), new DateTime(2023, 2, 18, 21, 4, 11, 349, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 349, DateTimeKind.Local).AddTicks(3700), new DateTime(2023, 2, 18, 21, 4, 11, 349, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 351, DateTimeKind.Local).AddTicks(9222), new DateTime(2023, 2, 18, 21, 4, 11, 349, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(31), new DateTime(2023, 2, 18, 21, 4, 11, 351, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(122), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(129), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(126) });
        }
    }
}
