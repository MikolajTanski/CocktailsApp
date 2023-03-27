using Drinks_app.Models;
using System.Collections.Generic;

namespace Drinks_app.Services.IServices
{
    public interface IIngredientService
    {
        Ingredient GetIngredientById(long id);
        IEnumerable<Ingredient> GetAllIngredient();
        void CreateIngredient(Ingredient ingredient);
        void DeleteIngredient(long id);
        void UpdateIngredient(Ingredient ingredient);
        IEnumerable<Ingredient> GetIngredientsFromString(string IngredientsString);
    }
}
