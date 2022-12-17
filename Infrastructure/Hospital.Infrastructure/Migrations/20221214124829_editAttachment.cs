using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editAttachment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Extension",
                schema: "Gnr",
                table: "Attachment",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 16, 18, 28, 970, DateTimeKind.Local).AddTicks(1439), new DateTime(2022, 12, 14, 16, 18, 28, 970, DateTimeKind.Local).AddTicks(1383) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 16, 18, 28, 970, DateTimeKind.Local).AddTicks(1443), new DateTime(2022, 12, 14, 16, 18, 28, 970, DateTimeKind.Local).AddTicks(1441) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 16, 18, 28, 970, DateTimeKind.Local).AddTicks(1446), new DateTime(2022, 12, 14, 16, 18, 28, 970, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 16, 18, 28, 971, DateTimeKind.Local).AddTicks(6507), new DateTime(2022, 12, 14, 16, 18, 28, 970, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 16, 18, 28, 971, DateTimeKind.Local).AddTicks(6728), new DateTime(2022, 12, 14, 16, 18, 28, 971, DateTimeKind.Local).AddTicks(6722) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Extension",
                schema: "Gnr",
                table: "Attachment",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 11, 16, 0, 152, DateTimeKind.Local).AddTicks(9753), new DateTime(2022, 12, 14, 11, 16, 0, 152, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 11, 16, 0, 152, DateTimeKind.Local).AddTicks(9757), new DateTime(2022, 12, 14, 11, 16, 0, 152, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 11, 16, 0, 152, DateTimeKind.Local).AddTicks(9759), new DateTime(2022, 12, 14, 11, 16, 0, 152, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 11, 16, 0, 154, DateTimeKind.Local).AddTicks(133), new DateTime(2022, 12, 14, 11, 16, 0, 152, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 14, 11, 16, 0, 154, DateTimeKind.Local).AddTicks(195), new DateTime(2022, 12, 14, 11, 16, 0, 154, DateTimeKind.Local).AddTicks(192) });
        }
    }
}
