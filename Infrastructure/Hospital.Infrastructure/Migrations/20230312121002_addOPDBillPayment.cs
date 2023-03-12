using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addOPDBillPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaidAmount",
                schema: "Med",
                table: "OPDBill",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OPDBillPayment",
                schema: "Med",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OPDBillId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPDBillPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OPDBillPayment_OPDBill_OPDBillId",
                        column: x => x.OPDBillId,
                        principalSchema: "Med",
                        principalTable: "OPDBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3161), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3163), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3165), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3212), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3214), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3213) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3216), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3218), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3220), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3222), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2562), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2565), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2566), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2568), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2569), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2568) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2571), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2572), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2573), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2575), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2578), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 92, DateTimeKind.Local).AddTicks(2191), new DateTime(2023, 3, 12, 15, 40, 2, 92, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 92, DateTimeKind.Local).AddTicks(2194), new DateTime(2023, 3, 12, 15, 40, 2, 92, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 92, DateTimeKind.Local).AddTicks(2195), new DateTime(2023, 3, 12, 15, 40, 2, 92, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3311), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3312), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3314), new DateTime(2023, 3, 12, 15, 40, 2, 97, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 93, DateTimeKind.Local).AddTicks(2553), new DateTime(2023, 3, 12, 15, 40, 2, 92, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2436), new DateTime(2023, 3, 12, 15, 40, 2, 93, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2535), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2537), new DateTime(2023, 3, 12, 15, 40, 2, 94, DateTimeKind.Local).AddTicks(2536) });

            migrationBuilder.CreateIndex(
                name: "IX_OPDBillPayment_OPDBillId",
                schema: "Med",
                table: "OPDBillPayment",
                column: "OPDBillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OPDBillPayment",
                schema: "Med");

            migrationBuilder.DropColumn(
                name: "PaidAmount",
                schema: "Med",
                table: "OPDBill");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7477), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7480), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7482), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7484), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7486), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7488), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7487) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7490), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7493), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7495), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7435), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7437), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7438), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7440), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7439) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7442), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7443), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7445), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7444) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7447), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7448), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7450), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7452), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 535, DateTimeKind.Local).AddTicks(8566), new DateTime(2023, 3, 12, 8, 50, 48, 535, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 535, DateTimeKind.Local).AddTicks(8569), new DateTime(2023, 3, 12, 8, 50, 48, 535, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 535, DateTimeKind.Local).AddTicks(8571), new DateTime(2023, 3, 12, 8, 50, 48, 535, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7516), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7518), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7519), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 536, DateTimeKind.Local).AddTicks(8460), new DateTime(2023, 3, 12, 8, 50, 48, 535, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7282), new DateTime(2023, 3, 12, 8, 50, 48, 536, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7337), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7340), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7339) });
        }
    }
}
