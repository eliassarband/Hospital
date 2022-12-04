using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Service",
                schema: "Gnr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    OPDRate = table.Column<int>(type: "int", nullable: false),
                    IPDRate = table.Column<int>(type: "int", nullable: false),
                    AddPercentage = table.Column<int>(type: "int", nullable: false),
                    AddAmount = table.Column<int>(type: "int", nullable: false),
                    DiscountPercentage = table.Column<int>(type: "int", nullable: false),
                    DiscountAmount = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotInUse = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Service_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "Gnr",
                        principalTable: "Department",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 28, 5, 648, DateTimeKind.Local).AddTicks(432), new DateTime(2022, 12, 4, 11, 28, 5, 648, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 28, 5, 648, DateTimeKind.Local).AddTicks(436), new DateTime(2022, 12, 4, 11, 28, 5, 648, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 28, 5, 648, DateTimeKind.Local).AddTicks(439), new DateTime(2022, 12, 4, 11, 28, 5, 648, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 28, 5, 649, DateTimeKind.Local).AddTicks(1138), new DateTime(2022, 12, 4, 11, 28, 5, 648, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 28, 5, 649, DateTimeKind.Local).AddTicks(1194), new DateTime(2022, 12, 4, 11, 28, 5, 649, DateTimeKind.Local).AddTicks(1190) });

            migrationBuilder.CreateIndex(
                name: "IX_Service_DepartmentId",
                schema: "Gnr",
                table: "Service",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Service",
                schema: "Gnr");

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
    }
}
