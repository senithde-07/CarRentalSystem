namespace CarRentalSystem.Cashier
{
    partial class returncar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtinsuranceno = new System.Windows.Forms.TextBox();
            this.lblinsuranceno = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.txtreturncarid = new System.Windows.Forms.TextBox();
            this.lblselcustomer = new System.Windows.Forms.Label();
            this.txtreturncus = new System.Windows.Forms.TextBox();
            this.txtreturncarname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.returndate1 = new System.Windows.Forms.DateTimePicker();
            this.lblreturndate = new System.Windows.Forms.Label();
            this.dgvreturncar = new System.Windows.Forms.DataGridView();
            this.txtreturnnid = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreturncar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.dgvreturncar);
            this.panel2.Controls.Add(this.returndate1);
            this.panel2.Controls.Add(this.lblreturndate);
            this.panel2.Controls.Add(this.txtreturnnid);
            this.panel2.Controls.Add(this.txtreturncarid);
            this.panel2.Controls.Add(this.lblselcustomer);
            this.panel2.Controls.Add(this.txtreturncus);
            this.panel2.Controls.Add(this.txtreturncarname);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbltotalamount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtinsuranceno);
            this.panel2.Controls.Add(this.lblinsuranceno);
            this.panel2.Controls.Add(this.lbl8);
            this.panel2.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1256, 445);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Rs .";
            // 
            // txtinsuranceno
            // 
            this.txtinsuranceno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtinsuranceno.Location = new System.Drawing.Point(284, 366);
            this.txtinsuranceno.Multiline = true;
            this.txtinsuranceno.Name = "txtinsuranceno";
            this.txtinsuranceno.Size = new System.Drawing.Size(228, 38);
            this.txtinsuranceno.TabIndex = 12;
            // 
            // lblinsuranceno
            // 
            this.lblinsuranceno.AutoSize = true;
            this.lblinsuranceno.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinsuranceno.Location = new System.Drawing.Point(22, 366);
            this.lblinsuranceno.Name = "lblinsuranceno";
            this.lblinsuranceno.Size = new System.Drawing.Size(113, 36);
            this.lblinsuranceno.TabIndex = 11;
            this.lblinsuranceno.Text = "Delay Fee";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.Black;
            this.lbl8.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.ForeColor = System.Drawing.Color.White;
            this.lbl8.Location = new System.Drawing.Point(18, 18);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(176, 50);
            this.lbl8.TabIndex = 4;
            this.lbl8.Text = "Return Car";
            // 
            // txtreturncarid
            // 
            this.txtreturncarid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtreturncarid.Location = new System.Drawing.Point(235, 148);
            this.txtreturncarid.Multiline = true;
            this.txtreturncarid.Name = "txtreturncarid";
            this.txtreturncarid.Size = new System.Drawing.Size(277, 38);
            this.txtreturncarid.TabIndex = 45;
            // 
            // lblselcustomer
            // 
            this.lblselcustomer.AutoSize = true;
            this.lblselcustomer.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselcustomer.Location = new System.Drawing.Point(21, 263);
            this.lblselcustomer.Name = "lblselcustomer";
            this.lblselcustomer.Size = new System.Drawing.Size(116, 36);
            this.lblselcustomer.TabIndex = 43;
            this.lblselcustomer.Text = "Customer";
            // 
            // txtreturncus
            // 
            this.txtreturncus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtreturncus.Location = new System.Drawing.Point(234, 261);
            this.txtreturncus.Multiline = true;
            this.txtreturncus.Name = "txtreturncus";
            this.txtreturncus.Size = new System.Drawing.Size(277, 38);
            this.txtreturncus.TabIndex = 42;
            // 
            // txtreturncarname
            // 
            this.txtreturncarname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtreturncarname.Location = new System.Drawing.Point(234, 205);
            this.txtreturncarname.Multiline = true;
            this.txtreturncarname.Name = "txtreturncarname";
            this.txtreturncarname.Size = new System.Drawing.Size(277, 38);
            this.txtreturncarname.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 36);
            this.label9.TabIndex = 38;
            this.label9.Text = "Car ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 36);
            this.label1.TabIndex = 39;
            this.label1.Text = "Car Model";
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.Location = new System.Drawing.Point(22, 98);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(106, 36);
            this.lbltotalamount.TabIndex = 40;
            this.lbltotalamount.Text = "Retern ID";
            // 
            // returndate1
            // 
            this.returndate1.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returndate1.Location = new System.Drawing.Point(235, 318);
            this.returndate1.Name = "returndate1";
            this.returndate1.Size = new System.Drawing.Size(299, 30);
            this.returndate1.TabIndex = 47;
            // 
            // lblreturndate
            // 
            this.lblreturndate.AutoSize = true;
            this.lblreturndate.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreturndate.Location = new System.Drawing.Point(23, 319);
            this.lblreturndate.Name = "lblreturndate";
            this.lblreturndate.Size = new System.Drawing.Size(135, 36);
            this.lblreturndate.TabIndex = 46;
            this.lblreturndate.Text = "Return Date";
            // 
            // dgvreturncar
            // 
            this.dgvreturncar.BackgroundColor = System.Drawing.Color.Black;
            this.dgvreturncar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvreturncar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvreturncar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreturncar.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvreturncar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvreturncar.GridColor = System.Drawing.Color.Black;
            this.dgvreturncar.Location = new System.Drawing.Point(598, 94);
            this.dgvreturncar.Name = "dgvreturncar";
            this.dgvreturncar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvreturncar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvreturncar.RowHeadersWidth = 51;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvreturncar.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvreturncar.RowTemplate.Height = 24;
            this.dgvreturncar.Size = new System.Drawing.Size(605, 310);
            this.dgvreturncar.TabIndex = 48;
            this.dgvreturncar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvreturncar_CellContentClick);
            // 
            // txtreturnnid
            // 
            this.txtreturnnid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtreturnnid.Location = new System.Drawing.Point(234, 96);
            this.txtreturnnid.Multiline = true;
            this.txtreturnnid.Name = "txtreturnnid";
            this.txtreturnnid.Size = new System.Drawing.Size(277, 38);
            this.txtreturnnid.TabIndex = 45;
            // 
            // returncar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Name = "returncar";
            this.Size = new System.Drawing.Size(1256, 886);
            this.Load += new System.EventHandler(this.returncar_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreturncar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtinsuranceno;
        private System.Windows.Forms.Label lblinsuranceno;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.TextBox txtreturncarid;
        private System.Windows.Forms.Label lblselcustomer;
        private System.Windows.Forms.TextBox txtreturncus;
        private System.Windows.Forms.TextBox txtreturncarname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.DateTimePicker returndate1;
        private System.Windows.Forms.Label lblreturndate;
        private System.Windows.Forms.DataGridView dgvreturncar;
        private System.Windows.Forms.TextBox txtreturnnid;
    }
}
