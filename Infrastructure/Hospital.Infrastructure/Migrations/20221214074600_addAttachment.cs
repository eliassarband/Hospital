using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addAttachment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 13, 31, 56, 822, DateTimeKind.Local).AddTicks(8792), new DateTime(2022, 12, 12, 13, 31, 56, 822, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 13, 31, 56, 822, DateTimeKind.Local).AddTicks(8796), new DateTime(2022, 12, 12, 13, 31, 56, 822, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 13, 31, 56, 822, DateTimeKind.Local).AddTicks(8799), new DateTime(2022, 12, 12, 13, 31, 56, 822, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 13, 31, 56, 824, DateTimeKind.Local).AddTicks(882), new DateTime(2022, 12, 12, 13, 31, 56, 822, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 13, 31, 56, 824, DateTimeKind.Local).AddTicks(943), new DateTime(2022, 12, 12, 13, 31, 56, 824, DateTimeKind.Local).AddTicks(936) });
        }
    }
}
