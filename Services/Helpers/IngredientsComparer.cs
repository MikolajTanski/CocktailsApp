using Drinks_app.Models;
using System.Collections.Generic;
using System;

namespace Drinks_app.Services.Helpers
{
    class IngredientsComparer : IEqualityComparer<Ingredient>
    {
        public bool Equals(Ingredient x, Ingredient y)
        {
            if (string.Equals(x.Name, y.Name, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }

        public int GetHashCode(Ingredient obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
