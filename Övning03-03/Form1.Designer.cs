namespace Övning03_03
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
            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            tbxA = new TextBox();
            tbxB = new TextBox();
            tbxC = new TextBox();
            lblSumma = new Label();
            lblMedel = new Label();
            SuspendLayout();
            // 
            // btnKör
            // 
            btnKör.Location = new Point(296, 330);
            btnKör.Name = "btnKör";
            btnKör.Size = new Size(75, 23);
            btnKör.TabIndex = 0;
            btnKör.Text = "Kör";
            btnKör.UseVisualStyleBackColor = true;
            btnKör.Click += btnKör_Click;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(142, 60);
            lblA.Name = "lblA";
            lblA.Size = new Size(32, 15);
            lblA.TabIndex = 1;
            lblA.Text = "Tal A";
            lblA.Click += lblA_Click;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(143, 108);
            lblB.Name = "lblB";
            lblB.Size = new Size(31, 15);
            lblB.TabIndex = 2;
            lblB.Text = "Tal B";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(143, 168);
            lblC.Name = "lblC";
            lblC.Size = new Size(32, 15);
            lblC.TabIndex = 3;
            lblC.Text = "Tal C";
            // 
            // tbxA
            // 
            tbxA.Location = new Point(296, 52);
            tbxA.Name = "tbxA";
            tbxA.Size = new Size(100, 23);
            tbxA.TabIndex = 4;
            // 
            // tbxB
            // 
            tbxB.Location = new Point(296, 108);
            tbxB.Name = "tbxB";
            tbxB.Size = new Size(100, 23);
            tbxB.TabIndex = 5;
            // 
            // tbxC
            // 
            tbxC.Location = new Point(296, 165);
            tbxC.Name = "tbxC";
            tbxC.Size = new Size(100, 23);
            tbxC.TabIndex = 6;
            // 
            // lblSumma
            // 
            lblSumma.AutoSize = true;
            lblSumma.Location = new Point(296, 220);
            lblSumma.Name = "lblSumma";
            lblSumma.Size = new Size(51, 15);
            lblSumma.TabIndex = 7;
            lblSumma.Text = "Summa:";
            // 
            // lblMedel
            // 
            lblMedel.AutoSize = true;
            lblMedel.Location = new Point(296, 252);
            lblMedel.Name = "lblMedel";
            lblMedel.Size = new Size(72, 15);
            lblMedel.TabIndex = 8;
            lblMedel.Text = "Medelvärde:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMedel);
            Controls.Add(lblSumma);
            Controls.Add(tbxC);
            Controls.Add(tbxB);
            Controls.Add(tbxA);
            Controls.Add(lblC);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(btnKör);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKör;
        private Label lblA;
        private Label lblB;
        private Label lblC;
        private TextBox tbxA;
        private TextBox tbxB;
        private TextBox tbxC;
        private Label lblSumma;
        private Label lblMedel;
    }
}