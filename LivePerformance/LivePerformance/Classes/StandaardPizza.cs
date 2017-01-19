using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class StandaardPizza : Pizza
    {
        public string Naam { get; set; }
        public StandaardPizza(int Id, string Vorm, string Formaat, string Naam)
            : base(Id, Vorm, Formaat)
        {
            this.Naam = Naam;
        }

        public override string ToString()
        {
            return base.ToString() +", " +  Naam;
        }
    }
}
