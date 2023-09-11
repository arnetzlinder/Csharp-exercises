namespace Exempel03_01
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
            lblTal = new Label();
            tbxTal = new TextBox();
            tbxKvadrat = new TextBox();
            lblKvadrat = new Label();
            SuspendLayout();
            // 
            // btnKör
            // 
            btnKör.Location = new Point(388, 325);
            btnKör.Name = "btnKör";
            btnKör.Size = new Size(190, 23);
            btnKör.TabIndex = 0;
            btnKör.Text = "Beräkna kvadraten";
            btnKör.UseVisualStyleBackColor = true;
            btnKör.Click += btnKör_Click;
            // 
            // lblTal
            // 
            lblTal.AutoSize = true;
            lblTal.Location = new Point(312, 148);
            lblTal.Name = "lblTal";
            lblTal.Size = new Size(21, 15);
            lblTal.TabIndex = 1;
            lblTal.Text = "Tal";
            lblTal.Click += label1_Click;
            // 
            // tbxTal
            // 
            tbxTal.Location = new Point(444, 145);
            tbxTal.Name = "tbxTal";
            tbxTal.Size = new Size(100, 23);
            tbxTal.TabIndex = 2;
            // 
            // tbxKvadrat
            // 
            tbxKvadrat.Location = new Point(444, 255);
            tbxKvadrat.Name = "tbxKvadrat";
            tbxKvadrat.Size = new Size(100, 23);
            tbxKvadrat.TabIndex = 4;
            // 
            // lblKvadrat
            // 
            lblKvadrat.AutoSize = true;
            lblKvadrat.Location = new Point(457, 237);
            lblKvadrat.Name = "lblKvadrat";
            lblKvadrat.Size = new Size(76, 15);
            lblKvadrat.TabIndex = 3;
            lblKvadrat.Text = "Kvadraten är:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxKvadrat);
            Controls.Add(lblKvadrat);
            Controls.Add(tbxTal);
            Controls.Add(lblTal);
            Controls.Add(btnKör);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKör;
        private Label lblTal;
        private TextBox tbxTal;
        private TextBox tbxKvadrat;
        private Label lblKvadrat;
    }
}