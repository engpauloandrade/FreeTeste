namespace FreeTeste.Api.Services
{
    public class RandomService
    {

        // Faça um gerador de números com 6 dígitos
        // Caso queira ir mais além, faça um gerador de senhas, utilize a using System.Security.Cryptography;
        // https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography?view=net-6.0
        // é possível gerar senhas aleatórias com a classe RandomNumberGenerator

        // Aqui poderíamos transformar o método em assincrono? "public task async<int> GenerateRandomNumbersAsync" ? Sim? Não?
        // Qual é a diferença entre um método síncrono e assíncrono? Qual a necessidade de usar assíncrono?
        // Sim, você pode pesquisar no chatGPT, é uma ferramenta.
        public int GenerateRandomNumbers()
        {
            return 100;
        }

    }
}
