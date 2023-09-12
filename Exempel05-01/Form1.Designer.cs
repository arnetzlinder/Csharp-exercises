namespace Exempel05_01
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
            lblTid = new Label();
            lblSvar = new Label();
            tbxTid = new TextBox();
            SuspendLayout();
            // 
            // btnKör
            // 
            btnKör.Location = new Point(406, 328);
            btnKör.Name = "btnKör";
            btnKör.Size = new Size(75, 23);
            btnKör.TabIndex = 0;
            btnKör.Text = "Kör";
            btnKör.UseVisualStyleBackColor = true;
            btnKör.Click += btnKör_Click;
            // 
            // lblTid
            // 
            lblTid.AutoSize = true;
            lblTid.Location = new Point(194, 170);
            lblTid.Name = "lblTid";
            lblTid.Size = new Size(77, 15);
            lblTid.TabIndex = 1;
            lblTid.Text = "Tid i minuter:";
            // 
            // lblSvar
            // 
            lblSvar.AutoSize = true;
            lblSvar.Location = new Point(372, 256);
            lblSvar.Name = "lblSvar";
            lblSvar.Size = new Size(38, 15);
            lblSvar.TabIndex = 2;
            lblSvar.Text = "label1";
            // 
            // tbxTid
            // 
            tbxTid.Location = new Point(372, 162);
            tbxTid.Name = "tbxTid";
            tbxTid.Size = new Size(100, 23);
            tbxTid.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxTid);
            Controls.Add(lblSvar);
            Controls.Add(lblTid);
            Controls.Add(btnKör);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKör;
        private Label lblTid;
        private Label lblSvar;
        private TextBox tbxTid;
    }
}