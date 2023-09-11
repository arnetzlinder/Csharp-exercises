namespace Exempel03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(tbxTal.Text);

            int kvadrat = tal * tal;
            string text = kvadrat.ToString();
            tbxKvadrat.Text = text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}