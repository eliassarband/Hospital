using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addOPDBillReceiptNo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(259), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(251) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(269), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(276), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(284), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(291), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(301), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(309), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(173), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(180), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(186), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(183) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(194), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(200), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(197) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(208), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(214), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 349, DateTimeKind.Local).AddTicks(3683), new DateTime(2023, 2, 18, 21, 4, 11, 349, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 349, DateTimeKind.Local).AddTicks(3692), new DateTime(2023, 2, 18, 21, 4, 11, 349, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 349, DateTimeKind.Local).AddTicks(3700), new DateTime(2023, 2, 18, 21, 4, 11, 349, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 351, DateTimeKind.Local).AddTicks(9222), new DateTime(2023, 2, 18, 21, 4, 11, 349, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(31), new DateTime(2023, 2, 18, 21, 4, 11, 351, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(122), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(129), new DateTime(2023, 2, 18, 21, 4, 11, 354, DateTimeKind.Local).AddTicks(126) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiptNo",
                schema: "Sec",
                table: "OPDBill");

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
        }
    }
}
