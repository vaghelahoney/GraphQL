using GraphQL.Models;

namespace GraphQL.IRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<EmployeeModel>> GetAllEmployeeAsync();

        Task<EmployeeModel?> GetEmployeeByIdAsync(int id);

        Task<EmployeeModel> CreateEmployeeAsync(EmployeeModel employee);

        Task<EmployeeModel?> UpdateEmployeeAsync(
            int id,
            EmployeeModel employee);

        Task<bool> DeleteEmployeeAsync(int id);
    }
}
