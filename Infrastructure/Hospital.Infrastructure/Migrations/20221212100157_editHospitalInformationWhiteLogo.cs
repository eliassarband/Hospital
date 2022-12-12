using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editHospitalInformationWhiteLogo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "WhiteLogo",
                schema: "Gnr",
                table: "HospitalInformation",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 13, 31, 56, 822, DateTimeKind.Local).AddTicks(8792), new DateTime(2022, 12, 12, 13, 31, 56, 822, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 13, 31, 56, 822, DateTimeKind.Local).AddTicks(8796), new DateTime(2022, 12, 12, 13, 31, 56, 822, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 13, 31, 56, 822, DateTimeKind.Local).AddTicks(8799), new DateTime(2022, 12, 12, 13, 31, 56, 822, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 13, 31, 56, 824, DateTimeKind.Local).AddTicks(882), new DateTime(2022, 12, 12, 13, 31, 56, 822, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 13, 31, 56, 824, DateTimeKind.Local).AddTicks(943), new DateTime(2022, 12, 12, 13, 31, 56, 824, DateTimeKind.Local).AddTicks(936) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WhiteLogo",
                schema: "Gnr",
                table: "HospitalInformation");

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 11, 12, 17, 769, DateTimeKind.Local).AddTicks(7050), new DateTime(2022, 12, 12, 11, 12, 17, 769, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 11, 12, 17, 769, DateTimeKind.Local).AddTicks(7054), new DateTime(2022, 12, 12, 11, 12, 17, 769, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 11, 12, 17, 769, DateTimeKind.Local).AddTicks(7057), new DateTime(2022, 12, 12, 11, 12, 17, 769, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 11, 12, 17, 770, DateTimeKind.Local).AddTicks(7638), new DateTime(2022, 12, 12, 11, 12, 17, 769, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 12, 11, 12, 17, 770, DateTimeKind.Local).AddTicks(7690), new DateTime(2022, 12, 12, 11, 12, 17, 770, DateTimeKind.Local).AddTicks(7688) });
        }
    }
}
