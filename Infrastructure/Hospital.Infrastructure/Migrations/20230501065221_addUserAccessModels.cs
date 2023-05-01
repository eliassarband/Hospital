using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addUserAccessModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormCategory",
                schema: "Sec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                schema: "Sec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Form",
                schema: "Sec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormCategoryd = table.Column<int>(type: "int", nullable: false),
                    FormCategoryId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Form_FormCategory_FormCategoryId",
                        column: x => x.FormCategoryId,
                        principalSchema: "Sec",
                        principalTable: "FormCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupUser",
                schema: "Sec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupUser_Group_GroupId",
                        column: x => x.GroupId,
                        principalSchema: "Sec",
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupUser_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Sec",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormAccess",
                schema: "Sec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormAccess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormAccess_Form_FormId",
                        column: x => x.FormId,
                        principalSchema: "Sec",
                        principalTable: "Form",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormAccess_Group_GroupId",
                        column: x => x.GroupId,
                        principalSchema: "Sec",
                        principalTable: "Group",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormAccess_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Sec",
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FormAction",
                schema: "Sec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormAction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormAction_Form_FormId",
                        column: x => x.FormId,
                        principalSchema: "Sec",
                        principalTable: "Form",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormActionAccess",
                schema: "Sec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    FormActionId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormActionAccess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormActionAccess_FormAction_FormActionId",
                        column: x => x.FormActionId,
                        principalSchema: "Sec",
                        principalTable: "FormAction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormActionAccess_Group_GroupId",
                        column: x => x.GroupId,
                        principalSchema: "Sec",
                        principalTable: "Group",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormActionAccess_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Sec",
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7035), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7038), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7040), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7042), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7041) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7045), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7047), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7049), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7051), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7053), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6950), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6953), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6951) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6954), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6956), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6955) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6958), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6959), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6958) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6967), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6973), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6995), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6997), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6998), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 190, DateTimeKind.Local).AddTicks(2756), new DateTime(2023, 5, 1, 10, 22, 20, 190, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 190, DateTimeKind.Local).AddTicks(2759), new DateTime(2023, 5, 1, 10, 22, 20, 190, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 190, DateTimeKind.Local).AddTicks(2761), new DateTime(2023, 5, 1, 10, 22, 20, 190, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7078), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7080), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7082), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 191, DateTimeKind.Local).AddTicks(5877), new DateTime(2023, 5, 1, 10, 22, 20, 190, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6811), new DateTime(2023, 5, 1, 10, 22, 20, 191, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6913), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6915), new DateTime(2023, 5, 1, 10, 22, 20, 192, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.CreateIndex(
                name: "IX_Form_FormCategoryId",
                schema: "Sec",
                table: "Form",
                column: "FormCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FormAccess_FormId",
                schema: "Sec",
                table: "FormAccess",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormAccess_GroupId",
                schema: "Sec",
                table: "FormAccess",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_FormAccess_UserId",
                schema: "Sec",
                table: "FormAccess",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormAction_FormId",
                schema: "Sec",
                table: "FormAction",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormActionAccess_FormActionId",
                schema: "Sec",
                table: "FormActionAccess",
                column: "FormActionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormActionAccess_GroupId",
                schema: "Sec",
                table: "FormActionAccess",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_FormActionAccess_UserId",
                schema: "Sec",
                table: "FormActionAccess",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupUser_GroupId",
                schema: "Sec",
                table: "GroupUser",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupUser_UserId",
                schema: "Sec",
                table: "GroupUser",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormAccess",
                schema: "Sec");

            migrationBuilder.DropTable(
                name: "FormActionAccess",
                schema: "Sec");

            migrationBuilder.DropTable(
                name: "GroupUser",
                schema: "Sec");

            migrationBuilder.DropTable(
                name: "FormAction",
                schema: "Sec");

            migrationBuilder.DropTable(
                name: "Group",
                schema: "Sec");

            migrationBuilder.DropTable(
                name: "Form",
                schema: "Sec");

            migrationBuilder.DropTable(
                name: "FormCategory",
                schema: "Sec");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4018), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4020), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4024), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4026), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4028), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4030), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4032), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4034), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4036), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3977), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3979), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3982), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3981) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3983), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3985), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3987), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3989), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3990), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3991), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3993), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 288, DateTimeKind.Local).AddTicks(7334), new DateTime(2023, 4, 18, 14, 42, 5, 288, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 288, DateTimeKind.Local).AddTicks(7357), new DateTime(2023, 4, 18, 14, 42, 5, 288, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 288, DateTimeKind.Local).AddTicks(7374), new DateTime(2023, 4, 18, 14, 42, 5, 288, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4053), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4055), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4056), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 290, DateTimeKind.Local).AddTicks(2268), new DateTime(2023, 4, 18, 14, 42, 5, 288, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3854), new DateTime(2023, 4, 18, 14, 42, 5, 290, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3951), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3953), new DateTime(2023, 4, 18, 14, 42, 5, 291, DateTimeKind.Local).AddTicks(3952) });
        }
    }
}
