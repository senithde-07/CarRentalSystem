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
    public partial class PaymentManagement : UserControl
    {
        public PaymentManagement()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\Desktop\CarRentalSystem\CarRentalSystemDB.mdf;Integrated Security=True;Connect Timeout=30");

        public static object SelectItems { get; internal set; }

        private void rentalID()
        {
            Con.Open();
            string query = "select Id from rentalTbl ";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Load(rdr);
            comboBoxrentId.ValueMember = "Id";
            comboBoxrentId.DataSource = dt;
            Con.Close();
        }
      

        private void fetchcusname()
        {
            Con.Open();
            string query = "select * from rentalTbl where Id = '" + comboBoxrentId.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                txtrentcus.Text = dr["cusname"].ToString();
                textBox2.Text = dr["carname"].ToString();
                textBox3.Text = dr["days"].ToString();
                textBox5.Text = dr["carid"].ToString();
            }
            Con.Close();
        }

       

        private void dailyprice()
        {
            Con.Open();
            string query = "select * from caraddTbl where Id = " + textBox5.Text.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtdailyprice.Text = dr["Dailyprice"].ToString();
            }
            Con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            fetchcusname();
            dailyprice();
        }

        private void lblrs_Click(object sender, EventArgs e)
        {

        }

        private void txtdaliyprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaymentManagement_Load(object sender, EventArgs e)
        {
            rentalID();
            populate();
            


        }

        private void comboBoxrentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtdailyprice.Text);
            int b = Convert.ToInt32(textBox3.Text);
            txttotal.Text = Convert.ToString(a*b);
        }

     

        private void btnLogOut_Yes_Click(object sender, EventArgs e)
        {
            if (txtcash.Text == "" || textbalance.Text == "")
            {
                MessageBox.Show("Calculate Balance Correctly");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into paymentTbl values ('"+ txtinvoiveno.Text+ "'," + comboBoxrentId.SelectedValue.ToString() + ",'" + textBox5.Text + "','" + textBox2.Text + "','" + txtrentcus.Text + "','" + textBox3.Text + "','" + txtdailyprice.Text + "','" + txttotal.Text + "','" + txtcash.Text + "','" + textbalance.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment Successfully !");
                    Con.Close();
                    populate();

                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
                //Cashier.paymentsuccessfulmsg objlogout = new Cashier.paymentsuccessfulmsg();
                //MessageBox.Show("Payment Successfully !");
                //objlogout.Show();
            }
                
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from paymentTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvpayment.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if(txttotal.Text == "" || txtcash.Text == "")
            {
                MessageBox.Show("First calculate the Total Amount!!!");
            }
            else if(Convert.ToInt32(txtcash.Text) < Convert.ToInt32(txttotal.Text))
            {
                MessageBox.Show("There is something wrong!");
            }
            else
            {
                int x, y;
                x = Convert.ToInt32(txtcash.Text);
                y = Convert.ToInt32(txttotal.Text);
                
                textbalance.Text = Convert.ToString(x - y);
            }


        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if(txttotal.Text == "" || txtcash.Text == "" || textbalance.Text == "")
            {
                MessageBox.Show("There is something wrong. Fill the calculation part correctly.");
            }
            else
            {
                Cashier.CustomerInvoice invoice = new Cashier.CustomerInvoice();
                invoice.CusName = txtrentcus.Text;
                invoice.rentid = comboBoxrentId.Text;
                invoice.carid = textBox5.Text;
                invoice.carmodel = textBox2.Text;
                invoice.days = textBox3.Text;
                invoice.dailyprice = txtdailyprice.Text;
                invoice.total = txttotal.Text;
                invoice.cash = txtcash.Text;
                invoice.balance = textbalance.Text;
                //invoice.cusphone = Admin.Cusomers_Management.txtcusphoneno.Text;
                invoice.ShowDialog();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txttotal.Clear();
            txtcash.Clear();
            textbalance.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txttotal.Text == "" || txtcash.Text == "" || textbalance.Text == "")
            {
                MessageBox.Show("Select the RentalId !!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from paymentTbl where rentalid=" + comboBoxrentId.SelectedValue.ToString() + ";";
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

        private void dgvpayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtinvoiveno.Text = dgvpayment.CurrentRow.Cells[0].Value.ToString();
            comboBoxrentId.SelectedValue = dgvpayment.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = dgvpayment.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dgvpayment.CurrentRow.Cells[3].Value.ToString();
            txtrentcus.Text = dgvpayment.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dgvpayment.CurrentRow.Cells[5].Value.ToString();
            txtdailyprice.Text = dgvpayment.CurrentRow.Cells[6].Value.ToString();
            txttotal.Text = dgvpayment.CurrentRow.Cells[7].Value.ToString();
            txtcash.Text = dgvpayment.CurrentRow.Cells[8].Value.ToString();
            textbalance.Text = dgvpayment.CurrentRow.Cells[9].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
