using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Data;

namespace LivePerformance.Logic
{
    public class InventarisRepository : IInventarisContext
    {
        private IInventarisContext Context;

        public InventarisRepository(IInventarisContext context)
        {
            this.Context = context;
        }

        public List<Ingredient> GetAllIngredients()
        {
            return Context.GetAllIngredients();
        }

        public List<Product> GetAllProducts()
        {
            return Context.GetAllProducts();
        }

        public List<Pizza> GetAllStandardPizzas()
        {
            return Context.GetAllStandardPizzas();
        }

    }
}
