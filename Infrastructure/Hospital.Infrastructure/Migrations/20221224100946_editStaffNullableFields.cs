using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editStaffNullableFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OPDChargePercent",
                schema: "Med",
                table: "Staff",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NightOPDChargePercent",
                schema: "Med",
                table: "Staff",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NightIPDChargePercent",
                schema: "Med",
                table: "Staff",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IPDChargePercent",
                schema: "Med",
                table: "Staff",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "Med",
                table: "Staff",
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
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3257), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3264), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3270), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3275), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3281), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3287), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3293), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3187), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3193), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3198), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3203), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3209), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3214), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3219), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 224, DateTimeKind.Local).AddTicks(3962), new DateTime(2022, 12, 24, 13, 39, 46, 224, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 224, DateTimeKind.Local).AddTicks(3966), new DateTime(2022, 12, 24, 13, 39, 46, 224, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 224, DateTimeKind.Local).AddTicks(3970), new DateTime(2022, 12, 24, 13, 39, 46, 224, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 226, DateTimeKind.Local).AddTicks(4342), new DateTime(2022, 12, 24, 13, 39, 46, 224, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3030), new DateTime(2022, 12, 24, 13, 39, 46, 226, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3148), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3154), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3151) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OPDChargePercent",
                schema: "Med",
                table: "Staff",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NightOPDChargePercent",
                schema: "Med",
                table: "Staff",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NightIPDChargePercent",
                schema: "Med",
                table: "Staff",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IPDChargePercent",
                schema: "Med",
                table: "Staff",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "Med",
                table: "Staff",
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
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5910), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5914), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5918), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5921), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5924), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5928), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5931), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5870), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5873), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5876), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5879), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5877) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5882), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5886), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5889), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 367, DateTimeKind.Local).AddTicks(6928), new DateTime(2022, 12, 24, 12, 2, 21, 367, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 367, DateTimeKind.Local).AddTicks(6989), new DateTime(2022, 12, 24, 12, 2, 21, 367, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 367, DateTimeKind.Local).AddTicks(6992), new DateTime(2022, 12, 24, 12, 2, 21, 367, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 368, DateTimeKind.Local).AddTicks(6933), new DateTime(2022, 12, 24, 12, 2, 21, 367, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5801), new DateTime(2022, 12, 24, 12, 2, 21, 368, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5847), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5849) });
        }
    }
}
