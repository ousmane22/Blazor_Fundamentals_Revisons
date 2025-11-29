using ShopHRM.Services;
using ShopHRM.Shared.Domain;

namespace ShopHRM.Components.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;
        private Employee? _selectedEmployee { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employees = MockDataService.Employees;
        }

        public void ShowQuickViewPopup(Employee seletedEmployee)
        {
            _selectedEmployee = seletedEmployee;
        }
    }
}
