using FreeTeste.Api.Database;
using FreeTeste.Api.Models;

namespace FreeTeste.Api.Services
{

    // A injeção da classe ApiDbContext está correta?
    // Não seria melhor injetar uma interface? Como ficaria? Para que servem as interfaces?
    // Não seria ideal colocar uma paginação? Eu passo a pagina 1 e a quantidade de cores por página, assim para página 2 e etc
    // Que tal melhorar essa Api? O tipo "ColorList" em public ColorList GetColorsList() pode ser substituido? Pelo que?
    public class ColorService
    {
        ApiDbContext _dbContext;
        public ColorService(ApiDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public ColorList GetColorsList()
        {
            return new ColorList() { Colors = _dbContext.Colors.ToList() };
        }

    }
}
