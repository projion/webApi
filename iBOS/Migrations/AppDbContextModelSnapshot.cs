﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iBOS.DataAccess;

#nullable disable

namespace iBOS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("iBOS.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("EmployeeCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("EmployeeSalary")
                        .HasColumnType("float");

                    b.Property<int>("SupervisorId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.ToTable("tblEmployee");

                    b.HasData(
                        new
                        {
                            EmployeeId = 502030,
                            EmployeeCode = "EMP320",
                            EmployeeName = "Mehedi Hasan",
                            EmployeeSalary = 50000.0,
                            SupervisorId = 502036
                        },
                        new
                        {
                            EmployeeId = 502031,
                            EmployeeCode = "EMP321",
                            EmployeeName = "Ashikur Rahman",
                            EmployeeSalary = 45000.0,
                            SupervisorId = 502036
                        },
                        new
                        {
                            EmployeeId = 502032,
                            EmployeeCode = "EMP322",
                            EmployeeName = "Rakibul Islam",
                            EmployeeSalary = 52000.0,
                            SupervisorId = 502030
                        },
                        new
                        {
                            EmployeeId = 502033,
                            EmployeeCode = "EMP323",
                            EmployeeName = "Hasan Abdullah",
                            EmployeeSalary = 46000.0,
                            SupervisorId = 502031
                        },
                        new
                        {
                            EmployeeId = 502034,
                            EmployeeCode = "EMP324",
                            EmployeeName = "Akib Khan",
                            EmployeeSalary = 66000.0,
                            SupervisorId = 502032
                        },
                        new
                        {
                            EmployeeId = 502035,
                            EmployeeCode = "EMP325",
                            EmployeeName = "Rasel Shikder",
                            EmployeeSalary = 53500.0,
                            SupervisorId = 502033
                        },
                        new
                        {
                            EmployeeId = 502036,
                            EmployeeCode = "EMP326",
                            EmployeeName = "Selim Reja",
                            EmployeeSalary = 59000.0,
                            SupervisorId = 502035
                        });
                });

            modelBuilder.Entity("iBOS.Models.EmployeeAttendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AttendanceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsOffday")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPresent")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("tblEmployeeAttendance");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AttendanceDate = new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 502030,
                            IsOffday = false,
                            IsPresent = true
                        },
                        new
                        {
                            Id = 2,
                            AttendanceDate = new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 502030,
                            IsOffday = true,
                            IsPresent = false
                        },
                        new
                        {
                            Id = 3,
                            AttendanceDate = new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 502031,
                            IsOffday = false,
                            IsPresent = true
                        });
                });

            modelBuilder.Entity("iBOS.Models.EmployeeAttendance", b =>
                {
                    b.HasOne("iBOS.Models.Employee", "Employee")
                        .WithMany("EmployeeAttendances")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("iBOS.Models.Employee", b =>
                {
                    b.Navigation("EmployeeAttendances");
                });
#pragma warning restore 612, 618
        }
    }
}
