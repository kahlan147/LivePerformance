using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Data;
using System.Data;

namespace LivePerformance.Logic
{
    public class BestellingRepository : IBestellingContext
    {
        private IBestellingContext Context;

        public BestellingRepository(IBestellingContext context)
        {
            this.Context = context;
        }

        public void CreateNieuweBestelling(Bestelling bestelling)
        {
            Context.CreateNieuweBestelling(bestelling);
        }

    }
}
