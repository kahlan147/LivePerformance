using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Bestelling
    {
        public int Id { get; set; }
        public int KlantNummer { get; set; }
        public bool Ophalen { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public List<Product> Products { get; set; }
        public readonly Klant HuidigeKlant;



        public Bestelling(Klant HuidigeKlant)
        {
            this.Pizzas = new List<Pizza>();
            this.Products = new List<Product>();
            this.HuidigeKlant = HuidigeKlant;
        }

        public decimal GetTotalPrice()
        {
            decimal TotalPrice = 0;
            foreach (Pizza pizza in Pizzas)
            {
                foreach (Ingredient ingredient in pizza.Ingredienten)
                {
                    TotalPrice += getCost(ingredient, Convert.ToDecimal(0.25));
                }
            }
            foreach (Product product in Products)
            {
                TotalPrice += getCost(product, 0);
            }
            return TotalPrice;
        }

        private decimal getCost(IPriceable Sellable, decimal reduction)
        {
            return Sellable.VerkoopPrijs - (Sellable.VerkoopPrijs * reduction);
        }
    }
}
