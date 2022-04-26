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
            string query = "select * from caraddTbl where Available = '"+"YES"+"'";
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
            fillcombo();
      


        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxcarsearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            
        }

        private void fillcombo()
        {
            Con.Open();
            string query = "select  ctgname from carctgTbl ";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ctgname", typeof(string));
            dt.Load(rdr);
            comboBoxcarsearch.ValueMember = "ctgname";
            comboBoxcarsearch.DataSource = dt;



            Con.Close();
        }
    }
}
