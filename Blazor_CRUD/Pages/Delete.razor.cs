using Blazor_CRUD.Model;
using Blazor_CRUD.Services;
using Microsoft.AspNetCore.Components;

namespace Blazor_CRUD.Pages
{
    public partial class Delete
    {
        [Parameter]
        public Guid Id { get; set; }

        [Inject]
        public required IEmployeeService EmployeeService { get; set; }

        private EmployeeViewMdel employee = new EmployeeViewMdel();
        protected override async Task OnInitializedAsync()
        {
            await EmployeeService.Delete(Id);
            NavigationManager.NavigateTo("/");
        }

        protected async Task RemoveUser(Guid id)
        {
            await EmployeeService.Delete(id);
            NavigationManager.NavigateTo("/");
        }
    }
}
