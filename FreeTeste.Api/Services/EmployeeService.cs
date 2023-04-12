using FreeTeste.Api.Database;
using FreeTeste.Api.Models;

namespace FreeTeste.Api.Services
{
    public class EmployeeService
    {
        //As mesmas questões anteriores se aplicam para cá
        
        ApiDbContext _dbContext;
        public EmployeeService(ApiDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        // Por que esse método GetEmployeeList não é assíncrono? Ajudaria em alguma coisa mudar?
        // O método UpdateEmployee também não é assíncrono, é esse o comportamento que queremos?
        // Sim, pesquise no chatGPT ou documentação em como transformar esse método em assíncrono,
        // faça perguntas, faça testes, tire suas dúvidas.

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
