namespace приложа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Stalin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TBox.Text);
            MessageBox.Show("Are you ready kids?","Welcome to Kazahstan");
            TBox.Text = "You was scummed!!! you lost your pussy-wife and one cup of rice!!!";
        }

        private void stuckToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hereToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Few... Thank you dude", "You really want to help?");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}