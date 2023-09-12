namespace Exempel05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int allaMinuter = int.Parse( tbxTid.Text );
            int timmar = allaMinuter / 60;
            int minuter = allaMinuter % 60;

            lblSvar.Text = "" + timmar + "tim. och " + minuter + "min.";
        }
    }
}