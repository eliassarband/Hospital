using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addOPDBillPaymentType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillNo",
                schema: "Sec",
                table: "OPDBill");

            migrationBuilder.DropColumn(
                name: "ReceiptNo",
                schema: "Sec",
                table: "OPDBill");

            migrationBuilder.AddColumn<int>(
                name: "PaymentTypeId",
                schema: "Sec",
                table: "OPDBill",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "Code", "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { "PaymentType", new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5927), new DateTime(2023, 2, 28, 14, 7, 26, 630, DateTimeKind.Local).AddTicks(5926), "Payment Type" });

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

            migrationBuilder.CreateIndex(
                name: "IX_OPDBill_PaymentTypeId",
                schema: "Sec",
                table: "OPDBill",
                column: "PaymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OPDBill_BasicInformation_PaymentTypeId",
                schema: "Sec",
                table: "OPDBill",
                column: "PaymentTypeId",
                principalSchema: "Gnr",
                principalTable: "BasicInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OPDBill_BasicInformation_PaymentTypeId",
                schema: "Sec",
                table: "OPDBill");

            migrationBuilder.DropIndex(
                name: "IX_OPDBill_PaymentTypeId",
                schema: "Sec",
                table: "OPDBill");

            migrationBuilder.DropColumn(
                name: "PaymentTypeId",
                schema: "Sec",
                table: "OPDBill");

            migrationBuilder.AddColumn<string>(
                name: "BillNo",
                schema: "Sec",
                table: "OPDBill",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReceiptNo",
                schema: "Sec",
                table: "OPDBill",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7254), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7257), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7259), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7261), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7263), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7265), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7267), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7225), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7227), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7228), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7230), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7231), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7233), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { "InsurancePaymentType", new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7234), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7233), "Insurance Payment Type" });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 784, DateTimeKind.Local).AddTicks(7057), new DateTime(2023, 2, 19, 10, 31, 57, 784, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 784, DateTimeKind.Local).AddTicks(7060), new DateTime(2023, 2, 19, 10, 31, 57, 784, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 784, DateTimeKind.Local).AddTicks(7061), new DateTime(2023, 2, 19, 10, 31, 57, 784, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 785, DateTimeKind.Local).AddTicks(7787), new DateTime(2023, 2, 19, 10, 31, 57, 784, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7147), new DateTime(2023, 2, 19, 10, 31, 57, 785, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7203), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7205), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7204) });
        }
    }
}
