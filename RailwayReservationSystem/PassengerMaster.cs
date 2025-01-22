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
    public partial class PassengerMaster : Form
    {
        public PassengerMaster()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pavil\Documents\RemyRailwaysDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from PASSENGERTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (PnameTb.Text == "" || PPhoneTb.Text == "" || PaddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (MaleRd.Checked == true)
                {
                    Gender = "Male";
                }
                else if (FemaleRd.Checked == true)
                {
                    Gender = "Female";
                }
                try
                {
                    Con.Open();
                    string Query = "insert into PASSENGERTBL values('" + PnameTb.Text + "','" + PaddressTb.Text + "' ,'" + Gender + "','" + NatCb.SelectedItem.ToString() + "','" + PPhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Added Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Reset()
        {
            PnameTb.Text = "";
            PaddressTb.Text = "";
            PPhoneTb.Text = "";
            MaleRd.Checked = false;
            FemaleRd.Checked = false;
            NatCb.SelectedIndex = -1;
            key = 0;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;
        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PnameTb.Text = PassengerDGV.SelectedRows[0].Cells[1].Value.ToString();
            PaddressTb.Text = PassengerDGV.SelectedRows[0].Cells[2].Value.ToString();
            NatCb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[4].Value.ToString();
            PPhoneTb.Text = PassengerDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (PnameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PassengerDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Passenger To Be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "delete from PASSENGERTBL where PId=" + key + "";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Train Deleted Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (PnameTb.Text == "" || PPhoneTb.Text == "" || PaddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (MaleRd.Checked == true)
                {
                    Gender = "Male";
                }
                else if (FemaleRd.Checked == true)
                {
                    Gender = "Female";
                }
                try
                {
                    Con.Open();
                   
                    string Query = "update PASSENGERTBL set Pname='" + PnameTb.Text + "',PAdd='" + PaddressTb.Text + "',PGender='" + Gender + "', PNat='"+ NatCb.SelectedItem.ToString() + "',PPhone='"+ PPhoneTb.Text + "' where PId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
