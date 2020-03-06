using System;
using JPSHolidayTrackerSystem.Shared.Entitities;
using Microsoft.EntityFrameworkCore;

namespace JPSHolidayTrackerSystem.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Department>().HasData(new Department { Id = 1, Name = "Customer Service" });
            modelBuilder.Entity<Department>().HasData(new Department { Id = 2, Name = "IT" });
            modelBuilder.Entity<Department>().HasData(new Department { Id = 3, Name = "JPS Walker" });
            modelBuilder.Entity<Department>().HasData(new Department { Id = 4, Name = "FOS" });
            modelBuilder.Entity<Department>().HasData(new Department { Id = 5, Name = "Responses" });
            modelBuilder.Entity<Department>().HasData(new Department { Id = 6, Name = "Creditor Liason" });
            modelBuilder.Entity<Department>().HasData(new Department { Id = 7, Name = "Sales" });


            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 1,
                DepartmentId = 2,
                Email = "lukasz.choros@jpsfinancial.co.uk",
                FirstName = "Lukasz",
                LastName = "Smith",
                Phone = "324777888773",
                Gender = Shared.Enums.Gender.Male,
                JoinedDate = DateTime.Now,
                IsActive = true,
                BirthDate = new DateTime(1989, 1, 16)
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 2,
                DepartmentId = 2,
                Email = "paul.duff@jpsfinancial.co.uk",
                FirstName = "Paul",
                LastName = "Duff",
                Phone = "0777777777",
                Gender = Shared.Enums.Gender.Male,
                JoinedDate = DateTime.Now,
                IsActive = true,
                BirthDate = new DateTime(1967, 1, 12)
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 3,
                DepartmentId = 1,
                Email = "josh.edwards@jpsfinancial.co.uk",
                FirstName = "Josh",
                LastName = "Edwards",
                Phone = "0777777777",
                Gender = Shared.Enums.Gender.Male,
                JoinedDate = DateTime.Now,
                IsActive = true,
                BirthDate = new DateTime(1995, 12, 18)
            });
        }
    }
}
