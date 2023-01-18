﻿// <auto-generated />
using System;
using Hospital.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    [DbContext(typeof(HospitalContext))]
    [Migration("20221219080433_seedDataBasicInformationCategoryCorrection")]
    partial class seedDataBasicInformationCategoryCorrection
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hospital.Domain.Core.Entities.Attachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Extension")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Attachment", "Gnr");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.BasicInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<bool>("AllowChange")
                        .HasColumnType("bit");

                    b.Property<bool>("AllowDelete")
                        .HasColumnType("bit");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int?>("RelatedBasicInformationId")
                        .HasColumnType("int");

                    b.Property<string>("StrCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("RelatedBasicInformationId");

                    b.ToTable("BasicInformation", "Gnr");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.BasicInformationCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("RelatedCategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("Viewable")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("RelatedCategoryId");

                    b.ToTable("BasicInformationCategory", "Gnr");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "StaffType",
                            CreatedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3579),
                            CreatedUser = "elias.sarband",
                            ModifiedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3574),
                            Name = "Staff Type",
                            Viewable = true
                        },
                        new
                        {
                            Id = 2,
                            Code = "NamePrefix",
                            CreatedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3585),
                            CreatedUser = "elias.sarband",
                            ModifiedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3582),
                            Name = "Name Prefix",
                            Viewable = true
                        },
                        new
                        {
                            Id = 3,
                            Code = "Speciality",
                            CreatedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3589),
                            CreatedUser = "elias.sarband",
                            ModifiedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3587),
                            Name = "Speciality",
                            Viewable = true
                        },
                        new
                        {
                            Id = 4,
                            Code = "Qualification",
                            CreatedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3594),
                            CreatedUser = "elias.sarband",
                            ModifiedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3592),
                            Name = "Qualification",
                            Viewable = true
                        },
                        new
                        {
                            Id = 5,
                            Code = "City",
                            CreatedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3598),
                            CreatedUser = "elias.sarband",
                            ModifiedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3596),
                            Name = "City",
                            Viewable = true
                        },
                        new
                        {
                            Id = 6,
                            Code = "Area",
                            CreatedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3602),
                            CreatedUser = "elias.sarband",
                            ModifiedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3600),
                            Name = "Area",
                            RelatedCategoryId = 5,
                            Viewable = true
                        });
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<int?>("MainDepartmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("NotInUse")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MainDepartmentId");

                    b.ToTable("Department", "Gnr");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.HospitalInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BackupDirectory1")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("BackupDirectory2")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrencyCents")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CurrencyName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CurrencySymbol")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("Logo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Mobile")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RegisterationNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("SessionTimeout")
                        .HasColumnType("int");

                    b.Property<byte[]>("WhiteLogo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("HospitalInformation", "Gnr");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Role", "Sec");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "Super",
                            CreatedDate = new DateTime(2022, 12, 19, 11, 34, 33, 717, DateTimeKind.Local).AddTicks(8823),
                            CreatedUser = "elias.sarband",
                            Description = "",
                            ModifiedDate = new DateTime(2022, 12, 19, 11, 34, 33, 717, DateTimeKind.Local).AddTicks(8768),
                            Name = "Super Admin"
                        },
                        new
                        {
                            Id = 2,
                            Code = "Admin",
                            CreatedDate = new DateTime(2022, 12, 19, 11, 34, 33, 717, DateTimeKind.Local).AddTicks(8829),
                            CreatedUser = "elias.sarband",
                            Description = "",
                            ModifiedDate = new DateTime(2022, 12, 19, 11, 34, 33, 717, DateTimeKind.Local).AddTicks(8827),
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = 3,
                            Code = "Operator",
                            CreatedDate = new DateTime(2022, 12, 19, 11, 34, 33, 717, DateTimeKind.Local).AddTicks(8881),
                            CreatedUser = "elias.sarband",
                            Description = "",
                            ModifiedDate = new DateTime(2022, 12, 19, 11, 34, 33, 717, DateTimeKind.Local).AddTicks(8879),
                            Name = "Operator"
                        });
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("NotInUse")
                        .HasColumnType("bit");

                    b.Property<int>("Rest")
                        .HasColumnType("int");

                    b.Property<int?>("RoomTypeId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Room", "Gnr");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Floor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("NotInUse")
                        .HasColumnType("bit");

                    b.Property<string>("Ward")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("RoomType", "Gnr");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddAmount")
                        .HasColumnType("int");

                    b.Property<int?>("AddPercentage")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("DiscountAmount")
                        .HasColumnType("int");

                    b.Property<int?>("DiscountPercentage")
                        .HasColumnType("int");

                    b.Property<int?>("IPDRate")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("NotInUse")
                        .HasColumnType("bit");

                    b.Property<int?>("OPDRate")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Service", "Gnr");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("AttachmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AttachmentId");

                    b.ToTable("User", "Sec");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CreatedDate = new DateTime(2022, 12, 19, 11, 34, 33, 719, DateTimeKind.Local).AddTicks(7324),
                            CreatedUser = "elias.sarband",
                            Email = "elias.sarband@gmail.com",
                            FirstName = "Elias",
                            LastName = "Sarband",
                            ModifiedDate = new DateTime(2022, 12, 19, 11, 34, 33, 717, DateTimeKind.Local).AddTicks(9048),
                            Password = "SEIE/b+BtdSahkhMsl4KK3SuEjCF1OKUEn4oQYMaYSc=",
                            PhoneNumber = "9125056182",
                            Theme = "Light",
                            Username = "elias.sarband"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            CreatedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3477),
                            CreatedUser = "elias.sarband",
                            Email = "",
                            FirstName = "Admin",
                            LastName = "AccurateCo",
                            ModifiedDate = new DateTime(2022, 12, 19, 11, 34, 33, 719, DateTimeKind.Local).AddTicks(7335),
                            Password = "dW/0ZNtG5T5uIyhEYh0J9Q==",
                            PhoneNumber = "9125056182",
                            Theme = "Light",
                            Username = "accurateco"
                        });
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole", "Sec");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3544),
                            CreatedUser = "elias.sarband",
                            ModifiedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3542),
                            RoleId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3548),
                            CreatedUser = "elias.sarband",
                            ModifiedDate = new DateTime(2022, 12, 19, 11, 34, 33, 721, DateTimeKind.Local).AddTicks(3546),
                            RoleId = 1,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.BasicInformation", b =>
                {
                    b.HasOne("Hospital.Domain.Core.Entities.BasicInformationCategory", "Category")
                        .WithMany("BasicInformations")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.Domain.Core.Entities.BasicInformation", "RelatedBasicInformation")
                        .WithMany("BasicInformations")
                        .HasForeignKey("RelatedBasicInformationId");

                    b.Navigation("Category");

                    b.Navigation("RelatedBasicInformation");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.BasicInformationCategory", b =>
                {
                    b.HasOne("Hospital.Domain.Core.Entities.BasicInformationCategory", "RelatedCategory")
                        .WithMany("BasicInformationCategories")
                        .HasForeignKey("RelatedCategoryId");

                    b.Navigation("RelatedCategory");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.Department", b =>
                {
                    b.HasOne("Hospital.Domain.Core.Entities.Department", "MainDepartment")
                        .WithMany()
                        .HasForeignKey("MainDepartmentId");

                    b.Navigation("MainDepartment");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.Room", b =>
                {
                    b.HasOne("Hospital.Domain.Core.Entities.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.Service", b =>
                {
                    b.HasOne("Hospital.Domain.Core.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.User", b =>
                {
                    b.HasOne("Hospital.Domain.Core.Entities.Attachment", "Attachment")
                        .WithMany()
                        .HasForeignKey("AttachmentId");

                    b.Navigation("Attachment");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.UserRole", b =>
                {
                    b.HasOne("Hospital.Domain.Core.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.Domain.Core.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.BasicInformation", b =>
                {
                    b.Navigation("BasicInformations");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.BasicInformationCategory", b =>
                {
                    b.Navigation("BasicInformationCategories");

                    b.Navigation("BasicInformations");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Hospital.Domain.Core.Entities.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
