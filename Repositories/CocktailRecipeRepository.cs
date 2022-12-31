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

        
        public void DeleteCocktailRecipe(string Recipe r)
        {
        var DeleteCocktailRecipe = from recipe 
                                   in CocktailRecipes
                                   where recipe.Id == r.Id
                                   select recipe;
        db.CocktailRecipes.DeletOnSubmit(DeleteCocktailRecipe);
    }
    
        var cocktailRecipe = from CocktailRecipeAll 
                         in CocktailRecipes
                         select CocktailRecipeAll;

    public CocktailRecipe GetCocktailRecipeById(CocktailRecipe c)
    var GetCocktailRecipeById = from i
                                in CocktailRecipe
                                where i.Id == c.Id 


    var UpdateCocktailRecipe = from updateRecipe
                               in CocktailRecipes
                               where updateRecipe.Name == cocktailRecipe.Name
                               select updateRecipe;
    UpdateCocktailRecipe.is_dafault = false;
    Context.SaveChanges();
}
}
