using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addStaff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staff",
                schema: "Med",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffTypeId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NamePrefixId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DateOfJoining = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SpecialityId = table.Column<int>(type: "int", nullable: true),
                    QualificationId = table.Column<int>(type: "int", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    AreaId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    OPDChargePercent = table.Column<int>(type: "int", nullable: false),
                    IPDChargePercent = table.Column<int>(type: "int", nullable: false),
                    NightOPDChargePercent = table.Column<int>(type: "int", nullable: false),
                    NightIPDChargePercent = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_BasicInformation_AreaId",
                        column: x => x.AreaId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_BasicInformation_CityId",
                        column: x => x.CityId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_BasicInformation_NamePrefixId",
                        column: x => x.NamePrefixId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_BasicInformation_QualificationId",
                        column: x => x.QualificationId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_BasicInformation_SpecialityId",
                        column: x => x.SpecialityId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_BasicInformation_StaffTypeId",
                        column: x => x.StaffTypeId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StaffTiming",
                schema: "Med",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    WeekDayNo = table.Column<int>(type: "int", nullable: false),
                    WeekDayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffTiming", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffTiming_Staff_StaffId",
                        column: x => x.StaffId,
                        principalSchema: "Med",
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5928), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5931), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.InsertData(
                schema: "Gnr",
                table: "BasicInformation",
                columns: new[] { "Id", "Active", "AllowChange", "AllowDelete", "CategoryId", "Code", "CreatedDate", "CreatedUser", "IsDeleted", "ModifiedDate", "ModifiedUser", "Name", "Priority", "RelatedBasicInformationId", "StrCode" },
                values: new object[,]
                {
                    { 101, true, false, false, 1, 1, new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5910), "elias.sarband", false, new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5906), null, "Doctor", 1, null, "Doctor" },
                    { 102, true, false, false, 1, 2, new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5914), "elias.sarband", false, new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5912), null, "Nurse", 2, null, "Nurse" },
                    { 103, true, false, false, 1, 3, new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5918), "elias.sarband", false, new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5916), null, "Staff", 3, null, "Staff" },
                    { 201, true, false, false, 2, 1, new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5921), "elias.sarband", false, new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5919), null, "Mr", 1, null, "Mr" },
                    { 202, true, false, false, 2, 2, new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5924), "elias.sarband", false, new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5922), null, "Mrs", 2, null, "Mrs" }
                });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5870), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5873), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5876), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5879), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5877) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5882), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5886), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5889), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 367, DateTimeKind.Local).AddTicks(6928), new DateTime(2022, 12, 24, 12, 2, 21, 367, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 367, DateTimeKind.Local).AddTicks(6989), new DateTime(2022, 12, 24, 12, 2, 21, 367, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 367, DateTimeKind.Local).AddTicks(6992), new DateTime(2022, 12, 24, 12, 2, 21, 367, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 368, DateTimeKind.Local).AddTicks(6933), new DateTime(2022, 12, 24, 12, 2, 21, 367, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5801), new DateTime(2022, 12, 24, 12, 2, 21, 368, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5847), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 12, 24, 12, 2, 21, 369, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.CreateIndex(
                name: "IX_Staff_AreaId",
                schema: "Med",
                table: "Staff",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_CityId",
                schema: "Med",
                table: "Staff",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_NamePrefixId",
                schema: "Med",
                table: "Staff",
                column: "NamePrefixId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_QualificationId",
                schema: "Med",
                table: "Staff",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_SpecialityId",
                schema: "Med",
                table: "Staff",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_StaffTypeId",
                schema: "Med",
                table: "Staff",
                column: "StaffTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffTiming_StaffId",
                schema: "Med",
                table: "StaffTiming",
                column: "StaffId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffTiming",
                schema: "Med");

            migrationBuilder.DropTable(
                name: "Staff",
                schema: "Med");

            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4413), new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4419), new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4415) });

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4383), new DateTime(2022, 12, 24, 10, 42, 47, 675, DateTimeKind.Local).AddTicks(4380) });

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
    }
}
