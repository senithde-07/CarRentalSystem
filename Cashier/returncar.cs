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
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\Desktop\CarRentalSystem\CarRentalSystemDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from paymentTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvreturncar.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void returncar_Load(object sender, EventArgs e)
        {
            populate();
            
        }

        private void dgvreturncar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtreturnnid.Text = dgvreturncar.CurrentRow.Cells[0].Value.ToString();
            txtreturncarid.Text = dgvreturncar.CurrentRow.Cells[1].Value.ToString();
            txtreturncarname.Text = dgvreturncar.CurrentRow.Cells[2].Value.ToString();
            txtreturncus.Text = dgvreturncar.CurrentRow.Cells[3].Value.ToString();
            
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
