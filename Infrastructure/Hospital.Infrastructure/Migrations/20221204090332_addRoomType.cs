using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addRoomType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoomType",
                schema: "Gnr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Ward = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NotInUse = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomType", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomType",
                schema: "Gnr");

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 3, 31, 321, DateTimeKind.Local).AddTicks(7338), new DateTime(2022, 12, 4, 12, 3, 31, 321, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 3, 31, 321, DateTimeKind.Local).AddTicks(7341), new DateTime(2022, 12, 4, 12, 3, 31, 321, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 3, 31, 321, DateTimeKind.Local).AddTicks(7344), new DateTime(2022, 12, 4, 12, 3, 31, 321, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 3, 31, 322, DateTimeKind.Local).AddTicks(7762), new DateTime(2022, 12, 4, 12, 3, 31, 321, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 12, 3, 31, 322, DateTimeKind.Local).AddTicks(7816), new DateTime(2022, 12, 4, 12, 3, 31, 322, DateTimeKind.Local).AddTicks(7812) });
        }
    }
}
