namespace Övning05_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int minaPengar = int.Parse( tbxPengar.Text );
            int varansPris = int.Parse(tbxPris.Text );
            bool pengarFinns = false;

            if(minaPengar > varansPris)
            {
                pengarFinns = true;
            } else
            {
                pengarFinns = false;
            }

            lblSvar.Text = "Du har råd med varan: " + pengarFinns;
        }

        
    }
}