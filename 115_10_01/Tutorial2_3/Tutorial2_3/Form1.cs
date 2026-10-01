namespace Tutorial2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Buongiorno";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            translateLabel.Text = "Buenos días!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Guten Morgen";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Buenos días!";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
