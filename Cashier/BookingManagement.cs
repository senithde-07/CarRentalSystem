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

namespace CarRentalSystem.Cashier
{
    public partial class BookingManagement : UserControl
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\Desktop\CarRentalSystem\CarRentalSystemDB.mdf;Integrated Security=True;Connect Timeout=30");
        public BookingManagement()
        {
            InitializeComponent();
        }


        private void fillcustomer()
        {
            Con.Open();
            string query = "select Fname from customerTbl ";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fname", typeof(string));
            dt.Load(rdr);
            comboBoxselcustomer.ValueMember = "Fname";
            comboBoxselcustomer.DataSource = dt;



            Con.Close();
        }

        private void fillID()
        {
            Con.Open();
            string query = "select Id from caraddTbl where Available = '"+"YES"+"' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Load(rdr);
            comboBoxselcar.ValueMember = "Id";
            comboBoxselcar.DataSource = dt;



            Con.Close();
        }

        /*private void fillcarctg()
        {
            Con.Open();
            string query = "select ctgname from carctgTbl ";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ctgname", typeof(string));
            dt.Load(rdr);
            comboBoxcarcat.ValueMember = "ctgname";
            comboBoxcarcat.DataSource = dt;



            Con.Close();
        }*/

        /*private void carid()
        {
            Con.Open();
            string query = "select id from rentalTbl ";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(string));
            dt.Load(rdr);
            comboBoxselcar.ValueMember = "id";
            comboBoxselcar.DataSource = dt;
            Con.Close();
        }*/

        private void fetchcarname()
        {
            Con.Open();
            string query = "select * from caraddTbl where Id = " + comboBoxselcar.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtrentcarname.Text = dr["Carname"].ToString();
               
            }
            Con.Close();
        }


        private void lblcolour_Click(object sender, EventArgs e)
        {

        }

        private void lbltotalamount_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BookingManagement_Load(object sender, EventArgs e)
        {
            //carid();
            fillcustomer();
            fillID();
            //fillcarctg();
            populate();




        }

        private void btncashierADD_Click(object sender, EventArgs e)
        {
            if (txtrentalid.Text == "" ||  txtrentalnoofday.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into rentalTbl values (" + txtrentalid.Text + ",'" + comboBoxselcustomer.SelectedValue.ToString() + "','" + comboBoxselcar.SelectedValue.ToString() + "','" + txtrentcarname.Text + "','" + txtrentalnoofday.Text + "','" + rentdate.Text + "','" + returndate.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added");
                    Con.Close();
                    populate();



                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
            }
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from rentalTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvrental.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void btncashierCLEAR_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtrentalid.Clear();
            txtrentalnoofday.Clear();
        }

        private void btncashierUPDATE_Click(object sender, EventArgs e)
        {
            if (txtrentalid.Text == "" || txtrentalnoofday.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update rentalTbl set days = '" + txtrentalnoofday.Text + "' where Id = " + txtrentalid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                    Con.Close();
                    populate();



                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
            }
        }

        private void btncashierDELETE_Click(object sender, EventArgs e)
        {
            if (txtrentalid.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from rentalTbl where Id=" + txtrentalid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void dgvrental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtrentalid.Text = dgvrental.CurrentRow.Cells[0].Value.ToString();
            comboBoxselcustomer.SelectedValue = dgvrental.CurrentRow.Cells[1].Value.ToString();
            comboBoxselcar.SelectedValue = dgvrental.CurrentRow.Cells[2].Value.ToString();
            txtrentcarname.Text = dgvrental.CurrentRow.Cells[3].Value.ToString();
            txtrentalnoofday.Text = dgvrental.CurrentRow.Cells[4].Value.ToString();
            rentdate.Text = dgvrental.CurrentRow.Cells[5].Value.ToString();
            returndate.Text = dgvrental.CurrentRow.Cells[6].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            fetchcarname();
        }
    }


}
