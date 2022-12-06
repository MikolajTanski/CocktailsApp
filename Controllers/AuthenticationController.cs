using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Drinks_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register()
        {

            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {

            return Ok();
        }
    }
}
