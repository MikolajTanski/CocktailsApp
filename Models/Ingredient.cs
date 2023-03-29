using Microsoft.CodeAnalysis.Operations;
using System.Collections.Generic;

namespace Drinks_app.Models
{
    public class Ingredient
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CocktailRecipe> CocktailRecipes { get; set; }
    }
}
