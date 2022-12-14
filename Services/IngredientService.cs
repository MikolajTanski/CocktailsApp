using Drinks_app.Models;
using Drinks_app.Repositories;
using Drinks_app.Services.IServices;
using System.Collections.Generic;

namespace Drinks_app.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IngredientRepository _ingredientRepository;
        public IngredientService(IngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public void CreateIngredient(Ingredient ingredient)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteIngredient(Ingredient ingredient)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Ingredient> GetAllIngredient()
        {
            throw new System.NotImplementedException();
        }

        public Ingredient GetIngredient(long id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            throw new System.NotImplementedException();
        }
    }
}
