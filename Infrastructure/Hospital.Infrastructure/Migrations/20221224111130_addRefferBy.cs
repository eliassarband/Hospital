using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addRefferBy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RefferBy",
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
                    Address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    OPDPercent = table.Column<int>(type: "int", nullable: true),
                    IPDPercent = table.Column<int>(type: "int", nullable: true),
                    OPDAmount = table.Column<int>(type: "int", nullable: true),
                    IPDAmount = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefferBy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefferBy_BasicInformation_AreaId",
                        column: x => x.AreaId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RefferBy_BasicInformation_CityId",
                        column: x => x.CityId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RefferBy_BasicInformation_NamePrefixId",
                        column: x => x.NamePrefixId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RefferBy_BasicInformation_QualificationId",
                        column: x => x.QualificationId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RefferBy_BasicInformation_SpecialityId",
                        column: x => x.SpecialityId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RefferBy_BasicInformation_StaffTypeId",
                        column: x => x.StaffTypeId,
                        principalSchema: "Gnr",
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9133), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9137), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9140), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9143), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9146), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9149), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9152), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9097), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9100), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9102), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9105), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9108), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9113), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 505, DateTimeKind.Local).AddTicks(8293), new DateTime(2022, 12, 24, 14, 41, 30, 505, DateTimeKind.Local).AddTicks(8239) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 505, DateTimeKind.Local).AddTicks(8297), new DateTime(2022, 12, 24, 14, 41, 30, 505, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 505, DateTimeKind.Local).AddTicks(8300), new DateTime(2022, 12, 24, 14, 41, 30, 505, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(182), new DateTime(2022, 12, 24, 14, 41, 30, 505, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9072), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9075), new DateTime(2022, 12, 24, 14, 41, 30, 507, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.CreateIndex(
                name: "IX_RefferBy_AreaId",
                schema: "Med",
                table: "RefferBy",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_RefferBy_CityId",
                schema: "Med",
                table: "RefferBy",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_RefferBy_NamePrefixId",
                schema: "Med",
                table: "RefferBy",
                column: "NamePrefixId");

            migrationBuilder.CreateIndex(
                name: "IX_RefferBy_QualificationId",
                schema: "Med",
                table: "RefferBy",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_RefferBy_SpecialityId",
                schema: "Med",
                table: "RefferBy",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_RefferBy_StaffTypeId",
                schema: "Med",
                table: "RefferBy",
                column: "StaffTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefferBy",
                schema: "Med");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3257), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3264), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3270), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3275), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3281), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3287), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3293), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3187), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3193), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3198), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3203), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3209), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3214), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3219), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 224, DateTimeKind.Local).AddTicks(3962), new DateTime(2022, 12, 24, 13, 39, 46, 224, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 224, DateTimeKind.Local).AddTicks(3966), new DateTime(2022, 12, 24, 13, 39, 46, 224, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 224, DateTimeKind.Local).AddTicks(3970), new DateTime(2022, 12, 24, 13, 39, 46, 224, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 226, DateTimeKind.Local).AddTicks(4342), new DateTime(2022, 12, 24, 13, 39, 46, 224, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3030), new DateTime(2022, 12, 24, 13, 39, 46, 226, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3148), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3154), new DateTime(2022, 12, 24, 13, 39, 46, 228, DateTimeKind.Local).AddTicks(3151) });
        }
    }
}
