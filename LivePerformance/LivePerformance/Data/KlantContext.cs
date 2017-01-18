using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LivePerformance.Data
{
    public class KlantContext : IKlantContext
    {
        private string query;
        
        public void AddKlant(string Naam, string Adres)
        {
            query = @"EXECUTE AddKlant '"+ Naam + "', '" + Adres +"';";
            Database.Execute(query);
        }

        public void GeefKlantNummer(Klant klant)
        {
            query = @"SELECT dbo.GeefKlantNummer('" + klant.Naam + "', '" + klant.Adres + "') as 'Klantnummer';";
            DataTable result = Database.Execute(query);
            DataRow row = result.Rows[0];
            klant.Klantnummer = Convert.ToInt32(row["Klantnummer"]);
        }
    }
}
