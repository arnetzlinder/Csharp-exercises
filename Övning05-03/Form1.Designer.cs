namespace Övning05_03
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
            btnKör = new Button();
            lblPengar = new Label();
            lblPris = new Label();
            lblSvar = new Label();
            tbxPengar = new TextBox();
            tbxPris = new TextBox();
            SuspendLayout();
            // 
            // btnKör
            // 
            btnKör.Location = new Point(386, 299);
            btnKör.Name = "btnKör";
            btnKör.Size = new Size(75, 23);
            btnKör.TabIndex = 0;
            btnKör.Text = "Räkna ut";
            btnKör.UseVisualStyleBackColor = true;
            btnKör.Click += btnKör_Click;
            // 
            // lblPengar
            // 
            lblPengar.AutoSize = true;
            lblPengar.Location = new Point(230, 99);
            lblPengar.Name = "lblPengar";
            lblPengar.Size = new Size(80, 15);
            lblPengar.TabIndex = 1;
            lblPengar.Text = "Mina pengar: ";
            // 
            // lblPris
            // 
            lblPris.AutoSize = true;
            lblPris.Location = new Point(230, 134);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(69, 15);
            lblPris.TabIndex = 2;
            lblPris.Text = "Varans pris: ";
            // 
            // lblSvar
            // 
            lblSvar.AutoSize = true;
            lblSvar.Location = new Point(393, 220);
            lblSvar.Name = "lblSvar";
            lblSvar.Size = new Size(38, 15);
            lblSvar.TabIndex = 3;
            lblSvar.Text = "label1";
            // 
            // tbxPengar
            // 
            tbxPengar.Location = new Point(386, 91);
            tbxPengar.Name = "tbxPengar";
            tbxPengar.Size = new Size(100, 23);
            tbxPengar.TabIndex = 4;
            // 
            // tbxPris
            // 
            tbxPris.Location = new Point(386, 126);
            tbxPris.Name = "tbxPris";
            tbxPris.Size = new Size(100, 23);
            tbxPris.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxPris);
            Controls.Add(tbxPengar);
            Controls.Add(lblSvar);
            Controls.Add(lblPris);
            Controls.Add(lblPengar);
            Controls.Add(btnKör);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKör;
        private Label lblPengar;
        private Label lblPris;
        private Label lblSvar;
        private TextBox tbxPengar;
        private TextBox tbxPris;
    }
}