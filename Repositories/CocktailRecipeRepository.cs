using Drinks_app.Data;
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
                var DeleteCocktailRecipe = from recipe
                                           in _db.CocktailRecipes
                                           where recipe.Id == id
                                           select recipe;
                if (DeleteCocktailRecipe != null)
                {
                    _db.CocktailRecipes.Remove((CocktailRecipe)DeleteCocktailRecipe);
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

            var getCocktailRecipeById = (from c
                                        in _db.CocktailRecipes
                                        where c.Id == id
                                        select c)
                                        .Include(c => c.User).FirstOrDefault();


            return getCocktailRecipeById;
            
        }
        public void UpdateCocktailRecipe(CocktailRecipe cocktailRecipe)
        {

            var UpdateCocktailRecipe = from updateRecipe
                                   in _db.CocktailRecipes
                                       where updateRecipe.Name == cocktailRecipe.Name
                                       select updateRecipe;
            foreach(CocktailRecipe recip in UpdateCocktailRecipe)
            {
                recip.Name = new CocktailRecipe().Name;
                recip.Recipe = new CocktailRecipe().Recipe;
            }
            _db.SaveChanges();
            //UpdateCocktailRecipe.is_default = false;
            //Context.SaveChanges();
        }
    } 
}


