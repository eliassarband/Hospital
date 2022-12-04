using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataForUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CreatedUser", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 12, 18, 38, 288, DateTimeKind.Local).AddTicks(2810), "elias.sarband", new DateTime(2022, 11, 15, 12, 18, 38, 288, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "CreatedUser", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 12, 18, 38, 288, DateTimeKind.Local).AddTicks(2816), "elias.sarband", new DateTime(2022, 11, 15, 12, 18, 38, 288, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CreatedUser", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 12, 18, 38, 288, DateTimeKind.Local).AddTicks(2821), "elias.sarband", new DateTime(2022, 11, 15, 12, 18, 38, 288, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CreatedUser", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 12, 18, 38, 290, DateTimeKind.Local).AddTicks(2391), "elias.sarband", new DateTime(2022, 11, 15, 12, 18, 38, 288, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "UserRole",
                columns: new[] { "Id", "CreatedDate", "CreatedUser", "ModifiedDate", "ModifiedUser", "RoleId", "UserId" },
                values: new object[] { 1, new DateTime(2022, 11, 15, 12, 18, 38, 290, DateTimeKind.Local).AddTicks(2472), "elias.sarband", new DateTime(2022, 11, 15, 12, 18, 38, 290, DateTimeKind.Local).AddTicks(2468), null, 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CreatedUser", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 12, 12, 55, 194, DateTimeKind.Local).AddTicks(1302), null, new DateTime(2022, 11, 15, 12, 12, 55, 194, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "CreatedUser", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 12, 12, 55, 194, DateTimeKind.Local).AddTicks(1306), null, new DateTime(2022, 11, 15, 12, 12, 55, 194, DateTimeKind.Local).AddTicks(1304) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CreatedUser", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 12, 12, 55, 194, DateTimeKind.Local).AddTicks(1309), null, new DateTime(2022, 11, 15, 12, 12, 55, 194, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CreatedUser", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 12, 12, 55, 195, DateTimeKind.Local).AddTicks(7260), null, new DateTime(2022, 11, 15, 12, 12, 55, 194, DateTimeKind.Local).AddTicks(1474) });
        }
    }
}
