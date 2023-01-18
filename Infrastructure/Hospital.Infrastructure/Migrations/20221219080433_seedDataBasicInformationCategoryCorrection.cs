using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedDataBasicInformationCategoryCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "Viewable" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3579), new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3574), true });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "Viewable" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3585), new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3582), true });

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
                columns: new[] { "CreatedDate", "ModifiedDate", "Viewable" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3594), new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3592), true });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "RelatedCategoryId", "Viewable" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3598), new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3596), null, true });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate", "RelatedCategoryId", "Viewable" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3602), new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3600), 5, true });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "Viewable" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7713), new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7709), false });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "Viewable" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7716), new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7714), false });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7719), new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "Viewable" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7721), new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7720), false });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "RelatedCategoryId", "Viewable" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7724), new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7723), 5, false });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate", "RelatedCategoryId", "Viewable" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7727), new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7726), null, false });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 32, 18, 210, DateTimeKind.Local).AddTicks(902), new DateTime(2022, 12, 19, 11, 32, 18, 210, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 32, 18, 210, DateTimeKind.Local).AddTicks(908), new DateTime(2022, 12, 19, 11, 32, 18, 210, DateTimeKind.Local).AddTicks(906) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 32, 18, 210, DateTimeKind.Local).AddTicks(912), new DateTime(2022, 12, 19, 11, 32, 18, 210, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 32, 18, 211, DateTimeKind.Local).AddTicks(8361), new DateTime(2022, 12, 19, 11, 32, 18, 210, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7565), new DateTime(2022, 12, 19, 11, 32, 18, 211, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7686), new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7689), new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7687) });
        }
    }
}
