using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RailwayReservationSystem
{
    public partial class TravelMaster : Form
    {
        public TravelMaster()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pavil\Documents\RemyRailwaysDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
