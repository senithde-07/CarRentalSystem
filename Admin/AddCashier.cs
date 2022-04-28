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
    public partial class AddCashier : UserControl
    {
        public AddCashier()
        {
            InitializeComponent();
        }



        private void AddCashier_Load(object sender, EventArgs e)
        {
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\Desktop\CarRentalSystem\CarRentalSystemDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from cashierTbl";
            SqlDataAdapter da = new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvAddcashier.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void btncashierADD_Click(object sender, EventArgs e)
        {
            if (txtcashID.Text == "" || txtcashfname.Text == "" || txtcashLname.Text == "" || txtcashaddress.Text == "" || txtcashphoneno.Text == "" || txtcashnic.Text == "" || txtcashpassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into cashierTbl values (" + txtcashID.Text + ",'" + txtcashfname.Text + "','" + txtcashLname.Text + "','" + txtcashaddress.Text + "','" + txtcashphoneno.Text + "','" + txtcashnic.Text + "','" + txtcashpassword.Text + "')";
                    //string query = "select count (*) from addcashiers where Cashier Id = '" + txtcashID.Text + "' and  First Name = '" + txtcashfname.Text + "' and Last Name = '" + txtcashLname.Text + "' and Address = '" + txtcashaddress.Text + "'and Phone NO = '" + txtcashphoneno.Text + "'and NIC NO = '" + txtcashnic.Text + "'and Password = '" + txtcashpassword.Text + "'";
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

        private void dgvAddcashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcashID.Text = dgvAddcashier.CurrentRow.Cells[0].Value.ToString();
            txtcashfname.Text = dgvAddcashier.CurrentRow.Cells[1].Value.ToString();
            txtcashLname.Text = dgvAddcashier.CurrentRow.Cells[2].Value.ToString();
            txtcashaddress.Text = dgvAddcashier.CurrentRow.Cells[3].Value.ToString();
            txtcashphoneno.Text = dgvAddcashier.CurrentRow.Cells[4].Value.ToString();
            txtcashnic.Text = dgvAddcashier.CurrentRow.Cells[5].Value.ToString();
            txtcashpassword.Text = dgvAddcashier.CurrentRow.Cells[6].Value.ToString();

        }

        private void btncashierCLEAR_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtcashID.Clear();
            txtcashfname.Clear();
            txtcashLname.Clear();
            txtcashaddress.Clear();
            txtcashphoneno.Clear();
            txtcashnic.Clear();
            txtcashpassword.Clear();
            
        }

        private void btncashierDELETE_Click(object sender, EventArgs e)
        {
            if(txtcashID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from cashierTbl where Id=" + txtcashID.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch(Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btncashierUPDATE_Click(object sender, EventArgs e)
        {

        }

        private void btncashierUPDATE_Click_1(object sender, EventArgs e)
        {
            if (txtcashID.Text == "" || txtcashfname.Text == "" || txtcashLname.Text == "" || txtcashaddress.Text == "" || txtcashphoneno.Text == "" || txtcashnic.Text == "" || txtcashpassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update cashierTbl set fname = '" + txtcashfname.Text + "',lname = '" + txtcashLname.Text + "',address = '" + txtcashaddress.Text + "',phoneno = '" + txtcashphoneno.Text + "',nicno = '" + txtcashnic.Text + "',password = '" + txtcashpassword.Text + "' where Id = " + txtcashID.Text+";";
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
    }
}
