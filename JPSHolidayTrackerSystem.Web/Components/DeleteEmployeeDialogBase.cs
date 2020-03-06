using JPSHolidayTrackerSystem.Shared.Entitities;
using JPSHolidayTrackerSystem.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JPSHolidayTrackerSystem.Web.Components
{
    public class DeleteEmployeeDialogBase : ComponentBase
    {
        public int DeleteId { get; set; }
        public bool ShowDialog { get; set; }
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }
        public Employee Employee { get; set; } = new Employee();

        //protected override async Task OnInitializedAsync()
        //{
        //    Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(Id));
        //}

        public void Show(int id)
        {
            ShowDialog = true;
            DeleteId = id;
            StateHasChanged();
        }

        protected async Task DeleteEmployee()
        {
            await EmployeeDataService.DeleteEmployee(DeleteId);
            ShowDialog = false;
            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }

        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }
    }
}
