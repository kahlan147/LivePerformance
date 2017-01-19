using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformance.Data;
using LivePerformance.Logic;

namespace LivePerformance
{
    public partial class BestellingForm : Form
    {
        private InventarisRepository InventarisRepo;
        public BestellingForm()
        {
            InitializeComponent();
            this.Text = "Bestelling";
            DoListBoxes();
        }

        public BestellingForm(Klant HuidigeKlant)
        {
            InitializeComponent();
            this.Text = "Bestelling voor: " + HuidigeKlant.Naam;
            DoListBoxes();
        }

        private void DoListBoxes()
        {
            InventarisRepo = new InventarisRepository(new InventarisContext());
            List<Ingredient> Ingredienten = InventarisRepo.GetAllIngredients();
            foreach(Ingredient ing in Ingredienten){
                lbProducten.Items.Add(ing.ToString());
            }
        }

        private void btVoegProd_Click(object sender, EventArgs e)
        {

        }
    }
}
