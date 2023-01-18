using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patient",
                schema: "Med",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePrefixId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    AreaId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    RefferById = table.Column<int>(type: "int", nullable: true),
                    NationalIdCart = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    InsuranceId = table.Column<int>(type: "int", nullable: true),
                    InsuranceNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ProposalNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AttachmentId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "Gnr",
                        principalTable: "Attachment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_BasicInformation_AreaId",
                        column: x => x.AreaId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_BasicInformation_CityId",
                        column: x => x.CityId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_BasicInformation_GenderId",
                        column: x => x.GenderId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_BasicInformation_NamePrefixId",
                        column: x => x.NamePrefixId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_Insurance_InsuranceId",
                        column: x => x.InsuranceId,
                        principalSchema: "Med",
                        principalTable: "Insurance",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_RefferBy_RefferById",
                        column: x => x.RefferById,
                        principalSchema: "Med",
                        principalTable: "RefferBy",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Patient_AreaId",
                schema: "Med",
                table: "Patient",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_AttachmentId",
                schema: "Med",
                table: "Patient",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_CityId",
                schema: "Med",
                table: "Patient",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_GenderId",
                schema: "Med",
                table: "Patient",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_InsuranceId",
                schema: "Med",
                table: "Patient",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_NamePrefixId",
                schema: "Med",
                table: "Patient",
                column: "NamePrefixId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_RefferById",
                schema: "Med",
                table: "Patient",
                column: "RefferById");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patient",
                schema: "Med");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9133), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9137), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9140), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9143), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9146), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9149), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9152), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9097), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9100), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9102), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9105), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9108), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9113), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 505, DateTimeKind.Local).AddTicks(8293), new DateTime(2022, 12, 24, 14, 41, 30, 505, DateTimeKind.Local).AddTicks(8239) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 505, DateTimeKind.Local).AddTicks(8297), new DateTime(2022, 12, 24, 14, 41, 30, 505, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 505, DateTimeKind.Local).AddTicks(8300), new DateTime(2022, 12, 24, 14, 41, 30, 505, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(182), new DateTime(2022, 12, 24, 14, 41, 30, 505, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9072), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9075), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9074) });
        }
    }
}
