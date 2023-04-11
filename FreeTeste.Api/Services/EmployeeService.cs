using FreeTeste.Api.Database;
using FreeTeste.Api.Models;

namespace FreeTeste.Api.Services
{
    public class EmployeeService
    {
        ApiDbContext _dbContext;
        public EmployeeService(ApiDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        // Traz uma lista de funcionários cadastrados no banco de dados
        public EmployeeList GetEmployeeList()
        {
            return new EmployeeList() { Employees = _dbContext.Employees.ToList() };
        }

        //Atualiza um funcionário no banco de dados
        public void UpdateEmployee(Employee employee)
        {
            _dbContext.Employees.Update(employee);
            _dbContext.SaveChanges();
        }
    }
}
