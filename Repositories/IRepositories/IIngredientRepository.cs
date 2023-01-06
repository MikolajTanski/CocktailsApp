using Drinks_app.Models;
using System.Collections.Generic;

namespace Drinks_app.Repositories.IRepositories
{
    public interface IIngredientRepository
    {
        void UpdateIngredient(Ingredient ingredient);
        Ingredient GetIngredientById(long id);
        IEnumerable<Ingredient> GetAllIngredient();
        IEnumerable<Ingredient> GetIngredientsFromString(string IngredientsString);
        void CreateIngredient(Ingredient ingredient);
        void DeleteIngredient(long id);
    }
}
