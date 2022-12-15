using Drinks_app.Data;
using Drinks_app.Models;
using Drinks_app.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Drinks_app.Repositories
{
    public class CocktailRecipeRepository : ICocktailRecipeRepository
    {
        private readonly ApplicationDbContext _db;

        public CocktailRecipeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void CreateCocktailRecipe(CocktailRecipe cocktailRecipe)
        {
            _db.CocktailRecipes.Add(cocktailRecipe);
            _db.SaveChanges();

        }

        public void DeleteCocktailRecipe(long id)
        {
            var cocktailRecipe = _db.CocktailRecipes.Find(id);
            if (cocktailRecipe != null) _db.CocktailRecipes.Remove(cocktailRecipe);
            _db.SaveChanges();
        }

        public IEnumerable<CocktailRecipe> GetAllCocktailRecipe()
        {
            var cocktailRecipe = _db.CocktailRecipes.ToList();
            return cocktailRecipe;
        }

        public CocktailRecipe GetCocktailRecipeById(long id)
        {
            var cocktailRecipe = _db.CocktailRecipes.Find(id);
            return cocktailRecipe;
        }

        public void UpdateCocktailRecipe(CocktailRecipe cocktailRecipe)
        {
            _db.Entry(cocktailRecipe).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
