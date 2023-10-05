using Blazor_CRUD.Model;

namespace Blazor_CRUD.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeViewMdel>> GetData();

        Task AddEmployee(EmployeeViewMdel employee);

        Task<string> Delete(Guid id);


        Task<EmployeeViewMdel> GetUserData(Guid id);

        Task UpdateEmployee(EmployeeViewMdel emp);
    }
}
