using Microsoft.AspNetCore.Mvc;
using TesteFrenet.Api.Services;

namespace TesteFrenet.Api.Controllers
{

    /// Ao rodar o código abaixo o serviço deveria sempre retornar um número aleatório de 6 dígitos, mas ele fica retornando sempre o mesmo número.
    /// Faça as alterações para que o número retornado seja sempre diferente
    /// Crie as injeções de dependências
    /// Crie tratamentos de erro para a controller abaixo

    [ApiController]
    [Route("[controller]")]
    public class Teste1Controller
    {
        //Se eu mudar para [HttpPost], o resultado vai mudar ou vai continuar fazendo um Get?
        [HttpGet("numbers")]
        public int GetNumbers() // public int está correto? E se usarmos public IActionResult? O que mudaria? Para que serve?
        {
            //Aqui estamos instanciando a classe RandomService, e se injetarmos ela? Não seria melhor?
            var randomService = new RandomService();

            return randomService.GenerateRandomNumbers();
        }

    }
}
