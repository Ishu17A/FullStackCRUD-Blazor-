using Blazor_CRUD.Model;
using System.Net.Http.Json;
using System.Reflection.Metadata;

namespace Blazor_CRUD.Services
{
    public class EmployeeService : IEmployeeService
    {

        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }


        public IEnumerable<EmployeeViewMdel> RandomResponse;

        public async Task<IEnumerable<EmployeeViewMdel>> GetData()
        {
            return RandomResponse = await httpClient.GetFromJsonAsync<IEnumerable<EmployeeViewMdel>>("api/Employee/all");
        }

        public  async Task AddEmployee(EmployeeViewMdel employee)
        {
           
            var response = await httpClient.PostAsJsonAsync("api/Employee/Add", employee);
            response.EnsureSuccessStatusCode();
        }

        public async Task<string> Delete(Guid id)
        {
            var DeleteResponse = await httpClient.DeleteAsync($"/api/Employee/delete/{id}");
          var aa =  DeleteResponse.ToString();

           return aa;   
        }

        public async Task<EmployeeViewMdel> GetUserData(Guid id)
        {
            var UserData = await httpClient.GetFromJsonAsync<EmployeeViewMdel>($"/api/Employee/GetEmployeeById/{id}");     
            return UserData;
        }

        public async Task UpdateEmployee(EmployeeViewMdel employee)
        {

            var response = await httpClient.PostAsJsonAsync($"api/Employee/edit/{employee.Id}", employee);
            response.EnsureSuccessStatusCode();

        }
    }
}

