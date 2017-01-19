namespace LivePerformance
{
    partial class BestellingForm
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
            this.lbStandPizza = new System.Windows.Forms.ListBox();
            this.lbProducten = new System.Windows.Forms.ListBox();
            this.lbBestelling = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btVoegPizza = new System.Windows.Forms.Button();
            this.btVoegProd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btCustomPizza = new System.Windows.Forms.Button();
            this.btPlusEen = new System.Windows.Forms.Button();
            this.btMinEen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStandPizza
            // 
            this.lbStandPizza.FormattingEnabled = true;
            this.lbStandPizza.Location = new System.Drawing.Point(12, 25);
            this.lbStandPizza.Name = "lbStandPizza";
            this.lbStandPizza.Size = new System.Drawing.Size(120, 316);
            this.lbStandPizza.TabIndex = 0;
            // 
            // lbProducten
            // 
            this.lbProducten.FormattingEnabled = true;
            this.lbProducten.Location = new System.Drawing.Point(160, 25);
            this.lbProducten.Name = "lbProducten";
            this.lbProducten.Size = new System.Drawing.Size(120, 316);
            this.lbProducten.TabIndex = 1;
            // 
            // lbBestelling
            // 
            this.lbBestelling.FormattingEnabled = true;
            this.lbBestelling.Location = new System.Drawing.Point(492, 25);
            this.lbBestelling.Name = "lbBestelling";
            this.lbBestelling.Size = new System.Drawing.Size(127, 316);
            this.lbBestelling.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // btVoegPizza
            // 
            this.btVoegPizza.Location = new System.Drawing.Point(28, 354);
            this.btVoegPizza.Name = "btVoegPizza";
            this.btVoegPizza.Size = new System.Drawing.Size(75, 23);
            this.btVoegPizza.TabIndex = 6;
            this.btVoegPizza.Text = "Voeg toe";
            this.btVoegPizza.UseVisualStyleBackColor = true;
            // 
            // btVoegProd
            // 
            this.btVoegProd.Location = new System.Drawing.Point(169, 354);
            this.btVoegProd.Name = "btVoegProd";
            this.btVoegProd.Size = new System.Drawing.Size(75, 23);
            this.btVoegProd.TabIndex = 7;
            this.btVoegProd.Text = "Voeg toe";
            this.btVoegProd.UseVisualStyleBackColor = true;
            this.btVoegProd.Click += new System.EventHandler(this.btVoegProd_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(517, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btCustomPizza
            // 
            this.btCustomPizza.Location = new System.Drawing.Point(296, 25);
            this.btCustomPizza.Name = "btCustomPizza";
            this.btCustomPizza.Size = new System.Drawing.Size(84, 72);
            this.btCustomPizza.TabIndex = 9;
            this.btCustomPizza.Text = "Custom Pizza";
            this.btCustomPizza.UseVisualStyleBackColor = true;
            // 
            // btPlusEen
            // 
            this.btPlusEen.Location = new System.Drawing.Point(435, 105);
            this.btPlusEen.Name = "btPlusEen";
            this.btPlusEen.Size = new System.Drawing.Size(51, 45);
            this.btPlusEen.TabIndex = 10;
            this.btPlusEen.Text = "+1";
            this.btPlusEen.UseVisualStyleBackColor = true;
            // 
            // btMinEen
            // 
            this.btMinEen.Location = new System.Drawing.Point(435, 156);
            this.btMinEen.Name = "btMinEen";
            this.btMinEen.Size = new System.Drawing.Size(51, 45);
            this.btMinEen.TabIndex = 11;
            this.btMinEen.Text = "-1";
            this.btMinEen.UseVisualStyleBackColor = true;
            // 
            // BestellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 399);
            this.Controls.Add(this.btMinEen);
            this.Controls.Add(this.btPlusEen);
            this.Controls.Add(this.btCustomPizza);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btVoegProd);
            this.Controls.Add(this.btVoegPizza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBestelling);
            this.Controls.Add(this.lbProducten);
            this.Controls.Add(this.lbStandPizza);
            this.Name = "BestellingForm";
            this.Text = "Bestelling voor:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStandPizza;
        private System.Windows.Forms.ListBox lbProducten;
        private System.Windows.Forms.ListBox lbBestelling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btVoegPizza;
        private System.Windows.Forms.Button btVoegProd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btCustomPizza;
        private System.Windows.Forms.Button btPlusEen;
        private System.Windows.Forms.Button btMinEen;
    }
}