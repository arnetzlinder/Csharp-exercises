namespace Exempel02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKlick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mitt första program i C#", "Meddelande",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}