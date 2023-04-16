using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addPrintCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrintCount",
                schema: "Med",
                table: "OPDBill",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OPDBillId",
                schema: "Med",
                table: "IPDRegisteration",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrintCount",
                schema: "Med",
                table: "IPDRegisteration",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7477), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7480), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7482), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7484), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7486), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7488), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7487) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7490), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7493), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7495), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7435), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7437), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7438), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7440), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7439) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7442), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7443), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7445), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7444) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7447), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7448), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7450), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7452), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 535, DateTimeKind.Local).AddTicks(8566), new DateTime(2023, 3, 12, 8, 50, 48, 535, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 535, DateTimeKind.Local).AddTicks(8569), new DateTime(2023, 3, 12, 8, 50, 48, 535, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 535, DateTimeKind.Local).AddTicks(8571), new DateTime(2023, 3, 12, 8, 50, 48, 535, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7516), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7518), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7519), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 536, DateTimeKind.Local).AddTicks(8460), new DateTime(2023, 3, 12, 8, 50, 48, 535, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7282), new DateTime(2023, 3, 12, 8, 50, 48, 536, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7337), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7340), new DateTime(2023, 3, 12, 8, 50, 48, 537, DateTimeKind.Local).AddTicks(7339) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrintCount",
                schema: "Med",
                table: "OPDBill");

            migrationBuilder.DropColumn(
                name: "OPDBillId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropColumn(
                name: "PrintCount",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8608), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8610), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8612), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8614), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8616), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8618), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8620), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8622), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8623), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8506), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8508), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8507) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8509), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8569), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8570), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8572), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8573), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8573) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8575), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8576), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8579), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8580), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 279, DateTimeKind.Local).AddTicks(9279), new DateTime(2023, 3, 11, 15, 4, 45, 279, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 279, DateTimeKind.Local).AddTicks(9282), new DateTime(2023, 3, 11, 15, 4, 45, 279, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 279, DateTimeKind.Local).AddTicks(9283), new DateTime(2023, 3, 11, 15, 4, 45, 279, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8642), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8644), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8645), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 280, DateTimeKind.Local).AddTicks(9429), new DateTime(2023, 3, 11, 15, 4, 45, 279, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8427), new DateTime(2023, 3, 11, 15, 4, 45, 280, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8481), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8483), new DateTime(2023, 3, 11, 15, 4, 45, 281, DateTimeKind.Local).AddTicks(8482) });
        }
    }
}
