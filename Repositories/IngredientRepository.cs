using Drinks_app.Data;
using Drinks_app.Models;
using Drinks_app.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
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
            var deleteingredients = (from r
                                     in _db.Ingredients
                                     where r.Id == id
                                     select r).
                                     FirstOrDefault();
                                     
            if (deleteingredients != null)
            {
                _db.Ingredients.Remove(deleteingredients);
            }
            _db.SaveChanges();
        }

        public IEnumerable<Ingredient> GetAllIngredient()
        {
            var allingredients = from c
                                 in _db.Ingredients
                                 select new Ingredient
                                 {
                                     Id = c.Id,
                                     Name = c.Name

                                 };
            return allingredients;
        }

        public Ingredient GetIngredientById(long id)
        {
            var ingredients = (from i
                               in _db.Ingredients
                               where i.Id == id
                               select i).FirstOrDefault();
            return ingredients;
        }
        public Ingredient GetIngredientByName(string name)
        {
            return _db.Ingredients.Where(i => i.Name == name).FirstOrDefault();
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            var updateIngredient = from u
                                   in _db.Ingredients
                                   where u.Id == ingredient.Id
                                   select u;
            foreach(Ingredient i in updateIngredient)
            {
                i.Name = ingredient.Name;
            }
            _db.SaveChanges();
        }

        public IEnumerable<Ingredient> GetIngredientsFromString(string IngredientsString)
        {
            IEnumerable<Ingredient> Ingredients = new Collection<Ingredient>();
            string[] IngredientsArr = IngredientsString.Split(",").Select(i => i.Trim()).ToArray();
            foreach(string IngredientName in IngredientsArr)
            {
                Ingredients.Append(this.GetIngredientByName(IngredientName));
            }

            return Ingredients;
        }
    }
}
