using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public abstract class Pizza
    {
        public string Naam { get; set; }
        public string Vorm { get; set; }
        public string Formaat { get; set; }
        public List<Ingredient> Ingredienten { get; set; }

        

        public Pizza()
        {
            Ingredienten = new List<Ingredient>();
        }

        public Pizza(string Vorm, string Formaat)
        {
            this.Vorm = Vorm;
            this.Formaat = Formaat;
            Ingredienten = new List<Ingredient>();
        }

        public override string ToString(){
            return Vorm + ", " + Formaat;
        }
    }
}
