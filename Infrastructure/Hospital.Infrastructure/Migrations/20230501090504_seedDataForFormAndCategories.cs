using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedDataForFormAndCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FormCategoryd",
                schema: "Sec",
                table: "Form",
                newName: "Priority");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sec",
                table: "FormCategory",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                schema: "Sec",
                table: "FormCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ShowInDashboard",
                schema: "Sec",
                table: "FormCategory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sec",
                table: "FormAction",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                schema: "Sec",
                table: "FormAction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sec",
                table: "Form",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AddColumn<bool>(
                name: "ShowInMenu",
                schema: "Sec",
                table: "Form",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                schema: "Sec",
                table: "Form",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6726), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6729), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6731), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6733), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6735), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6737), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6740), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6743), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformation",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6745), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6613), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6615), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6617), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6619), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6620), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6622), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6628), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6635), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6643), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6645), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "BasicInformationCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6647), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "FormCategory",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "ModifiedDate", "ModifiedUser", "Name", "Priority", "ShowInDashboard" },
                values: new object[,]
                {
                    { 1, "Dashboards", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6794), null, "Dashboards", 1, false },
                    { 2, "Appointment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6797), null, "Appointment", 2, true },
                    { 3, "OPD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6798), null, "OPD", 3, true },
                    { 4, "IPD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6799), null, "IPD", 4, true },
                    { 5, "EPrecryption", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6800), null, "E-Precryption", 5, true },
                    { 6, "Labratoy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6801), null, "Labratoy", 6, true },
                    { 7, "Pharmacy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6802), null, "Pharmacy", 7, true },
                    { 8, "Financial", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6803), null, "Financial", 8, true },
                    { 9, "HR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6804), null, "Human Resoutces", 9, true },
                    { 10, "Reports", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6805), null, "Reports", 10, true },
                    { 11, "Setting", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6806), null, "Setting", 11, false },
                    { 12, "Security", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6807), null, "Security", 12, false }
                });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 761, DateTimeKind.Local).AddTicks(5654), new DateTime(2023, 5, 1, 12, 35, 3, 761, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 761, DateTimeKind.Local).AddTicks(5657), new DateTime(2023, 5, 1, 12, 35, 3, 761, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 761, DateTimeKind.Local).AddTicks(5658), new DateTime(2023, 5, 1, 12, 35, 3, 761, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6767), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6769), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                schema: "Gnr",
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6770), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 762, DateTimeKind.Local).AddTicks(6943), new DateTime(2023, 5, 1, 12, 35, 3, 761, DateTimeKind.Local).AddTicks(5783) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6495), new DateTime(2023, 5, 1, 12, 35, 3, 762, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6585), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                schema: "Sec",
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6586) });

            migrationBuilder.InsertData(
                schema: "Sec",
                table: "Form",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Description", "FormCategoryId", "ModifiedDate", "ModifiedUser", "Name", "Priority", "ShowInMenu", "Url" },
                values: new object[,]
                {
                    { 101, "Desktop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6829), null, "Main Dashboard", 1, true, "Desktop" },
                    { 102, "Appointment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6833), null, "Appointment", 2, true, "AppointmentDashboard" },
                    { 103, "OPD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6835), null, "OPD", 3, true, "OPDDashboard" },
                    { 104, "IPD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6836), null, "IPD", 4, true, "IPDDashboard" },
                    { 105, "EPrecryption", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6837), null, "E-Precryption", 5, true, "EPrecryptionDashboard" },
                    { 106, "Labratoy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6838), null, "Labratoy", 6, true, "LabratoyDashboard" },
                    { 107, "Pharmacy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6839), null, "Pharmacy", 7, true, "PharmacyDashboard" },
                    { 108, "Financial", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6841), null, "Financial", 8, true, "FinancialDashboard" },
                    { 109, "HR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6842), null, "Human Resources", 9, true, "HRDashboard" },
                    { 110, "Reports", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6843), null, "Reports", 10, true, "ReportsDashboard" },
                    { 301, "Patients", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 3, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6844), null, "Patinet List", 1, true, "Patients" },
                    { 302, "PatinetDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 3, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6845), null, "Patinet Define", 2, false, "PatinetDefine" },
                    { 303, "OPDBills", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 3, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6846), null, "OPD Billing List", 3, true, "OPDBills" },
                    { 304, "OPDBillDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 3, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6847), null, "OPD Billing Define", 4, true, "OPDBillDefine" },
                    { 305, "OPDBillPayments", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 3, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6849), null, "OPD Billing Payment", 5, false, "OPDBillPayments" },
                    { 306, "DebtorOPDBills", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 3, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6850), null, "Receive Balance Payment", 6, true, "DebtorOPDBills" },
                    { 401, "Patients", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 4, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6851), null, "Patinet List", 1, true, "Patients" },
                    { 402, "PatinetDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 4, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6852), null, "Patinet Define", 2, false, "PatinetDefine" },
                    { 403, "IPDRegisterations", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 4, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6855), null, "Admited Patinet List", 3, true, "IPDRegisterations" },
                    { 404, "IPDRegisterationDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 4, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6856), null, "IPD Registeration", 1, true, "IPDRegisterationDefine" },
                    { 1001, "ReportTemplates", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 10, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6857), null, "Report Template List", 1, true, "ReportTemplates" },
                    { 1002, "ReportTemplateDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 10, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6858), null, "Report Template Define", 2, false, "ReportTemplateDefine" },
                    { 1003, "ReportTemplateDesign", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 10, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6859), null, "Report Template Design", 3, false, "ReportTemplateDesign" },
                    { 1004, "ReportShow", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 10, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6860), null, "Report Show", 4, false, "ReportShow" },
                    { 1101, "HospitalInformation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6861), null, "Hospital Information", 1, true, "HospitalInformation" },
                    { 1102, "Departments", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6863), null, "Department List", 2, true, "Departments" },
                    { 1103, "DepartmentDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6864), null, "Department Define", 3, false, "DepartmentDefine" },
                    { 1104, "Services", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6865), null, "Service List", 4, true, "Services" },
                    { 1105, "ServiceDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6866), null, "Service Define", 5, false, "ServiceDefine" },
                    { 1106, "Consultants", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6887), null, "Consultant List", 6, true, "Consultants" },
                    { 1107, "ConsultantDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6888), null, "Consultant Define", 7, false, "ConsultantDefine" },
                    { 1108, "ConsultantTimings", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6890), null, "Consultant Timing List", 8, true, "ConsultantTimings" },
                    { 1109, "ConsultantTimingDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6891), null, "Consultant Timing Define", 9, false, "ConsultantTimingDefine" },
                    { 1110, "RefferBies", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6892), null, "Reffer By List", 10, true, "RefferBies" },
                    { 1111, "RefferByDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6895), null, "Reffer By Define", 11, false, "RefferByDefine" },
                    { 1112, "Medicines", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6896), null, "Medicine List", 12, true, "Medicines" },
                    { 1113, "MedicineDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6897), null, "Medicine Define", 13, false, "MedicineDefine" },
                    { 1114, "RoomTypes", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6898), null, "Room Type List", 14, true, "RoomTypes" },
                    { 1115, "RoomTypeDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6899), null, "Room Type Define", 15, false, "RoomTypeDefine" },
                    { 1116, "Rooms", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6900), null, "Room List", 16, true, "Rooms" },
                    { 1117, "RoomDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6902), null, "Room Define", 17, false, "RoomDefine" },
                    { 1118, "Beds", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6903), null, "Bed List", 18, true, "Beds" },
                    { 1119, "BedDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6904), null, "Bed Define", 19, false, "BedDefine" },
                    { 1120, "Insurances", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6905), null, "Insurance List", 20, true, "Insurances" },
                    { 1121, "InsuranceDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6906), null, "Insurance Define", 21, false, "InsuranceDefine" },
                    { 1122, "InsuranceAgreements", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6907), null, "InsuranceAgreement List", 22, true, "InsuranceAgreements" },
                    { 1123, "InsuranceAgreementDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6908), null, "Insurance Agreement Define", 23, false, "InsuranceAgreementDefine" },
                    { 1124, "Cities", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6909), null, "City List", 24, true, "BasicInformations/City" },
                    { 1125, "CityDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6911), null, "City Define", 25, false, "CityDefine" },
                    { 1126, "Areas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6912), null, "Area List", 26, true, "BasicInformations/Area" },
                    { 1127, "AreaDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6913), null, "Area Define", 27, false, "AreaDefine" },
                    { 1128, "BasicInformationCategories", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6914), null, "Basic Information Category List", 28, true, "BasicInformationCategories" },
                    { 1129, "BasicInformationCategoryDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6915), null, "Basic Information Category Define", 29, false, "BasicInformationCategoryDefine" },
                    { 1130, "BasicInformations", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6916), null, "Basic Information List", 30, true, "BasicInformations" },
                    { 1131, "BasicInformationDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6917), null, "Basic Information Define", 31, false, "BasicInformationDefine" },
                    { 1132, "Settings", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 11, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6918), null, "Setting", 32, true, "Settings" },
                    { 1201, "Users", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 12, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6920), null, "User List", 1, true, "Users" },
                    { 1202, "UserDefine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 12, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6921), null, "User Define", 2, false, "UserDefine" },
                    { 1203, "ChangePassword", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 12, new DateTime(2023, 5, 1, 12, 35, 3, 763, DateTimeKind.Local).AddTicks(6922), null, "Change Password", 3, true, "ChangePassword" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "Form",
                keyColumn: "Id",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Sec",
                table: "FormCategory",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "Priority",
                schema: "Sec",
                table: "FormCategory");

            migrationBuilder.DropColumn(
                name: "ShowInDashboard",
                schema: "Sec",
                table: "FormCategory");

            migrationBuilder.DropColumn(
                name: "Priority",
                schema: "Sec",
                table: "FormAction");

            migrationBuilder.DropColumn(
                name: "ShowInMenu",
                schema: "Sec",
                table: "Form");

            migrationBuilder.DropColumn(
                name: "Url",
                schema: "Sec",
                table: "Form");

            migrationBuilder.RenameColumn(
                name: "Priority",
                schema: "Sec",
                table: "Form",
                newName: "FormCategoryd");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sec",
                table: "FormCategory",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sec",
                table: "FormAction",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sec",
                table: "Form",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

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
        }
    }
}
