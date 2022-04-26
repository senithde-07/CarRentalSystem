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

namespace CarRentalSystem.Admin
{
    public partial class Cusomers_Management : UserControl
    {
        public Cusomers_Management()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\Desktop\CarRentalSystem\CarRentalSystemDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from customerTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvcustomer.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void btncustomerADD_Click(object sender, EventArgs e)
        {
            if (txtcusID.Text == "" || txtcusfname.Text == "" || txtcusLname.Text == "" || txtcusaddress.Text == "" || txtcusnic.Text == "" || txtcusphoneno.Text == "" || txtcuslicenceno.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into customerTbl values (" + txtcusID.Text + ",'" + txtcusfname.Text + "','" + txtcusLname.Text + "','" + txtcusaddress.Text + "','" + txtcusnic.Text + "','" + txtcusphoneno.Text + "','" + txtcuslicenceno.Text + "')";
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

        private void Cusomers_Management_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dgvCustomerMange_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btncustomerCLEAR_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtcusID.Clear();
            txtcusfname.Clear();
            txtcusLname.Clear();
            txtcusaddress.Clear();
            txtcusnic.Clear();
            txtcusphoneno.Clear();
            txtcuslicenceno.Clear();

        }

        private void btncustomerUPDATE_Click(object sender, EventArgs e)
        {
            if (txtcusID.Text == "" || txtcusfname.Text == "" || txtcusLname.Text == "" || txtcusaddress.Text == "" || txtcusnic.Text == "" || txtcusphoneno.Text == "" || txtcuslicenceno.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update customerTbl set Fname = '" + txtcusfname.Text + "',Lname = '" + txtcusLname.Text + "',Address = '" + txtcusaddress.Text + "',NIC = '" + txtcusnic.Text + "',Phone = '" + txtcusphoneno.Text + "',Licence = '" + txtcuslicenceno.Text + "' where Id = " + txtcusID.Text + ";";
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

        private void btncustomerDELETE_Click(object sender, EventArgs e)
        {
            if (txtcusID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from customerTbl where Id=" + txtcusID.Text + ";";
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
    }
}
