﻿using System;
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
                if (row["Vegetarisch"].ToString() == "0")
                {
                    Vegetarisch = false;
                }
                int Onderdeel = Convert.ToInt32(row["PizzaOnderdeel"].ToString());
                Ingredient ingredient = new Ingredient(Id,Naam,InkoopPrijs,VerkoopPrijs,Vegetarisch, Onderdeel);
                Ingredienten.Add(ingredient);
            }
            return Ingredienten;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> Products = new List<Product>();
            query = @"SELECT * FROM GetAllProducts();";
            DataTable result = Database.Execute(query);
            foreach (DataRow row in result.Rows)
            {
                int Id = Convert.ToInt32(row["Id"].ToString());
                string Naam = row["Naam"].ToString();
                decimal InkoopPrijs = Convert.ToDecimal(row["InkoopPrijs"].ToString());
                decimal VerkoopPrijs = Convert.ToDecimal(row["VerkoopPrijs"].ToString());
                bool Alcoholisch = false;
                if(row["Alcoholisch"].ToString() == "1"){
                    Alcoholisch = true;
                }
                Product newProduct = new Product(Id, Naam, InkoopPrijs, VerkoopPrijs, Alcoholisch);
                Products.Add(newProduct);
            }

            return Products;
        }

        public List<Pizza> GetAllStandardPizzas()
        {
            List<Pizza> Pizzas = new List<Pizza>();
            query = @"SELECT * FROM GetAllStandaardPizzas();";
            DataTable result = Database.Execute(query);
            foreach (DataRow row in result.Rows)
            {
                int Id = Convert.ToInt32(row["Id"].ToString());
                string Vorm = row["Vorm"].ToString();
                string Formaat = row["Formaat"].ToString();
                string Naam = row["Naam"].ToString();
                StandaardPizza newPizza = new StandaardPizza(Id,Vorm,Formaat, Naam);
                Pizzas.Add(newPizza);
            }

            return Pizzas;
        }
    }
}