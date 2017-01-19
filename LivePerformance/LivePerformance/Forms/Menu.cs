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
using LivePerformance.Classes;

namespace LivePerformance
{
    public partial class Form1 : Form
    {
        Pizzeria pizzeria;
        public Form1()
        {
            InitializeComponent();
            pizzeria = new Pizzeria();
            LoadListBoxes();
            LoadTab2();
            LoadTab3();
        }

        private void LoadListBoxes(){
            foreach (Product product in pizzeria.Products)
            {
                lbProducten.Items.Add(product.ToString());
            }
            foreach (Pizza pizza in pizzeria.Pizzas)
            {
                lbStandPizza.Items.Add(pizza.ToString());
            }
        }

        //Header
        private void btAanmelden_Click(object sender, EventArgs e)
        {
            if (btAanmelden.Text == "Klant aanmelden")
            {
                string Naam = tbNaam.Text;
                string Adres = tbAdres.Text;
                if (Naam != null && Naam != "")
                {
                    pizzeria.NewCustomer(Naam, Adres);
                    btAanmelden.Text = "Klant Afmelden";
                    tbNaam.Visible = false;
                    tbAdres.Visible = false;
                    lbNaam.Visible = false;
                    lbAdres.Visible = false;
                    tbNaam.Text = "";
                    tbAdres.Text = "";
                }
                else
                {
                    MessageBox.Show("Voer een naam in");
                }
            }
            else
            {
                pizzeria.NewCustomer("Onbekend", "Onbekend");
                btAanmelden.Text = "Klant aanmelden";
                tbNaam.Visible = true;
                tbAdres.Visible = true;
                lbNaam.Visible = true;
                lbAdres.Visible = true;
            }
        }

        //Tab 1

        private void btVoegPizza_Click(object sender, EventArgs e)
        {
            string SelectedPizza = lbStandPizza.SelectedItem.ToString();
            pizzeria.AddPizzaToBestelling(SelectedPizza);
            DoBestellingListBox();
        }

        private void btVoegProd_Click(object sender, EventArgs e)
        {
            string SelectedProduct = lbProducten.SelectedItem.ToString();
            pizzeria.AddProductToBestelling(SelectedProduct);
            DoBestellingListBox();
        }

        private void DoBestellingListBox()
        {
            lbBestelling.Items.Clear();
            foreach (Pizza pizza in pizzeria.HuidigeBestelling.Pizzas)
            {
                lbBestelling.Items.Add(pizza.ToString());
            }
            foreach (Product product in pizzeria.HuidigeBestelling.Products)
            {
                lbBestelling.Items.Add(product.ToString());
            }
        }

        //tab 2

        private void LoadTab2()
        {
            cbVorm.Items.Add(Vorm.Vierkant);
            cbVorm.Items.Add(Vorm.Driehoek);
            cbVorm.Items.Add(Vorm.Rechthoek);
            cbVorm.SelectedIndex = 0;
            LoadTab2ListBoxes();
        }

        private void LoadTab2ListBoxes()
        {
            foreach (Ingredient ingredient in pizzeria.Ingredients)
            {
                if (ingredient.onderdeel == Onderdeel.Bodem)
                {
                    lbBodem.Items.Add(ingredient.ToString());
                }
                else if (ingredient.onderdeel == Onderdeel.Saus)
                {
                    lbSaus.Items.Add(ingredient.ToString());
                }
                else
                {
                    lbTopping.Items.Add(ingredient.ToString());
                }
            }
        }


