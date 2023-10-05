using Blazor_CRUD.Model;
using Blazor_CRUD.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.Extensions;

namespace Blazor_CRUD.Pages
{
    public partial class Add : ComponentBase
    {
        [Inject] IEmployeeService EmployeeService { get; set; }

        [Inject] HttpClient HttpClient { get; set; }


        private EmployeeViewMdel employee = new EmployeeViewMdel();
        protected async Task CreateEmployee(/*Employee employee*/)
        {
        

            await EmployeeService.AddEmployee(employee);
            employee = new();
            StateHasChanged();
            MyNavigationManager.NavigateTo("/");




        }
    }

}
