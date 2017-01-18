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
        BestellingRepository BestellingRepo;
        public Form1()
        {
            InitializeComponent();
            BestellingRepo = new BestellingRepository(new BestellingContext());
        }

        private void btAanmaken_Click(object sender, EventArgs e)
        {

        }

        private void btAanmelden_Click(object sender, EventArgs e)
        {

        }

        private void btOnbekend_Click(object sender, EventArgs e)
        {
            DataTable test = BestellingRepo.GetAllIngredients();
            foreach (DataRow row in test.Rows)
            {
                listBox1.Items.Add(row["Naam"]);
            }
        }
    }
}
