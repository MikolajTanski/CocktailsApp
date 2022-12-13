using System.Collections.Generic;

namespace Drinks_app.Models
{
    public class CocktailRecipe
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Recipe { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }

    }
}
