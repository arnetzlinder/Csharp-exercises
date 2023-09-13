namespace Exempel07_02
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
            lblAge = new Label();
            lblPris = new Label();
            tbxAge = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(274, 148);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(41, 15);
            lblAge.TabIndex = 0;
            lblAge.Text = "Ålder: ";
            // 
            // lblPris
            // 
            lblPris.AutoSize = true;
            lblPris.Location = new Point(274, 203);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(73, 15);
            lblPris.TabIndex = 1;
            lblPris.Text = "Resekostnad";
            // 
            // tbxAge
            // 
            tbxAge.Location = new Point(347, 145);
            tbxAge.Name = "tbxAge";
            tbxAge.Size = new Size(100, 23);
            tbxAge.TabIndex = 2;
            tbxAge.TextChanged += tbxAge_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(347, 265);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Beräkna";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(tbxAge);
            Controls.Add(lblPris);
            Controls.Add(lblAge);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAge;
        private Label lblPris;
        private TextBox tbxAge;
        private Button btnCalculate;
    }
}