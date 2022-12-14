using Drinks_app.Data;
using Drinks_app.Models;
using Drinks_app.Repositories.IRepositories;
using System.Collections.Generic;

namespace Drinks_app.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly ApplicationDbContext _db;

        public IngredientRepository(ApplicationDbContext db)
        {
            _db = db;
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

        public Ingredient UpdateIngredient(Ingredient ingredient)
        {
            throw new System.NotImplementedException();
        }
    }
}
