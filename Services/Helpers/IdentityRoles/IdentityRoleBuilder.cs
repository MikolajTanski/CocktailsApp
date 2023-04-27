using Drinks_app.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Drinks_app.Services.Helpers.IdentityRoles
{
    public class IdentityRoleBuilder
    {
        public async Task CreateRole(IServiceCollection services, string Name)
        {
            var serviceProvider = services.BuildServiceProvider();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            if (!await roleManager.RoleExistsAsync(Name))
            {
                var role = new IdentityRole(Name);
                await roleManager.CreateAsync(role);
            }
        }
    }
}
