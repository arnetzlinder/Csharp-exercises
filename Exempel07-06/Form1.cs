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
            string l�senord = tbxL�senord.Text;
            if (namn.Equals("Mia") && l�senord.Equals("Hemligt"))
            {
                lblResultat.Text = "Hej Mia";
            }
            else
            {
                lblResultat.Text = "Felaktigt namn eller l�senord!";
            }
        }

        private void tbxNamn_TextChanged(object sender, EventArgs e)
        {
            lblResultat.Text = "";
        }

        private void tbxL�senord_TextChanged(object sender, EventArgs e)
        {
            lblResultat.Text = "";
        }
    }
}