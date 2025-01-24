namespace RailwayReservationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Enter UserName and Phone Number");
            }
            else if (PassTb.Text.Length != 10)
            {
                MessageBox.Show("Wrong Phone number");
            }
            else
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
