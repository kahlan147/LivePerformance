﻿namespace LivePerformance
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.lbNaam = new System.Windows.Forms.Label();
            this.lbAdres = new System.Windows.Forms.Label();
            this.btAanmelden = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btMinEen = new System.Windows.Forms.Button();
            this.btPlusEen = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbBestelling = new System.Windows.Forms.ListBox();
            this.btVoegProd = new System.Windows.Forms.Button();
            this.btVoegPizza = new System.Windows.Forms.Button();
            this.lbProducten = new System.Windows.Forms.ListBox();
            this.lbStandPizza = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.btGereed = new System.Windows.Forms.Button();
            this.btTopping = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCustPizzaIng = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFormaatZ = new System.Windows.Forms.TextBox();
            this.tbFormaatY = new System.Windows.Forms.TextBox();
            this.tbFormaatX = new System.Windows.Forms.TextBox();
            this.cbVorm = new System.Windows.Forms.ComboBox();
            this.lbTopping = new System.Windows.Forms.ListBox();
            this.lbSaus = new System.Windows.Forms.ListBox();
            this.lbBodem = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lbY = new System.Windows.Forms.Label();
            this.lbZ = new System.Windows.Forms.Label();
            this.btBodem = new System.Windows.Forms.Button();
            this.btSaus = new System.Windows.Forms.Button();
            this.btNewCusPizza = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(32, 34);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 20);
            this.tbNaam.TabIndex = 0;
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(155, 34);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(100, 20);
            this.tbAdres.TabIndex = 1;
            // 
            // lbNaam
            // 
            this.lbNaam.AutoSize = true;
            this.lbNaam.Location = new System.Drawing.Point(29, 18);
            this.lbNaam.Name = "lbNaam";
            this.lbNaam.Size = new System.Drawing.Size(38, 13);
            this.lbNaam.TabIndex = 2;
            this.lbNaam.Text = "Naam:";
            // 
            // lbAdres
            // 
            this.lbAdres.AutoSize = true;
            this.lbAdres.Location = new System.Drawing.Point(152, 18);
            this.lbAdres.Name = "lbAdres";
            this.lbAdres.Size = new System.Drawing.Size(37, 13);
            this.lbAdres.TabIndex = 3;
            this.lbAdres.Text = "Adres:";
            // 
            // btAanmelden
            // 
            this.btAanmelden.Location = new System.Drawing.Point(273, 14);
            this.btAanmelden.Name = "btAanmelden";
            this.btAanmelden.Size = new System.Drawing.Size(75, 40);
            this.btAanmelden.TabIndex = 5;
            this.btAanmelden.Text = "Klant aanmelden";
            this.btAanmelden.UseVisualStyleBackColor = true;
            this.btAanmelden.Click += new System.EventHandler(this.btAanmelden_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 410);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btMinEen);
            this.tabPage1.Controls.Add(this.btPlusEen);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.lbBestelling);
            this.tabPage1.Controls.Add(this.btVoegProd);
            this.tabPage1.Controls.Add(this.btVoegPizza);
            this.tabPage1.Controls.Add(this.lbProducten);
            this.tabPage1.Controls.Add(this.lbStandPizza);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bestelling";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bestelling";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Producten";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pizzas";
            // 
            // btMinEen
            // 
            this.btMinEen.Location = new System.Drawing.Point(483, 178);
            this.btMinEen.Name = "btMinEen";
            this.btMinEen.Size = new System.Drawing.Size(51, 45);
            this.btMinEen.TabIndex = 12;
            this.btMinEen.Text = "-1";
            this.btMinEen.UseVisualStyleBackColor = true;
            // 
            // btPlusEen
            // 
            this.btPlusEen.Location = new System.Drawing.Point(483, 127);
            this.btPlusEen.Name = "btPlusEen";
            this.btPlusEen.Size = new System.Drawing.Size(51, 45);
            this.btPlusEen.TabIndex = 11;
            this.btPlusEen.Text = "+1";
            this.btPlusEen.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Klaar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbBestelling
            // 
            this.lbBestelling.FormattingEnabled = true;
            this.lbBestelling.Location = new System.Drawing.Point(540, 33);
            this.lbBestelling.Name = "lbBestelling";
            this.lbBestelling.Size = new System.Drawing.Size(206, 316);
            this.lbBestelling.TabIndex = 9;
            // 
            // btVoegProd
            // 
            this.btVoegProd.Location = new System.Drawing.Point(315, 355);
            this.btVoegProd.Name = "btVoegProd";
            this.btVoegProd.Size = new System.Drawing.Size(75, 23);
            this.btVoegProd.TabIndex = 8;
            this.btVoegProd.Text = "Voeg toe";
            this.btVoegProd.UseVisualStyleBackColor = true;
            this.btVoegProd.Click += new System.EventHandler(this.btVoegProd_Click);
            // 
            // btVoegPizza
            // 
            this.btVoegPizza.Location = new System.Drawing.Point(65, 355);
            this.btVoegPizza.Name = "btVoegPizza";
            this.btVoegPizza.Size = new System.Drawing.Size(75, 23);
            this.btVoegPizza.TabIndex = 7;
            this.btVoegPizza.Text = "Voeg toe";
            this.btVoegPizza.UseVisualStyleBackColor = true;
            this.btVoegPizza.Click += new System.EventHandler(this.btVoegPizza_Click);
            // 
            // lbProducten
            // 
            this.lbProducten.FormattingEnabled = true;
            this.lbProducten.Location = new System.Drawing.Point(239, 33);
            this.lbProducten.Name = "lbProducten";
            this.lbProducten.Size = new System.Drawing.Size(211, 316);
            this.lbProducten.TabIndex = 2;
            // 
            // lbStandPizza
            // 
            this.lbStandPizza.FormattingEnabled = true;
            this.lbStandPizza.Location = new System.Drawing.Point(6, 33);
            this.lbStandPizza.Name = "lbStandPizza";
            this.lbStandPizza.Size = new System.Drawing.Size(218, 316);
            this.lbStandPizza.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btNewCusPizza);
            this.tabPage2.Controls.Add(this.btSaus);
            this.tabPage2.Controls.Add(this.btBodem);
            this.tabPage2.Controls.Add(this.lbZ);
            this.tabPage2.Controls.Add(this.lbY);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btGereed);
            this.tabPage2.Controls.Add(this.btTopping);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lbCustPizzaIng);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbFormaatZ);
            this.tabPage2.Controls.Add(this.tbFormaatY);
            this.tabPage2.Controls.Add(this.tbFormaatX);
            this.tabPage2.Controls.Add(this.cbVorm);
            this.tabPage2.Controls.Add(this.lbTopping);
            this.tabPage2.Controls.Add(this.lbSaus);
            this.tabPage2.Controls.Add(this.lbBodem);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Custom pizza";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(603, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Pizza:";
            // 
            // btGereed
            // 
            this.btGereed.Location = new System.Drawing.Point(644, 353);
            this.btGereed.Name = "btGereed";
            this.btGereed.Size = new System.Drawing.Size(75, 23);
            this.btGereed.TabIndex = 14;
            this.btGereed.Text = "Gereed";
            this.btGereed.UseVisualStyleBackColor = true;
            this.btGereed.Click += new System.EventHandler(this.btGereed_Click);
            // 
            // btTopping
            // 
            this.btTopping.Location = new System.Drawing.Point(437, 353);
            this.btTopping.Name = "btTopping";
            this.btTopping.Size = new System.Drawing.Size(75, 23);
            this.btTopping.TabIndex = 13;
            this.btTopping.Text = "Voeg toe";
            this.btTopping.UseVisualStyleBackColor = true;
            this.btTopping.Click += new System.EventHandler(this.btTopping_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Toppings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Saus:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bodem:";
            // 
            // lbCustPizzaIng
            // 
            this.lbCustPizzaIng.FormattingEnabled = true;
            this.lbCustPizzaIng.Location = new System.Drawing.Point(606, 31);
            this.lbCustPizzaIng.Name = "lbCustPizzaIng";
            this.lbCustPizzaIng.Size = new System.Drawing.Size(152, 316);
            this.lbCustPizzaIng.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Formaat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vorm:";
            // 
            // tbFormaatZ
            // 
            this.tbFormaatZ.Location = new System.Drawing.Point(242, 81);
            this.tbFormaatZ.Name = "tbFormaatZ";
            this.tbFormaatZ.Size = new System.Drawing.Size(100, 20);
            this.tbFormaatZ.TabIndex = 6;
            // 
            // tbFormaatY
            // 
            this.tbFormaatY.Location = new System.Drawing.Point(121, 81);
            this.tbFormaatY.Name = "tbFormaatY";
            this.tbFormaatY.Size = new System.Drawing.Size(100, 20);
            this.tbFormaatY.TabIndex = 5;
            // 
            // tbFormaatX
            // 
            this.tbFormaatX.Location = new System.Drawing.Point(6, 81);
            this.tbFormaatX.Name = "tbFormaatX";
            this.tbFormaatX.Size = new System.Drawing.Size(100, 20);
            this.tbFormaatX.TabIndex = 4;
            // 
            // cbVorm
            // 
            this.cbVorm.FormattingEnabled = true;
            this.cbVorm.Location = new System.Drawing.Point(56, 31);
            this.cbVorm.Name = "cbVorm";
            this.cbVorm.Size = new System.Drawing.Size(121, 21);
            this.cbVorm.TabIndex = 3;
            this.cbVorm.SelectedIndexChanged += new System.EventHandler(this.cbVorm_SelectedIndexChanged);
            // 
            // lbTopping
            // 
            this.lbTopping.FormattingEnabled = true;
            this.lbTopping.Location = new System.Drawing.Point(400, 31);
            this.lbTopping.Name = "lbTopping";
            this.lbTopping.Size = new System.Drawing.Size(146, 316);
            this.lbTopping.TabIndex = 2;
            // 
            // lbSaus
            // 
            this.lbSaus.FormattingEnabled = true;
            this.lbSaus.Location = new System.Drawing.Point(215, 135);
            this.lbSaus.Name = "lbSaus";
            this.lbSaus.Size = new System.Drawing.Size(127, 212);
            this.lbSaus.TabIndex = 1;
            // 
            // lbBodem
            // 
            this.lbBodem.FormattingEnabled = true;
            this.lbBodem.Location = new System.Drawing.Point(6, 135);
            this.lbBodem.Name = "lbBodem";
            this.lbBodem.Size = new System.Drawing.Size(138, 212);
            this.lbBodem.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(764, 384);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(764, 384);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(764, 384);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(764, 384);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(108, 84);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(12, 13);
            this.lbY.TabIndex = 16;
            this.lbY.Text = "x";
            // 
            // lbZ
            // 
            this.lbZ.AutoSize = true;
            this.lbZ.Location = new System.Drawing.Point(227, 84);
            this.lbZ.Name = "lbZ";
            this.lbZ.Size = new System.Drawing.Size(12, 13);
            this.lbZ.TabIndex = 17;
            this.lbZ.Text = "x";
            // 
            // btBodem
            // 
            this.btBodem.Location = new System.Drawing.Point(31, 353);
            this.btBodem.Name = "btBodem";
            this.btBodem.Size = new System.Drawing.Size(75, 23);
            this.btBodem.TabIndex = 18;
            this.btBodem.Text = "Voeg toe";
            this.btBodem.UseVisualStyleBackColor = true;
            this.btBodem.Click += new System.EventHandler(this.btBodem_Click);
            // 
            // btSaus
            // 
            this.btSaus.Location = new System.Drawing.Point(242, 353);
            this.btSaus.Name = "btSaus";
            this.btSaus.Size = new System.Drawing.Size(75, 23);
            this.btSaus.TabIndex = 19;
            this.btSaus.Text = "Voeg toe";
            this.btSaus.UseVisualStyleBackColor = true;
            this.btSaus.Click += new System.EventHandler(this.btSaus_Click);
            // 
            // btNewCusPizza
            // 
            this.btNewCusPizza.Location = new System.Drawing.Point(224, 19);
            this.btNewCusPizza.Name = "btNewCusPizza";
            this.btNewCusPizza.Size = new System.Drawing.Size(118, 42);
            this.btNewCusPizza.TabIndex = 20;
            this.btNewCusPizza.Text = "Nieuwe pizza";
            this.btNewCusPizza.UseVisualStyleBackColor = true;
            this.btNewCusPizza.Click += new System.EventHandler(this.btNewCusPizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 473);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btAanmelden);
            this.Controls.Add(this.lbAdres);
            this.Controls.Add(this.lbNaam);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.tbNaam);
            this.Name = "Form1";
            this.Text = "Klant aanmelden";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.Label lbNaam;
        private System.Windows.Forms.Label lbAdres;
        private System.Windows.Forms.Button btAanmelden;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ListBox lbStandPizza;
        private System.Windows.Forms.ListBox lbProducten;
        private System.Windows.Forms.Button btVoegPizza;
        private System.Windows.Forms.Button btVoegProd;
        private System.Windows.Forms.ListBox lbBestelling;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btPlusEen;
        private System.Windows.Forms.Button btMinEen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCustPizzaIng;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFormaatZ;
        private System.Windows.Forms.TextBox tbFormaatY;
        private System.Windows.Forms.TextBox tbFormaatX;
        private System.Windows.Forms.ComboBox cbVorm;
        private System.Windows.Forms.ListBox lbTopping;
        private System.Windows.Forms.ListBox lbSaus;
        private System.Windows.Forms.ListBox lbBodem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btGereed;
        private System.Windows.Forms.Button btTopping;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbZ;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Button btSaus;
        private System.Windows.Forms.Button btBodem;
        private System.Windows.Forms.Button btNewCusPizza;
    }
}

