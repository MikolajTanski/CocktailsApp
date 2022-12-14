using Drinks_app.Models;
using System.Collections.Generic;

namespace Drinks_app.Services.IServices
{
    public interface ICocktailRecipeService
    {
        CocktailRecipe GetCocktailRecipe(long id);
        IEnumerable<CocktailRecipe> GetAllCocktailRecipe();
        void CreateCocktailRecipe(CocktailRecipe cocktailRecipe);
        void DeleteCocktailRecipe(CocktailRecipe cocktailRecipe);
        void UpdateCocktailRecipe(CocktailRecipe cocktailRecipe);
    }
}
