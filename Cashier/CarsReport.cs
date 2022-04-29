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
    public partial class Cars_Report : UserControl
    {
        public Cars_Report()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\Desktop\CarRentalSystem\CarRentalSystemDB.mdf;Integrated Security=True;Connect Timeout=30");


        public void available()
        {
            Con.Open();
            string query = "select * from caraddTbl where Available = '" + "YES" + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvcarmangement.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Cars_Report_Load(object sender, EventArgs e)
        {
            available();
            

        }

        
        private void btnrefresh_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxcarsearch_SelectionChangeCommitted(object sender, EventArgs e)
        {


        }



        private void txtreportctg_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtseach_TextChanged(object sender, EventArgs e)
        {
            if (txtseach.Text == "")
            {
                available();
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "select Id as 'ID', Carname as 'CarName', Carctg as 'Category', Carno as 'CarNo',Dailyprice as 'DPrice' , Engcap as 'EngCap' , Insuranceno , Colour , Available  from caraddTbl where Carctg LIKE '" + txtseach.Text + "%'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Con);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dgvcarmangement.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
                finally
                {
                    Con.Close();
                }
            }

        }

        private void txtseachcarname_TextChanged(object sender, EventArgs e)
        {
            if (txtseachcarname.Text == "")
            {
                available();
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "select Id as 'ID', Carname as 'CarName', Carctg as 'Category', Carno as 'CarNo',Dailyprice as 'DPrice' , Engcap as 'EngCap' , Insuranceno , Colour , Available  from caraddTbl where Carname LIKE '" + txtseachcarname.Text + "%'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Con);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dgvcarmangement.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
                finally
                {
                    Con.Close();
                }
            }
        }
    }
}
