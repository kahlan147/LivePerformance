using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public abstract class Pizza
    {
        public string Vorm { get; set; }
        public string Formaat { get; set; }
        public decimal Prijs { get; set; }
        public List<Ingredient> Ingredienten { get; set; }
        public Pizza()
        {
            Ingredienten = new List<Ingredient>();
        }

        public virtual string ToString(){
            return Vorm + ", " + Formaat + ", " + Prijs;
        }
    }
}
