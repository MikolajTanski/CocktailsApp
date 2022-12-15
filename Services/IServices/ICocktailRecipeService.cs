﻿using Drinks_app.Models;
using System.Collections.Generic;

namespace Drinks_app.Services.IServices
{
    public interface ICocktailRecipeService
    {
        CocktailRecipe GetCocktailRecipeById(long id);
        IEnumerable<CocktailRecipe> GetAllCocktailRecipe();
        void CreateCocktailRecipe(CocktailRecipe cocktailRecipe);
        void DeleteCocktailRecipe(long id);
        void UpdateCocktailRecipe(CocktailRecipe cocktailRecipe);
    }
}
