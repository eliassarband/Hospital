using Hospital.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Hospital.Domain.Core.Helpers;

namespace Hospital.Infrastructure.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions options) : base(options)
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
                new User() { Id = 1, FirstName = "Elias", LastName = "Sarband", Username = "elias.sarband", Password = CryptographyHelper.Encrypt("Elias 8831"), Email = "elias.sarband@gmail.com", PhoneNumber = "9125056182", Active = true, Theme = "Light", CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" }
            );

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole() { Id = 1, UserId = 1, RoleId = 1, CreatedDate = DateTime.Now, CreatedUser = "elias.sarband" }
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

    }
}
