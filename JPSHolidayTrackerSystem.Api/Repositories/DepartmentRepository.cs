using JPSHolidayTrackerSystem.Api.Models;
using JPSHolidayTrackerSystem.Shared.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JPSHolidayTrackerSystem.Api.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _appDbContext.Departments;
        }

        public Department GetDepartmentById(int id)
        {
            return _appDbContext.Departments.FirstOrDefault(c => c.Id == id);
        }
    }
}
