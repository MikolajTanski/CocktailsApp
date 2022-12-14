using Drinks_app.Models;
using System.Collections.Generic;

namespace Drinks_app.Services.IServices
{
    public interface IIngredientService
    {
        Ingredient GetIngredient(long id);
        IEnumerable<Ingredient> GetAllIngredient();
        void CreateIngredient(Ingredient ingredient);
        void DeleteIngredient(Ingredient ingredient);
        void UpdateIngredient(Ingredient ingredient);
    }
}
