namespace Drinks_app.Models
{
    public class Ingredient
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public CocktailRecipe cocktailRecipe { get; set; }
    }
}
