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
        void AddNewIngredient(Ingredient ingredient);
        void AddNewStandardPizza(Pizza pizza);
        void AddNewProduct(Product product);
    }
}
