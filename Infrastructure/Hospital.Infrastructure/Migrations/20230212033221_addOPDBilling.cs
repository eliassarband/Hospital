using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addOPDBilling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OPDBill",
                schema: "Sec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    BillNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    PayableAmount = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPDBill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OPDBill_Patient_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "Med",
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OPDBillService",
                schema: "Sec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OPDBillId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPDBillService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OPDBillService_OPDBill_OPDBillId",
                        column: x => x.OPDBillId,
                        principalSchema: "Sec",
                        principalTable: "OPDBill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OPDBillService_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "Gnr",
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OPDBillService_Staff_StaffId",
                        column: x => x.StaffId,
                        principalSchema: "Med",
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5872), new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5875), new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5873) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5878), new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5912), new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5915), new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5919), new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5922), new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5838), new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5834) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5841), new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5843), new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5842) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5845), new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5848), new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5851), new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5853), new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 755, DateTimeKind.Local).AddTicks(7657), new DateTime(2023, 2, 12, 7, 2, 20, 755, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 755, DateTimeKind.Local).AddTicks(7660), new DateTime(2023, 2, 12, 7, 2, 20, 755, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 755, DateTimeKind.Local).AddTicks(7663), new DateTime(2023, 2, 12, 7, 2, 20, 755, DateTimeKind.Local).AddTicks(7661) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 756, DateTimeKind.Local).AddTicks(7266), new DateTime(2023, 2, 12, 7, 2, 20, 755, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5689), new DateTime(2023, 2, 12, 7, 2, 20, 756, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5733), new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5736), new DateTime(2023, 2, 12, 7, 2, 20, 757, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.CreateIndex(
                name: "IX_OPDBill_PatientId",
                schema: "Sec",
                table: "OPDBill",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_OPDBillService_OPDBillId",
                schema: "Sec",
                table: "OPDBillService",
                column: "OPDBillId");

            migrationBuilder.CreateIndex(
                name: "IX_OPDBillService_ServiceId",
                schema: "Sec",
                table: "OPDBillService",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_OPDBillService_StaffId",
                schema: "Sec",
                table: "OPDBillService",
                column: "StaffId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OPDBillService",
                schema: "Sec");

            migrationBuilder.DropTable(
                name: "OPDBill",
                schema: "Sec");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4857), new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4865), new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4869), new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4873), new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4876), new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4879), new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4883), new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4815), new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4819), new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4821), new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4825), new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4829), new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4832), new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4835), new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 834, DateTimeKind.Local).AddTicks(4237), new DateTime(2023, 1, 14, 16, 33, 48, 834, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 834, DateTimeKind.Local).AddTicks(4240), new DateTime(2023, 1, 14, 16, 33, 48, 834, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 834, DateTimeKind.Local).AddTicks(4243), new DateTime(2023, 1, 14, 16, 33, 48, 834, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 835, DateTimeKind.Local).AddTicks(5145), new DateTime(2023, 1, 14, 16, 33, 48, 834, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4734), new DateTime(2023, 1, 14, 16, 33, 48, 835, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4787), new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4790), new DateTime(2023, 1, 14, 16, 33, 48, 836, DateTimeKind.Local).AddTicks(4789) });
        }
    }
}
