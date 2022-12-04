using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Sec");

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "Sec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Sec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Theme = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                schema: "Sec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Sec",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Sec",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "Role",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "ModifiedDate", "ModifiedUser", "Name" },
                values: new object[,]
                {
                    { 1, "Super", new DateTime(2022, 11, 15, 12, 12, 55, 194, DateTimeKind.Local).AddTicks(1302), null, "", new DateTime(2022, 11, 15, 12, 12, 55, 194, DateTimeKind.Local).AddTicks(1233), null, "Super Admin" },
                    { 2, "Admin", new DateTime(2022, 11, 15, 12, 12, 55, 194, DateTimeKind.Local).AddTicks(1306), null, "", new DateTime(2022, 11, 15, 12, 12, 55, 194, DateTimeKind.Local).AddTicks(1304), null, "Administrator" },
                    { 3, "Operator", new DateTime(2022, 11, 15, 12, 12, 55, 194, DateTimeKind.Local).AddTicks(1309), null, "", new DateTime(2022, 11, 15, 12, 12, 55, 194, DateTimeKind.Local).AddTicks(1307), null, "Operator" }
                });

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "User",
                columns: new[] { "Id", "Active", "CreatedDate", "CreatedUser", "Email", "FirstName", "LastName", "ModifiedDate", "ModifiedUser", "Password", "PhoneNumber", "Photo", "Theme", "Username" },
                values: new object[] { 1, true, new DateTime(2022, 11, 15, 12, 12, 55, 195, DateTimeKind.Local).AddTicks(7260), null, "elias.sarband@gmail.com", "Elias", "Sarband", new DateTime(2022, 11, 15, 12, 12, 55, 194, DateTimeKind.Local).AddTicks(1474), null, "SEIE/b+BtdSahkhMsl4KK3SuEjCF1OKUEn4oQYMaYSc=", "9125056182", null, "Light", "elias.sarband" });

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                schema: "Sec",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                schema: "Sec",
                table: "UserRole",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRole",
                schema: "Sec");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "Sec");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Sec");
        }
    }
}
