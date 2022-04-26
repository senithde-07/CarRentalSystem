using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.Cashier
{
    public partial class CashierDashboard : Form
    {
        public CashierDashboard()
        {
            InitializeComponent();
        }

        private void btncashier1_Click(object sender, EventArgs e)
        {
            Cashier.Cars_Report UC_CarsReport = new Cashier.Cars_Report();
            UC_Main_Conrol.showControl(UC_CarsReport, pnl_Cashierdashboard_uc);
        }

        private void btncashier2_Click(object sender, EventArgs e)
        {
            Cashier.BookingManagement UC_BookingManagement = new Cashier.BookingManagement();
            UC_Main_Conrol.showControl(UC_BookingManagement, pnl_Cashierdashboard_uc);
        }

        private void btnadminlogout_Click(object sender, EventArgs e)
        {
            CommonUI.LogOutWarningMsg objlogout = new CommonUI.LogOutWarningMsg();
            objlogout.Show();
        }

        private void btncashier3_Click(object sender, EventArgs e)
        {
            Cashier.PaymentManagement UC_PaymentManagement = new Cashier.PaymentManagement();
            UC_Main_Conrol.showControl(UC_PaymentManagement, pnl_Cashierdashboard_uc);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            lblCashiername.Text = CommonUI.Login.CashierName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cashier.returncar UC_returncar = new Cashier.returncar();
            UC_Main_Conrol.showControl(UC_returncar, pnl_Cashierdashboard_uc);
        }
    }
}
