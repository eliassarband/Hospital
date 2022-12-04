using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editDepartmentMainDept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainDept",
                schema: "Gnr",
                table: "Department");

            migrationBuilder.AddColumn<string>(
                name: "MainDeptartment",
                schema: "Gnr",
                table: "Department",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 8, 34, 450, DateTimeKind.Local).AddTicks(4104), new DateTime(2022, 12, 4, 11, 8, 34, 450, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 8, 34, 450, DateTimeKind.Local).AddTicks(4107), new DateTime(2022, 12, 4, 11, 8, 34, 450, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 8, 34, 450, DateTimeKind.Local).AddTicks(4110), new DateTime(2022, 12, 4, 11, 8, 34, 450, DateTimeKind.Local).AddTicks(4108) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 8, 34, 451, DateTimeKind.Local).AddTicks(4262), new DateTime(2022, 12, 4, 11, 8, 34, 450, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 8, 34, 451, DateTimeKind.Local).AddTicks(4307), new DateTime(2022, 12, 4, 11, 8, 34, 451, DateTimeKind.Local).AddTicks(4305) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainDeptartment",
                schema: "Gnr",
                table: "Department");

            migrationBuilder.AddColumn<string>(
                name: "MainDept",
                schema: "Gnr",
                table: "Department",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
