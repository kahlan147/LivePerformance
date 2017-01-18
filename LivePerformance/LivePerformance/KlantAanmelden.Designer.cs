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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btOnbekend = new System.Windows.Forms.Button();
            this.btAanmelden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(29, 56);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 20);
            this.tbNaam.TabIndex = 0;
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(29, 110);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(100, 20);
            this.tbAdres.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adres";
            // 
            // btOnbekend
            // 
            this.btOnbekend.Location = new System.Drawing.Point(145, 158);
            this.btOnbekend.Name = "btOnbekend";
            this.btOnbekend.Size = new System.Drawing.Size(87, 35);
            this.btOnbekend.TabIndex = 4;
            this.btOnbekend.Text = "Klant onbekend";
            this.btOnbekend.UseVisualStyleBackColor = true;
            this.btOnbekend.Click += new System.EventHandler(this.btOnbekend_Click);
            // 
            // btAanmelden
            // 
            this.btAanmelden.Location = new System.Drawing.Point(157, 67);
            this.btAanmelden.Name = "btAanmelden";
            this.btAanmelden.Size = new System.Drawing.Size(75, 40);
            this.btAanmelden.TabIndex = 5;
            this.btAanmelden.Text = "Klant aanmelden";
            this.btAanmelden.UseVisualStyleBackColor = true;
            this.btAanmelden.Click += new System.EventHandler(this.btAanmelden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btAanmelden);
            this.Controls.Add(this.btOnbekend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.tbNaam);
            this.Name = "Form1";
            this.Text = "Klant aanmelden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOnbekend;
        private System.Windows.Forms.Button btAanmelden;
    }
}

