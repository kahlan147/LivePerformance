using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Logic;
using LivePerformance.Data;

namespace LivePerformance.Classes
{

    public enum Vorm { Vierkant, Driehoek, Rechthoek };

    public class Pizzeria
    {
        private InventarisRepository InventarisRepo;
        private BestellingRepository BestellingRepo;
        public Klant HuidigeKlant { get; private set; }
        public List<Product> Products { get; private set; }
        public List<Pizza> Pizzas { get; private set; }
        public List<Ingredient> Ingredients { get; private set; }
        public Bestelling HuidigeBestelling { get; private set; }
        public Pizza CurrentNewPizza { get; set; }
        public List<Ingredient> IngredientsCustPizza { get; set; }

        public Pizzeria()
        {
            InventarisRepo = new InventarisRepository(new InventarisContext());
            BestellingRepo = new BestellingRepository(new BestellingContext());
            Klant unknownKlant = new Klant("Unknown", "Unknown");
            HuidigeBestelling = new Bestelling(unknownKlant);
            GetLists();
        }

        public void GetLists()
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

        public void SaveBestelling()
        {
            BestellingRepo.CreateNieuweBestelling(HuidigeBestelling);
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

        public void AddCustomPizzaToBestelling(Pizza pizza)
        {
            HuidigeBestelling.Pizzas.Add(pizza);
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

        public void AddNewIngredient(Ingredient ingredient)
        {
            InventarisRepo.AddNewIngredient(ingredient);
        }

        public void AddNewProduct(Product product)
        {
            InventarisRepo.AddNewProduct(product);
        }

        public void AddNewStandardPizza(Pizza pizza)
        {
            InventarisRepo.AddNewStandardPizza(pizza);
        }

        public decimal[] getTotalPrice()
        {
            foreach (Pizza pizza in HuidigeBestelling.Pizzas)
            {
                if(pizza is StandaardPizza){
                    StandaardPizza newPizza = (StandaardPizza)pizza;
                    List<Ingredient> ingredients = InventarisRepo.GetIngredientsFromPizza(newPizza.Id);
                    pizza.Ingredienten = ingredients;
                }
            }
            return HuidigeBestelling.GetTotalPrice();
        }
    }
}
