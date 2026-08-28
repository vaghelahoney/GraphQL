using GraphQL.IRepositories;
using GraphQL.Models;

namespace GraphQL.GraphQL
{
    public class Mutation
    {
        public async Task<EmployeeModel> CreateEmployee(
            EmployeeInput input,
            [Service] IEmployeeRepository repository)
        {
            var employee = new EmployeeModel
            {
                Name = input.Name,
                Email = input.Email,
                Mobile = input.Mobile,
                IsActive = input.IsActive,
                Gender = input.Gender.ToString(),
                CreatedDate = input.CreatedDate,
                Price = input.Price,
                TenantId = input.TenantId
            };

            return await repository.CreateEmployeeAsync(employee);
        }

        public async Task<EmployeeModel?> UpdateEmployee(
            int id,
            EmployeeInput input,
            [Service] IEmployeeRepository repository)
        {
            var employee = new EmployeeModel
            {
                Name = input.Name,
                Email = input.Email,
                Gender = input.Gender.ToString(),
                Mobile = input.Mobile,
                IsActive = input.IsActive,
                CreatedDate = input.CreatedDate,
                Price = input.Price,
                TenantId = input.TenantId

            };

            return await repository.UpdateEmployeeAsync(
                id,
                employee);
        }

        public async Task<bool> DeleteEmployee(
            int id,
            [Service] IEmployeeRepository repository)
        {
            return await repository.DeleteEmployeeAsync(id);
        }
    }
}
