using Drinks_app.Models;
using Drinks_app.Repositories;
using Drinks_app.Services.IServices;
using System.Collections.Generic;

namespace Drinks_app.Services
{
    public class CocktailRecipeService : ICocktailRecipeService
    {
        private readonly CocktailRecipeRepository _cocktailRecipeRepository;
        public CocktailRecipeService(CocktailRecipeRepository cocktailRecipeRepository)
        {
            _cocktailRecipeRepository = cocktailRecipeRepository;
        }

        public void CreateCocktailRecipe(CocktailRecipe cocktailRecipe)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCocktailRecipe(CocktailRecipe cocktailRecipe)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CocktailRecipe> GetAllCocktailRecipe()
        {
            throw new System.NotImplementedException();
        }

        public CocktailRecipe GetCocktailRecipe(long id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCocktailRecipe(CocktailRecipe cocktailRecipe)
        {
            throw new System.NotImplementedException();
        }
    }
}
