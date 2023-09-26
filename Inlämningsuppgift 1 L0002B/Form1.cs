namespace Inlämningsuppgift_1_L0002B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeräkna_Click(object sender, EventArgs e)
        {
            int varansPris = int.Parse(tbxPris.Text);
            int kundsBetalning = int.Parse(tbxBetalat.Text);
            int växel = kundsBetalning - varansPris;

            int femhundra = 500;
            int tvåhundra = 200;
            int etthundra = 100;
            int femtio = 50;
            int tjugo = 20;
            int tio = 10;
            int fem = 5;
            int en = 1;


        }
    }
}