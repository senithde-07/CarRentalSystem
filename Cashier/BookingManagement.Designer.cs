namespace CarRentalSystem.Cashier
{
    partial class BookingManagement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtrentcarname = new System.Windows.Forms.TextBox();
            this.btncashierDELETE = new System.Windows.Forms.Button();
            this.btncashierUPDATE = new System.Windows.Forms.Button();
            this.btncashierCLEAR = new System.Windows.Forms.Button();
            this.btncashierADD = new System.Windows.Forms.Button();
            this.returndate = new System.Windows.Forms.DateTimePicker();
            this.rentdate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxselcustomer = new System.Windows.Forms.ComboBox();
            this.comboBoxselcar = new System.Windows.Forms.ComboBox();
            this.lblreturndate = new System.Windows.Forms.Label();
            this.txtrentalnoofday = new System.Windows.Forms.TextBox();
            this.lblnoofday = new System.Windows.Forms.Label();
            this.lblselcustomer = new System.Windows.Forms.Label();
            this.txtrentalid = new System.Windows.Forms.TextBox();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.lblrentdate = new System.Windows.Forms.Label();
            this.lblcarcat = new System.Windows.Forms.Label();
            this.lblselcar = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.dgvrental = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrental)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtrentcarname);
            this.panel1.Controls.Add(this.btncashierDELETE);
            this.panel1.Controls.Add(this.btncashierUPDATE);
            this.panel1.Controls.Add(this.btncashierCLEAR);
            this.panel1.Controls.Add(this.btncashierADD);
            this.panel1.Controls.Add(this.returndate);
            this.panel1.Controls.Add(this.rentdate);
            this.panel1.Controls.Add(this.comboBoxselcustomer);
            this.panel1.Controls.Add(this.comboBoxselcar);
            this.panel1.Controls.Add(this.lblreturndate);
            this.panel1.Controls.Add(this.txtrentalnoofday);
            this.panel1.Controls.Add(this.lblnoofday);
            this.panel1.Controls.Add(this.lblselcustomer);
            this.panel1.Controls.Add(this.txtrentalid);
            this.panel1.Controls.Add(this.lbltotalamount);
            this.panel1.Controls.Add(this.lblrentdate);
            this.panel1.Controls.Add(this.lblcarcat);
            this.panel1.Controls.Add(this.lblselcar);
            this.panel1.Controls.Add(this.lbl11);
            this.panel1.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 445);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtrentcarname
            // 
            this.txtrentcarname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrentcarname.Location = new System.Drawing.Point(236, 280);
            this.txtrentcarname.Multiline = true;
            this.txtrentcarname.Name = "txtrentcarname";
            this.txtrentcarname.Size = new System.Drawing.Size(277, 38);
            this.txtrentcarname.TabIndex = 28;
            // 
            // btncashierDELETE
            // 
            this.btncashierDELETE.BackColor = System.Drawing.Color.Red;
            this.btncashierDELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncashierDELETE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncashierDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncashierDELETE.ForeColor = System.Drawing.Color.Black;
            this.btncashierDELETE.Location = new System.Drawing.Point(657, 366);
            this.btncashierDELETE.Name = "btncashierDELETE";
            this.btncashierDELETE.Size = new System.Drawing.Size(176, 46);
            this.btncashierDELETE.TabIndex = 24;
            this.btncashierDELETE.Text = "DELETE";
            this.btncashierDELETE.UseVisualStyleBackColor = false;
            this.btncashierDELETE.Click += new System.EventHandler(this.btncashierDELETE_Click);
            // 
            // btncashierUPDATE
            // 
            this.btncashierUPDATE.BackColor = System.Drawing.Color.Lime;
            this.btncashierUPDATE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncashierUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncashierUPDATE.ForeColor = System.Drawing.Color.Black;
            this.btncashierUPDATE.Location = new System.Drawing.Point(444, 366);
            this.btncashierUPDATE.Name = "btncashierUPDATE";
            this.btncashierUPDATE.Size = new System.Drawing.Size(176, 46);
            this.btncashierUPDATE.TabIndex = 25;
            this.btncashierUPDATE.Text = "UPDATE";
            this.btncashierUPDATE.UseVisualStyleBackColor = false;
            this.btncashierUPDATE.Click += new System.EventHandler(this.btncashierUPDATE_Click);
            // 
            // btncashierCLEAR
            // 
            this.btncashierCLEAR.BackColor = System.Drawing.Color.Blue;
            this.btncashierCLEAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncashierCLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncashierCLEAR.ForeColor = System.Drawing.Color.Black;
            this.btncashierCLEAR.Location = new System.Drawing.Point(234, 366);
            this.btncashierCLEAR.Name = "btncashierCLEAR";
            this.btncashierCLEAR.Size = new System.Drawing.Size(176, 46);
            this.btncashierCLEAR.TabIndex = 26;
            this.btncashierCLEAR.Text = "CLEAR";
            this.btncashierCLEAR.UseVisualStyleBackColor = false;
            this.btncashierCLEAR.Click += new System.EventHandler(this.btncashierCLEAR_Click);
            // 
            // btncashierADD
            // 
            this.btncashierADD.BackColor = System.Drawing.Color.Cyan;
            this.btncashierADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncashierADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncashierADD.ForeColor = System.Drawing.Color.Black;
            this.btncashierADD.Location = new System.Drawing.Point(27, 366);
            this.btncashierADD.Name = "btncashierADD";
            this.btncashierADD.Size = new System.Drawing.Size(176, 46);
            this.btncashierADD.TabIndex = 27;
            this.btncashierADD.Text = "ADD";
            this.btncashierADD.UseVisualStyleBackColor = false;
            this.btncashierADD.Click += new System.EventHandler(this.btncashierADD_Click);
            // 
            // returndate
            // 
            this.returndate.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returndate.Location = new System.Drawing.Point(781, 223);
            this.returndate.Name = "returndate";
            this.returndate.Size = new System.Drawing.Size(299, 30);
            this.returndate.TabIndex = 23;
            this.returndate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // rentdate
            // 
            this.rentdate.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentdate.Location = new System.Drawing.Point(781, 170);
            this.rentdate.Name = "rentdate";
            this.rentdate.Size = new System.Drawing.Size(299, 30);
            this.rentdate.TabIndex = 23;
            // 
            // comboBoxselcustomer
            // 
            this.comboBoxselcustomer.FormattingEnabled = true;
            this.comboBoxselcustomer.Location = new System.Drawing.Point(234, 162);
            this.comboBoxselcustomer.Name = "comboBoxselcustomer";
            this.comboBoxselcustomer.Size = new System.Drawing.Size(278, 39);
            this.comboBoxselcustomer.TabIndex = 20;
            this.comboBoxselcustomer.Text = "Select Customer";
            // 
            // comboBoxselcar
            // 
            this.comboBoxselcar.FormattingEnabled = true;
            this.comboBoxselcar.Location = new System.Drawing.Point(235, 221);
            this.comboBoxselcar.Name = "comboBoxselcar";
            this.comboBoxselcar.Size = new System.Drawing.Size(278, 39);
            this.comboBoxselcar.TabIndex = 19;
            this.comboBoxselcar.Text = "Select Car ID";
            // 
            // lblreturndate
            // 
            this.lblreturndate.AutoSize = true;
            this.lblreturndate.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreturndate.Location = new System.Drawing.Point(569, 224);
            this.lblreturndate.Name = "lblreturndate";
            this.lblreturndate.Size = new System.Drawing.Size(135, 36);
            this.lblreturndate.TabIndex = 17;
            this.lblreturndate.Text = "Return Date";
            this.lblreturndate.Click += new System.EventHandler(this.lblcolour_Click);
            // 
            // txtrentalnoofday
            // 
            this.txtrentalnoofday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrentalnoofday.Location = new System.Drawing.Point(781, 105);
            this.txtrentalnoofday.Multiline = true;
            this.txtrentalnoofday.Name = "txtrentalnoofday";
            this.txtrentalnoofday.Size = new System.Drawing.Size(299, 38);
            this.txtrentalnoofday.TabIndex = 16;
            // 
            // lblnoofday
            // 
            this.lblnoofday.AutoSize = true;
            this.lblnoofday.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoofday.Location = new System.Drawing.Point(568, 105);
            this.lblnoofday.Name = "lblnoofday";
            this.lblnoofday.Size = new System.Drawing.Size(132, 36);
            this.lblnoofday.TabIndex = 15;
            this.lblnoofday.Text = "NO. of Days";
            // 
            // lblselcustomer
            // 
            this.lblselcustomer.AutoSize = true;
            this.lblselcustomer.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselcustomer.Location = new System.Drawing.Point(21, 166);
            this.lblselcustomer.Name = "lblselcustomer";
            this.lblselcustomer.Size = new System.Drawing.Size(183, 36);
            this.lblselcustomer.TabIndex = 13;
            this.lblselcustomer.Text = "Select Customer";
            // 
            // txtrentalid
            // 
            this.txtrentalid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrentalid.Location = new System.Drawing.Point(235, 105);
            this.txtrentalid.Multiline = true;
            this.txtrentalid.Name = "txtrentalid";
            this.txtrentalid.Size = new System.Drawing.Size(277, 38);
            this.txtrentalid.TabIndex = 12;
            this.txtrentalid.TextChanged += new System.EventHandler(this.txtTotalamount_TextChanged);
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.Location = new System.Drawing.Point(22, 107);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(106, 36);
            this.lbltotalamount.TabIndex = 11;
            this.lbltotalamount.Text = "Rental ID";
            this.lbltotalamount.Click += new System.EventHandler(this.lbltotalamount_Click);
            // 
            // lblrentdate
            // 
            this.lblrentdate.AutoSize = true;
            this.lblrentdate.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrentdate.Location = new System.Drawing.Point(569, 168);
            this.lblrentdate.Name = "lblrentdate";
            this.lblrentdate.Size = new System.Drawing.Size(134, 36);
            this.lblrentdate.TabIndex = 9;
            this.lblrentdate.Text = "Rental Date";
            // 
            // lblcarcat
            // 
            this.lblcarcat.AutoSize = true;
            this.lblcarcat.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarcat.Location = new System.Drawing.Point(22, 282);
            this.lblcarcat.Name = "lblcarcat";
            this.lblcarcat.Size = new System.Drawing.Size(119, 36);
            this.lblcarcat.TabIndex = 5;
            this.lblcarcat.Text = "Car Name";
            // 
            // lblselcar
            // 
            this.lblselcar.AutoSize = true;
            this.lblselcar.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselcar.Location = new System.Drawing.Point(22, 225);
            this.lblselcar.Name = "lblselcar";
            this.lblselcar.Size = new System.Drawing.Size(77, 36);
            this.lblselcar.TabIndex = 5;
            this.lblselcar.Text = "Car ID";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.BackColor = System.Drawing.Color.Black;
            this.lbl11.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.ForeColor = System.Drawing.Color.White;
            this.lbl11.Location = new System.Drawing.Point(18, 18);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(315, 50);
            this.lbl11.TabIndex = 4;
            this.lbl11.Text = "Rental Management";
            // 
            // dgvrental
            // 
            this.dgvrental.BackgroundColor = System.Drawing.Color.Black;
            this.dgvrental.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvrental.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvrental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrental.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrental.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvrental.GridColor = System.Drawing.Color.Black;
            this.dgvrental.Location = new System.Drawing.Point(130, 462);
            this.dgvrental.Name = "dgvrental";
            this.dgvrental.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrental.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvrental.RowHeadersWidth = 51;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrental.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvrental.RowTemplate.Height = 24;
            this.dgvrental.Size = new System.Drawing.Size(1002, 408);
            this.dgvrental.TabIndex = 8;
            this.dgvrental.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrental_CellContentClick);
            // 
            // BookingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvrental);
            this.Controls.Add(this.panel1);
            this.Name = "BookingManagement";
            this.Size = new System.Drawing.Size(1256, 886);
            this.Load += new System.EventHandler(this.BookingManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrental)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker rentdate;
        private System.Windows.Forms.ComboBox comboBoxselcustomer;
        private System.Windows.Forms.ComboBox comboBoxselcar;
        private System.Windows.Forms.Label lblreturndate;
        private System.Windows.Forms.TextBox txtrentalnoofday;
        private System.Windows.Forms.Label lblnoofday;
        private System.Windows.Forms.Label lblselcustomer;
        private System.Windows.Forms.TextBox txtrentalid;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label lblrentdate;
        private System.Windows.Forms.Label lblcarcat;
        private System.Windows.Forms.Label lblselcar;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.DateTimePicker returndate;
        private System.Windows.Forms.Button btncashierDELETE;
        private System.Windows.Forms.Button btncashierUPDATE;
        private System.Windows.Forms.Button btncashierCLEAR;
        private System.Windows.Forms.Button btncashierADD;
        private System.Windows.Forms.DataGridView dgvrental;
        private System.Windows.Forms.TextBox txtrentcarname;
    }
}
