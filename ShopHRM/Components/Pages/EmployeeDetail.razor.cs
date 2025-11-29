using Microsoft.AspNetCore.Components;
using ShopHRM.Services;
using ShopHRM.Shared.Domain;

namespace ShopHRM.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();


        protected async override Task OnInitializedAsync()
        {
            Employee =  MockDataService.Employees.Single(e => e.EmployeeId == EmployeeId);
        }


        private void ChangeHolidayState()
        {
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
        }
    }
}
