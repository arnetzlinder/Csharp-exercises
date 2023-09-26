namespace Exempel08_01
{
    public partial class Form1 : Form
    {
        int datornsTal;
        int antalGissningar;
        public Form1()
        {
            InitializeComponent();

            lbxSt�rstaTalet.Items.Add(10);
            lbxSt�rstaTalet.Items.Add(20);

            lbxSt�rstaTalet.SelectedItem = lbxSt�rstaTalet.Items[0];

            tbxMinaResultat.AppendText("Rad 1\r\n");
            tbxMinaResultat.AppendText("Rad 2\r\n");

        }

        private void btnStartaSpelet_Click(object sender, EventArgs e)
        {
            string st�rstaTal = lbxSt�rstaTalet.SelectedItem.ToString();
            int st�rst = int.Parse(st�rstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, st�rst + 1);


            btnStartaSpelet.Enabled = false;
            gbxSpeldata.Enabled = false;
            gbxSpelet.Enabled = true;

            lblDatornsTal.Text = "??";

            antalGissningar = 0;
        }

        private void btnGissa_Click(object sender, EventArgs e)
        {
            antalGissningar++;
            string gissa = tbxGissa.Text;
            int gissatTal = int.Parse(gissa);

            if (gissatTal == datornsTal)
            {
                lblMinaResultat.Text = "Korrekt efter " +
                    antalGissningar + " f�rs�k.";
                gbxSpelet.Enabled = false;
                btnSpelaIgen.Enabled = true;

                lblDatornsTal.Text = datornsTal.ToString();
                tbxMinaResultat.AppendText(antalGissningar + " f�rs�k\n");
            }
            else if (gissatTal < datornsTal)
            {
                lblResultat.Text = "F�r l�gt. F�rs�k igen!";
            }
            else
            {
                lblResultat.Text = "F�r h�gt. F�rs�k igen!";
            }
        }

        private void btnSpelaIgen_Click(object sender, EventArgs e)
        {
            string st�rstaTal = lbxSt�rstaTalet.SelectedItem.ToString();
            int st�rst = int.Parse(st�rstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, st�rst + 1);

            gbxSpelet.Enabled = true;
            btnSpelaIgen.Enabled = false;

            antalGissningar = 0;

            tbxGissa.Clear();

            lblResultat.Text = "";

            lblDatornsTal.Text = "??";
        }

        private void lbxSt�rstaTalet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}