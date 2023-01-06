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

        public IEnumerable<CocktailRecipe> GetAllCocktailRecipe() { 
           var AllCocktailRecipe = from c
                             in _db.CocktailRecipes
                             join u in _db.Users on c.User.Id equals u.Id
                             select new CocktailRecipe
                             {
                                 Id = c.Id,
                                 Name = c.Name,
                                 Recipe = c.Recipe,
                                 User = u,
                             };
            return AllCocktailRecipe;
        }
        public CocktailRecipe GetCocktailRecipeById(long id)
        {

            var GetCocktailRecipeById = from i
                                        in _db.CocktailRecipes
                                        join u in _db.Users on i.User.Id equals u.Id
                                        where i.Id == id
                                        select new CocktailRecipe
                                        {
                                            Id = i.Id,
                                            Name = i.Name,
                                            Recipe = i.Recipe,
                                            User = u,
                                        };
            return (CocktailRecipe)GetCocktailRecipeById;
            
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


