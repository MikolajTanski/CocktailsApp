using Drinks_app.Models;
using System.Collections.Generic;

namespace Drinks_app.Repositories.IRepositories
{
    public interface ICocktailRecipeRepository
    {
        void UpdateCocktailRecipe(CocktailRecipe cocktailRecipe);
        CocktailRecipe GetCocktailRecipeById(long id);
        IEnumerable<CocktailRecipe> GetAllCocktailRecipe();
        void CreateCocktailRecipe(CocktailRecipe cocktailRecipe);
        void DeleteCocktailRecipe(long id);
    }
}
