using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editMainDepartmentType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainDeptartment",
                schema: "Gnr",
                table: "Department");

            migrationBuilder.AddColumn<int>(
                name: "MainDepartmentId",
                schema: "Gnr",
                table: "Department",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Department_MainDepartmentId",
                schema: "Gnr",
                table: "Department",
                column: "MainDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Department_MainDepartmentId",
                schema: "Gnr",
                table: "Department",
                column: "MainDepartmentId",
                principalSchema: "Gnr",
                principalTable: "Department",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Department_MainDepartmentId",
                schema: "Gnr",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_MainDepartmentId",
                schema: "Gnr",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "MainDepartmentId",
                schema: "Gnr",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "MainDeptartmentId",
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
                values: new object[] { new DateTime(2022, 12, 17, 11, 45, 16, 155, DateTimeKind.Local).AddTicks(8724), new DateTime(2022, 12, 17, 11, 45, 16, 155, DateTimeKind.Local).AddTicks(8672) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 45, 16, 155, DateTimeKind.Local).AddTicks(8729), new DateTime(2022, 12, 17, 11, 45, 16, 155, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 45, 16, 155, DateTimeKind.Local).AddTicks(8733), new DateTime(2022, 12, 17, 11, 45, 16, 155, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 45, 16, 157, DateTimeKind.Local).AddTicks(7280), new DateTime(2022, 12, 17, 11, 45, 16, 155, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 45, 16, 157, DateTimeKind.Local).AddTicks(7326), new DateTime(2022, 12, 17, 11, 45, 16, 157, DateTimeKind.Local).AddTicks(7324) });
        }
    }
}
