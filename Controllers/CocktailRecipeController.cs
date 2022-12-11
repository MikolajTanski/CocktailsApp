using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Drinks_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CocktailRecipeController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllCocktailRecipes()
        {
            return Ok();
        }
    }
}
