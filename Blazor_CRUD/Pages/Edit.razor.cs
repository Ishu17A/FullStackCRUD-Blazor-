using Blazor_CRUD.Model;
using Blazor_CRUD.Services;
using Microsoft.AspNetCore.Components;

namespace Blazor_CRUD.Pages
{
    public partial class Edit
    {

        [Parameter]
     
        public Guid id { get; set; }

        [Inject]
        public required IEmployeeService EmployeeService { get; set; }

        EmployeeViewMdel employee { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
           employee =   await EmployeeService.GetUserData(id);

       
        }

/*
        public Employee employees = new Employee();*/
        protected async Task SaveEmployee(/*Employee employees*/)
        {


            await EmployeeService.UpdateEmployee(employee);
            employee = new();
            StateHasChanged();
            NavigationManager.NavigateTo("/");




        }


    }

}
