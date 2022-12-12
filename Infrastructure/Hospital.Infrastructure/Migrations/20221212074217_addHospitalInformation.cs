using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addHospitalInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HospitalInformation",
                schema: "Gnr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Logo = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    RegisterationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackupDirectory1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BackupDirectory2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CurrencyName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CurrencySymbol = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CurrencyCents = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SessionTimeout = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalInformation", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 11, 12, 17, 769, DateTimeKind.Local).AddTicks(7050), new DateTime(2022, 12, 12, 11, 12, 17, 769, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 11, 12, 17, 769, DateTimeKind.Local).AddTicks(7054), new DateTime(2022, 12, 12, 11, 12, 17, 769, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 11, 12, 17, 769, DateTimeKind.Local).AddTicks(7057), new DateTime(2022, 12, 12, 11, 12, 17, 769, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 11, 12, 17, 770, DateTimeKind.Local).AddTicks(7638), new DateTime(2022, 12, 12, 11, 12, 17, 769, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 11, 12, 17, 770, DateTimeKind.Local).AddTicks(7690), new DateTime(2022, 12, 12, 11, 12, 17, 770, DateTimeKind.Local).AddTicks(7688) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HospitalInformation",
                schema: "Gnr");

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 54, 36, 939, DateTimeKind.Local).AddTicks(6016), new DateTime(2022, 12, 4, 12, 54, 36, 939, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 54, 36, 939, DateTimeKind.Local).AddTicks(6020), new DateTime(2022, 12, 4, 12, 54, 36, 939, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 54, 36, 939, DateTimeKind.Local).AddTicks(6023), new DateTime(2022, 12, 4, 12, 54, 36, 939, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 54, 36, 940, DateTimeKind.Local).AddTicks(6686), new DateTime(2022, 12, 4, 12, 54, 36, 939, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 54, 36, 940, DateTimeKind.Local).AddTicks(6735), new DateTime(2022, 12, 4, 12, 54, 36, 940, DateTimeKind.Local).AddTicks(6732) });
        }
    }
}
