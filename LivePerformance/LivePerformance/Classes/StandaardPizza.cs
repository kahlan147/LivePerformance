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
        public StandaardPizza()
            : base()
        {

        }

        public override string ToString()
        {
            return base.ToString() +", " +  Naam;
        }
    }
}
