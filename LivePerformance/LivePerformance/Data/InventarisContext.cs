using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LivePerformance.Data
{
    public class InventarisContext : IInventarisContext
    {
        private string query;

        public List<Ingredient> GetAllIngredients()
        {
            List<Ingredient> Ingredienten = new List<Ingredient>();
            query = @"SELECT * FROM GetAllIngredients();";
            DataTable result = Database.Execute(query);
            foreach (DataRow row in result.Rows)
            {
                int Id = Convert.ToInt32(row["Id"]);
                string Naam = row["Naam"].ToString();
                decimal InkoopPrijs = Convert.ToDecimal(row["InkoopPrijs"]);
                decimal VerkoopPrijs = Convert.ToDecimal(row["VerkoopPrijs"]);
                bool Vegetarisch = true;
                Ingredient ingredient = new Ingredient(Id,Naam,InkoopPrijs,VerkoopPrijs,Vegetarisch);
                Ingredienten.Add(ingredient);
            }
            return Ingredienten;
        }
    }
}
