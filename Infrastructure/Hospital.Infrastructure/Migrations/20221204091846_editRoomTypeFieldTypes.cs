using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editRoomTypeFieldTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Floor",
                schema: "Gnr",
                table: "RoomType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 48, 46, 495, DateTimeKind.Local).AddTicks(4970), new DateTime(2022, 12, 4, 12, 48, 46, 495, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 48, 46, 495, DateTimeKind.Local).AddTicks(4974), new DateTime(2022, 12, 4, 12, 48, 46, 495, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 48, 46, 495, DateTimeKind.Local).AddTicks(4978), new DateTime(2022, 12, 4, 12, 48, 46, 495, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 48, 46, 496, DateTimeKind.Local).AddTicks(6309), new DateTime(2022, 12, 4, 12, 48, 46, 495, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 48, 46, 496, DateTimeKind.Local).AddTicks(6358), new DateTime(2022, 12, 4, 12, 48, 46, 496, DateTimeKind.Local).AddTicks(6355) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Floor",
                schema: "Gnr",
                table: "RoomType",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 33, 31, 784, DateTimeKind.Local).AddTicks(1348), new DateTime(2022, 12, 4, 12, 33, 31, 784, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 33, 31, 784, DateTimeKind.Local).AddTicks(1352), new DateTime(2022, 12, 4, 12, 33, 31, 784, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 33, 31, 784, DateTimeKind.Local).AddTicks(1354), new DateTime(2022, 12, 4, 12, 33, 31, 784, DateTimeKind.Local).AddTicks(1353) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 33, 31, 785, DateTimeKind.Local).AddTicks(1587), new DateTime(2022, 12, 4, 12, 33, 31, 784, DateTimeKind.Local).AddTicks(1474) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 33, 31, 785, DateTimeKind.Local).AddTicks(1644), new DateTime(2022, 12, 4, 12, 33, 31, 785, DateTimeKind.Local).AddTicks(1641) });
        }
    }
}
