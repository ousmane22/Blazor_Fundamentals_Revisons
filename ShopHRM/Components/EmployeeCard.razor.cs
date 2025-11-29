using Microsoft.AspNetCore.Components;
using ShopHRM.Shared.Domain;


namespace ShopHRM.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee  Employee { get; set; } = new Employee();
    }
}
