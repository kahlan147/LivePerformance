using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class StandaardPizza : Pizza
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public StandaardPizza(int Id, string Vorm, string Formaat, string Naam)
            : base(Vorm, Formaat)
        {
            this.Id = Id;
            this.Naam = Naam;
        }

        public override string ToString()
        {
            return Id + ", " +  Naam + ", " + base.ToString();
        }
    }
}
