using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public abstract class Pizza
    {
        public int Id { get; set; }
        public string Vorm { get; set; }
        public string Formaat { get; set; }
        public List<Ingredient> Ingredienten { get; set; }

        

        public Pizza()
        {
            Ingredienten = new List<Ingredient>();
        }

        public Pizza(int Id, string Vorm, string Formaat)
        {
            this.Id = Id;
            this.Vorm = Vorm;
            this.Formaat = Formaat;
        }

        public override string ToString(){
            return Id + ", " + Vorm + ", " + Formaat;
        }
    }
}
