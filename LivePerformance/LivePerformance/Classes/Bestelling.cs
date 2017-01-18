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

        private decimal TotalPrice;

        public Bestelling()
        {
            this.Pizzas = new List<Pizza>();
            this.Products = new List<Product>();
            this.TotalPrice = 0;
        }

        public decimal GetTotalPrice()
        {
            
            return TotalPrice;
        }

        private decimal getCost(IPriceable Sellable, int reduction)
        {
            return 0;
        }
    }
}
