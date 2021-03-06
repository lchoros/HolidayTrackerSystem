﻿// <auto-generated />
using System;
using JPSHolidayTrackerSystem.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JPSHolidayTrackerSystem.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200304154056_EmployessBirthDateField")]
    partial class EmployessBirthDateField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JPSHolidayTrackerSystem.Shared.Entitities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Customer Service"
                        },
                        new
                        {
                            Id = 2,
                            Name = "IT"
                        },
                        new
                        {
                            Id = 3,
                            Name = "JPS Walker"
                        },
                        new
                        {
                            Id = 4,
                            Name = "FOS"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Responses"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Creditor Liason"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Sales"
                        });
                });

            modelBuilder.Entity("JPSHolidayTrackerSystem.Shared.Entitities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("JoinedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1989, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 2,
                            Email = "lukasz.choros@jpsfinancial.co.uk",
                            FirstName = "Lukasz",
                            Gender = 0,
                            IsActive = true,
                            JoinedDate = new DateTime(2020, 3, 4, 15, 40, 56, 42, DateTimeKind.Local).AddTicks(3389),
                            LastName = "Smith",
                            Phone = "324777888773"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1967, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 2,
                            Email = "paul.duff@jpsfinancial.co.uk",
                            FirstName = "Paul",
                            Gender = 0,
                            IsActive = true,
                            JoinedDate = new DateTime(2020, 3, 4, 15, 40, 56, 46, DateTimeKind.Local).AddTicks(1133),
                            LastName = "Duff",
                            Phone = "0777777777"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1995, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            Email = "josh.edwards@jpsfinancial.co.uk",
                            FirstName = "Josh",
                            Gender = 0,
                            IsActive = true,
                            JoinedDate = new DateTime(2020, 3, 4, 15, 40, 56, 46, DateTimeKind.Local).AddTicks(1261),
                            LastName = "Edwards",
                            Phone = "0777777777"
                        });
                });

            modelBuilder.Entity("JPSHolidayTrackerSystem.Shared.Entitities.Employee", b =>
                {
                    b.HasOne("JPSHolidayTrackerSystem.Shared.Entitities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
