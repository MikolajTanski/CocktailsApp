using Microsoft.EntityFrameworkCore;
using Drinks_app.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Drinks_app.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<CocktailRecipe> CocktailRecipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
