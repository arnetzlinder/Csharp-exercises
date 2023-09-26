namespace Exempel07_05
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
            lblAntalPersoner = new Label();
            tbxAntalPersoner = new TextBox();
            lblResultat = new Label();
            btnHyresKostnad = new Button();
            SuspendLayout();
            // 
            // lblAntalPersoner
            // 
            lblAntalPersoner.AutoSize = true;
            lblAntalPersoner.Location = new Point(245, 143);
            lblAntalPersoner.Name = "lblAntalPersoner";
            lblAntalPersoner.Size = new Size(84, 15);
            lblAntalPersoner.TabIndex = 0;
            lblAntalPersoner.Text = "Antal personer";
            // 
            // tbxAntalPersoner
            // 
            tbxAntalPersoner.Location = new Point(390, 135);
            tbxAntalPersoner.Name = "tbxAntalPersoner";
            tbxAntalPersoner.Size = new Size(100, 23);
            tbxAntalPersoner.TabIndex = 1;
            tbxAntalPersoner.TextChanged += tbxAntalPersoner_TextChanged;
            // 
            // lblResultat
            // 
            lblResultat.BorderStyle = BorderStyle.Fixed3D;
            lblResultat.Location = new Point(245, 208);
            lblResultat.Name = "lblResultat";
            lblResultat.Size = new Size(137, 23);
            lblResultat.TabIndex = 2;
            lblResultat.Text = "Här kommer resultatet";
            lblResultat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnHyresKostnad
            // 
            btnHyresKostnad.Location = new Point(390, 271);
            btnHyresKostnad.Name = "btnHyresKostnad";
            btnHyresKostnad.Size = new Size(121, 23);
            btnHyresKostnad.TabIndex = 3;
            btnHyresKostnad.Text = "Hyreskostnad";
            btnHyresKostnad.UseVisualStyleBackColor = true;
            btnHyresKostnad.Click += btnHyresKostnad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHyresKostnad);
            Controls.Add(lblResultat);
            Controls.Add(tbxAntalPersoner);
            Controls.Add(lblAntalPersoner);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAntalPersoner;
        private TextBox tbxAntalPersoner;
        private Label lblResultat;
        private Button btnHyresKostnad;
    }
}