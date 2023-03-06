using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IPDRegisterationNewFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Agreement",
                schema: "Med",
                table: "IPDRegisteration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BedId",
                schema: "Med",
                table: "IPDRegisteration",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CaseTypeId",
                schema: "Med",
                table: "IPDRegisteration",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConsultantInchargeId",
                schema: "Med",
                table: "IPDRegisteration",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                schema: "Med",
                table: "IPDRegisteration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RelationshipId",
                schema: "Med",
                table: "IPDRegisteration",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                schema: "Med",
                table: "IPDRegisteration",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomTypeId",
                schema: "Med",
                table: "IPDRegisteration",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondConsultantId",
                schema: "Med",
                table: "IPDRegisteration",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThirdConsultantId",
                schema: "Med",
                table: "IPDRegisteration",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WardId",
                schema: "Med",
                table: "IPDRegisteration",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WitnessName",
                schema: "Med",
                table: "IPDRegisteration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8047), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8049), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8051), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8053), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8055), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8057), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8056) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8059), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8061), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8063), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8003), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8005), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8007), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8006) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8008), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8008) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8010), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8011), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8013), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8012) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8014), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8015), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8018), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8017) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8019), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 597, DateTimeKind.Local).AddTicks(8192), new DateTime(2023, 3, 6, 15, 9, 43, 597, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 597, DateTimeKind.Local).AddTicks(8195), new DateTime(2023, 3, 6, 15, 9, 43, 597, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 597, DateTimeKind.Local).AddTicks(8197), new DateTime(2023, 3, 6, 15, 9, 43, 597, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8095), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8097), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8098), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(8097) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 598, DateTimeKind.Local).AddTicks(8678), new DateTime(2023, 3, 6, 15, 9, 43, 597, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(7889), new DateTime(2023, 3, 6, 15, 9, 43, 598, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(7970), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(7972), new DateTime(2023, 3, 6, 15, 9, 43, 599, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisteration_BedId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "BedId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisteration_CaseTypeId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "CaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisteration_ConsultantInchargeId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "ConsultantInchargeId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisteration_RelationshipId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "RelationshipId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisteration_RoomId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisteration_RoomTypeId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisteration_SecondConsultantId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "SecondConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisteration_ThirdConsultantId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "ThirdConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDRegisteration_WardId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "WardId");

            migrationBuilder.AddForeignKey(
                name: "FK_IPDRegisteration_BasicInformation_CaseTypeId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "CaseTypeId",
                principalSchema: "Gnr",
                principalTable: "BasicInformation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IPDRegisteration_BasicInformation_RelationshipId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "RelationshipId",
                principalSchema: "Gnr",
                principalTable: "BasicInformation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IPDRegisteration_BasicInformation_WardId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "WardId",
                principalSchema: "Gnr",
                principalTable: "BasicInformation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IPDRegisteration_Bed_BedId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "BedId",
                principalSchema: "Gnr",
                principalTable: "Bed",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IPDRegisteration_RoomType_RoomTypeId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "RoomTypeId",
                principalSchema: "Gnr",
                principalTable: "RoomType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IPDRegisteration_Room_RoomId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "RoomId",
                principalSchema: "Gnr",
                principalTable: "Room",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IPDRegisteration_Staff_ConsultantInchargeId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "ConsultantInchargeId",
                principalSchema: "Med",
                principalTable: "Staff",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IPDRegisteration_Staff_SecondConsultantId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "SecondConsultantId",
                principalSchema: "Med",
                principalTable: "Staff",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IPDRegisteration_Staff_ThirdConsultantId",
                schema: "Med",
                table: "IPDRegisteration",
                column: "ThirdConsultantId",
                principalSchema: "Med",
                principalTable: "Staff",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IPDRegisteration_BasicInformation_CaseTypeId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropForeignKey(
                name: "FK_IPDRegisteration_BasicInformation_RelationshipId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropForeignKey(
                name: "FK_IPDRegisteration_BasicInformation_WardId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropForeignKey(
                name: "FK_IPDRegisteration_Bed_BedId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropForeignKey(
                name: "FK_IPDRegisteration_RoomType_RoomTypeId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropForeignKey(
                name: "FK_IPDRegisteration_Room_RoomId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropForeignKey(
                name: "FK_IPDRegisteration_Staff_ConsultantInchargeId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropForeignKey(
                name: "FK_IPDRegisteration_Staff_SecondConsultantId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropForeignKey(
                name: "FK_IPDRegisteration_Staff_ThirdConsultantId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropIndex(
                name: "IX_IPDRegisteration_BedId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropIndex(
                name: "IX_IPDRegisteration_CaseTypeId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropIndex(
                name: "IX_IPDRegisteration_ConsultantInchargeId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropIndex(
                name: "IX_IPDRegisteration_RelationshipId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropIndex(
                name: "IX_IPDRegisteration_RoomId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropIndex(
                name: "IX_IPDRegisteration_RoomTypeId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropIndex(
                name: "IX_IPDRegisteration_SecondConsultantId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropIndex(
                name: "IX_IPDRegisteration_ThirdConsultantId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropIndex(
                name: "IX_IPDRegisteration_WardId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropColumn(
                name: "Agreement",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropColumn(
                name: "BedId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropColumn(
                name: "CaseTypeId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropColumn(
                name: "ConsultantInchargeId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropColumn(
                name: "Details",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropColumn(
                name: "RelationshipId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropColumn(
                name: "RoomId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropColumn(
                name: "RoomTypeId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropColumn(
                name: "SecondConsultantId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropColumn(
                name: "ThirdConsultantId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropColumn(
                name: "WardId",
                schema: "Med",
                table: "IPDRegisteration");

            migrationBuilder.DropColumn(
                name: "WitnessName",
                schema: "Med",
                table: "IPDRegisteration");

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

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6471), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6473), new DateTime(2023, 3, 6, 12, 13, 45, 841, DateTimeKind.Local).AddTicks(6472) });

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
    }
}
