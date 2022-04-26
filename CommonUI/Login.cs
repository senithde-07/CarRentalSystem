using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRentalSystem.CommonUI
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string CashierName = "";

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\Desktop\CarRentalSystem\CarRentalSystemDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void btnLogin_Click(object sender, EventArgs e)
        {
           if(txtLoginUsername.Text == "" || txtLoginPassword.Text == "")
            {
                MessageBox.Show("Enter the UserID & Password");
            }
           else
            {
                if(comboselctrole.SelectedIndex>-1)
                {
                    if (comboselctrole.SelectedItem.ToString() == "ADMIN")
                    {
                        if (txtLoginUsername.Text == "Admin" && txtLoginPassword.Text == "Admin")
                        {
                            Admin.AdminDashboard adm = new Admin.AdminDashboard();
                            adm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Enter Correct UserID & Password");
                        }
                    }
                    else
                    {
                        
                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from cashierTbl where fname = '" + txtLoginUsername.Text + "' and password = '" + txtLoginPassword.Text + "' ", Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if(dt.Rows[0][0].ToString() == "1")
                        {
                            CashierName = txtLoginUsername.Text;
                            Cashier.CashierDashboard cash = new Cashier.CashierDashboard();
                            cash.Show();
                            this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong UserID or Password");
                        }
                        Con.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Select Correct Role");
                }
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
