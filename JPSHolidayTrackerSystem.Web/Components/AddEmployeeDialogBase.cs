using JPSHolidayTrackerSystem.Shared.Entitities;
using JPSHolidayTrackerSystem.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace JPSHolidayTrackerSystem.Web.Components
{
    public class AddEmployeeDialogBase : ComponentBase
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        public Employee Employee { get; set; } = new Employee { DepartmentId = 1, BirthDate = DateTime.Now, JoinedDate = DateTime.Now };
        public bool ShowDialog { get; set; }
        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }

        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }

        private void ResetDialog()
        {
            Employee = new Employee { DepartmentId = 1, BirthDate = DateTime.Now, JoinedDate = DateTime.Now };
        }

        protected async Task HandleValidSubmit()
        {
            await EmployeeDataService.AddEmployee(Employee);
            ShowDialog = false;
            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }
    }
}
