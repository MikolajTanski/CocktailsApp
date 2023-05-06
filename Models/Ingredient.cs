using Microsoft.CodeAnalysis.Operations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Drinks_app.Models
{
    public class Ingredient
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<CocktailRecipe> CocktailRecipes { get; set; }
    }
}
