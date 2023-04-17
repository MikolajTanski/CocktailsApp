using Drinks_app.Models;
using System.Collections.Generic;

namespace Drinks_app.Repositories.IRepositories
{
    public interface ICocktailRecipeRepository
    {
        void UpdateCocktailRecipe(CocktailRecipe cocktailRecipe);
        CocktailRecipe GetCocktailRecipeById(long id);
        CocktailRecipe GetCocktailRecipeByName(string name);
        IEnumerable<CocktailRecipe> GetAllCocktailRecipe();
        IEnumerable<CocktailRecipe> SearchCocktailRecipeByIngredient(List<Ingredient> ingredients);
        void CreateCocktailRecipe(CocktailRecipe cocktailRecipe);
        void DeleteCocktailRecipe(long id);
    }
}
