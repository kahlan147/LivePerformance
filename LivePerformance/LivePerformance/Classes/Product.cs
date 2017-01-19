using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Product : IPriceable
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public decimal InkoopPrijs { get; set; }
        public decimal VerkoopPrijs { get; set; }
        public bool Alcoholisch { get; set; }

        public Product()
        {

        }

        public Product(int Id, string Naam, decimal InkoopPrijs, decimal VerkoopPrijs, bool Alcoholisch)
        {
            this.Id = Id;
            this.Naam = Naam;
            this.InkoopPrijs = InkoopPrijs;
            this.VerkoopPrijs = VerkoopPrijs;
            this.Alcoholisch = Alcoholisch;
        }

        public decimal CalcTruePrice()
        {
            return VerkoopPrijs;
        }

        public override string ToString()
        {
            return Id + ", " + Naam + ", " + InkoopPrijs + ", " + VerkoopPrijs + ", " + Alcoholisch;
        }
    }
}
