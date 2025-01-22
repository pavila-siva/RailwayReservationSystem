using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class TrainMaster : Form
    {
        public TrainMaster()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pavil\Documents\RemyRailwaysDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from TRAINTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            TrainDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string TrStatus = "";
            if (TrNameTb.Text == "" || TrainCapTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (BusyRd.Checked == true)
                {
                    TrStatus = "Busy";
                }
                else if (FreeRd.Checked == true)
                {
                    TrStatus = "Available";
                }
                try
                {
                    Con.Open();
                    string Query = "insert into TRAINTBL values('" + TrNameTb.Text + "'," + TrainCapTb.Text + " ,'" + TrStatus + "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Train Added Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void reset()
        {
            TrNameTb.Text = "";
            TrainCapTb.Text = "";
            BusyRd.Checked = false;
            FreeRd.Checked = false;
            key = 0;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int key = 0;
        private void TrainDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TrNameTb.Text = TrainDGV.SelectedRows[0].Cells[1].Value.ToString();
            TrainCapTb.Text = TrainDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (TrNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TrainDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Train To Be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "delete from TRAINTBL where TrainId=" + key + "";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Train Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string TrStatus = "";
            if (TrNameTb.Text == "" || TrainCapTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (BusyRd.Checked == true)
                {
                    TrStatus = "Busy";
                }
                else if (FreeRd.Checked == true)
                {
                    TrStatus = "Available";
                }
                try
                {
                    Con.Open();
                    string Query = "update TRAINTBL set TrainName='"+TrNameTb.Text+"',TrainCap="+TrainCapTb.Text+",TrainSatus='"+TrStatus+"'where TrainId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Train Updated Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
