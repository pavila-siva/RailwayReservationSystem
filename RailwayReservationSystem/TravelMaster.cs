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
using Microsoft.SqlServer.Server;
using System.Text.RegularExpressions;

namespace RailwayReservationSystem
{
    public partial class TravelMaster : Form
    {
        public TravelMaster()
        {
            InitializeComponent();
            populate();
            FillTCode();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pavil\Documents\RemyRailwaysDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from TRAVELTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            TravelDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FillTCode()
        {
            string TrStatus = "Busy";
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TrainId from TRAINTBL where TrainSatus='" + TrStatus + "'", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TrainId", typeof(int));
            dt.Load(rdr);
            TCode.ValueMember = "TrainId";
            TCode.DataSource = dt;
            Con.Close();
        }


        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ChangeStatus()
        {
            string TrStatus = "Busy";

            try
            {
                Con.Open();
                string Query = "update TRAINTBL set  TrainSatus='" + TrStatus + "'where TrainId=" + TCode.SelectedValue.ToString() + ";";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Train Updated Successfully");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (Tcost.Text == "" || TCode.SelectedIndex == -1 || SrcCb.SelectedIndex == -1 || DestCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into TRAVELTBL values('" + TravelDate.Value.ToString("yyyy-MM-dd") + "','" + TCode.SelectedValue.ToString() + "' ,'" + SrcCb.SelectedItem.ToString() + "','" + DestCb.SelectedItem.ToString() + "','" + Tcost.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Travel Added Successfully");
                    Con.Close();
                    populate();
                    ChangeStatus();
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
            SrcCb.SelectedIndex = -1;
            DestCb.SelectedIndex = -1;
            //TCode.SelectedIndex = -1;
            Tcost.Text = "";

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (SrcCb.SelectedIndex == -1 || DestCb.SelectedIndex == -1 || Tcost.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "update TRAVELTBL set TravDate='" + TravelDate.Text + "',Train='" + TCode.SelectedValue.ToString() + "',Src='" + SrcCb.SelectedItem.ToString() + "', Dest='" + DestCb.SelectedItem.ToString() + "',Cost='" + Tcost.Text + "' where TravCode=" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Travel Updated Successfully");
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
        int key = 0;
        private void TravelDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TravelDate.Text = TravelDGV.SelectedRows[0].Cells[1].Value.ToString();
            TCode.SelectedValue = TravelDGV.SelectedRows[0].Cells[2].Value.ToString();
            SrcCb.SelectedItem = TravelDGV.SelectedRows[0].Cells[3].Value.ToString();
            DestCb.SelectedItem = TravelDGV.SelectedRows[0].Cells[4].Value.ToString();
            Tcost.Text = TravelDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (TCode.SelectedIndex == -1)
            {
                key = 0;
                //Tcost.Text = "";
                //SrcCb.SelectedIndex = -1;
                //DestCb.SelectedIndex = -1;
            }
            else
            {
                key = Convert.ToInt32(TravelDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void TravelMaster_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Hide();
        }
    }
}
