namespace Exempel08_01
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
            pbxBild = new PictureBox();
            gbxSpeldata = new GroupBox();
            lblStörstaTalet = new Label();
            lbxStörstaTalet = new ListBox();
            gbxSpelet = new GroupBox();
            lblResultat = new Label();
            tbxMinaResultat = new TextBox();
            lblMinaResultat = new Label();
            btnGissa = new Button();
            tbxGissa = new TextBox();
            lblDatornsTal = new Label();
            lblGissa = new Label();
            lblDator = new Label();
            btnStartaSpelet = new Button();
            btnSpelaIgen = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxBild).BeginInit();
            gbxSpeldata.SuspendLayout();
            gbxSpelet.SuspendLayout();
            SuspendLayout();
            // 
            // pbxBild
            // 
            pbxBild.BackgroundImage = Properties.Resources.exempel08_01;
            pbxBild.Location = new Point(12, 12);
            pbxBild.Name = "pbxBild";
            pbxBild.Size = new Size(340, 40);
            pbxBild.TabIndex = 0;
            pbxBild.TabStop = false;
            // 
            // gbxSpeldata
            // 
            gbxSpeldata.Controls.Add(lblStörstaTalet);
            gbxSpeldata.Controls.Add(lbxStörstaTalet);
            gbxSpeldata.Location = new Point(12, 65);
            gbxSpeldata.Name = "gbxSpeldata";
            gbxSpeldata.Size = new Size(210, 70);
            gbxSpeldata.TabIndex = 1;
            gbxSpeldata.TabStop = false;
            gbxSpeldata.Text = "Speldata";
            // 
            // lblStörstaTalet
            // 
            lblStörstaTalet.AutoSize = true;
            lblStörstaTalet.Location = new Point(17, 20);
            lblStörstaTalet.Name = "lblStörstaTalet";
            lblStörstaTalet.Size = new Size(72, 15);
            lblStörstaTalet.TabIndex = 4;
            lblStörstaTalet.Text = "Största talet:";
            // 
            // lbxStörstaTalet
            // 
            lbxStörstaTalet.FormattingEnabled = true;
            lbxStörstaTalet.ItemHeight = 15;
            lbxStörstaTalet.Location = new Point(95, 20);
            lbxStörstaTalet.Name = "lbxStörstaTalet";
            lbxStörstaTalet.Size = new Size(90, 49);
            lbxStörstaTalet.TabIndex = 3;
            lbxStörstaTalet.SelectedIndexChanged += lbxStörstaTalet_SelectedIndexChanged;
            // 
            // gbxSpelet
            // 
            gbxSpelet.Controls.Add(lblResultat);
            gbxSpelet.Controls.Add(tbxMinaResultat);
            gbxSpelet.Controls.Add(lblMinaResultat);
            gbxSpelet.Controls.Add(btnGissa);
            gbxSpelet.Controls.Add(tbxGissa);
            gbxSpelet.Controls.Add(lblDatornsTal);
            gbxSpelet.Controls.Add(lblGissa);
            gbxSpelet.Controls.Add(lblDator);
            gbxSpelet.Enabled = false;
            gbxSpelet.Location = new Point(12, 140);
            gbxSpelet.Name = "gbxSpelet";
            gbxSpelet.Size = new Size(340, 110);
            gbxSpelet.TabIndex = 2;
            gbxSpelet.TabStop = false;
            gbxSpelet.Text = "Spelet";
            // 
            // lblResultat
            // 
            lblResultat.AutoSize = true;
            lblResultat.Location = new Point(30, 80);
            lblResultat.Name = "lblResultat";
            lblResultat.Size = new Size(76, 15);
            lblResultat.TabIndex = 7;
            lblResultat.Text = "Mina resultat";
            // 
            // tbxMinaResultat
            // 
            tbxMinaResultat.Enabled = false;
            tbxMinaResultat.Location = new Point(228, 45);
            tbxMinaResultat.Multiline = true;
            tbxMinaResultat.Name = "tbxMinaResultat";
            tbxMinaResultat.ScrollBars = ScrollBars.Vertical;
            tbxMinaResultat.Size = new Size(90, 60);
            tbxMinaResultat.TabIndex = 6;
            // 
            // lblMinaResultat
            // 
            lblMinaResultat.AutoSize = true;
            lblMinaResultat.Location = new Point(228, 19);
            lblMinaResultat.Name = "lblMinaResultat";
            lblMinaResultat.Size = new Size(76, 15);
            lblMinaResultat.TabIndex = 5;
            lblMinaResultat.Text = "Mina resultat";
            // 
            // btnGissa
            // 
            btnGissa.Location = new Point(148, 45);
            btnGissa.Name = "btnGissa";
            btnGissa.Size = new Size(51, 23);
            btnGissa.TabIndex = 4;
            btnGissa.Text = "Gissa";
            btnGissa.UseVisualStyleBackColor = true;
            btnGissa.Click += btnGissa_Click;
            // 
            // tbxGissa
            // 
            tbxGissa.Location = new Point(93, 45);
            tbxGissa.Name = "tbxGissa";
            tbxGissa.Size = new Size(49, 23);
            tbxGissa.TabIndex = 3;
            // 
            // lblDatornsTal
            // 
            lblDatornsTal.AutoSize = true;
            lblDatornsTal.Location = new Point(104, 24);
            lblDatornsTal.Name = "lblDatornsTal";
            lblDatornsTal.Size = new Size(38, 15);
            lblDatornsTal.TabIndex = 2;
            lblDatornsTal.Text = "label1";
            // 
            // lblGissa
            // 
            lblGissa.AutoSize = true;
            lblGissa.Location = new Point(17, 53);
            lblGissa.Name = "lblGissa";
            lblGissa.Size = new Size(70, 15);
            lblGissa.TabIndex = 1;
            lblGissa.Text = "Gissa ett tal:";
            // 
            // lblDator
            // 
            lblDator.AutoSize = true;
            lblDator.Location = new Point(16, 24);
            lblDator.Name = "lblDator";
            lblDator.Size = new Size(67, 15);
            lblDator.TabIndex = 0;
            lblDator.Text = "Datorns tal:";
            // 
            // btnStartaSpelet
            // 
            btnStartaSpelet.Location = new Point(240, 77);
            btnStartaSpelet.Name = "btnStartaSpelet";
            btnStartaSpelet.Size = new Size(90, 23);
            btnStartaSpelet.TabIndex = 3;
            btnStartaSpelet.Text = "Starta spelet";
            btnStartaSpelet.UseVisualStyleBackColor = true;
            btnStartaSpelet.Click += btnStartaSpelet_Click;
            // 
            // btnSpelaIgen
            // 
            btnSpelaIgen.Enabled = false;
            btnSpelaIgen.Location = new Point(240, 111);
            btnSpelaIgen.Name = "btnSpelaIgen";
            btnSpelaIgen.Size = new Size(90, 23);
            btnSpelaIgen.TabIndex = 4;
            btnSpelaIgen.Text = "Spela igen";
            btnSpelaIgen.UseVisualStyleBackColor = true;
            btnSpelaIgen.Click += btnSpelaIgen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 261);
            Controls.Add(btnSpelaIgen);
            Controls.Add(btnStartaSpelet);
            Controls.Add(gbxSpelet);
            Controls.Add(gbxSpeldata);
            Controls.Add(pbxBild);
            Name = "Form1";
            Text = "Exempel";
            ((System.ComponentModel.ISupportInitialize)pbxBild).EndInit();
            gbxSpeldata.ResumeLayout(false);
            gbxSpeldata.PerformLayout();
            gbxSpelet.ResumeLayout(false);
            gbxSpelet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxBild;
        private GroupBox gbxSpeldata;
        private GroupBox gbxSpelet;
        private ListBox lbxStörstaTalet;
        private Label lblStörstaTalet;
        private Label lblMinaResultat;
        private Button btnGissa;
        private TextBox tbxGissa;
        private Label lblDatornsTal;
        private Label lblGissa;
        private Label lblDator;
        private TextBox tbxMinaResultat;
        private Button btnStartaSpelet;
        private Button btnSpelaIgen;
        private Label lblResultat;
    }
}