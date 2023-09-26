namespace Exempel07_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStörstaTalet_Click(object sender, EventArgs e)
        {
            string t1 = tbxTal1.Text;
            double tal1 = double.Parse(t1);
            string t2 = tbxTal2.Text;
            double tal2 = double.Parse(t2);
            double max = tal1 > tal2 ? tal1 : tal2;
            lblResultat.Text = "Det största talet är " + max;
        }

        private void tbxTal1_TextChanged(object sender, EventArgs e)
        {
            lblResultat.Text = "";
        }

        private void tbxTal2_TextChanged(object sender, EventArgs e)
        {
            lblResultat.Text = "";
        }
    }
}