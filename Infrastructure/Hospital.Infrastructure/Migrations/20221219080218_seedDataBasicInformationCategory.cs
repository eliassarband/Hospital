using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedDataBasicInformationCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "ModifiedDate", "ModifiedUser", "Name", "RelatedCategoryId", "Viewable" },
                values: new object[,]
                {
                    { 1, "StaffType", new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7713), "elias.sarband", new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7709), null, "Staff Type", null, false },
                    { 2, "NamePrefix", new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7716), "elias.sarband", new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7714), null, "Name Prefix", null, false },
                    { 3, "Speciality", new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7719), "elias.sarband", new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7717), null, "Speciality", null, true },
                    { 4, "Qualification", new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7721), "elias.sarband", new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7720), null, "Qualification", null, false },
                    { 5, "City", new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7724), "elias.sarband", new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7723), null, "City", 5, false },
                    { 6, "Area", new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7727), "elias.sarband", new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7726), null, "Area", null, false }
                });

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

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "User",
                columns: new[] { "Id", "Active", "AttachmentId", "CreatedDate", "CreatedUser", "Email", "FirstName", "LastName", "ModifiedDate", "ModifiedUser", "Password", "PhoneNumber", "Theme", "Username" },
                values: new object[] { 2, true, null, new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7565), "elias.sarband", "", "Admin", "AccurateCo", new DateTime(2022, 12, 19, 11, 32, 18, 211, DateTimeKind.Local).AddTicks(8385), null, "dW/0ZNtG5T5uIyhEYh0J9Q==", "9125056182", "Light", "accurateco" });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7686), new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "UserRole",
                columns: new[] { "Id", "CreatedDate", "CreatedUser", "ModifiedDate", "ModifiedUser", "RoleId", "UserId" },
                values: new object[] { 2, new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7689), "elias.sarband", new DateTime(2022, 12, 19, 11, 32, 18, 212, DateTimeKind.Local).AddTicks(7687), null, 1, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 18, 11, 34, 53, 137, DateTimeKind.Local).AddTicks(1044), new DateTime(2022, 12, 18, 11, 34, 53, 137, DateTimeKind.Local).AddTicks(993) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 18, 11, 34, 53, 137, DateTimeKind.Local).AddTicks(1047), new DateTime(2022, 12, 18, 11, 34, 53, 137, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 18, 11, 34, 53, 137, DateTimeKind.Local).AddTicks(1050), new DateTime(2022, 12, 18, 11, 34, 53, 137, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 18, 11, 34, 53, 138, DateTimeKind.Local).AddTicks(7478), new DateTime(2022, 12, 18, 11, 34, 53, 137, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 18, 11, 34, 53, 138, DateTimeKind.Local).AddTicks(7528), new DateTime(2022, 12, 18, 11, 34, 53, 138, DateTimeKind.Local).AddTicks(7522) });
        }
    }
}
