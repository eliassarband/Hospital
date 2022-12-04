using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Room",
                schema: "Gnr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    Rest = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    NotInUse = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_RoomType_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalSchema: "Gnr",
                        principalTable: "RoomType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomTypeId",
                schema: "Gnr",
                table: "Room",
                column: "RoomTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Room",
                schema: "Gnr");

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
    }
}
