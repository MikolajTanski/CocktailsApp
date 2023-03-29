using Drinks_app.Models;
using Drinks_app.Models.DTO;
using System.Collections.Generic;

namespace Drinks_app.Services.IServices
{
    public interface ICocktailRecipeService
    {
        CocktailRecipe GetCocktailRecipeById(long id);
        IEnumerable<CocktailRecipe> GetAllCocktailRecipe();
        IEnumerable<CocktailRecipe> SearchCocktailRecipeByIngredient(string ingredients);

        void CreateCocktailRecipe(CocktailRecipeDto cocktailRecipeDto);
        void DeleteCocktailRecipe(long id);
        void UpdateCocktailRecipe(CocktailRecipeDto cocktailRecipeDto);
    }
}
