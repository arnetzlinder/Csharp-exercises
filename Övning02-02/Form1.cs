namespace Övning02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Metoden visar en meddelanderuta.
        private void button1_Click(object sender, EventArgs e)
        {
            //Här visas meddelanderutan
            MessageBox.Show(
                "Mitt första program", "Meddelande",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}