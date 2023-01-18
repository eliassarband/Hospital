using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editMainDepartmentTypeSpelling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainDeptartmentId",
                schema: "Gnr",
                table: "Department");

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 18, 11, 34, 53, 137, DateTimeKind.Local).AddTicks(1044), new DateTime(2022, 12, 18, 11, 34, 53, 137, DateTimeKind.Local).AddTicks(993) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 18, 11, 34, 53, 137, DateTimeKind.Local).AddTicks(1047), new DateTime(2022, 12, 18, 11, 34, 53, 137, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 18, 11, 34, 53, 137, DateTimeKind.Local).AddTicks(1050), new DateTime(2022, 12, 18, 11, 34, 53, 137, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 18, 11, 34, 53, 138, DateTimeKind.Local).AddTicks(7478), new DateTime(2022, 12, 18, 11, 34, 53, 137, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 18, 11, 34, 53, 138, DateTimeKind.Local).AddTicks(7528), new DateTime(2022, 12, 18, 11, 34, 53, 138, DateTimeKind.Local).AddTicks(7522) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MainDeptartmentId",
                schema: "Gnr",
                table: "Department",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 18, 11, 21, 15, 283, DateTimeKind.Local).AddTicks(8406), new DateTime(2022, 12, 18, 11, 21, 15, 283, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 18, 11, 21, 15, 283, DateTimeKind.Local).AddTicks(8409), new DateTime(2022, 12, 18, 11, 21, 15, 283, DateTimeKind.Local).AddTicks(8407) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 18, 11, 21, 15, 283, DateTimeKind.Local).AddTicks(8412), new DateTime(2022, 12, 18, 11, 21, 15, 283, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 18, 11, 21, 15, 285, DateTimeKind.Local).AddTicks(4928), new DateTime(2022, 12, 18, 11, 21, 15, 283, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 18, 11, 21, 15, 285, DateTimeKind.Local).AddTicks(5033), new DateTime(2022, 12, 18, 11, 21, 15, 285, DateTimeKind.Local).AddTicks(5029) });
        }
    }
}
