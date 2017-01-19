namespace LivePerformance
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
            this.button3 = new System.Windows.Forms.Button();
            this.lbBestelling = new System.Windows.Forms.ListBox();
            this.btVoegProd = new System.Windows.Forms.Button();
            this.btVoegPizza = new System.Windows.Forms.Button();
            this.lbProducten = new System.Windows.Forms.ListBox();
            this.lbStandPizza = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.tbNewPizNaam = new System.Windows.Forms.TextBox();
            this.btNewPizza = new System.Windows.Forms.Button();
            this.btNewCusPizza = new System.Windows.Forms.Button();
            this.btSaus = new System.Windows.Forms.Button();
            this.btBodem = new System.Windows.Forms.Button();
            this.lbZ = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
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
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btProAanmaken = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbAlcohol = new System.Windows.Forms.CheckBox();
            this.tbProVer = new System.Windows.Forms.TextBox();
            this.tbProIn = new System.Windows.Forms.TextBox();
            this.btIngAanmaken = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbNewOnd = new System.Windows.Forms.ComboBox();
            this.cbVegetarisch = new System.Windows.Forms.CheckBox();
            this.tbProNaam = new System.Windows.Forms.TextBox();
            this.tbVerkIng = new System.Windows.Forms.TextBox();
            this.tbInkIng = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbIngNaam = new System.Windows.Forms.TextBox();
            this.cbBezorgen = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Klaar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.tbNewPizNaam);
            this.tabPage2.Controls.Add(this.btNewPizza);
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(676, 169);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Naam:";
            // 
            // tbNewPizNaam
            // 
            this.tbNewPizNaam.Location = new System.Drawing.Point(676, 185);
            this.tbNewPizNaam.Name = "tbNewPizNaam";
            this.tbNewPizNaam.Size = new System.Drawing.Size(68, 20);
            this.tbNewPizNaam.TabIndex = 22;
            // 
            // btNewPizza
            // 
            this.btNewPizza.Location = new System.Drawing.Point(676, 211);
            this.btNewPizza.Name = "btNewPizza";
            this.btNewPizza.Size = new System.Drawing.Size(75, 65);
            this.btNewPizza.TabIndex = 21;
            this.btNewPizza.Text = "Als standaard opslaan";
            this.btNewPizza.UseVisualStyleBackColor = true;
            this.btNewPizza.Click += new System.EventHandler(this.btNewPizza_Click);
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
            // lbZ
            // 
            this.lbZ.AutoSize = true;
            this.lbZ.Location = new System.Drawing.Point(227, 84);
            this.lbZ.Name = "lbZ";
            this.lbZ.Size = new System.Drawing.Size(12, 13);
            this.lbZ.TabIndex = 17;
            this.lbZ.Text = "x";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Pizza:";
            // 
            // btGereed
            // 
            this.btGereed.Location = new System.Drawing.Point(542, 353);
            this.btGereed.Name = "btGereed";
            this.btGereed.Size = new System.Drawing.Size(75, 23);
            this.btGereed.TabIndex = 14;
            this.btGereed.Text = "Gereed";
            this.btGereed.UseVisualStyleBackColor = true;
            this.btGereed.Click += new System.EventHandler(this.btGereed_Click);
            // 
            // btTopping
            // 
            this.btTopping.Location = new System.Drawing.Point(366, 353);
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
            this.label8.Location = new System.Drawing.Point(363, 15);
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
            this.lbCustPizzaIng.Location = new System.Drawing.Point(518, 31);
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
            this.lbTopping.Location = new System.Drawing.Point(366, 31);
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
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.btProAanmaken);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.cbAlcohol);
            this.tabPage3.Controls.Add(this.tbProVer);
            this.tabPage3.Controls.Add(this.tbProIn);
            this.tabPage3.Controls.Add(this.btIngAanmaken);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cbNewOnd);
            this.tabPage3.Controls.Add(this.cbVegetarisch);
            this.tabPage3.Controls.Add(this.tbProNaam);
            this.tabPage3.Controls.Add(this.tbVerkIng);
            this.tabPage3.Controls.Add(this.tbInkIng);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.tbIngNaam);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(764, 384);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Toevoegen";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(267, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Product";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(81, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Ingredient";
            // 
            // btProAanmaken
            // 
            this.btProAanmaken.Location = new System.Drawing.Point(251, 314);
            this.btProAanmaken.Name = "btProAanmaken";
            this.btProAanmaken.Size = new System.Drawing.Size(75, 23);
            this.btProAanmaken.TabIndex = 17;
            this.btProAanmaken.Text = "Aanmaken";
            this.btProAanmaken.UseVisualStyleBackColor = true;
            this.btProAanmaken.Click += new System.EventHandler(this.btProAanmaken_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(243, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Naam";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(243, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Inkoop prijs in centen";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(243, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Verkoop prijs in centen";
            // 
            // cbAlcohol
            // 
            this.cbAlcohol.AutoSize = true;
            this.cbAlcohol.Location = new System.Drawing.Point(246, 278);
            this.cbAlcohol.Name = "cbAlcohol";
            this.cbAlcohol.Size = new System.Drawing.Size(80, 17);
            this.cbAlcohol.TabIndex = 13;
            this.cbAlcohol.Text = "Alcoholisch";
            this.cbAlcohol.UseVisualStyleBackColor = true;
            // 
            // tbProVer
            // 
            this.tbProVer.Location = new System.Drawing.Point(246, 239);
            this.tbProVer.Name = "tbProVer";
            this.tbProVer.Size = new System.Drawing.Size(100, 20);
            this.tbProVer.TabIndex = 12;
            // 
            // tbProIn
            // 
            this.tbProIn.Location = new System.Drawing.Point(246, 187);
            this.tbProIn.Name = "tbProIn";
            this.tbProIn.Size = new System.Drawing.Size(100, 20);
            this.tbProIn.TabIndex = 11;
            // 
            // btIngAanmaken
            // 
            this.btIngAanmaken.Location = new System.Drawing.Point(45, 321);
            this.btIngAanmaken.Name = "btIngAanmaken";
            this.btIngAanmaken.Size = new System.Drawing.Size(75, 23);
            this.btIngAanmaken.TabIndex = 10;
            this.btIngAanmaken.Text = "Aanmaken";
            this.btIngAanmaken.UseVisualStyleBackColor = true;
            this.btIngAanmaken.Click += new System.EventHandler(this.btIngAanmaken_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Onderdeel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Verkoop prijs in centen";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Inkoop prijs in centen";
            // 
            // cbNewOnd
            // 
            this.cbNewOnd.FormattingEnabled = true;
            this.cbNewOnd.Location = new System.Drawing.Point(42, 275);
            this.cbNewOnd.Name = "cbNewOnd";
            this.cbNewOnd.Size = new System.Drawing.Size(100, 21);
            this.cbNewOnd.TabIndex = 6;
            // 
            // cbVegetarisch
            // 
            this.cbVegetarisch.AutoSize = true;
            this.cbVegetarisch.Location = new System.Drawing.Point(45, 239);
            this.cbVegetarisch.Name = "cbVegetarisch";
            this.cbVegetarisch.Size = new System.Drawing.Size(82, 17);
            this.cbVegetarisch.TabIndex = 5;
            this.cbVegetarisch.Text = "Vegetarisch";
            this.cbVegetarisch.UseVisualStyleBackColor = true;
            // 
            // tbProNaam
            // 
            this.tbProNaam.Location = new System.Drawing.Point(246, 132);
            this.tbProNaam.Name = "tbProNaam";
            this.tbProNaam.Size = new System.Drawing.Size(100, 20);
            this.tbProNaam.TabIndex = 4;
            // 
            // tbVerkIng
            // 
            this.tbVerkIng.Location = new System.Drawing.Point(42, 200);
            this.tbVerkIng.Name = "tbVerkIng";
            this.tbVerkIng.Size = new System.Drawing.Size(100, 20);
            this.tbVerkIng.TabIndex = 3;
            // 
            // tbInkIng
            // 
            this.tbInkIng.Location = new System.Drawing.Point(42, 148);
            this.tbInkIng.Name = "tbInkIng";
            this.tbInkIng.Size = new System.Drawing.Size(100, 20);
            this.tbInkIng.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Naam";
            // 
            // tbIngNaam
            // 
            this.tbIngNaam.Location = new System.Drawing.Point(42, 93);
            this.tbIngNaam.Name = "tbIngNaam";
            this.tbIngNaam.Size = new System.Drawing.Size(100, 20);
            this.tbIngNaam.TabIndex = 0;
            // 
            // cbBezorgen
            // 
            this.cbBezorgen.AutoSize = true;
            this.cbBezorgen.Location = new System.Drawing.Point(497, 34);
            this.cbBezorgen.Name = "cbBezorgen";
            this.cbBezorgen.Size = new System.Drawing.Size(71, 17);
            this.cbBezorgen.TabIndex = 7;
            this.cbBezorgen.Text = "Bezorgen";
            this.cbBezorgen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 473);
            this.Controls.Add(this.cbBezorgen);
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.ListBox lbStandPizza;
        private System.Windows.Forms.ListBox lbProducten;
        private System.Windows.Forms.Button btVoegPizza;
        private System.Windows.Forms.Button btVoegProd;
        private System.Windows.Forms.ListBox lbBestelling;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.Button btIngAanmaken;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbNewOnd;
        private System.Windows.Forms.CheckBox cbVegetarisch;
        private System.Windows.Forms.TextBox tbProNaam;
        private System.Windows.Forms.TextBox tbVerkIng;
        private System.Windows.Forms.TextBox tbInkIng;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbIngNaam;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbAlcohol;
        private System.Windows.Forms.TextBox tbProVer;
        private System.Windows.Forms.TextBox tbProIn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btProAanmaken;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbNewPizNaam;
        private System.Windows.Forms.Button btNewPizza;
        private System.Windows.Forms.CheckBox cbBezorgen;
    }
}

