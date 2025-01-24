using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            TrainMaster Train = new TrainMaster();
            Train.Show();
            this.Hide();
        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            TrainMaster Train = new TrainMaster();
            Train.Show();
            this.Hide();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            CancellationMaster Cancel = new CancellationMaster();
            Cancel.Show();
            this.Hide();
        }
        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            CancellationMaster Cancel = new CancellationMaster();
            Cancel.Show();
            this.Hide();
        }
        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            ReservationMaster Res = new ReservationMaster();
            Res.Show();
            this.Hide();
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {
            ReservationMaster Res = new ReservationMaster();
            Res.Show();
            this.Hide();
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            PassengerMaster pas = new PassengerMaster();
            pas.Show();
            this.Hide();
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            PassengerMaster pas = new PassengerMaster();
            pas.Show();
            this.Hide();
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            TravelMaster travel = new TravelMaster();
            travel.Show();
            this.Hide();
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {
            TravelMaster travel = new TravelMaster();
            travel.Show();
            this.Hide();
        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }
    }
}
