namespace Övning07_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeräkna_Click(object sender, EventArgs e)
        {
            int literBensin = int.Parse(tbxLiter.Text);
            int fullTank = 50;
            double bensinPris = 14.50;

            if ((fullTank - literBensin) < 10)
            {
                lblSvar.Text = "Du behöver inte tanka, kör på!";
            } else
            {
                double tankMängd = (fullTank - literBensin);
                double kostnad = tankMängd * bensinPris;

                lblSvar.Text = "Tanka " + tankMängd + " liter. Det kostar " + kostnad + " kr.";
            }
        }
    }
}