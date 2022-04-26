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
    public partial class Cars_Management : UserControl
    {
        public Cars_Management()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\Desktop\CarRentalSystem\CarRentalSystemDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void fillcombo()
        {
            Con.Open();
            string query = "select  ctgname from carctgTbl ";
            SqlCommand cmd = new SqlCommand(query,Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ctgname",typeof(string));
            dt.Load(rdr);
            comboBoxcarcatgerory.ValueMember = "ctgname";
            comboBoxcarcatgerory.DataSource = dt;



            Con.Close();
        }
        private void lbl7_Click(object sender, EventArgs e)
        {

        }

        public void populate()
        {
            Con.Open();
            string query = "select * from caraddTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvcarmangement.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void btncarmanADD_Click(object sender, EventArgs e)
        {
            if (txtcarid.Text == "" || txtcarname.Text == "" ||  txtcarno.Text == "" || txtdaliyprice.Text == "" || txtengcap.Text == "" || txtinsuranceno.Text == "" || txtcolour.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into caraddTbl values (" + txtcarid.Text + ",'" + txtcarname.Text + "','" + comboBoxcarcatgerory.SelectedValue.ToString()+ "','" + txtcarno.Text + "','" + txtdaliyprice.Text + "','" + txtengcap.Text + "','" + txtinsuranceno.Text + "','" + txtcolour.Text + "','"+ comboavailable.SelectedItem.ToString() + "')";
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

        private void comboBoxcarcatgerory_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Cars_Management_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
        }

        private void btncarmanCLEAR_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtcarid.Clear();
            txtcarname.Clear();
            txtcarno.Clear();
            txtdaliyprice.Clear();
            txtengcap.Clear();
            txtinsuranceno.Clear();
            txtcolour.Clear();

        }

        private void btncarmanUPDATE_Click(object sender, EventArgs e)
        {
            if (txtcarid.Text == "" || txtcarname.Text == "" || txtcarno.Text == "" || txtdaliyprice.Text == "" || txtengcap.Text == "" || txtinsuranceno.Text == "" || txtcolour.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update caraddTbl set Carname = '" + txtcarname.Text + "',Carno = '" + txtcarno.Text + "',Dailyprice = '" + txtdaliyprice.Text + "',Engcap = '" + txtengcap.Text + "',Insuranceno = '" + txtinsuranceno.Text + "',Colour = '" + txtcolour.Text + "' where Id = " + txtcarid.Text + ";";
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

        private void btncarmanDELETE_Click(object sender, EventArgs e)
        {
            if (txtcarid.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from caraddTbl where Id=" + txtcarid.Text + ";";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
