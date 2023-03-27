using Drinks_app.Models;
using Drinks_app.Repositories.IRepositories;
using Drinks_app.Services.IServices;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Drinks_app.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;
        public IngredientService(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public void CreateIngredient(Ingredient ingredient)
        {
            _ingredientRepository.CreateIngredient(ingredient);
        }

        public void DeleteIngredient(long id)
        {
            _ingredientRepository.DeleteIngredient(id);
        }

        public IEnumerable<Ingredient> GetAllIngredient()
        {
            var result = _ingredientRepository.GetAllIngredient();
            return result;
        }

        public Ingredient GetIngredientById(long id)
        {
            var result = _ingredientRepository.GetIngredientById(id);
            return result;
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            _ingredientRepository.UpdateIngredient(ingredient);
        }
        public IEnumerable<Ingredient> GetIngredientsFromString(string IngredientsString)
        {
            List<Ingredient> Ingredients = new List<Ingredient>();
            string[] IngredientsArr = IngredientsString.Split(",").Select(i => i.Trim()).ToArray();
            foreach (string IngredientName in IngredientsArr)
            {
                Ingredients.Add(_ingredientRepository.GetIngredientByName(IngredientName));
            }

            return Ingredients;
        }
    }
}
