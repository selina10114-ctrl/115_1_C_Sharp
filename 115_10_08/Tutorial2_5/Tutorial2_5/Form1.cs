namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showBackButton_Click(object sender, EventArgs e)
        {
            cardBackPictureBox.Visible = true;
            cardFacePictureBox.Visible = false;
        }

        

        private void showFaceButton_Click(object sender, EventArgs e)
        {
            cardBackPictureBox.Visible = false;
            cardFacePictureBox.Visible = true;
        }
    }
}

