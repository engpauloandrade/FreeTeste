using Microsoft.AspNetCore.Mvc;
using TesteFrenet.Api.Database;
using TesteFrenet.Api.Models;
using TesteFrenet.Api.Services;

namespace TesteFrenet.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Teste2Controller
    {
        // Essa injeção de dependência está correta? Que tal criar a interface IApiDbContext e injetar ela aqui?
        ApiDbContext _dbContext;
        public Teste2Controller(ApiDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        //Cores e funcionários deveriam estar sendo listados na mesma controller? Não seria melhor separar as reponsabilidades?
        [HttpGet("colors")]
        public ColorList GetColors() 
        {

            var colorService = new ColorService(_dbContext);

            return colorService.GetColorsList();

        }

        [HttpGet("employees")]
        public EmployeeList GetEmployees() // public ColorList é correto de usar? E se usarmos Public IActionResult? O que mudaria? Para que serve?
        {
            // E se colocarmos um Try-Catch, seria melhor? 
            // Aqui estamos instanciando a classe EmployeeService, e se injetarmos ela? Não seria melhor?
            // Se optar por injetar, vai fazer igual a do banco de dados ou é melhor criar uma interface?
            var employeeService = new EmployeeService(_dbContext);

            return employeeService.GetEmployeeList();

        }


        // Eu estou utilizando o HttpPost para atualizar um funcionário, está correto? Não? Sim?
        // Aqui as injeções de dependências estão de acordo?
        // Estou utilizando [FromQuery], isso está correto? Está mostrando duas vezes o campo Id, como deixar só 1?
        // Você já ouviu falar em classes DTO? AutoMapper?
        // Segue documentação do AutoMapper https://docs.automapper.org/en/stable/index.html

        [HttpPost("employees/{id}")]
        public Employee UpdateEmployees(int id, [FromQuery] Employee employee)
        {
            var existingEmployee = _dbContext.Employees.Find(id);

            // Esse if deveria estar aqui mesmo? É responsabilidade da Controller?
            if (existingEmployee == null)
            {
                return null;
            }

            // O código abaixo deveria estar aqui na controller mesmo? Não é responsabilidade da classe Service isso?
            // A Controller não é responsável por apenas passar a informação para a classe service?
            // Afinal, para que serve a classe service em um projeto?

            existingEmployee.FirstName = employee.FirstName;
            existingEmployee.LastName = employee.LastName;
            existingEmployee.Email = employee.Email;
            existingEmployee.Date = employee.Date;
            existingEmployee.Salary = employee.Salary;

            var employeeService = new EmployeeService(_dbContext);

            employeeService.UpdateEmployee(existingEmployee);

            return existingEmployee;
        }

    }
}
