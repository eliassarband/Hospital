using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addInsurance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "med");

            migrationBuilder.CreateTable(
                name: "Insurance",
                schema: "med",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    OPDDiscountPercent = table.Column<int>(type: "int", nullable: false),
                    IPDDiscountPercent = table.Column<int>(type: "int", nullable: false),
                    AdvancePaymentPercent = table.Column<int>(type: "int", nullable: false),
                    AdvancePaymentAmount = table.Column<int>(type: "int", nullable: false),
                    IncurancePaymentTypeId = table.Column<int>(type: "int", nullable: false),
                    NotInUse = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Insurance_BasicInformation_IncurancePaymentTypeId",
                        column: x => x.IncurancePaymentTypeId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "ModifiedDate", "ModifiedUser", "Name", "RelatedCategoryId", "Viewable" },
                values: new object[] { 7, "InsurancePaymentType", new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9690), "elias.sarband", new DateTime(2022, 12, 19, 12, 6, 46, 122, DateTimeKind.Local).AddTicks(9689), null, "Insurance Payment Type", null, true });

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

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_IncurancePaymentTypeId",
                schema: "med",
                table: "Insurance",
                column: "IncurancePaymentTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insurance",
                schema: "med");

            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3579), new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3585), new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3589), new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3594), new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3598), new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3602), new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 717, DateTimeKind.Local).AddTicks(8823), new DateTime(2022, 12, 19, 11, 34, 33, 717, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 717, DateTimeKind.Local).AddTicks(8829), new DateTime(2022, 12, 19, 11, 34, 33, 717, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 717, DateTimeKind.Local).AddTicks(8881), new DateTime(2022, 12, 19, 11, 34, 33, 717, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 719, DateTimeKind.Local).AddTicks(7324), new DateTime(2022, 12, 19, 11, 34, 33, 717, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3477), new DateTime(2022, 12, 19, 11, 34, 33, 719, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3544), new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3548), new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3546) });
        }
    }
}
