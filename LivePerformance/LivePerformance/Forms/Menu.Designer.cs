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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lbStandPizza = new System.Windows.Forms.ListBox();
            this.lbProducten = new System.Windows.Forms.ListBox();
            this.btVoegPizza = new System.Windows.Forms.Button();
            this.btVoegProd = new System.Windows.Forms.Button();
            this.lbBestelling = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btPlusEen = new System.Windows.Forms.Button();
            this.btMinEen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.cbVorm = new System.Windows.Forms.ComboBox();
            this.tbFormaatX = new System.Windows.Forms.TextBox();
            this.tbFormaatY = new System.Windows.Forms.TextBox();
            this.tbFormaatZ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.listBox4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbFormaatZ);
            this.tabPage2.Controls.Add(this.tbFormaatY);
            this.tabPage2.Controls.Add(this.tbFormaatX);
            this.tabPage2.Controls.Add(this.cbVorm);
            this.tabPage2.Controls.Add(this.listBox3);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Custom pizza";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(986, 384);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(986, 384);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(986, 384);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(986, 384);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lbStandPizza
            // 
            this.lbStandPizza.FormattingEnabled = true;
            this.lbStandPizza.Location = new System.Drawing.Point(6, 33);
            this.lbStandPizza.Name = "lbStandPizza";
            this.lbStandPizza.Size = new System.Drawing.Size(218, 316);
            this.lbStandPizza.TabIndex = 1;
            // 
            // lbProducten
            // 
            this.lbProducten.FormattingEnabled = true;
            this.lbProducten.Location = new System.Drawing.Point(239, 33);
            this.lbProducten.Name = "lbProducten";
            this.lbProducten.Size = new System.Drawing.Size(211, 316);
            this.lbProducten.TabIndex = 2;
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
            // lbBestelling
            // 
            this.lbBestelling.FormattingEnabled = true;
            this.lbBestelling.Location = new System.Drawing.Point(540, 33);
            this.lbBestelling.Name = "lbBestelling";
            this.lbBestelling.Size = new System.Drawing.Size(206, 316);
            this.lbBestelling.TabIndex = 9;
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
            // btPlusEen
            // 
            this.btPlusEen.Location = new System.Drawing.Point(483, 127);
            this.btPlusEen.Name = "btPlusEen";
            this.btPlusEen.Size = new System.Drawing.Size(51, 45);
            this.btPlusEen.TabIndex = 11;
            this.btPlusEen.Text = "+1";
            this.btPlusEen.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pizzas";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bestelling";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 212);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(215, 150);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(127, 212);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(410, 31);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(146, 277);
            this.listBox3.TabIndex = 2;
            // 
            // cbVorm
            // 
            this.cbVorm.FormattingEnabled = true;
            this.cbVorm.Location = new System.Drawing.Point(56, 31);
            this.cbVorm.Name = "cbVorm";
            this.cbVorm.Size = new System.Drawing.Size(121, 21);
            this.cbVorm.TabIndex = 3;
            // 
            // tbFormaatX
            // 
            this.tbFormaatX.Location = new System.Drawing.Point(6, 81);
            this.tbFormaatX.Name = "tbFormaatX";
            this.tbFormaatX.Size = new System.Drawing.Size(100, 20);
            this.tbFormaatX.TabIndex = 4;
            // 
            // tbFormaatY
            // 
            this.tbFormaatY.Location = new System.Drawing.Point(126, 81);
            this.tbFormaatY.Name = "tbFormaatY";
            this.tbFormaatY.Size = new System.Drawing.Size(100, 20);
            this.tbFormaatY.TabIndex = 5;
            // 
            // tbFormaatZ
            // 
            this.tbFormaatZ.Location = new System.Drawing.Point(242, 81);
            this.tbFormaatZ.Name = "tbFormaatZ";
            this.tbFormaatZ.Size = new System.Drawing.Size(100, 20);
            this.tbFormaatZ.TabIndex = 6;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Formaat:";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(606, 31);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(152, 316);
            this.listBox4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bodem:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Saus:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ingredienten";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Voeg toe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Gereed";
            this.button2.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFormaatZ;
        private System.Windows.Forms.TextBox tbFormaatY;
        private System.Windows.Forms.TextBox tbFormaatX;
        private System.Windows.Forms.ComboBox cbVorm;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

