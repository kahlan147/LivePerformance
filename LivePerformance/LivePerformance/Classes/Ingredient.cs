using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public enum Onderdeel { Bodem, Saus, Topping };
    public class Ingredient : IPriceable
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public decimal InkoopPrijs { get; set; }
        public decimal VerkoopPrijs { get; set; }
        public bool Vegetarisch { get; set; }

        public Onderdeel onderdeel { get; set; }

        public Ingredient()
        {

        }

        public Ingredient(int Id, string Naam, decimal InkoopPrijs, decimal VerkoopPrijs, bool Vegetarisch, Onderdeel Onderdeel)
        {
            this.Id = Id;
            this.Naam = Naam;
            this.InkoopPrijs = InkoopPrijs;
            this.VerkoopPrijs = VerkoopPrijs;
            this.Vegetarisch = Vegetarisch;
            this.onderdeel = Onderdeel;
        }

        public decimal CalcTruePrice()
        {
            return VerkoopPrijs;
        }

        public override string ToString()
        {
            return Naam + ", " + InkoopPrijs + ", " + VerkoopPrijs + ", " + Vegetarisch;
        }
    }
}
