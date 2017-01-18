using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformance.Logic;
using LivePerformance.Data;

namespace LivePerformance
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btAanmelden_Click(object sender, EventArgs e)
        {
            string Naam = tbNaam.Text;
            string Adres = tbAdres.Text;
            if (Naam != null && Naam != "")
            {
                Klant HuidigeKlant = new Klant(Naam, Adres);
                BestellingForm bestellingForm = new BestellingForm(HuidigeKlant);
                bestellingForm.Show();
            }
            else
            {
                MessageBox.Show("Voer een naam in");
            }
        }

        private void btOnbekend_Click(object sender, EventArgs e)
        {
            Klant HuidigeKlant = new Klant();
            BestellingForm bestellingForm = new BestellingForm(HuidigeKlant);
            bestellingForm.Show();
        }
    }
}
