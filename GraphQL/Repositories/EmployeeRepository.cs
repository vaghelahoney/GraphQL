using GraphQL.Data;
using GraphQL.IRepositories;
using GraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<EmployeeModel>> GetAllEmployeeAsync()
        {
            return await _context.Employee
                .AsNoTracking()
                .ToListAsync();
        }

        // READ BY ID
        public async Task<EmployeeModel?> GetEmployeeByIdAsync(int id)
        {
            return await _context.Employee
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        // CREATE
        public async Task<EmployeeModel> CreateEmployeeAsync(
            EmployeeModel employee)
        {
            _context.Employee.Add(employee);

            await _context.SaveChangesAsync();

            return employee;
        }

        // UPDATE
        public async Task<EmployeeModel?> UpdateEmployeeAsync(
            int id,
            EmployeeModel employee)
        {
            var existingEmployee = await _context.Employee
                .FirstOrDefaultAsync(x => x.Id == id);

            if (existingEmployee == null)
            {
                return null;
            }

            existingEmployee.Name = employee.Name;
            existingEmployee.Email = employee.Email;

            await _context.SaveChangesAsync();

            return existingEmployee;
        }

        // DELETE
        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            var employee = await _context.Employee
                .FirstOrDefaultAsync(x => x.Id == id);

            if (employee == null)
            {
                return false;
            }

            _context.Employee.Remove(employee);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
