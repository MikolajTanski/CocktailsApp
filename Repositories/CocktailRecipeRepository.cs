﻿using Drinks_app.Data;
using Drinks_app.Models;
using Drinks_app.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Drinks_app.Repositories
{
    public class CocktailRecipeRepository : ICocktailRecipeRepository
    {
        private readonly ApplicationDbContext _db;

        public CocktailRecipeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void CreateCocktailRecipe(CocktailRecipe cocktailRecipe)
        {
            _db.CocktailRecipes.Add(cocktailRecipe);
            _db.SaveChanges();

        }

        //[DataObjectMethod(DataObjectMethodType.Delete)]
        public void DeleteCocktailRecipe(long id)
        {
            //using (var db = _db.CocktailRecipes()) {
                var deleteCocktailRecipe = (from recipe
                                           in _db.CocktailRecipes
                                           where recipe.Id == id
                                           select recipe).Include(recipe => recipe.User).Include(recipe => recipe.Ingredients).FirstOrDefault();
                if (deleteCocktailRecipe != null)
                {
                _db.CocktailRecipes.Remove(deleteCocktailRecipe);
              
                _db.SaveChanges();

                }
            //}
        }


        public IEnumerable<CocktailRecipe> GetAllCocktailRecipe()
        {
            var AllCocktailRecipes = from c in _db.CocktailRecipes
                                     select new CocktailRecipe
                                     {
                                         Id = c.Id,
                                         Name = c.Name,
                                         Recipe = c.Recipe,
                                         User = c.User,
                                     };
            return AllCocktailRecipes;
        }

            public CocktailRecipe GetCocktailRecipeById(long id)
        {

            var getCocktailRecipeById = (from i
                                        in _db.CocktailRecipes
                                        where i.Id == id
                                        select i).FirstOrDefault();
                                     
            return getCocktailRecipeById;
            
        }
        public void UpdateCocktailRecipe(CocktailRecipe cocktailRecipe)
        {

            var UpdateCocktailRecipe = from updateRecipe
                                   in _db.CocktailRecipes
                                        where updateRecipe.Id == cocktailRecipe.Id
                                        select updateRecipe;
            foreach(CocktailRecipe recip in UpdateCocktailRecipe)
            {
                recip.Name = cocktailRecipe.Name;
                recip.Recipe = cocktailRecipe.Recipe;
            }
            
           
            _db.SaveChanges();
            //UpdateCocktailRecipe.is_default = false;
            //Context.SaveChanges();
        }
    } 
}