        private void cbVorm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVorm.SelectedIndex == 0)
            {
                tbFormaatY.Visible = false;
                tbFormaatZ.Visible = false;
                lbY.Visible = false;
                lbZ.Visible = false;
            }
            else if (cbVorm.SelectedIndex == 1)
            {
                tbFormaatY.Visible = true;
                tbFormaatZ.Visible = false;
                lbY.Visible = true;
                lbZ.Visible = false;
            }
            else if (cbVorm.SelectedIndex == 2)
            {
                tbFormaatY.Visible = true;
                tbFormaatZ.Visible = true;
                lbY.Visible = true;
                lbZ.Visible = true;
            }
        }

        private void btBodem_Click(object sender, EventArgs e)
        {
            if (IsPizzaMade())
            {
                foreach (Ingredient ingredient in pizzeria.CurrentNewPizza.Ingredienten)
                {
                    if (ingredient.onderdeel == Onderdeel.Bodem)
                    {
                        pizzeria.CurrentNewPizza.Ingredienten.Remove(ingredient);
                        break;
                    }
                }
                Ingredient newIngredient = null;
                foreach (Ingredient ingredient in pizzeria.Ingredients)
                {
                    if (ingredient.ToString() == lbBodem.SelectedItem.ToString())
                    {
                        newIngredient = ingredient;
                    }
                }
                pizzeria.CurrentNewPizza.Ingredienten.Add(newIngredient);
                showCurrentIngredients();
            }
            else
            {
                MessageBox.Show("Maak eerst een pizza aan");
            }
        }

        private void btSaus_Click(object sender, EventArgs e)
        {
            if(IsPizzaMade()){
                foreach (Ingredient ingredient in pizzeria.CurrentNewPizza.Ingredienten)
                {
                    if (ingredient.onderdeel == Onderdeel.Saus)
                    {
                        pizzeria.CurrentNewPizza.Ingredienten.Remove(ingredient);
                    }
                }
                Ingredient newIngredient = null;
                foreach (Ingredient ingredient in pizzeria.Ingredients)
                {
                    if (ingredient.ToString() == lbSaus.SelectedItem.ToString())
                    {
                        newIngredient = ingredient;
                        break;
                    }
                }
                pizzeria.CurrentNewPizza.Ingredienten.Add(newIngredient);
                showCurrentIngredients();
            }
            else
            {
                MessageBox.Show("Maak eerst een pizza aan");
            }
        }

        private void btTopping_Click(object sender, EventArgs e)
        {
            if (IsPizzaMade())
            {
                Ingredient newIngredient = null;
                foreach (Ingredient ingredient in pizzeria.Ingredients)
                {
                    if (ingredient.ToString() == lbTopping.SelectedItem.ToString())
                    {
                        newIngredient = ingredient;
                    }
                }
                pizzeria.CurrentNewPizza.Ingredienten.Add(newIngredient);
                showCurrentIngredients();
            }
            else
            {
                MessageBox.Show("Maak eerst een pizza aan");
            }
        }

        private void btNewCusPizza_Click(object sender, EventArgs e)
        {
            string Vorm = cbVorm.SelectedItem.ToString();
            string Formaat = tbFormaatX.Text;
            if(cbVorm.SelectedItem.ToString() == "Rechthoek"){
                Formaat += "x" + tbFormaatY.Text;
            }
            else if(cbVorm.SelectedItem.ToString() == "Driehoek"){
                Formaat+= "x" + tbFormaatY.Text + "x" + tbFormaatZ.Text;
            }
            CustomPizza customPizza = new CustomPizza(Vorm, Formaat);
            pizzeria.CurrentNewPizza = customPizza;
        }

        private void showCurrentIngredients()
        {
            lbCustPizzaIng.Items.Clear();
            foreach (Ingredient ingredient in pizzeria.CurrentNewPizza.Ingredienten)
            {
                lbCustPizzaIng.Items.Add(ingredient.ToString());
            }
        }

        private bool IsPizzaMade()
        {
            if (pizzeria.CurrentNewPizza != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void btGereed_Click(object sender, EventArgs e)
        {
            pizzeria.AddCustomPizzaToBestelling(pizzeria.CurrentNewPizza);
            DoBestellingListBox();
            pizzeria.CurrentNewPizza = null;
            lbCustPizzaIng.Items.Clear();
            MessageBox.Show("Custom pizza is aan de bestelling toegevoegd");
        }

        //tab 3
        private void LoadTab3()
        {
            cbNewOnd.Items.Add(Onderdeel.Bodem);
            cbNewOnd.Items.Add(Onderdeel.Saus);
            cbNewOnd.Items.Add(Onderdeel.Topping);
            cbNewOnd.SelectedIndex = 0;
        }

        private void btIngAanmaken_Click(object sender, EventArgs e)
        {
            string Naam = tbIngNaam.Text;
            decimal InkoopPrijs = Convert.ToDecimal(tbInkIng.Text);
            decimal VerkoopPrijs = Convert.ToDecimal(tbVerkIng.Text);
            bool Vegetarisch = cbVegetarisch.Checked;
            Onderdeel onderdeel = (Onderdeel)cbNewOnd.SelectedItem;
            Ingredient newIngredient = new Ingredient(-1, Naam, InkoopPrijs, VerkoopPrijs, Vegetarisch, onderdeel);
            pizzeria.AddNewIngredient(newIngredient);
        }


    }
}
