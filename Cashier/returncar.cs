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
    public partial class returncar : UserControl
    {
        public returncar()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("M/d/yyyy");
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\Desktop\CarRentalSystem\CarRentalSystemDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void invoicenum()
        {
            Con.Open();
            string query = "select invoiceno from paymentTbl ";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("invoiceno", typeof(string));
            dt.Load(rdr);
            comboBoxreturninvoiceno.ValueMember = "invoiceno";
            comboBoxreturninvoiceno.DataSource = dt;
            Con.Close();
        }


        private void Fetchcusname()
        {
            Con.Open();
            string query = "select * from paymentTbl where invoiceno = " + comboBoxreturninvoiceno.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtreturncarid.Text = dr["carid"].ToString();
                txtreturncarname.Text = dr["carmodel"].ToString();
                txtreturncus.Text = dr["customer"].ToString();
                returndate1.Text = dr["returndate"].ToString();
            }
            Con.Close();
        }


        public string Date;


        private void returncar_Load(object sender, EventArgs e)
        {
            invoicenum();
            currentdate.Text= Date;
            populate();



        }

        private void dgvreturncar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Fetchcusname();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        internal void ShowDialog()
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void delaytotalbtn_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(delaydates.Text);
            int b = Convert.ToInt32(delayfee.Text);
            total.Text = Convert.ToString(a * b);
        }

        private void btnLogOut_Yes_Click(object sender, EventArgs e)
        {
            
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from returnTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvreturn.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (total.Text == "" || txtcash.Text == "")
            {
                MessageBox.Show("First calculate the Total Amount!!!");
            }
            else if (Convert.ToInt32(txtcash.Text) < Convert.ToInt32(total.Text))
            {
                MessageBox.Show("There is something wrong!");
            }
            else
            {
                int x, y;
                x = Convert.ToInt32(txtcash.Text);
                y = Convert.ToInt32(total.Text);

                textbalance.Text = Convert.ToString(x - y);
            }
        }

        private void btnpaid_Click(object sender, EventArgs e)
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
                    string query = "insert into returnTbl values ('" + txtreturnnid.Text + "','" + txtreturncarname.Text + "','" + txtreturncus.Text + "','" + delaydates.Text + "','" + total.Text + "','" + txtcash.Text + "','" + textbalance.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment Successfully & The Car was Returned !");
                    Con.Close();
                    populate();

                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }

            }
        }

        private void dgvreturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtreturnnid.Text = dgvreturn.CurrentRow.Cells[0].Value.ToString();
            txtreturncarid.Text = dgvreturn.CurrentRow.Cells[1].Value.ToString();
            txtreturncarname.Text = dgvreturn.CurrentRow.Cells[2].Value.ToString();
            txtreturncus.Text = dgvreturn.CurrentRow.Cells[3].Value.ToString();
            delaydates.Text = dgvreturn.CurrentRow.Cells[4].Value.ToString();
            total.Text = dgvreturn.CurrentRow.Cells[5].Value.ToString();
            txtcash.Text = dgvreturn.CurrentRow.Cells[6].Value.ToString();
            //textbalance.Text = dgvreturn.CurrentRow.Cells[7].Value.ToString();

        }

        private void lbltotalamount_Click(object sender, EventArgs e)
        {

        }

        private void txtreturnnid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             clear();
        }

        private void clear()
        {
            txtreturnnid.Clear();
            delaydates.Clear();
            total.Clear();
            txtcash.Clear();
            textbalance.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtreturnnid.Text == "" || delaydates.Text == "" || total.Text == "" || txtcash.Text == "" || textbalance.Text == "")
            {
                MessageBox.Show("Select the ReturnID !!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from returnTbl where invoiceno=" + txtreturnnid.Text + ";";
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

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (total.Text == "" || txtcash.Text == "")
            {
                MessageBox.Show("There is something wrong. Fill the calculation part correctly.");
            }
            else
            {
                Cashier.returninvoice invoice = new Cashier.returninvoice();
                invoice.returnid = txtreturnnid.Text;
                invoice.carmodel = txtreturncarname.Text;
                invoice.CusName = txtreturncus.Text;
                invoice.delaydates = delaydates.Text;
                invoice.delayfee = delayfee.Text;
                invoice.total = total.Text;
                invoice.cash = txtcash.Text;
                invoice.balance = textbalance.Text;
                invoice.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*if (txtreturnnid.Text == "" || delaydates.Text == "" || total.Text == "" || txtcash.Text == "" || textbalance.Text == "")
            {
                MessageBox.Show("Select the Customer !!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from customerTbl where Id=" + comboBoxreturninvoiceno.Text + ";";
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
            }*/
        }
    }
}
