using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Logic;
using LivePerformance.Data;

namespace LivePerformance.Classes
{

    enum Vorm { Vierkant, Driehoek, Rechthoek };

    public class Pizzeria
    {
        private InventarisRepository InventarisRepo;
        public Klant HuidigeKlant { get; private set; }
        public List<Product> Products { get; private set; }
        public List<Pizza> Pizzas { get; private set; }
        public List<Ingredient> Ingredients { get; private set; }
        public Bestelling HuidigeBestelling { get; private set; }

        public Pizzeria()
        {
            InventarisRepo = new InventarisRepository(new InventarisContext());
            GetLists();
        }

        private void GetLists()
        {
            Products = InventarisRepo.GetAllProducts();
            Pizzas = InventarisRepo.GetAllStandardPizzas();
            Ingredients = InventarisRepo.GetAllIngredients();
        }

        public void NewCustomer(string Naam, string Adres)
        {
            HuidigeKlant = new Klant(Naam, Adres);
            HuidigeBestelling = new Bestelling(HuidigeKlant);
        }

        public void AddPizzaToBestelling(string PizzaString)
        {
            Pizza chosenPizza = null;
            foreach (Pizza pizza in Pizzas)
            {
                if (pizza.ToString() == PizzaString)
                {
                    chosenPizza = pizza;
                }
            }
            HuidigeBestelling.Pizzas.Add(chosenPizza);
        }

        public void AddProductToBestelling(string ProductString)
        {
            Product chosenProduct = null;
            foreach (Product product in Products)
            {
                if (product.ToString() == ProductString)
                {
                    chosenProduct = product;
                }
            }
            HuidigeBestelling.Products.Add(chosenProduct);
        }
    }
}
