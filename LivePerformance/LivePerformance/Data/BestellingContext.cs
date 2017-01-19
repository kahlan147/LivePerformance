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

        public void CreateNieuweBestelling(Bestelling bestelling)
        {
            query = @"EXECUTE CreateNieuweBestelling " + bestelling.HuidigeKlant.Klantnummer + ", " + bestelling.Ophalen + ";";
            Database.Execute(query);
            query = @"SELECT dbo.GetNieuweBestellingId() AS Id;";
            DataTable result = Database.Execute(query);
            DataRow row = result.Rows[0];
            int Id = Convert.ToInt32(row["Id"].ToString());

            foreach (Product product in bestelling.Products)
            {
                query = @"EXECUTE AddProductToBestelling " + Id + ", " + product.Id + ";";
                Database.Execute(query);
            }
            foreach (Pizza pizza in bestelling.Pizzas)
            {
                if(pizza is StandaardPizza){
                    StandaardPizza newPizza = (StandaardPizza)pizza;
                    query = @"EXECUTE AddStandaardPizzaToBestelling " + Id + ", " + newPizza.Id+ "; ";
                    Database.Execute(query);
                }
                else if (pizza is CustomPizza)
                {
                    CustomPizza newPizza = (CustomPizza)pizza;
                    query = @"INSERT INTO CustomPizza VALUES(" + Id + ", '" + newPizza.Vorm + "', '" + newPizza.Formaat + "');";
                    Database.Execute(query);
                    foreach (Ingredient ingredient in newPizza.Ingredienten)
                    {
                        query = @"INSERT INTO CusPizIng VALUES(" + Id + ", " + ingredient.Id + ");";
                        Database.Execute(query);
                    }
                }
            }
        }
    }
}
