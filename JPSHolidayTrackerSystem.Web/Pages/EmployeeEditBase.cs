using JPSHolidayTrackerSystem.Shared.Entitities;
using JPSHolidayTrackerSystem.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JPSHolidayTrackerSystem.Web.Pages
{
    public class EmployeeEditBase : ComponentBase
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        [Inject]
        public IDepartmentDataService DepartmentDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string Id { get; set; }
        public Employee Employee { get; set; } = new Employee();
        public IEnumerable<Employee> Employees { get; set; }
        protected string DepartmentId = string.Empty;
        public List<Department> Departments { get; set; } = new List<Department>();
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        protected override async Task OnInitializedAsync()
        {
            Saved = false;
            Departments = (await DepartmentDataService.GetAllDepartments()).ToList();
            int.TryParse(Id, out var employeeId);

            if (employeeId == 0) //new employee is being created
            {
                //add some defaults
                Employee = new Employee { DepartmentId = 1, BirthDate = DateTime.Now, JoinedDate = DateTime.Now };
            }
            else
            {
                Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(Id));
            }
            DepartmentId = Employee.DepartmentId.ToString();
        }

        protected async Task DeleteEmployee()
        {
            await EmployeeDataService.DeleteEmployee(Employee.Id);
            StatusClass = "alert-success";
            Message = "Deleted successfully";
            Saved = true;
        }

        protected async Task HandleValidSubmit()
        {
            Employee.DepartmentId = int.Parse(DepartmentId);
            if(Employee.Id == 0)
            {
                var addedEmployee = await EmployeeDataService.AddEmployee(Employee);
                if(addedEmployee != null)
                {
                    StatusClass = "alert-success";
                    Message = "New employee added successfully";
                    Saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something wnet wrond adding the new employee. Please try again.";
                    Saved = false;
                }
            }
            else
            {
                await EmployeeDataService.UpdateEmployee(Employee);
                StatusClass = "alert-success";
                Message = "Employee updated successfully";
                Saved = true;
            }
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/employeeoverview");
        }
    }
}
