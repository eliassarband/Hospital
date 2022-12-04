using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                schema: "Gnr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    MainDept = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotInUse = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 10, 32, 31, 987, DateTimeKind.Local).AddTicks(4947), new DateTime(2022, 12, 4, 10, 32, 31, 987, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 10, 32, 31, 987, DateTimeKind.Local).AddTicks(4950), new DateTime(2022, 12, 4, 10, 32, 31, 987, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 10, 32, 31, 987, DateTimeKind.Local).AddTicks(4953), new DateTime(2022, 12, 4, 10, 32, 31, 987, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 10, 32, 31, 989, DateTimeKind.Local).AddTicks(9949), new DateTime(2022, 12, 4, 10, 32, 31, 987, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 10, 32, 31, 990, DateTimeKind.Local).AddTicks(190), new DateTime(2022, 12, 4, 10, 32, 31, 990, DateTimeKind.Local).AddTicks(178) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Department",
                schema: "Gnr");

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 17, 36, 145, DateTimeKind.Local).AddTicks(9671), new DateTime(2022, 11, 15, 15, 17, 36, 145, DateTimeKind.Local).AddTicks(9615) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 17, 36, 145, DateTimeKind.Local).AddTicks(9674), new DateTime(2022, 11, 15, 15, 17, 36, 145, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 17, 36, 145, DateTimeKind.Local).AddTicks(9677), new DateTime(2022, 11, 15, 15, 17, 36, 145, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 17, 36, 147, DateTimeKind.Local).AddTicks(3), new DateTime(2022, 11, 15, 15, 17, 36, 145, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 17, 36, 147, DateTimeKind.Local).AddTicks(77), new DateTime(2022, 11, 15, 15, 17, 36, 147, DateTimeKind.Local).AddTicks(73) });
        }
    }
}
