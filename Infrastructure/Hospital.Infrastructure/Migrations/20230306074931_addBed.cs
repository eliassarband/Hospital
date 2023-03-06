using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addBed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ward",
                schema: "Gnr",
                table: "RoomType");

            migrationBuilder.AddColumn<int>(
                name: "WardId",
                schema: "Gnr",
                table: "RoomType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Bed",
                schema: "Gnr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    NotInUse = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bed_Room_RoomId",
                        column: x => x.RoomId,
                        principalSchema: "Gnr",
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9613), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9607) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9615), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9617), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9619), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9621), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9622), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9624), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9626), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9628), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9545), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9547), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9548), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9548) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9550), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9549) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9551), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9552), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9551) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9554), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9555), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9556), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 378, DateTimeKind.Local).AddTicks(224), new DateTime(2023, 3, 6, 11, 19, 31, 378, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 378, DateTimeKind.Local).AddTicks(226), new DateTime(2023, 3, 6, 11, 19, 31, 378, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 378, DateTimeKind.Local).AddTicks(228), new DateTime(2023, 3, 6, 11, 19, 31, 378, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9649), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9648) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9651), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(437), new DateTime(2023, 3, 6, 11, 19, 31, 378, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9477), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9526), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9528), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.CreateIndex(
                name: "IX_RoomType_WardId",
                schema: "Gnr",
                table: "RoomType",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_Bed_RoomId",
                schema: "Gnr",
                table: "Bed",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomType_BasicInformation_WardId",
                schema: "Gnr",
                table: "RoomType",
                column: "WardId",
                principalSchema: "Gnr",
                principalTable: "BasicInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomType_BasicInformation_WardId",
                schema: "Gnr",
                table: "RoomType");

            migrationBuilder.DropTable(
                name: "Bed",
                schema: "Gnr");

            migrationBuilder.DropIndex(
                name: "IX_RoomType_WardId",
                schema: "Gnr",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "WardId",
                schema: "Gnr",
                table: "RoomType");

            migrationBuilder.AddColumn<string>(
                name: "Ward",
                schema: "Gnr",
                table: "RoomType",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(933), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(928) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(936), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(938), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(937) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(940), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(938) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(968), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(970), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(972), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(974), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(973) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(976), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(975) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(890), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(887) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(892), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(894), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(895), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(897), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(899), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(898) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(905), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(907), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(906) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(909), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(908) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 28, DateTimeKind.Local).AddTicks(1076), new DateTime(2023, 3, 5, 17, 39, 0, 28, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 28, DateTimeKind.Local).AddTicks(1079), new DateTime(2023, 3, 5, 17, 39, 0, 28, DateTimeKind.Local).AddTicks(1078) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 28, DateTimeKind.Local).AddTicks(1081), new DateTime(2023, 3, 5, 17, 39, 0, 28, DateTimeKind.Local).AddTicks(1080) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(1001), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(1003), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 29, DateTimeKind.Local).AddTicks(1490), new DateTime(2023, 3, 5, 17, 39, 0, 28, DateTimeKind.Local).AddTicks(1309) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(806), new DateTime(2023, 3, 5, 17, 39, 0, 29, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(866), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(868), new DateTime(2023, 3, 5, 17, 39, 0, 30, DateTimeKind.Local).AddTicks(868) });
        }
    }
}
