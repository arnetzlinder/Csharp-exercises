namespace Inlämningsuppgift_1_L0002B
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPris = new Label();
            lblBelopp = new Label();
            tbxPris = new TextBox();
            tbxBetalat = new TextBox();
            btnBeräkna = new Button();
            lblVäxel = new Label();
            SuspendLayout();
            // 
            // lblPris
            // 
            lblPris.AutoSize = true;
            lblPris.Location = new Point(169, 120);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(69, 15);
            lblPris.TabIndex = 0;
            lblPris.Text = "Varans pris: ";
            // 
            // lblBelopp
            // 
            lblBelopp.AutoSize = true;
            lblBelopp.Location = new Point(169, 160);
            lblBelopp.Name = "lblBelopp";
            lblBelopp.Size = new Size(87, 15);
            lblBelopp.TabIndex = 1;
            lblBelopp.Text = "Du har betalat: ";
            // 
            // tbxPris
            // 
            tbxPris.Location = new Point(334, 117);
            tbxPris.Name = "tbxPris";
            tbxPris.Size = new Size(100, 23);
            tbxPris.TabIndex = 2;
            // 
            // tbxBetalat
            // 
            tbxBetalat.Location = new Point(334, 152);
            tbxBetalat.Name = "tbxBetalat";
            tbxBetalat.Size = new Size(100, 23);
            tbxBetalat.TabIndex = 3;
            // 
            // btnBeräkna
            // 
            btnBeräkna.Location = new Point(334, 265);
            btnBeräkna.Name = "btnBeräkna";
            btnBeräkna.Size = new Size(123, 23);
            btnBeräkna.TabIndex = 4;
            btnBeräkna.Text = "Beräkna växel";
            btnBeräkna.UseVisualStyleBackColor = true;
            btnBeräkna.Click += btnBeräkna_Click;
            // 
            // lblVäxel
            // 
            lblVäxel.AutoSize = true;
            lblVäxel.Location = new Point(334, 214);
            lblVäxel.Name = "lblVäxel";
            lblVäxel.Size = new Size(86, 15);
            lblVäxel.TabIndex = 5;
            lblVäxel.Text = "Du får tillbaka: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblVäxel);
            Controls.Add(btnBeräkna);
            Controls.Add(tbxBetalat);
            Controls.Add(tbxPris);
            Controls.Add(lblBelopp);
            Controls.Add(lblPris);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPris;
        private Label lblBelopp;
        private TextBox tbxPris;
        private TextBox tbxBetalat;
        private Button btnBeräkna;
        private Label lblVäxel;
    }
}