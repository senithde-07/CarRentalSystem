using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.Admin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnadmin2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnadmin1_Click(object sender, EventArgs e)
        {
            Admin.Cars_Category_Management UC_CarsCategoryManagement = new Admin.Cars_Category_Management();
            UC_Main_Conrol.showControl(UC_CarsCategoryManagement, pnl_admindashboard_uc);
        }

        private void btnadmin2_Click_1(object sender, EventArgs e)
        {
            Admin.Cars_Management UC_CarsManagement = new Admin.Cars_Management();
            UC_Main_Conrol.showControl(UC_CarsManagement, pnl_admindashboard_uc);
        }

        private void btnadmin3_Click(object sender, EventArgs e)
        {
            Admin.Cusomers_Management UC_CusomersManagement = new Admin.Cusomers_Management();
            UC_Main_Conrol.showControl(UC_CusomersManagement, pnl_admindashboard_uc);
        }

        private void btnadmin4_Click(object sender, EventArgs e)
        {
            Admin.AddCashier UC_AddCashier = new Admin.AddCashier();
            UC_Main_Conrol.showControl(UC_AddCashier, pnl_admindashboard_uc);
        }

        private void btnadminlogout_Click(object sender, EventArgs e)
        {
            CommonUI.LogOutWarningMsg objlogout = new CommonUI.LogOutWarningMsg();
            objlogout.Show();
        }

        private void pnl_admindashboard_uc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
