using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    enum Onderdeel { Bodem, Saus, Topping };
    public class Ingredient : IPriceable
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public decimal InkoopPrijs { get; set; }
        public decimal VerkoopPrijs { get; set; }
        public bool Vegetarisch { get; set; }

        public int Onderdeel { get; set; }

        public Ingredient()
        {

        }

        public Ingredient(int Id, string Naam, decimal InkoopPrijs, decimal VerkoopPrijst, bool Vegetarisch, int Onderdeel)
        {
            this.Id = Id;
            this.Naam = Naam;
            this.InkoopPrijs = InkoopPrijs;
            this.VerkoopPrijs = VerkoopPrijs;
            this.Vegetarisch = Vegetarisch;
            this.Onderdeel = Onderdeel;
        }

        public decimal CalcTruePrice()
        {
            return VerkoopPrijs;
        }

        public override string ToString()
        {
            return Naam + ", " + InkoopPrijs + ", " + VerkoopPrijs + ", " + Vegetarisch + ", " + Onderdeel;
        }
    }
}
