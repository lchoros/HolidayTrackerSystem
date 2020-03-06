using JPSHolidayTrackerSystem.Shared.Entitities;
using JPSHolidayTrackerSystem.Web.Components;
using JPSHolidayTrackerSystem.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JPSHolidayTrackerSystem.Web.Pages
{
    public class EmployeeOverviewBase : ComponentBase
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        [Inject]
        public IDepartmentDataService DepartmentDataService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Department> Departments { get; set; }

        protected AddEmployeeDialogBase AddEmployeeDialog { get; set; }
        protected DeleteEmployeeDialogBase DeleteEmployeeDialog { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            Departments = (await DepartmentDataService.GetAllDepartments()).ToList();
        }

        public async void AddEmployeeDialog_OnDialogClose()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            StateHasChanged();
        }

        public async void DeleteEmployeeDialog_OnDialogClose()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            StateHasChanged();
        }

        protected void QuickAddEmployee()
        {
            AddEmployeeDialog.Show();
        }

        protected void ShowDeleteEmployeeDialog(int id)
        {
            DeleteEmployeeDialog.Show(id);
        }
    }
}
