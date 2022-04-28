using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace CarRentalSystem.Cashier
{
    public partial class returninvoice : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
             int nLeftRect,     // x-coordinate of upper-left corner
             int nTopRect,      // y-coordinate of upper-left corner
             int nRightRect,    // x-coordinate of lower-right corner
             int nBottomRect,   // y-coordinate of lower-right corner
             int nWidthEllipse, // width of ellipse
             int nHeightEllipse // height of ellipse
         );

        public returninvoice()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Date = DateTime.Now.ToString("M/d/yyyy");
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\Desktop\CarRentalSystem\CarRentalSystemDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();


        }

        
        private Bitmap memoryimg;

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }


        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Print");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        public string Date, returnid, carmodel, CusName, delaydates, delayfee, total, cash, balance;

        private void returninvoice_Load(object sender, EventArgs e)
        {
            textBox2.Text = Date;
            textBox1.Text = returnid;
            txtreturncarname.Text = carmodel;
            txtreturncusname.Text = CusName;
            txtdelaydates.Text = delaydates;
            txtdelayfee.Text = delayfee;
            txtreturntotal.Text = total;
            txtreturn1total.Text = total;
            txtreturncash.Text = cash;
            txtreturnbalancce.Text = balance;



        }

        private void panelPrint_Paint(object sender, PaintEventArgs e)
        {
            txtinvoicecashiername.Text = CommonUI.Login.CashierName;
        }

        private void txtinvoicecarctg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
