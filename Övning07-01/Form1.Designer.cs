namespace Övning07_01
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
            lblLiter = new Label();
            tbxLiter = new TextBox();
            lblSvar = new Label();
            btnBeräkna = new Button();
            SuspendLayout();
            // 
            // lblLiter
            // 
            lblLiter.AutoSize = true;
            lblLiter.Location = new Point(257, 138);
            lblLiter.Name = "lblLiter";
            lblLiter.Size = new Size(74, 15);
            lblLiter.TabIndex = 0;
            lblLiter.Text = "Liter bensin: ";
            // 
            // tbxLiter
            // 
            tbxLiter.Location = new Point(366, 130);
            tbxLiter.Name = "tbxLiter";
            tbxLiter.Size = new Size(100, 23);
            tbxLiter.TabIndex = 1;
            // 
            // lblSvar
            // 
            lblSvar.AutoSize = true;
            lblSvar.Location = new Point(291, 202);
            lblSvar.Name = "lblSvar";
            lblSvar.Size = new Size(229, 15);
            lblSvar.TabIndex = 2;
            lblSvar.Text = "Här kommer det stå vad du behöver tanka";
            // 
            // btnBeräkna
            // 
            btnBeräkna.Location = new Point(366, 260);
            btnBeräkna.Name = "btnBeräkna";
            btnBeräkna.Size = new Size(75, 23);
            btnBeräkna.TabIndex = 3;
            btnBeräkna.Text = "Beräkna";
            btnBeräkna.UseVisualStyleBackColor = true;
            btnBeräkna.Click += btnBeräkna_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBeräkna);
            Controls.Add(lblSvar);
            Controls.Add(tbxLiter);
            Controls.Add(lblLiter);
            Name = "Form1";
            Text = "Behöver jag tanka?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLiter;
        private TextBox tbxLiter;
        private Label lblSvar;
        private Button btnBeräkna;
    }
}