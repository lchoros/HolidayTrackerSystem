using JPSHolidayTrackerSystem.ComponentsLibrary.Map;
using JPSHolidayTrackerSystem.Shared.Entitities;
using JPSHolidayTrackerSystem.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JPSHolidayTrackerSystem.Web.Pages
{
    public class EmployeeDetailBase : ComponentBase
    {
        [Parameter]
        public string Id { get; set; }
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        [Inject]
        public IDepartmentDataService DepartmentDataService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public string Department = string.Empty;
        public Employee Employee { get; set; } = new Employee();

        public List<Marker> MapMarkers { get; set; } = new List<Marker>();

        protected override async Task OnInitializedAsync()
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(Id));
            Department = (await DepartmentDataService.GetDepartmentById(Employee.DepartmentId)).Name;
            MapMarkers = new List<Marker>
            {
                new Marker{Description = $"{Employee.FirstName} {Employee.LastName}",  ShowPopup = false, X = 53.5357812, Y = -2.2339628}
            };
        }
    }
}
