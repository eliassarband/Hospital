using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addBasicInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasicInformationCategory",
                schema: "Gnr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Viewable = table.Column<bool>(type: "bit", nullable: false),
                    RelatedCategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicInformationCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasicInformationCategory_BasicInformationCategory_RelatedCategoryId",
                        column: x => x.RelatedCategoryId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformationCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BasicInformation",
                schema: "Gnr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    StrCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    RelatedBasicInformationId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    AllowChange = table.Column<bool>(type: "bit", nullable: false),
                    AllowDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasicInformation_BasicInformationCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformationCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasicInformation_BasicInformation_RelatedBasicInformationId",
                        column: x => x.RelatedBasicInformationId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_BasicInformation_CategoryId",
                schema: "Gnr",
                table: "BasicInformation",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BasicInformation_RelatedBasicInformationId",
                schema: "Gnr",
                table: "BasicInformation",
                column: "RelatedBasicInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_BasicInformationCategory_RelatedCategoryId",
                schema: "Gnr",
                table: "BasicInformationCategory",
                column: "RelatedCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasicInformation",
                schema: "Gnr");

            migrationBuilder.DropTable(
                name: "BasicInformationCategory",
                schema: "Gnr");

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
    }
}
