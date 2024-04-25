namespace OpakovaniWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button tlacitko = (Button)sender;
            textBox1.Text = tlacitko.Text;
        }
    }
}
