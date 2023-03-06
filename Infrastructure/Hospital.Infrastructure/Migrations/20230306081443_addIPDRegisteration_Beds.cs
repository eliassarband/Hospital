using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addIPDRegisterationBeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IPDRegisterationRoom_Room_RoomId",
                schema: "Med",
                table: "IPDRegisterationRoom");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                schema: "Med",
                table: "IPDRegisterationRoom",
                newName: "BedId");

            migrationBuilder.RenameIndex(
                name: "IX_IPDRegisterationRoom_RoomId",
                schema: "Med",
                table: "IPDRegisterationRoom",
                newName: "IX_IPDRegisterationRoom_BedId");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3061), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3063), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3067), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3069), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3068) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3072), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3074), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3076), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3078), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3080), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3079) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3021), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3022), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3024), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3025), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3027), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3028), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3029), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3034), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3035), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 129, DateTimeKind.Local).AddTicks(3176), new DateTime(2023, 3, 6, 11, 44, 43, 129, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 129, DateTimeKind.Local).AddTicks(3178), new DateTime(2023, 3, 6, 11, 44, 43, 129, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 129, DateTimeKind.Local).AddTicks(3185), new DateTime(2023, 3, 6, 11, 44, 43, 129, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3098), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3100), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 130, DateTimeKind.Local).AddTicks(3696), new DateTime(2023, 3, 6, 11, 44, 43, 129, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(2903), new DateTime(2023, 3, 6, 11, 44, 43, 130, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(2994), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(2996), new DateTime(2023, 3, 6, 11, 44, 43, 131, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.AddForeignKey(
                name: "FK_IPDRegisterationRoom_Bed_BedId",
                schema: "Med",
                table: "IPDRegisterationRoom",
                column: "BedId",
                principalSchema: "Gnr",
                principalTable: "Bed",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IPDRegisterationRoom_Bed_BedId",
                schema: "Med",
                table: "IPDRegisterationRoom");

            migrationBuilder.RenameColumn(
                name: "BedId",
                schema: "Med",
                table: "IPDRegisterationRoom",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_IPDRegisterationRoom_BedId",
                schema: "Med",
                table: "IPDRegisterationRoom",
                newName: "IX_IPDRegisterationRoom_RoomId");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9613), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9607) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9615), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9617), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9619), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9621), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9622), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9624), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9626), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9628), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9545), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9547), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9548), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9548) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9550), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9549) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9551), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9552), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9551) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9554), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9555), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9556), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 378, DateTimeKind.Local).AddTicks(224), new DateTime(2023, 3, 6, 11, 19, 31, 378, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 378, DateTimeKind.Local).AddTicks(226), new DateTime(2023, 3, 6, 11, 19, 31, 378, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 378, DateTimeKind.Local).AddTicks(228), new DateTime(2023, 3, 6, 11, 19, 31, 378, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9649), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9648) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9651), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(437), new DateTime(2023, 3, 6, 11, 19, 31, 378, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9477), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9526), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9528), new DateTime(2023, 3, 6, 11, 19, 31, 379, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.AddForeignKey(
                name: "FK_IPDRegisterationRoom_Room_RoomId",
                schema: "Med",
                table: "IPDRegisterationRoom",
                column: "RoomId",
                principalSchema: "Gnr",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
