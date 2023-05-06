using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Drinks_app.Models
{
    public class CocktailRecipe
    {
        public long Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public string Recipe { get; set; }
        public ApplicationUser User { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }

    }
}
