﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Bestelling
    {
        public int Id { get; set; }
        public int KlantNummer { get; set; }
        public bool Ophalen { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public List<Product> Products { get; set; }

        public readonly Klant HuidigeKlant;

        public Bestelling(Klant HuidigeKlant)
        {
            this.Pizzas = new List<Pizza>();
            this.Products = new List<Product>();
            this.HuidigeKlant = HuidigeKlant;
        }

        public decimal GetTotalPrice()
        {
            decimal TotalPrice = 0;
            decimal reductionPercentage;
            foreach (Pizza pizza in Pizzas)
            {
                if (pizza is StandaardPizza)
                {
                    reductionPercentage = Convert.ToDecimal(0.25);
                }
                else
                {
                    reductionPercentage = 0;
                }
                foreach (Ingredient ingredient in pizza.Ingredienten)
                {
                    TotalPrice += getCost(ingredient, reductionPercentage);
                }
            }
            foreach (Product product in Products)
            {
                TotalPrice += getCost(product, 0);
            }
            return TotalPrice;
        }

        private decimal getCost(IPriceable Sellable, decimal reduction)
        {
            decimal duplicator = 1;
            if (Sellable is Pizza)
            {
                Pizza pizza = (Pizza)Sellable;
                string formaat = pizza.Formaat;
                string vorm = pizza.Vorm;
                int[] numbers = new int[6];
                string number = "";
                decimal Oppervlakte = 0;

                switch (vorm)
                {
                    case "Vierkant":
                        foreach (char thisChar in formaat)
                        {
                            if (thisChar == 'c')
                            {
                                break;
                            }
                            number += thisChar;
                        }
                        Oppervlakte = Convert.ToDecimal(Convert.ToInt32(number) * Math.PI);
                        break;
                    case "Rechthoek":
                        foreach (char thisChar in formaat)
                        {
                            if (thisChar == 'x')
                            {
                                numbers[0] = Convert.ToInt32(number);
                                number = "";
                            }
                            if (thisChar == 'c')
                            {
                                numbers[1] = Convert.ToInt32(number);
                                break;
                            }
                            number += thisChar;
                        }
                        Oppervlakte = Convert.ToDecimal(numbers[0] * numbers[1]);
                        break;
                    case "Driehoek":
                        int x = 0;
                        foreach (char thisChar in formaat)
                        {
                            if (thisChar == 'x')
                            {
                                numbers[x] = Convert.ToInt32(number);
                                number = "";
                                x++;
                            }
                            if (thisChar == 'c')
                            {
                                numbers[2] = Convert.ToInt32(number);
                                break;
                            }
                            number += thisChar;
                        }
                        Oppervlakte = 
                        break;
                }
            }
            return (Sellable.VerkoopPrijs - (Sellable.VerkoopPrijs * reduction));
        }
    }
}
