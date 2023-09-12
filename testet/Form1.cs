namespace testet;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnFlytta_Click(object sender, EventArgs e)
    {
        int x = int.Parse(tbxX.Text);
        int y = int.Parse(tbxY.Text);

        Point nyPosition = new Point(x, y);

        btnFlytta.Location = nyPosition;
    }
}
