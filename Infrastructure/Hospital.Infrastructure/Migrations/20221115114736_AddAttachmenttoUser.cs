using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAttachmenttoUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                schema: "Sec",
                table: "User");

            migrationBuilder.EnsureSchema(
                name: "Gnr");

            migrationBuilder.AddColumn<int>(
                name: "AttachmentId",
                schema: "Sec",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Attachment",
                schema: "Gnr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 17, 36, 145, DateTimeKind.Local).AddTicks(9671), new DateTime(2022, 11, 15, 15, 17, 36, 145, DateTimeKind.Local).AddTicks(9615) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 17, 36, 145, DateTimeKind.Local).AddTicks(9674), new DateTime(2022, 11, 15, 15, 17, 36, 145, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 17, 36, 145, DateTimeKind.Local).AddTicks(9677), new DateTime(2022, 11, 15, 15, 17, 36, 145, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AttachmentId", "CreatedDate", "ModifiedDate" },
                values: new object[] { null, new DateTime(2022, 11, 15, 15, 17, 36, 147, DateTimeKind.Local).AddTicks(3), new DateTime(2022, 11, 15, 15, 17, 36, 145, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 15, 17, 36, 147, DateTimeKind.Local).AddTicks(77), new DateTime(2022, 11, 15, 15, 17, 36, 147, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.CreateIndex(
                name: "IX_User_AttachmentId",
                schema: "Sec",
                table: "User",
                column: "AttachmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Attachment_AttachmentId",
                schema: "Sec",
                table: "User",
                column: "AttachmentId",
                principalSchema: "Gnr",
                principalTable: "Attachment",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Attachment_AttachmentId",
                schema: "Sec",
                table: "User");

            migrationBuilder.DropTable(
                name: "Attachment",
                schema: "Gnr");

            migrationBuilder.DropIndex(
                name: "IX_User_AttachmentId",
                schema: "Sec",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AttachmentId",
                schema: "Sec",
                table: "User");

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                schema: "Sec",
                table: "User",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 12, 18, 38, 288, DateTimeKind.Local).AddTicks(2810), new DateTime(2022, 11, 15, 12, 18, 38, 288, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 12, 18, 38, 288, DateTimeKind.Local).AddTicks(2816), new DateTime(2022, 11, 15, 12, 18, 38, 288, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 12, 18, 38, 288, DateTimeKind.Local).AddTicks(2821), new DateTime(2022, 11, 15, 12, 18, 38, 288, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "Photo" },
                values: new object[] { new DateTime(2022, 11, 15, 12, 18, 38, 290, DateTimeKind.Local).AddTicks(2391), new DateTime(2022, 11, 15, 12, 18, 38, 288, DateTimeKind.Local).AddTicks(3052), null });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 12, 18, 38, 290, DateTimeKind.Local).AddTicks(2472), new DateTime(2022, 11, 15, 12, 18, 38, 290, DateTimeKind.Local).AddTicks(2468) });
        }
    }
}
