using Drinks_app.Models;
using System.Collections.Generic;

namespace Drinks_app.Repositories.IRepositories
{
    public interface ICocktailRecipeRepository
    {
        CocktailRecipe UpdateCocktailRecipe(CocktailRecipe cocktailRecipe);
        CocktailRecipe GetCocktailRecipe(long id);
        IEnumerable<CocktailRecipe> GetAllCocktailRecipe();
        void CreateCocktailRecipe(CocktailRecipe cocktailRecipe);
        void DeleteCocktailRecipe(CocktailRecipe cocktailRecipe);
    }
}
