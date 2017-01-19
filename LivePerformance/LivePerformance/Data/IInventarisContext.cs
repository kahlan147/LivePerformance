using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Data
{
    public interface IInventarisContext
    {
        List<Ingredient> GetAllIngredients();
        List<Product> GetAllProducts();
        List<Pizza> GetAllStandardPizzas();
    }
}
