using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addInsuranceAgreement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insurance_BasicInformation_IncurancePaymentTypeId",
                schema: "med",
                table: "Insurance");

            migrationBuilder.EnsureSchema(
                name: "Med");

            migrationBuilder.RenameTable(
                name: "Insurance",
                schema: "med",
                newName: "Insurance",
                newSchema: "Med");

            migrationBuilder.RenameColumn(
                name: "IncurancePaymentTypeId",
                schema: "Med",
                table: "Insurance",
                newName: "InsurancePaymentTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Insurance_IncurancePaymentTypeId",
                schema: "Med",
                table: "Insurance",
                newName: "IX_Insurance_InsurancePaymentTypeId");

            migrationBuilder.CreateTable(
                name: "InsuranceAgreement",
                schema: "Med",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AttachmentId = table.Column<int>(type: "int", nullable: true),
                    ShowWarningBefore = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceAgreement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsuranceAgreement_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "Gnr",
                        principalTable: "Attachment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InsuranceAgreement_Insurance_InsuranceId",
                        column: x => x.InsuranceId,
                        principalSchema: "Med",
                        principalTable: "Insurance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1026), new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1029), new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1031), new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1030) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1034), new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1036), new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1035) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1039), new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1038) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1042), new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 0, 26, 158, DateTimeKind.Local).AddTicks(3236), new DateTime(2022, 12, 19, 13, 0, 26, 158, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 0, 26, 158, DateTimeKind.Local).AddTicks(3239), new DateTime(2022, 12, 19, 13, 0, 26, 158, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 0, 26, 158, DateTimeKind.Local).AddTicks(3242), new DateTime(2022, 12, 19, 13, 0, 26, 158, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 0, 26, 159, DateTimeKind.Local).AddTicks(2665), new DateTime(2022, 12, 19, 13, 0, 26, 158, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(953), new DateTime(2022, 12, 19, 13, 0, 26, 159, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1002), new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1005), new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1004) });

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceAgreement_AttachmentId",
                schema: "Med",
                table: "InsuranceAgreement",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceAgreement_InsuranceId",
                schema: "Med",
                table: "InsuranceAgreement",
                column: "InsuranceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurance_BasicInformation_InsurancePaymentTypeId",
                schema: "Med",
                table: "Insurance",
                column: "InsurancePaymentTypeId",
                principalSchema: "Gnr",
                principalTable: "BasicInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insurance_BasicInformation_InsurancePaymentTypeId",
                schema: "Med",
                table: "Insurance");

            migrationBuilder.DropTable(
                name: "InsuranceAgreement",
                schema: "Med");

            migrationBuilder.EnsureSchema(
                name: "med");

            migrationBuilder.RenameTable(
                name: "Insurance",
                schema: "Med",
                newName: "Insurance",
                newSchema: "med");

            migrationBuilder.RenameColumn(
                name: "InsurancePaymentTypeId",
                schema: "med",
                table: "Insurance",
                newName: "IncurancePaymentTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Insurance_InsurancePaymentTypeId",
                schema: "med",
                table: "Insurance",
                newName: "IX_Insurance_IncurancePaymentTypeId");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9672), new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9675), new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9678), new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9682), new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9684), new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9688), new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9690), new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 12, 6, 46, 120, DateTimeKind.Local).AddTicks(9432), new DateTime(2022, 12, 19, 12, 6, 46, 120, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 12, 6, 46, 120, DateTimeKind.Local).AddTicks(9436), new DateTime(2022, 12, 19, 12, 6, 46, 120, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 12, 6, 46, 120, DateTimeKind.Local).AddTicks(9440), new DateTime(2022, 12, 19, 12, 6, 46, 120, DateTimeKind.Local).AddTicks(9438) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(172), new DateTime(2022, 12, 19, 12, 6, 46, 120, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9600), new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9643), new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9646), new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.AddForeignKey(
                name: "FK_Insurance_BasicInformation_IncurancePaymentTypeId",
                schema: "med",
                table: "Insurance",
                column: "IncurancePaymentTypeId",
                principalSchema: "Gnr",
                principalTable: "BasicInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
