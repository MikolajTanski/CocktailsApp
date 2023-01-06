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
       // void DeleteCocktailRecipe(long id);
        //CocktailRecipe GetCocktailRecipeById(CocktailRecipe c);
        //void DeleteCocktailRecipe(CocktailRecipe r);
        void DeleteCocktailRecipe(long id);
        //CocktailRecipe GetCocktailRecipeById(long id);
    }
}
