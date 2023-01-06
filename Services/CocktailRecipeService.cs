using Drinks_app.Models;
using Drinks_app.Models.DTO;
using Drinks_app.Repositories;
using Drinks_app.Repositories.IRepositories;
using Drinks_app.Services.IServices;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Drinks_app.Services
{
    public class CocktailRecipeService : ICocktailRecipeService
    {
        private readonly ICocktailRecipeRepository _cocktailRecipeRepository;
        private readonly IIngredientRepository _ingredientRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public CocktailRecipeService(
            ICocktailRecipeRepository cocktailRecipeRepository,
            UserManager<ApplicationUser> userManager,
            IIngredientRepository ingredientRepository
            )
        {
            _cocktailRecipeRepository = cocktailRecipeRepository;
            _userManager = userManager;
            _ingredientRepository = ingredientRepository;
        }
         
        public void CreateCocktailRecipe(CocktailRecipeDto dto)
        {
            ApplicationUser currentUser = _userManager.FindByEmailAsync(dto.userEmail).Result;
            ICollection<Ingredient> ingredients = _ingredientRepository.GetIngredientsFromString(dto.Ingredients).ToList();
            var newCocktailRecipe = new CocktailRecipe
            {
                Name = dto.Name,
                Recipe = dto.Recipe, 
                Ingredients = ingredients,
                User = currentUser
            };
            _cocktailRecipeRepository.CreateCocktailRecipe(newCocktailRecipe);
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

        public void UpdateCocktailRecipe(CocktailRecipeDto cocktailRecipeDto)
        {
            CocktailRecipe cocktailRecipe= new CocktailRecipe();  //yet to implement
            _cocktailRecipeRepository.UpdateCocktailRecipe(cocktailRecipe);
        }
    }
}
