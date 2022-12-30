using System.Collections.Generic;

namespace Drinks_app.Models
{
    public class Ingredient
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<CocktailRecipe> CocktailRecipes { get; set; }
    }
}
