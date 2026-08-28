using GraphQL.IRepositories;
using GraphQL.Models;

namespace GraphQL.GraphQL
{
    public class Query
    {
       
            // GET ALL
            public async Task<List<EmployeeModel>> GetEmployees([Service] IEmployeeRepository repository)
            {
                return await repository.GetAllEmployeeAsync();
            }

            // GET BY ID
            public async Task<EmployeeModel?> GetEmployee(int id,[Service] IEmployeeRepository repository)
            {
                return await repository.GetEmployeeByIdAsync(id);
            }
    }
}
