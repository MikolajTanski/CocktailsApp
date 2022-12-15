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
            _cocktailRecipeRepository.CreateCocktailRecipe(cocktailRecipe);
        }

        public void DeleteCocktailRecipe(long id)
        {
            _cocktailRecipeRepository.DeleteCocktailRecipe(id);
        }

        public IEnumerable<CocktailRecipe> GetAllCocktailRecipe()
        {
            var result = _cocktailRecipeRepository.GetAllCocktailRecipe();
            return result;
        }

        public CocktailRecipe GetCocktailRecipeById(long id)
        {
            var result = _cocktailRecipeRepository.GetCocktailRecipeById(id);
            return result;
        }

        public void UpdateCocktailRecipe(CocktailRecipe cocktailRecipe)
        {
            _cocktailRecipeRepository.UpdateCocktailRecipe(cocktailRecipe);
        }
    }
}
