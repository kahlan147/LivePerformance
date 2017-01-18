using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformance
{
    public partial class BestellingForm : Form
    {
        public BestellingForm()
        {
            InitializeComponent();
        }

        public BestellingForm(Klant HuidigeKlant)
        {
            InitializeComponent();
            this.Text = "Bestelling voor: " + HuidigeKlant.Naam;
        }
    }
}
