namespace Exempel07_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string a = tbxAge.Text;
            int age = int.Parse(a);
            int prisVuxen = 30;
            int prisReducerat = 20;
            if (age < 15 || age > 65 )
            {
                lblPris.Text = "Resan kostar " + prisReducerat + " kronor.";
            } else
            {
                lblPris.Text = "Resan kostar " + prisVuxen + " kronor.";
            }
        }

        private void tbxAge_TextChanged(object sender, EventArgs e)
        {
            lblPris.Text = "";
        }


    }
}