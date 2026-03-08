namespace TP_MODUL3_103022430011
{
    public partial class Form1 : Form
    {
        double total = 0;
        bool tambahDitekan = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonAngka_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            labelOutput.Text += btn.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != "")
            {
                total += Convert.ToDouble(labelOutput.Text);
                labelOutput.Text = "";
                tambahDitekan = true;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (tambahDitekan && labelOutput.Text != "")
            {
                total += Convert.ToDouble(labelOutput.Text);
                labelOutput.Text = total.ToString();
                total = 0;
                tambahDitekan = false;
            }
        }
    }
}
