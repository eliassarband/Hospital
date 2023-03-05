using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addSetting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Setting",
                schema: "Gnr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Key = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4187), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4190), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4193), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4195), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4198), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4201), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4204), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4150), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4152), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4154), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4153) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4156), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4158), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4160), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4161), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 924, DateTimeKind.Local).AddTicks(4198), new DateTime(2023, 3, 5, 11, 15, 58, 924, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 924, DateTimeKind.Local).AddTicks(4201), new DateTime(2023, 3, 5, 11, 15, 58, 924, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 924, DateTimeKind.Local).AddTicks(4203), new DateTime(2023, 3, 5, 11, 15, 58, 924, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.InsertData(
                schema: "Gnr",
                table: "Setting",
                columns: new[] { "Id", "CreatedDate", "CreatedUser", "Description", "Key", "ModifiedDate", "ModifiedUser", "Name", "Value" },
                values: new object[] { 1, new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4225), "elias.sarband", null, "PatientIdPrefix", new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4223), null, "Patient Identifier Prefix", "P" });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 925, DateTimeKind.Local).AddTicks(4741), new DateTime(2023, 3, 5, 11, 15, 58, 924, DateTimeKind.Local).AddTicks(4421) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4051), new DateTime(2023, 3, 5, 11, 15, 58, 925, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4121), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4123), new DateTime(2023, 3, 5, 11, 15, 58, 926, DateTimeKind.Local).AddTicks(4122) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Setting",
                schema: "Gnr");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5487), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5479) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5498), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5500), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5499) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5502), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5501) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5504), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5506), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5508), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5507) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5437), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5439), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5440), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5441), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5443), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5445), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5453), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 842, DateTimeKind.Local).AddTicks(4685), new DateTime(2023, 2, 28, 15, 43, 5, 842, DateTimeKind.Local).AddTicks(4673) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 842, DateTimeKind.Local).AddTicks(4688), new DateTime(2023, 2, 28, 15, 43, 5, 842, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 842, DateTimeKind.Local).AddTicks(4690), new DateTime(2023, 2, 28, 15, 43, 5, 842, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 843, DateTimeKind.Local).AddTicks(5603), new DateTime(2023, 2, 28, 15, 43, 5, 842, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5282), new DateTime(2023, 2, 28, 15, 43, 5, 843, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5406), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5405) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5409), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5408) });
        }
    }
}
