namespace Exempel07_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHyresKostnad_Click(object sender, EventArgs e)
        {
            int antalPersoner = int.Parse(tbxAntalPersoner.Text);
            switch (antalPersoner)
            {
                case 1:
                    lblResultat.Text = "Det kostar 70 kr";
                    break;
                case 2:
                    lblResultat.Text = "Det kostar 120 kr";
                    break;
                case 3:
                    lblResultat.Text = "Det kostar 150 kr";
                    break;
                default:
                    lblResultat.Text = "Du kan bara välja 1-3 personer, försök igen";
                    break;
            }
        }

        private void tbxAntalPersoner_TextChanged(object sender, EventArgs e)
        {
            lblResultat.Text = "";
        }
    }
}