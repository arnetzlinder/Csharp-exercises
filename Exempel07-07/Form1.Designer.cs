namespace Exempel07_07
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
            lblTal1 = new Label();
            tbxTal1 = new TextBox();
            lblTal2 = new Label();
            tbxTal2 = new TextBox();
            lblResultat = new Label();
            btnStörstaTalet = new Button();
            SuspendLayout();
            // 
            // lblTal1
            // 
            lblTal1.AutoSize = true;
            lblTal1.Location = new Point(257, 148);
            lblTal1.Name = "lblTal1";
            lblTal1.Size = new Size(33, 15);
            lblTal1.TabIndex = 0;
            lblTal1.Text = "Tal1: ";
            // 
            // tbxTal1
            // 
            tbxTal1.Location = new Point(318, 140);
            tbxTal1.Name = "tbxTal1";
            tbxTal1.Size = new Size(100, 23);
            tbxTal1.TabIndex = 1;
            tbxTal1.TextChanged += tbxTal1_TextChanged;
            // 
            // lblTal2
            // 
            lblTal2.AutoSize = true;
            lblTal2.Location = new Point(257, 189);
            lblTal2.Name = "lblTal2";
            lblTal2.Size = new Size(30, 15);
            lblTal2.TabIndex = 2;
            lblTal2.Text = "Tal2:";
            // 
            // tbxTal2
            // 
            tbxTal2.Location = new Point(318, 181);
            tbxTal2.Name = "tbxTal2";
            tbxTal2.Size = new Size(100, 23);
            tbxTal2.TabIndex = 3;
            tbxTal2.TextChanged += tbxTal2_TextChanged;
            // 
            // lblResultat
            // 
            lblResultat.BorderStyle = BorderStyle.Fixed3D;
            lblResultat.Location = new Point(318, 250);
            lblResultat.Name = "lblResultat";
            lblResultat.Size = new Size(238, 23);
            lblResultat.TabIndex = 4;
            lblResultat.Text = "label1";
            lblResultat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnStörstaTalet
            // 
            btnStörstaTalet.Location = new Point(318, 329);
            btnStörstaTalet.Name = "btnStörstaTalet";
            btnStörstaTalet.Size = new Size(148, 23);
            btnStörstaTalet.TabIndex = 5;
            btnStörstaTalet.Text = "Hitta största talet";
            btnStörstaTalet.UseVisualStyleBackColor = true;
            btnStörstaTalet.Click += btnStörstaTalet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStörstaTalet);
            Controls.Add(lblResultat);
            Controls.Add(tbxTal2);
            Controls.Add(lblTal2);
            Controls.Add(tbxTal1);
            Controls.Add(lblTal1);
            Name = "Form1";
            Text = "Exempel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTal1;
        private TextBox tbxTal1;
        private Label lblTal2;
        private TextBox tbxTal2;
        private Label lblResultat;
        private Button btnStörstaTalet;
    }
}