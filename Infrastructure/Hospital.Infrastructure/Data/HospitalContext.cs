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
                new Role() { Id = 2, Code = "Admin", Name = "Administrator", Description = "", CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                new Role() { Id = 3, Code = "Operator", Name = "Operator", Description = "", CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" }
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
                new BasicInformationCategory() { Id = 7, Code = "PaymentType", Name = "Payment Type", Viewable = false, RelatedCategoryId = null, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" }
            );

            modelBuilder.Entity<BasicInformation>().HasData(
                new BasicInformation() { Id = 101, Code = 1, StrCode = "Doctor", Name = "Doctor", CategoryId = 1, Priority = 1, RelatedBasicInformationId = null, Active = true, IsDeleted = false, AllowChange = false, AllowDelete = false, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                  new BasicInformation() { Id = 102, Code = 2, StrCode = "Nurse", Name = "Nurse", CategoryId = 1, Priority = 2, RelatedBasicInformationId = null, Active = true, IsDeleted = false, AllowChange = false, AllowDelete = false, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                  new BasicInformation() { Id = 103, Code = 3, StrCode = "Staff", Name = "Staff", CategoryId = 1, Priority = 3, RelatedBasicInformationId = null, Active = true, IsDeleted = false, AllowChange = false, AllowDelete = false, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },

                  new BasicInformation() { Id = 201, Code = 1, StrCode = "Mr", Name = "Mr", CategoryId = 2, Priority = 1, RelatedBasicInformationId = null, Active = true, IsDeleted = false, AllowChange = false, AllowDelete = false, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                  new BasicInformation() { Id = 202, Code = 2, StrCode = "Mrs", Name = "Mrs", CategoryId = 2, Priority = 2, RelatedBasicInformationId = null, Active = true, IsDeleted = false, AllowChange = false, AllowDelete = false, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },

                 new BasicInformation() { Id = 701, Code = 1, StrCode = "Cash", Name = "Cash", CategoryId = 7, Priority = 1, RelatedBasicInformationId = null, Active = true, IsDeleted = false, AllowChange = false, AllowDelete = false, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" },
                  new BasicInformation() { Id = 702, Code = 2, StrCode = "Credit", Name = "Credit", CategoryId = 7, Priority = 2, RelatedBasicInformationId = null, Active = true, IsDeleted = false, AllowChange = false, AllowDelete = false, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" }
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
        public DbSet<IPDRegisterationService> IPDRegisterationServices { get;}
        public DbSet<IPDRegisterationPayment> IPDRegisterationPayments { get; set; }
    }
}
