using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class basicInformationSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6500), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6502), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6504), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6503) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6506), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6508), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6507) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6511), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6513), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6515), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6458), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6460), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6462), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6463), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6464), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6463) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6466), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6465) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6467), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6468), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6469), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.InsertData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "ModifiedDate", "ModifiedUser", "Name", "RelatedCategoryId", "Viewable" },
                values: new object[,]
                {
                    { 10, "CaseType", new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6471), "elias.sarband", new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6471), null, "Case Type", null, true },
                    { 11, "Relationship", new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6473), "elias.sarband", new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6472), null, "Relationship", null, true }
                });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 839, DateTimeKind.Local).AddTicks(7183), new DateTime(2023, 3, 6, 12, 13, 45, 839, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 839, DateTimeKind.Local).AddTicks(7185), new DateTime(2023, 3, 6, 12, 13, 45, 839, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 839, DateTimeKind.Local).AddTicks(7187), new DateTime(2023, 3, 6, 12, 13, 45, 839, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6533), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6534), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6535), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 840, DateTimeKind.Local).AddTicks(7343), new DateTime(2023, 3, 6, 12, 13, 45, 839, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6387), new DateTime(2023, 3, 6, 12, 13, 45, 840, DateTimeKind.Local).AddTicks(7346) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6435), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6434) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6438), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6437) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9659), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9663), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9664), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9666), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9668), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9670), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9672), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9674), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9676), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9617), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9619), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9620), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9622), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9623), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9625), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9628), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9635), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9637), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 252, DateTimeKind.Local).AddTicks(9598), new DateTime(2023, 3, 6, 12, 11, 33, 252, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 252, DateTimeKind.Local).AddTicks(9601), new DateTime(2023, 3, 6, 12, 11, 33, 252, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 252, DateTimeKind.Local).AddTicks(9602), new DateTime(2023, 3, 6, 12, 11, 33, 252, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9697), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9699), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9700), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(141), new DateTime(2023, 3, 6, 12, 11, 33, 252, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9543), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9594), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9593) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9595), new DateTime(2023, 3, 6, 12, 11, 33, 254, DateTimeKind.Local).AddTicks(9595) });
        }
    }
}
