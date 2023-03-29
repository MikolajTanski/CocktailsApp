using Drinks_app.Models;
using System.Collections.Generic;

namespace Drinks_app.Repositories.IRepositories
{
    public interface IIngredientRepository
    {
        void UpdateIngredient(Ingredient ingredient);
        Ingredient GetIngredientById(long id);
        IEnumerable<Ingredient> GetAllIngredient();
        void CreateIngredient(Ingredient ingredient);
        void AddMissingIngredients(ICollection<Ingredient> ingredients);
        void DeleteIngredient(long id);
        public Ingredient GetIngredientByName(string name);
    }
}
