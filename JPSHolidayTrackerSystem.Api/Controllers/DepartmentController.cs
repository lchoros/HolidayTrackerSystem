using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JPSHolidayTrackerSystem.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace JPSHolidayTrackerSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public IActionResult GetDepartments()
        {
            return Ok(_departmentRepository.GetAllDepartments());
        }

        [HttpGet("{id}")]
        public IActionResult GetJobCategoryById(int id)
        {
            return Ok(_departmentRepository.GetDepartmentById(id));
        }
    }
}