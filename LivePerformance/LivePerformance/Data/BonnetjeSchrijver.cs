using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Data
{
    public static class BonnetjeSchrijver
    {

        public static void MaakBonnetje()
        {
            string[] lines = { "First line", "Second line", "Third line" };
            System.IO.File.WriteAllLines(@"C:\Users\Niels\Dropbox\LP\WriteLines.txt", lines);
        }
        
    }
}
