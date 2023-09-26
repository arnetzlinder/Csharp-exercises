namespace Exempel07_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrollera_Click(object sender, EventArgs e)
        {
            string namn = tbxNamn.Text;
            string lösenord = tbxLösenord.Text;
            if (namn.Equals("Mia") && lösenord.Equals("Hemligt"))
            {
                lblResultat.Text = "Hej Mia";
            }
            else
            {
                lblResultat.Text = "Felaktigt namn eller lösenord!";
            }
        }

        private void tbxNamn_TextChanged(object sender, EventArgs e)
        {
            lblResultat.Text = "";
        }

        private void tbxLösenord_TextChanged(object sender, EventArgs e)
        {
            lblResultat.Text = "";
        }
    }
}