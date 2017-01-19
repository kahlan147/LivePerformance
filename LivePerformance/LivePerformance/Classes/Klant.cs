using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LivePerformance.Data;
using LivePerformance.Logic;

namespace LivePerformance
{
    public class Klant
    {
        private KlantRepository KlantRepo;

        public int Klantnummer { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }


        public Klant()
        {

        }

        public Klant(string Naam, string Adres)
        {
            KlantRepo = new KlantRepository(new KlantContext());
            KlantRepo.AddKlant(Naam, Adres);
            this.Naam = Naam;
            this.Adres = Adres;
            this.Klantnummer = KlantRepo.GeefKlantNummer(this);
        }
    }
}
