﻿using System;
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
                    MessageBox.Show(pizzeria.HuidigeKlant.Klantnummer.ToString());
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
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



    }
}