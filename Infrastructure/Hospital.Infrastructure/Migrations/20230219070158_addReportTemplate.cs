using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addReportTemplate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportTemplate",
                schema: "Gnr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportTemplate", x => x.Id);
                });

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7234), new DateTime(2023, 2, 19, 10, 31, 57, 786, DateTimeKind.Local).AddTicks(7233) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportTemplate",
                schema: "Gnr");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3757), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3761), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3758) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3765), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3762) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3768), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3771), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3775), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3778), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3650), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3646) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3654), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3652) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3657), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3660), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3658) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3663), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3666), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3669), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 953, DateTimeKind.Local).AddTicks(3050), new DateTime(2023, 2, 18, 21, 49, 1, 953, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 953, DateTimeKind.Local).AddTicks(3054), new DateTime(2023, 2, 18, 21, 49, 1, 953, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 953, DateTimeKind.Local).AddTicks(3057), new DateTime(2023, 2, 18, 21, 49, 1, 953, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 954, DateTimeKind.Local).AddTicks(3970), new DateTime(2023, 2, 18, 21, 49, 1, 953, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3570), new DateTime(2023, 2, 18, 21, 49, 1, 954, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3617), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3620), new DateTime(2023, 2, 18, 21, 49, 1, 955, DateTimeKind.Local).AddTicks(3619) });
        }
    }
}
