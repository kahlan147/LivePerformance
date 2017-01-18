using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LivePerformance.Data
{
    public class BestellingContext : IBestellingContext
    {
        private string query;
        public DataTable GetAllIngredients()
        {
            query = @"SELECT * FROM Ingredient";
            DataTable result = Database.Execute(query);
            return result;
        }
    }
}
