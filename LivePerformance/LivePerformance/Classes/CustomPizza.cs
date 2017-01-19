using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class CustomPizza : Pizza
    {

        public CustomPizza(string Vorm, string Formaat)
            : base(Vorm, Formaat)
        {

        }

        public override string ToString()
        {
            return "Custom" + ", " + base.ToString();
        }
    }
}
