using Drinks_app.Models;
using System.Collections.Generic;

namespace Drinks_app.Repositories.IRepositories
{
    public interface IIngredientRepository
    {
        Ingredient UpdateIngredient(Ingredient ingredient);
        Ingredient GetIngredient(long id);
        IEnumerable<Ingredient> GetAllIngredient();
        void CreateIngredient(Ingredient ingredient);
        void DeleteIngredient(Ingredient ingredient);
    }
}
