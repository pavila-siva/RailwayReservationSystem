using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class ReservationMaster : Form
    {
        public ReservationMaster()
        {
            InitializeComponent();
            populate();
            FillPid();
            FillTCode();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pavil\Documents\RemyRailwaysDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from RESERVATIONTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            ReservationDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FillPid()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select pId from PassengerTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("pId", typeof(int));
            dt.Load(rdr);
            PIdCb.ValueMember = "pId";
            PIdCb.DataSource = dt;
            Con.Close();
        }
        private void FillTCode()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TravCode from TravelTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TravCode", typeof(int));
            dt.Load(rdr);
            TravelCb.ValueMember = "TravCode";
            TravelCb.DataSource = dt;
            Con.Close();
        }
        string pname;
        private void GetPName()
        {
            Con.Open();
            string mysql = "select * from PassengerTbl where pId=" + PIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                pname = dr["PName"].ToString();
            }
            Con.Close();
            //MessageBox.Show(pname);
        }
        string Date, Src, Dest;
        int Cost;
        private void GetTravel()
        {
            Con.Open();
            string mysql = "select * from TravelTbl where TravCode=" + TravelCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
               // Date = dr["TravDate"].ToString();
                Date = Convert.ToDateTime(dr["TravDate"]).ToString("yyyy-MM-dd");
                Src = dr["Src"].ToString();
                Dest = dr["Dest"].ToString();
                Cost = Convert.ToInt32(dr["Cost"].ToString());
            }
            Con.Close();
            // MessageBox.Show(Date + Src + Dest + Cost);
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPName();
           // MessageBox.Show("Selected Passenger Name: " + pname); // Debugging
        }

        private void TravelCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTravel();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (TravelCb.SelectedIndex == -1 || PIdCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into RESERVATIONTBL values(" + PIdCb.SelectedValue.ToString() + ",'" + pname + "' ,'" + TravelCb.SelectedValue.ToString() + "','" + Date + "','" + Src + "','" + Dest + "',"+Cost+")";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation Accepted");
                    Con.Close();
                    populate();
                   // Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
    }

