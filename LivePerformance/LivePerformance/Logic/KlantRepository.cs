using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Data;
using System.Data;

namespace LivePerformance.Logic
{
    public class KlantRepository : IKlantContext
    {
        private IKlantContext Context;

        public KlantRepository(IKlantContext context)
        {
            this.Context = context;
        }

        public void AddKlant(string Naam, string Adres)
        {
            Context.AddKlant(Naam, Adres);
        }

        public void GeefKlantNummer(Klant klant)
        {
            Context.GeefKlantNummer(klant);
        }
    }
}
