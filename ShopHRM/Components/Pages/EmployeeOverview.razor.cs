using ShopHRM.Services;
using ShopHRM.Shared.Domain;

namespace ShopHRM.Components.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;

        protected async override Task OnInitializedAsync()
        {
            Employees  =  MockDataService.Employees;
        }
    }
}
