using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Data
{
    public interface IKlantContext
    {
        void AddKlant(string Naam, string Adres);
        void GeefKlantNummer(Klant klant);
    }
}
