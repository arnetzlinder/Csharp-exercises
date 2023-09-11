namespace Övning03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblA_Click(object sender, EventArgs e)
        {

        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int talA = int.Parse(tbxA.Text);
            int talB = int.Parse(tbxB.Text);
            int talC = int.Parse(tbxC.Text);

            int summa = talA+ talB + talC;
            double medel = (double)summa / 3;

            string summan = summa.ToString();
            string medeln = medel.ToString();

            lblSumma.Text = "Summa: " + summan;
            lblMedel.Text = "Medelvärde: " + medeln; 

        }
    }
}