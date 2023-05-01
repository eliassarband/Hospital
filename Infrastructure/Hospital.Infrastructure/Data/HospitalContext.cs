using Hospital.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Hospital.Domain.Core.Helpers;

namespace Hospital.Infrastructure.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>().HasData(
                new Role() { Id = 1, Code = "Super", Name = "Super Admin", Description = "", CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                new Role() { Id = 2, Code = "User", Name = "User", Description = "", CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" }
            );

            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, FirstName = "Elias", LastName = "Sarband", Username = "elias.sarband", Password = CryptographyHelper.Encrypt("Elias 8831"), Email = "elias.sarband@gmail.com", PhoneNumber = "9125056182", Active = true, Theme = "Light", CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                new User() { Id = 2, FirstName = "Admin", LastName = "AccurateCo", Username = "accurateco", Password = CryptographyHelper.Encrypt("af1401"), Email = "", PhoneNumber = "9125056182", Active = true, Theme = "Light", CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" }
            );

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole() { Id = 1, UserId = 1, RoleId = 1, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                new UserRole() { Id = 2, UserId = 2, RoleId = 1, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" }
            );

            modelBuilder.Entity<BasicInformationCategory>().HasData(
                new BasicInformationCategory() { Id = 1, Code = "StaffType", Name = "Staff Type", Viewable = true, RelatedCategoryId = null, CreatedDate = DateTime.Now, CreatedUser="elias.sarband" },
                new BasicInformationCategory() { Id = 2, Code = "NamePrefix", Name = "Name Prefix", Viewable = true, RelatedCategoryId = null, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                new BasicInformationCategory() { Id = 3, Code = "Speciality", Name = "Speciality", Viewable = true, RelatedCategoryId = null, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                new BasicInformationCategory() { Id = 4, Code = "Qualification", Name = "Qualification", Viewable = true, RelatedCategoryId = null, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                new BasicInformationCategory() { Id = 5, Code = "City", Name = "City", Viewable = true, RelatedCategoryId = null, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                new BasicInformationCategory() { Id = 6, Code = "Area", Name = "Area", Viewable = true, RelatedCategoryId = 5, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                new BasicInformationCategory() { Id = 7, Code = "PaymentType", Name = "Payment Type", Viewable = false, RelatedCategoryId = null, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                new BasicInformationCategory() { Id = 8, Code = "Gender", Name = "Gender", Viewable = true, RelatedCategoryId = null, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                new BasicInformationCategory() { Id = 9, Code = "Ward", Name = "Ward", Viewable = true, RelatedCategoryId = null, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                new BasicInformationCategory() { Id = 10, Code = "CaseType", Name = "Case Type", Viewable = true, RelatedCategoryId = null, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                new BasicInformationCategory() { Id = 11, Code = "Relationship", Name = "Relationship", Viewable = true, RelatedCategoryId = null, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" }
            );

            modelBuilder.Entity<BasicInformation>().HasData(
                new BasicInformation() { Id = 101, Code = 1, StrCode = "Doctor", Name = "Doctor", CategoryId = 1, Priority = 1, RelatedBasicInformationId = null, Active = true, IsDeleted = false, AllowChange = false, AllowDelete = false, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                  new BasicInformation() { Id = 102, Code = 2, StrCode = "Nurse", Name = "Nurse", CategoryId = 1, Priority = 2, RelatedBasicInformationId = null, Active = true, IsDeleted = false, AllowChange = false, AllowDelete = false, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                  new BasicInformation() { Id = 103, Code = 3, StrCode = "Staff", Name = "Staff", CategoryId = 1, Priority = 3, RelatedBasicInformationId = null, Active = true, IsDeleted = false, AllowChange = false, AllowDelete = false, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },

                  new BasicInformation() { Id = 201, Code = 1, StrCode = "Mr", Name = "Mr", CategoryId = 2, Priority = 1, RelatedBasicInformationId = null, Active = true, IsDeleted = false, AllowChange = false, AllowDelete = false, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                  new BasicInformation() { Id = 202, Code = 2, StrCode = "Mrs", Name = "Mrs", CategoryId = 2, Priority = 2, RelatedBasicInformationId = null, Active = true, IsDeleted = false, AllowChange = false, AllowDelete = false, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },

                 new BasicInformation() { Id = 701, Code = 1, StrCode = "Cash", Name = "Cash", CategoryId = 7, Priority = 1, RelatedBasicInformationId = null, Active = true, IsDeleted = false, AllowChange = false, AllowDelete = false, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                  new BasicInformation() { Id = 702, Code = 2, StrCode = "Credit", Name = "Credit", CategoryId = 7, Priority = 2, RelatedBasicInformationId = null, Active = true, IsDeleted = false, AllowChange = false, AllowDelete = false, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },

                  new BasicInformation() { Id = 801, Code = 1, StrCode = "Male", Name = "Male", CategoryId = 8, Priority = 1, RelatedBasicInformationId = null, Active = true, IsDeleted = false, AllowChange = false, AllowDelete = false, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                  new BasicInformation() { Id = 802, Code = 2, StrCode = "Female", Name = "Female", CategoryId = 8, Priority = 2, RelatedBasicInformationId = null, Active = true, IsDeleted = false, AllowChange = false, AllowDelete = false, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" }
            );

            modelBuilder.Entity<Setting>().HasData(
                new Setting() { Id = 1, Name = "Patient Identifier Prefix", Key = "PatientIdPrefix", Value="P", CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                new Setting() { Id = 2, Name = "OPD Receipt Identifier Prefix", Key = "OPDReceiptNoPrefix", Value = "OP", CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                new Setting() { Id = 3, Name = "IPD No Prefix", Key = "IPDNoPrefix", Value = "IP", CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" }
            );

			modelBuilder.Entity<FormCategory>().HasData(
				new FormCategory() { Id = 1, Code = "Dashboards", Name = "Dashboards", ShowInDashboard = false, Priority = 1},
				new FormCategory() { Id = 2, Code = "Appointment", Name = "Appointment", ShowInDashboard = true, Priority = 2 },
				new FormCategory() { Id = 3, Code = "OPD", Name = "OPD", ShowInDashboard = true, Priority = 3 },
				new FormCategory() { Id = 4, Code = "IPD", Name = "IPD", ShowInDashboard = true, Priority = 4 },
				new FormCategory() { Id = 5, Code = "EPrecryption", Name = "E-Precryption", ShowInDashboard = true, Priority = 5 },
				new FormCategory() { Id = 6, Code = "Labratoy", Name = "Labratoy", ShowInDashboard = true, Priority = 6 },
				new FormCategory() { Id = 7, Code = "Pharmacy", Name = "Pharmacy", ShowInDashboard = true, Priority = 7 },
				new FormCategory() { Id = 8, Code = "Financial", Name = "Financial", ShowInDashboard = true, Priority = 8 },
				new FormCategory() { Id = 9, Code = "HR", Name = "Human Resoutces", ShowInDashboard = true, Priority = 9 },
				new FormCategory() { Id = 10, Code = "Reports", Name = "Reports", ShowInDashboard = true, Priority = 10 },
				new FormCategory() { Id = 11, Code = "Setting", Name = "Setting", ShowInDashboard = false, Priority = 11 },
				new FormCategory() { Id = 12, Code = "Security", Name = "Security", ShowInDashboard = false, Priority = 12 }
			);

            modelBuilder.Entity<Form>().HasData(
                new Form() { Id = 101, FormCategoryId = 1, Code = "Desktop", Name = "Main Dashboard", ShowInMenu = true, Priority = 1, Url = "Desktop" },
                new Form() { Id = 102, FormCategoryId = 1, Code = "Appointment", Name = "Appointment", ShowInMenu = true, Priority = 2, Url = "AppointmentDashboard" },
                new Form() { Id = 103, FormCategoryId = 1, Code = "OPD", Name = "OPD", ShowInMenu = true, Priority = 3, Url = "OPDDashboard" },
                new Form() { Id = 104, FormCategoryId = 1, Code = "IPD", Name = "IPD", ShowInMenu = true, Priority = 4, Url = "IPDDashboard" },
                new Form() { Id = 105, FormCategoryId = 1, Code = "EPrecryption", Name = "E-Precryption", ShowInMenu = true, Priority = 5, Url = "EPrecryptionDashboard" },
                new Form() { Id = 106, FormCategoryId = 1, Code = "Labratoy", Name = "Labratoy", ShowInMenu = true, Priority = 6, Url = "LabratoyDashboard" },
                new Form() { Id = 107, FormCategoryId = 1, Code = "Pharmacy", Name = "Pharmacy", ShowInMenu = true, Priority = 7, Url = "PharmacyDashboard" },
                new Form() { Id = 108, FormCategoryId = 1, Code = "Financial", Name = "Financial", ShowInMenu = true, Priority = 8, Url = "FinancialDashboard" },
                new Form() { Id = 109, FormCategoryId = 1, Code = "HR", Name = "Human Resources", ShowInMenu = true, Priority = 9, Url = "HRDashboard" },
                new Form() { Id = 110, FormCategoryId = 1, Code = "Reports", Name = "Reports", ShowInMenu = true, Priority = 10, Url = "ReportsDashboard" },

				new Form() { Id = 301, FormCategoryId = 3, Code = "Patients", Name = "Patinet List", ShowInMenu = true, Priority = 1, Url = "Patients" },
				new Form() { Id = 302, FormCategoryId = 3, Code = "PatinetDefine", Name = "Patinet Define", ShowInMenu = false, Priority = 2, Url = "PatinetDefine" },
				new Form() { Id = 303, FormCategoryId = 3, Code = "OPDBills", Name = "OPD Billing List", ShowInMenu = true, Priority = 3, Url = "OPDBills" },
				new Form() { Id = 304, FormCategoryId = 3, Code = "OPDBillDefine", Name = "OPD Billing Define", ShowInMenu = true, Priority = 4, Url = "OPDBillDefine" },
				new Form() { Id = 305, FormCategoryId = 3, Code = "OPDBillPayments", Name = "OPD Billing Payment", ShowInMenu = false, Priority = 5, Url = "OPDBillPayments" },
				new Form() { Id = 306, FormCategoryId = 3, Code = "DebtorOPDBills", Name = "Receive Balance Payment", ShowInMenu = true, Priority = 6, Url = "DebtorOPDBills" },

				new Form() { Id = 401, FormCategoryId = 4, Code = "Patients", Name = "Patinet List", ShowInMenu = true, Priority = 1, Url = "Patients" },
				new Form() { Id = 402, FormCategoryId = 4, Code = "PatinetDefine", Name = "Patinet Define", ShowInMenu = false, Priority = 2, Url = "PatinetDefine" },
				new Form() { Id = 403, FormCategoryId = 4, Code = "IPDRegisterations", Name = "Admited Patinet List", ShowInMenu = true, Priority = 3, Url = "IPDRegisterations" },
				new Form() { Id = 404, FormCategoryId = 4, Code = "IPDRegisterationDefine", Name = "IPD Registeration", ShowInMenu = true, Priority = 1, Url = "IPDRegisterationDefine" },

				new Form() { Id = 1001, FormCategoryId = 10, Code = "ReportTemplates", Name = "Report Template List", ShowInMenu = true, Priority = 1, Url = "ReportTemplates" },
				new Form() { Id = 1002, FormCategoryId = 10, Code = "ReportTemplateDefine", Name = "Report Template Define", ShowInMenu = false, Priority = 2, Url = "ReportTemplateDefine" },
				new Form() { Id = 1003, FormCategoryId = 10, Code = "ReportTemplateDesign", Name = "Report Template Design", ShowInMenu = false, Priority = 3, Url = "ReportTemplateDesign" },
				new Form() { Id = 1004, FormCategoryId = 10, Code = "ReportShow", Name = "Report Show", ShowInMenu = false, Priority = 4, Url = "ReportShow" },

				new Form() { Id = 1101, FormCategoryId = 11, Code = "HospitalInformation", Name = "Hospital Information", ShowInMenu = true, Priority = 1, Url = "HospitalInformation" },
				new Form() { Id = 1102, FormCategoryId = 11, Code = "Departments", Name = "Department List", ShowInMenu = true, Priority = 2, Url = "Departments" },
				new Form() { Id = 1103, FormCategoryId = 11, Code = "DepartmentDefine", Name = "Department Define", ShowInMenu = false, Priority = 3, Url = "DepartmentDefine" },
				new Form() { Id = 1104, FormCategoryId = 11, Code = "Services", Name = "Service List", ShowInMenu = true, Priority = 4, Url = "Services" },
				new Form() { Id = 1105, FormCategoryId = 11, Code = "ServiceDefine", Name = "Service Define", ShowInMenu = false, Priority = 5, Url = "ServiceDefine" },
				new Form() { Id = 1106, FormCategoryId = 11, Code = "Consultants", Name = "Consultant List", ShowInMenu = true, Priority = 6, Url = "Consultants" },
				new Form() { Id = 1107, FormCategoryId = 11, Code = "ConsultantDefine", Name = "Consultant Define", ShowInMenu = false, Priority = 7, Url = "ConsultantDefine" },
				new Form() { Id = 1108, FormCategoryId = 11, Code = "ConsultantTimings", Name = "Consultant Timing List", ShowInMenu = true, Priority = 8, Url = "ConsultantTimings" },
				new Form() { Id = 1109, FormCategoryId = 11, Code = "ConsultantTimingDefine", Name = "Consultant Timing Define", ShowInMenu = false, Priority = 9, Url = "ConsultantTimingDefine" },
				new Form() { Id = 1110, FormCategoryId = 11, Code = "RefferBies", Name = "Reffer By List", ShowInMenu = true, Priority = 10, Url = "RefferBies" },
				new Form() { Id = 1111, FormCategoryId = 11, Code = "RefferByDefine", Name = "Reffer By Define", ShowInMenu = false, Priority = 11, Url = "RefferByDefine" },
				new Form() { Id = 1112, FormCategoryId = 11, Code = "Medicines", Name = "Medicine List", ShowInMenu = true, Priority = 12, Url = "Medicines" },
				new Form() { Id = 1113, FormCategoryId = 11, Code = "MedicineDefine", Name = "Medicine Define", ShowInMenu = false, Priority = 13, Url = "MedicineDefine" },
				new Form() { Id = 1114, FormCategoryId = 11, Code = "RoomTypes", Name = "Room Type List", ShowInMenu = true, Priority = 14, Url = "RoomTypes" },
				new Form() { Id = 1115, FormCategoryId = 11, Code = "RoomTypeDefine", Name = "Room Type Define", ShowInMenu = false, Priority = 15, Url = "RoomTypeDefine" },
				new Form() { Id = 1116, FormCategoryId = 11, Code = "Rooms", Name = "Room List", ShowInMenu = true, Priority = 16, Url = "Rooms" },
				new Form() { Id = 1117, FormCategoryId = 11, Code = "RoomDefine", Name = "Room Define", ShowInMenu = false, Priority = 17, Url = "RoomDefine" },
				new Form() { Id = 1118, FormCategoryId = 11, Code = "Beds", Name = "Bed List", ShowInMenu = true, Priority = 18, Url = "Beds" },
				new Form() { Id = 1119, FormCategoryId = 11, Code = "BedDefine", Name = "Bed Define", ShowInMenu = false, Priority = 19, Url = "BedDefine" },
				new Form() { Id = 1120, FormCategoryId = 11, Code = "Insurances", Name = "Insurance List", ShowInMenu = true, Priority = 20, Url = "Insurances" },
				new Form() { Id = 1121, FormCategoryId = 11, Code = "InsuranceDefine", Name = "Insurance Define", ShowInMenu = false, Priority = 21, Url = "InsuranceDefine" },
				new Form() { Id = 1122, FormCategoryId = 11, Code = "InsuranceAgreements", Name = "InsuranceAgreement List", ShowInMenu = true, Priority = 22, Url = "InsuranceAgreements" },
				new Form() { Id = 1123, FormCategoryId = 11, Code = "InsuranceAgreementDefine", Name = "Insurance Agreement Define", ShowInMenu = false, Priority = 23, Url = "InsuranceAgreementDefine" },
				new Form() { Id = 1124, FormCategoryId = 11, Code = "Cities", Name = "City List", ShowInMenu = true, Priority = 24, Url = "BasicInformations/City" },
				new Form() { Id = 1125, FormCategoryId = 11, Code = "CityDefine", Name = "City Define", ShowInMenu = false, Priority = 25, Url = "CityDefine" },
				new Form() { Id = 1126, FormCategoryId = 11, Code = "Areas", Name = "Area List", ShowInMenu = true, Priority = 26, Url = "BasicInformations/Area" },
				new Form() { Id = 1127, FormCategoryId = 11, Code = "AreaDefine", Name = "Area Define", ShowInMenu = false, Priority = 27, Url = "AreaDefine" },
				new Form() { Id = 1128, FormCategoryId = 11, Code = "BasicInformationCategories", Name = "Basic Information Category List", ShowInMenu = true, Priority = 28, Url = "BasicInformationCategories" },
				new Form() { Id = 1129, FormCategoryId = 11, Code = "BasicInformationCategoryDefine", Name = "Basic Information Category Define", ShowInMenu = false, Priority = 29, Url = "BasicInformationCategoryDefine" },
				new Form() { Id = 1130, FormCategoryId = 11, Code = "BasicInformations", Name = "Basic Information List", ShowInMenu = true, Priority = 30, Url = "BasicInformations" },
				new Form() { Id = 1131, FormCategoryId = 11, Code = "BasicInformationDefine", Name = "Basic Information Define", ShowInMenu = false, Priority = 31, Url = "BasicInformationDefine" },
				new Form() { Id = 1132, FormCategoryId = 11, Code = "Settings", Name = "Setting", ShowInMenu = true, Priority = 32, Url = "Settings" },

				new Form() { Id = 1201, FormCategoryId = 12, Code = "Users", Name = "User List", ShowInMenu = true, Priority = 1, Url = "Users" },
				new Form() { Id = 1202, FormCategoryId = 12, Code = "UserDefine", Name = "User Define", ShowInMenu = false, Priority = 2, Url = "UserDefine" },
				new Form() { Id = 1203, FormCategoryId = 12, Code = "ChangePassword", Name = "Change Password", ShowInMenu = true, Priority = 3, Url = "ChangePassword" }

			);

            modelBuilder.Entity<FormAction>().HasData(
                new FormAction() { Id = 10101, FormId = 101, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 10102, FormId = 102, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 10103, FormId = 103, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 10104, FormId = 104, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 10105, FormId = 105, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 10106, FormId = 106, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 10107, FormId = 107, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 10108, FormId = 108, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 10109, FormId = 109, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 10110, FormId = 110, Code = "View", Name = "View", Priority = 1 },

                new FormAction() { Id = 30101, FormId = 301, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 30102, FormId = 301, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 30103, FormId = 301, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 30104, FormId = 301, Code = "Delete", Name = "Delete", Priority = 4 },
                new FormAction() { Id = 30105, FormId = 301, Code = "Select", Name = "Select", Priority = 5 },

                new FormAction() { Id = 30201, FormId = 302, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 30202, FormId = 302, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 30301, FormId = 303, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 30302, FormId = 303, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 30303, FormId = 303, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 30304, FormId = 303, Code = "Cancel", Name = "Cancel", Priority = 4 },
                new FormAction() { Id = 30305, FormId = 303, Code = "Select", Name = "Select", Priority = 5 },
                new FormAction() { Id = 30306, FormId = 303, Code = "Print", Name = "Print", Priority = 6 },
                new FormAction() { Id = 30307, FormId = 303, Code = "Payment", Name = "Payment", Priority = 7 },

                new FormAction() { Id = 30401, FormId = 304, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 30402, FormId = 304, Code = "Save", Name = "Save", Priority = 2 },
                new FormAction() { Id = 30403, FormId = 304, Code = "Print", Name = "Print", Priority = 3 },
                new FormAction() { Id = 30404, FormId = 304, Code = "AddPatient", Name = "Add Patient", Priority = 4 },
                new FormAction() { Id = 30405, FormId = 304, Code = "SearchPatient", Name = "Search Patient", Priority = 5 },
                new FormAction() { Id = 30406, FormId = 304, Code = "AddService", Name = "Add Service", Priority = 6 },
                new FormAction() { Id = 30407, FormId = 304, Code = "DeleteService", Name = "Delete Service", Priority = 7 },

                new FormAction() { Id = 30501, FormId = 305, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 30502, FormId = 305, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 30503, FormId = 305, Code = "Delete", Name = "Delete", Priority = 3 },
                new FormAction() { Id = 30504, FormId = 305, Code = "Print", Name = "Print", Priority = 4 },

                new FormAction() { Id = 30601, FormId = 306, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 30602, FormId = 306, Code = "Payment", Name = "Payment", Priority = 2 },

                new FormAction() { Id = 40101, FormId = 401, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 40102, FormId = 401, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 40103, FormId = 401, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 40104, FormId = 401, Code = "Delete", Name = "Delete", Priority = 4 },
                new FormAction() { Id = 40105, FormId = 401, Code = "Select", Name = "Select", Priority = 5 },

                new FormAction() { Id = 40201, FormId = 402, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 40202, FormId = 402, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 40301, FormId = 403, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 40302, FormId = 403, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 40303, FormId = 403, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 40304, FormId = 403, Code = "Cancel", Name = "Cancel", Priority = 4 },
                new FormAction() { Id = 40305, FormId = 403, Code = "Discharge", Name = "Discharge", Priority = 5 },
                new FormAction() { Id = 40306, FormId = 403, Code = "Print", Name = "Print", Priority = 6 },

                new FormAction() { Id = 40401, FormId = 404, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 40402, FormId = 404, Code = "Save", Name = "Save", Priority = 2 },
                new FormAction() { Id = 40403, FormId = 404, Code = "Print", Name = "Print", Priority = 3 },
                new FormAction() { Id = 40404, FormId = 404, Code = "AddPatient", Name = "Add Patient", Priority = 4 },
                new FormAction() { Id = 40405, FormId = 404, Code = "SearchPatient", Name = "Search Patient", Priority = 5 },
                new FormAction() { Id = 40406, FormId = 404, Code = "SearchOPD", Name = "Search OPD Billing", Priority = 6 },
                new FormAction() { Id = 40407, FormId = 404, Code = "AddRoom", Name = "Add Room", Priority = 7 },
                new FormAction() { Id = 40408, FormId = 404, Code = "DeleteRoom", Name = "Delete Room", Priority = 8 },
                new FormAction() { Id = 40409, FormId = 404, Code = "AddService", Name = "Add Service", Priority = 9 },
                new FormAction() { Id = 40410, FormId = 404, Code = "DeleteService", Name = "Delete Service", Priority = 10 },
                new FormAction() { Id = 40411, FormId = 404, Code = "AddPayment", Name = "Add Payment", Priority = 11 },
                new FormAction() { Id = 40412, FormId = 404, Code = "DeletePayment", Name = "Delete Payment", Priority = 12 },
                new FormAction() { Id = 40413, FormId = 404, Code = "PrintPayment", Name = "Print Payment", Priority = 13 },

				new FormAction() { Id = 100101, FormId = 1001, Code = "View", Name = "View", Priority = 1 },
				new FormAction() { Id = 100102, FormId = 1001, Code = "Add", Name = "Add", Priority = 2 },
				new FormAction() { Id = 100103, FormId = 1001, Code = "Edit", Name = "Edit", Priority = 3 },
				new FormAction() { Id = 100104, FormId = 1001, Code = "Delete", Name = "Delete", Priority = 4 },
				new FormAction() { Id = 100105, FormId = 1001, Code = "Design", Name = "Design", Priority = 5 },

				new FormAction() { Id = 100201, FormId = 1002, Code = "View", Name = "View", Priority = 1 },
				new FormAction() { Id = 100202, FormId = 1002, Code = "Save", Name = "Save", Priority = 2 },

				new FormAction() { Id = 100301, FormId = 1003, Code = "View", Name = "View", Priority = 1 },

				new FormAction() { Id = 100401, FormId = 1004, Code = "View", Name = "View", Priority = 1 },

				new FormAction() { Id = 110101, FormId = 1101, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 110102, FormId = 1101, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 110201, FormId = 1102, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 110202, FormId = 1102, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 110203, FormId = 1102, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 110204, FormId = 1102, Code = "Delete", Name = "Delete", Priority = 4 },

                new FormAction() { Id = 110301, FormId = 1103, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 110302, FormId = 1103, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 110401, FormId = 1104, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 110402, FormId = 1104, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 110403, FormId = 1104, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 110404, FormId = 1104, Code = "Delete", Name = "Delete", Priority = 4 },

                new FormAction() { Id = 110501, FormId = 1105, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 110502, FormId = 1105, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 110601, FormId = 1106, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 110602, FormId = 1106, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 110603, FormId = 1106, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 110604, FormId = 1106, Code = "Delete", Name = "Delete", Priority = 4 },

                new FormAction() { Id = 110701, FormId = 1107, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 110702, FormId = 1107, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 110801, FormId = 1108, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 110802, FormId = 1108, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 110803, FormId = 1108, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 110804, FormId = 1108, Code = "Delete", Name = "Delete", Priority = 4 },

                new FormAction() { Id = 110901, FormId = 1109, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 110902, FormId = 1109, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 111001, FormId = 1110, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 111002, FormId = 1110, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 111003, FormId = 1110, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 111004, FormId = 1110, Code = "Delete", Name = "Delete", Priority = 4 },

                new FormAction() { Id = 111101, FormId = 1111, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 111102, FormId = 1111, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 111201, FormId = 1112, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 111202, FormId = 1112, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 111203, FormId = 1112, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 111204, FormId = 1112, Code = "Delete", Name = "Delete", Priority = 4 },

                new FormAction() { Id = 111301, FormId = 1113, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 111302, FormId = 1113, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 111401, FormId = 1114, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 111402, FormId = 1114, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 111403, FormId = 1114, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 111404, FormId = 1114, Code = "Delete", Name = "Delete", Priority = 4 },

                new FormAction() { Id = 111501, FormId = 1115, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 111502, FormId = 1115, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 111601, FormId = 1116, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 111602, FormId = 1116, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 111603, FormId = 1116, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 111604, FormId = 1116, Code = "Delete", Name = "Delete", Priority = 4 },

                new FormAction() { Id = 111701, FormId = 1117, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 111702, FormId = 1117, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 111801, FormId = 1118, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 111802, FormId = 1118, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 111803, FormId = 1118, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 111804, FormId = 1118, Code = "Delete", Name = "Delete", Priority = 4 },

                new FormAction() { Id = 111901, FormId = 1119, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 111902, FormId = 1119, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 112001, FormId = 1120, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 112002, FormId = 1120, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 112003, FormId = 1120, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 112004, FormId = 1120, Code = "Delete", Name = "Delete", Priority = 4 },

                new FormAction() { Id = 112101, FormId = 1121, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 112102, FormId = 1121, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 112201, FormId = 1122, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 112202, FormId = 1122, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 112203, FormId = 1122, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 112204, FormId = 1122, Code = "Delete", Name = "Delete", Priority = 4 },

                new FormAction() { Id = 112301, FormId = 1123, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 112302, FormId = 1123, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 112401, FormId = 1124, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 112402, FormId = 1124, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 112403, FormId = 1124, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 112404, FormId = 1124, Code = "Delete", Name = "Delete", Priority = 4 },

                new FormAction() { Id = 112501, FormId = 1125, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 112502, FormId = 1125, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 112601, FormId = 1126, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 112602, FormId = 1126, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 112603, FormId = 1126, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 112604, FormId = 1126, Code = "Delete", Name = "Delete", Priority = 4 },

                new FormAction() { Id = 112701, FormId = 1127, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 112702, FormId = 1127, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 112801, FormId = 1128, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 112802, FormId = 1128, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 112803, FormId = 1128, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 112804, FormId = 1128, Code = "Delete", Name = "Delete", Priority = 4 },

                new FormAction() { Id = 112901, FormId = 1129, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 112902, FormId = 1129, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 113001, FormId = 1130, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 113002, FormId = 1130, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 113003, FormId = 1130, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 113004, FormId = 1130, Code = "Delete", Name = "Delete", Priority = 4 },

                new FormAction() { Id = 113101, FormId = 1131, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 113102, FormId = 1131, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 113201, FormId = 1132, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 113202, FormId = 1132, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 120101, FormId = 1201, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 120102, FormId = 1201, Code = "Add", Name = "Add", Priority = 2 },
                new FormAction() { Id = 120103, FormId = 1201, Code = "Edit", Name = "Edit", Priority = 3 },
                new FormAction() { Id = 120104, FormId = 1201, Code = "Delete", Name = "Delete", Priority = 4 },
				new FormAction() { Id = 120105, FormId = 1201, Code = "Reset", Name = "Reset Password", Priority = 5 },

				new FormAction() { Id = 120201, FormId = 1202, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 120202, FormId = 1202, Code = "Save", Name = "Save", Priority = 2 },

                new FormAction() { Id = 120301, FormId = 1203, Code = "View", Name = "View", Priority = 1 },
                new FormAction() { Id = 120302, FormId = 1203, Code = "Change", Name = "Change Password", Priority = 2 }

            );

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<HospitalInformation> HospitalInformations {get;set;}
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<BasicInformationCategory> BasicInformationCategories { get; set; } 
        public DbSet<BasicInformation> BasicInformations { get; set; }  
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<InsuranceAgreement> InsuranceAgreements { get; set;}
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StaffTiming> StaffTimings { get; set; }
        public DbSet<RefferBy> RefferBies { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<OPDBill> OPDBills { get; set; }  
        public DbSet<OPDBillService> OPDBillServices { get; set; }    
        public DbSet<ReportTemplate> ReportTemplates { get; set; }
        public DbSet<IPDRegisteration> IPDRegisterations { get; set;}
        public DbSet<IPDRegisterationRoom> IPDRegisterationRooms { get;set; }
        public DbSet<IPDRegisterationService> IPDRegisterationServices { get; set; }
        public DbSet<IPDRegisterationPayment> IPDRegisterationPayments { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<OPDBillPayment> OPDBillPayments { get; set;}
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }
        public DbSet<FormCategory> FormCategories { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<FormAction> FormActions { get; set; }
        public DbSet<FormActionAccess> FormActionsAccess { get; set; }

    }
}
