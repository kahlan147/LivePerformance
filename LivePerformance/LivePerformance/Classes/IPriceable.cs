using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public interface IPriceable
    {
        decimal InkoopPrijs { get; set; }
        decimal VerkoopPrijs { get; set; }

        decimal CalcTruePrice();
    }
}
