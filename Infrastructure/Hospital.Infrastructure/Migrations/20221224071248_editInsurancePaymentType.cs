using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editInsurancePaymentType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Gnr",
                table: "BasicInformation",
                columns: new[] { "Id", "Active", "AllowChange", "AllowDelete", "CategoryId", "Code", "CreatedDate", "CreatedUser", "IsDeleted", "ModifiedDate", "ModifiedUser", "Name", "Priority", "RelatedBasicInformationId", "StrCode" },
                values: new object[,]
                {
                    { 701, true, false, false, 7, 1, new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4413), "elias.sarband", false, new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4408), null, "Cash", 1, null, "Cash" },
                    { 702, true, false, false, 7, 2, new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4419), "elias.sarband", false, new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4415), null, "Credit", 2, null, "Credit" }
                });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4359), new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4363), new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4367), new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4370), new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4374), new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4378), new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate", "Viewable" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4383), new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4380), false });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 672, DateTimeKind.Local).AddTicks(7923), new DateTime(2022, 12, 24, 10, 42, 47, 672, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 672, DateTimeKind.Local).AddTicks(7929), new DateTime(2022, 12, 24, 10, 42, 47, 672, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 672, DateTimeKind.Local).AddTicks(7933), new DateTime(2022, 12, 24, 10, 42, 47, 672, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 674, DateTimeKind.Local).AddTicks(2207), new DateTime(2022, 12, 24, 10, 42, 47, 672, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4129), new DateTime(2022, 12, 24, 10, 42, 47, 674, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4323), new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4328), new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4326) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702);

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
                columns: new[] { "CreatedDate", "ModifiedDate", "Viewable" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1042), new DateTime(2022, 12, 19, 13, 0, 26, 160, DateTimeKind.Local).AddTicks(1040), true });

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
        }
    }
}
