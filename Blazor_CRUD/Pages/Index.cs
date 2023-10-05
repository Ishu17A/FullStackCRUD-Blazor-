using Blazor_CRUD.Model;
using Blazor_CRUD.Services;
using Microsoft.AspNetCore.Components;
using System.Net.Http;

namespace Blazor_CRUD.Pages
{
    public partial class Index 
    {
    

        [Inject] HttpClient? HttpClient { get; set; }
        [Inject]
     
        public required IEmployeeService EmployeeService { get; set; }

        public required IEnumerable<EmployeeViewMdel> Employees { get; set; }




        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetData()).ToList();
        }


    }
}
