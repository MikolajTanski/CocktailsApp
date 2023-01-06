using Drinks_app.Data;
using Drinks_app.Exception;
using Drinks_app.Models;
using Drinks_app.Repositories.IRepositories;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

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
            _db.Ingredients.Add(ingredient);
            _db.SaveChanges();
        }

        public void DeleteIngredient(long id)
        {
            var deleteIngredients = (from r
                                     in _db.Ingredients
                                     where r.Id == id
                                     select r).
                                     FirstOrDefault();

            if (deleteIngredients == null) throw new NotFoundException("Ingredients is not found");

            if (deleteIngredients != null)
            {
                _db.Ingredients.Remove(deleteIngredients);
            }
            _db.SaveChanges();
        }

        public IEnumerable<Ingredient> GetAllIngredient()
        {
            var allIngredients = from c
                                 in _db.Ingredients
                                 select new Ingredient
                                 {
                                     Id = c.Id,
                                     Name = c.Name

                                 };

            if (allIngredients == null) throw new NotFoundException("Ingredients is not found");

            return allIngredients;
        }

        public Ingredient GetIngredientById(long id)
        {
            var ingredients = (from i
                               in _db.Ingredients
                               where i.Id == id
                               select i).FirstOrDefault();

            if (ingredients == null) throw new NotFoundException("Ingredients is not found");

            return ingredients;
        }
        public Ingredient GetIngredientByName(string name)
        {
            var result = _db.Ingredients.Where(i => i.Name == name).FirstOrDefault();

            if (result == null) throw new NotFoundException("Ingredients is not found");

            return result;
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            var updateIngredient = from u
                                   in _db.Ingredients
                                   where u.Id == ingredient.Id
                                   select u;

            if (updateIngredient == null) throw new NotFoundException("Ingredients is not found");

            foreach (Ingredient i in updateIngredient)
            {
                i.Name = ingredient.Name;
            }
            _db.SaveChanges();
        }

        public IEnumerable<Ingredient> GetIngredientsFromString(string IngredientsString)
        {
            IEnumerable<Ingredient> Ingredients = new Collection<Ingredient>();
            string[] IngredientsArr = IngredientsString.Split(",").Select(i => i.Trim()).ToArray();
            foreach (string IngredientName in IngredientsArr)
            {
                Ingredients.Append(this.GetIngredientByName(IngredientName));
            }

            return Ingredients;
        }
    }
}
