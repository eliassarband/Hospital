using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addIPDRegisteration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "OPDBillService",
                schema: "Sec",
                newName: "OPDBillService",
                newSchema: "Med");

            migrationBuilder.RenameTable(
                name: "OPDBill",
                schema: "Sec",
                newName: "OPDBill",
                newSchema: "Med");

            migrationBuilder.CreateTable(
                name: "IPDRegisteration",
                schema: "Med",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    RefferById = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    PayableAmount = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPDRegisteration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IPDRegisteration_Patient_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "Med",
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IPDRegisteration_RefferBy_RefferById",
                        column: x => x.RefferById,
                        principalSchema: "Med",
                        principalTable: "RefferBy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IPDRegisterationPayment",
                schema: "Med",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IPDRegisterationId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentTypeId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ChequeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPDRegisterationPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IPDRegisterationPayment_BasicInformation_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IPDRegisterationPayment_IPDRegisteration_IPDRegisterationId",
                        column: x => x.IPDRegisterationId,
                        principalSchema: "Med",
                        principalTable: "IPDRegisteration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IPDRegisterationRoom",
                schema: "Med",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IPDRegisterationId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Days = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPDRegisterationRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IPDRegisterationRoom_IPDRegisteration_IPDRegisterationId",
                        column: x => x.IPDRegisterationId,
                        principalSchema: "Med",
                        principalTable: "IPDRegisteration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IPDRegisterationRoom_Room_RoomId",
                        column: x => x.RoomId,
                        principalSchema: "Gnr",
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IPDRegisterationService",
                schema: "Med",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IPDRegisterationId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPDRegisterationService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IPDRegisterationService_IPDRegisteration_IPDRegisterationId",
                        column: x => x.IPDRegisterationId,
                        principalSchema: "Med",
                        principalTable: "IPDRegisteration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IPDRegisterationService_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "Gnr",
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IPDRegisterationService_Staff_StaffId",
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
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5487), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5479) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5498), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5500), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5499) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5502), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5501) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5504), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5506), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5508), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5507) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5437), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5439), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5440), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5441), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5443), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5445), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5453), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 842, DateTimeKind.Local).AddTicks(4685), new DateTime(2023, 2, 28, 15, 43, 5, 842, DateTimeKind.Local).AddTicks(4673) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 842, DateTimeKind.Local).AddTicks(4688), new DateTime(2023, 2, 28, 15, 43, 5, 842, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 842, DateTimeKind.Local).AddTicks(4690), new DateTime(2023, 2, 28, 15, 43, 5, 842, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 843, DateTimeKind.Local).AddTicks(5603), new DateTime(2023, 2, 28, 15, 43, 5, 842, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5282), new DateTime(2023, 2, 28, 15, 43, 5, 843, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5406), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5405) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5409), new DateTime(2023, 2, 28, 15, 43, 5, 844, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisteration_PatientId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisteration_RefferById",
                schema: "Med",
                table: "IPDRegisteration",
                column: "RefferById");

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisterationPayment_IPDRegisterationId",
                schema: "Med",
                table: "IPDRegisterationPayment",
                column: "IPDRegisterationId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisterationPayment_PaymentTypeId",
                schema: "Med",
                table: "IPDRegisterationPayment",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisterationRoom_IPDRegisterationId",
                schema: "Med",
                table: "IPDRegisterationRoom",
                column: "IPDRegisterationId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisterationRoom_RoomId",
                schema: "Med",
                table: "IPDRegisterationRoom",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisterationService_IPDRegisterationId",
                schema: "Med",
                table: "IPDRegisterationService",
                column: "IPDRegisterationId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisterationService_ServiceId",
                schema: "Med",
                table: "IPDRegisterationService",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisterationService_StaffId",
                schema: "Med",
                table: "IPDRegisterationService",
                column: "StaffId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IPDRegisterationPayment",
                schema: "Med");

            migrationBuilder.DropTable(
                name: "IPDRegisterationRoom",
                schema: "Med");

            migrationBuilder.DropTable(
                name: "IPDRegisterationService",
                schema: "Med");

            migrationBuilder.DropTable(
                name: "IPDRegisteration",
                schema: "Med");

            migrationBuilder.RenameTable(
                name: "OPDBillService",
                schema: "Med",
                newName: "OPDBillService",
                newSchema: "Sec");

            migrationBuilder.RenameTable(
                name: "OPDBill",
                schema: "Med",
                newName: "OPDBill",
                newSchema: "Sec");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5977), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5980), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5982), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5984), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5989), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5991), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5992), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5991) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5917), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5919), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5920), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5923), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5925), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5926), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5927), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 628, DateTimeKind.Local).AddTicks(6473), new DateTime(2023, 2, 28, 14, 7, 26, 628, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 628, DateTimeKind.Local).AddTicks(6475), new DateTime(2023, 2, 28, 14, 7, 26, 628, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 628, DateTimeKind.Local).AddTicks(6476), new DateTime(2023, 2, 28, 14, 7, 26, 628, DateTimeKind.Local).AddTicks(6476) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 629, DateTimeKind.Local).AddTicks(6704), new DateTime(2023, 2, 28, 14, 7, 26, 628, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5839), new DateTime(2023, 2, 28, 14, 7, 26, 629, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5891), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5893), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5892) });
        }
    }
}
