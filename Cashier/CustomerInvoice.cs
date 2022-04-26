using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace CarRentalSystem.Cashier
{
    public partial class CustomerInvoice : Form
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
        public CustomerInvoice()
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
            memoryimg = new Bitmap (pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg,new Rectangle(0,0,pnl.Width,pnl.Height));
        }

        


        public string  Date,CusName ,rentid,carid,carmodel,days,dailyprice,total,cash,balance,cusphone,cashiername;
        

        private void CustomerInvoice_Load(object sender, EventArgs e)
        {
            textBox2.Text = Date;
            txtinvoicecusname.Text = CusName;
            txtinvoicerentid.Text = rentid;
            txtinvoicecarid.Text = carid;
            txtinvoicecarname.Text = carmodel;
            txtinvoicedays.Text = days;
            txtinvoicedailyprice.Text = dailyprice;
            txtinvoiceamount.Text = total;
            txtinvoicetotal.Text = total;
            txtinvoicecash.Text = cash;
            txtinvoicebalancce.Text = balance;
            //txtinvoicecusphone.Text = cusphone;
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void printPreviewDialog1_Load_1(object sender, EventArgs e)
        {

        }

        private void panelPrint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Print");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Print(this.panelPrint);
        }

        private void printinvoice(Panel pnl)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtinvoicecusphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtinvoicecusname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
