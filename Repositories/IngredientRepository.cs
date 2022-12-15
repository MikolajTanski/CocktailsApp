﻿using Drinks_app.Data;
using Drinks_app.Models;
using Drinks_app.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
            var ingredients = _db.Ingredients.Find(id);
            if (ingredients != null) _db.Ingredients.Remove(ingredients);
            _db.SaveChanges();
        }

        public IEnumerable<Ingredient> GetAllIngredient()
        {
            var ingredients = _db.Ingredients.ToList();
            return ingredients;
        }

        public Ingredient GetIngredientById(long id)
        {
            var ingredients = _db.Ingredients.Find(id);
            return ingredients;
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            _db.Entry(ingredient).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
