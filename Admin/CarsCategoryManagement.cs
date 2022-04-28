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
    public partial class Cars_Category_Management : UserControl
    {
        public Cars_Category_Management()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\Desktop\CarRentalSystem\CarRentalSystemDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from carctgtbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvcarctg.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void btncarctgADD_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtctg.Text == "" || txtdesc.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into carctgTbl values (" + txtID.Text + ",'" + txtctg.Text + "','" + txtdesc.Text + "')";
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

        private void lbl6_Click(object sender, EventArgs e)
        {

        }

        private void txtctg_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvcarctg_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            txtID.Text = dgvcarctg.CurrentRow.Cells[0].Value.ToString();
            txtctg.Text = dgvcarctg.CurrentRow.Cells[1].Value.ToString();
            txtdesc.Text = dgvcarctg.CurrentRow.Cells[2].Value.ToString();
        }

        private void Cars_Category_Management_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btncarctgCLEAR_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtID.Clear();
            txtctg.Clear();
            txtdesc.Clear();
            
        }

        private void btncarctgDELETE_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from carctgTbl where Id=" + txtID.Text + ";";
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

        private void btncarctgUPDATE_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtctg.Text == "" || txtdesc.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update carctgTbl set ctgname = '" + txtctg.Text + "',description = '" + txtdesc.Text + "' where Id = " + txtID.Text + ";";
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
