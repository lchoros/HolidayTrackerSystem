﻿// <auto-generated />
using JPSHolidayTrackerSystem.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JPSHolidayTrackerSystem.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200304120431_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JPSHolidayTrackerSystem.Shared.Entitities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "lukasz.choros@jpsfinancial.co.uk",
                            FirstName = "Lukasz",
                            LastName = "Smith",
                            Phone = "324777888773"
                        },
                        new
                        {
                            Id = 2,
                            Email = "paul.duff@jpsfinancial.co.uk",
                            FirstName = "Paul",
                            LastName = "Duff",
                            Phone = "0777777777"
                        },
                        new
                        {
                            Id = 3,
                            Email = "josh.edwards@jpsfinancial.co.uk",
                            FirstName = "Josh",
                            LastName = "Edwards",
                            Phone = "0777777777"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}