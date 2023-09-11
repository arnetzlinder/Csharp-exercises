namespace Övning02_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRöd_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void btnBlå_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }
    }
}