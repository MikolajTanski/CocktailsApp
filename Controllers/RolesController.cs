using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_app.Controllers
{
    [Authorize(Roles ="superadmin")]
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [HttpPost("{Name}")]
        public async Task<IActionResult> Create(string Name)
        {
            var role = new IdentityRole(Name);
            if(await _roleManager.RoleExistsAsync(Name))
            {
                return Ok("Role with that name has already been created");
            }
            await _roleManager.CreateAsync(role);
            return Ok("Success. Role has been created");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            if(roles.Any())
            {
                return Ok(roles);
            }
            return Ok("No elements to display");
        }
    }
}
