using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editServiceCost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cost",
                schema: "Gnr",
                table: "Service",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 43, 9, 725, DateTimeKind.Local).AddTicks(5011), new DateTime(2022, 12, 4, 11, 43, 9, 725, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 43, 9, 725, DateTimeKind.Local).AddTicks(5016), new DateTime(2022, 12, 4, 11, 43, 9, 725, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 43, 9, 725, DateTimeKind.Local).AddTicks(5018), new DateTime(2022, 12, 4, 11, 43, 9, 725, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 43, 9, 726, DateTimeKind.Local).AddTicks(5306), new DateTime(2022, 12, 4, 11, 43, 9, 725, DateTimeKind.Local).AddTicks(5139) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 43, 9, 726, DateTimeKind.Local).AddTicks(5400), new DateTime(2022, 12, 4, 11, 43, 9, 726, DateTimeKind.Local).AddTicks(5397) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                schema: "Gnr",
                table: "Service");

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 28, 5, 648, DateTimeKind.Local).AddTicks(432), new DateTime(2022, 12, 4, 11, 28, 5, 648, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 28, 5, 648, DateTimeKind.Local).AddTicks(436), new DateTime(2022, 12, 4, 11, 28, 5, 648, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 28, 5, 648, DateTimeKind.Local).AddTicks(439), new DateTime(2022, 12, 4, 11, 28, 5, 648, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 28, 5, 649, DateTimeKind.Local).AddTicks(1138), new DateTime(2022, 12, 4, 11, 28, 5, 648, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 11, 28, 5, 649, DateTimeKind.Local).AddTicks(1194), new DateTime(2022, 12, 4, 11, 28, 5, 649, DateTimeKind.Local).AddTicks(1190) });
        }
    }
}
