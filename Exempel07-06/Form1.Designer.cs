namespace Exempel07_06
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
            lblNamn = new Label();
            lblLösenord = new Label();
            tbxNamn = new TextBox();
            tbxLösenord = new TextBox();
            lblResultat = new Label();
            btnKontrollera = new Button();
            SuspendLayout();
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(201, 127);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(46, 15);
            lblNamn.TabIndex = 0;
            lblNamn.Text = "Namn: ";
            // 
            // lblLösenord
            // 
            lblLösenord.AutoSize = true;
            lblLösenord.Location = new Point(201, 159);
            lblLösenord.Name = "lblLösenord";
            lblLösenord.Size = new Size(59, 15);
            lblLösenord.TabIndex = 1;
            lblLösenord.Text = "Lösenord:";
            // 
            // tbxNamn
            // 
            tbxNamn.Location = new Point(301, 119);
            tbxNamn.Name = "tbxNamn";
            tbxNamn.Size = new Size(100, 23);
            tbxNamn.TabIndex = 2;
            tbxNamn.TextChanged += tbxNamn_TextChanged;
            // 
            // tbxLösenord
            // 
            tbxLösenord.Location = new Point(301, 156);
            tbxLösenord.Name = "tbxLösenord";
            tbxLösenord.Size = new Size(100, 23);
            tbxLösenord.TabIndex = 3;
            tbxLösenord.TextChanged += tbxLösenord_TextChanged;
            // 
            // lblResultat
            // 
            lblResultat.BorderStyle = BorderStyle.Fixed3D;
            lblResultat.Location = new Point(241, 237);
            lblResultat.Name = "lblResultat";
            lblResultat.Size = new Size(235, 23);
            lblResultat.TabIndex = 4;
            lblResultat.Text = "Här kommer resultatet stå sedan";
            lblResultat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnKontrollera
            // 
            btnKontrollera.Location = new Point(301, 298);
            btnKontrollera.Name = "btnKontrollera";
            btnKontrollera.Size = new Size(75, 23);
            btnKontrollera.TabIndex = 5;
            btnKontrollera.Text = "Kontrollera";
            btnKontrollera.UseVisualStyleBackColor = true;
            btnKontrollera.Click += btnKontrollera_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKontrollera);
            Controls.Add(lblResultat);
            Controls.Add(tbxLösenord);
            Controls.Add(tbxNamn);
            Controls.Add(lblLösenord);
            Controls.Add(lblNamn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNamn;
        private Label lblLösenord;
        private TextBox tbxNamn;
        private TextBox tbxLösenord;
        private Label lblResultat;
        private Button btnKontrollera;
    }
}