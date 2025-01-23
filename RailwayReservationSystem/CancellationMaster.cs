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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RailwayReservationSystem
{
    public partial class CancellationMaster : Form
    {
        public CancellationMaster()
        {
            InitializeComponent();
            populate();
            FillTicketId();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pavil\Documents\RemyRailwaysDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from CancellationTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            CancellationDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FillTicketId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TicketId from ReservationTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TicketId", typeof(int));
            dt.Load(rdr);
            TidCb.ValueMember = "TicketId";
            TidCb.DataSource = dt;
            Con.Close();
        }


        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (TidCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into CancellationTbl values(" + TidCb.SelectedValue.ToString() + ",'" + DateTime.Today.ToString("yyyy-MM-dd") + "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Cancelled");
                    Con.Close();
                    populate();
                    remove();
                    FillTicketId();
                    TidCb.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void remove()
        {

            try
            {
                Con.Open();
                string Query = "delete from ReservationTbl where TicketId=" + TidCb.SelectedValue.ToString() + "";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
