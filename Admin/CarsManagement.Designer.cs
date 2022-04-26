namespace CarRentalSystem.Admin
{
    partial class Cars_Management
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
            this.comboavailable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblrs = new System.Windows.Forms.Label();
            this.txtcarid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtcolour = new System.Windows.Forms.TextBox();
            this.lblcolour = new System.Windows.Forms.Label();
            this.txtengcap = new System.Windows.Forms.TextBox();
            this.lblengcap = new System.Windows.Forms.Label();
            this.txtcarno = new System.Windows.Forms.TextBox();
            this.lblcarno = new System.Windows.Forms.Label();
            this.txtinsuranceno = new System.Windows.Forms.TextBox();
            this.lblinsuranceno = new System.Windows.Forms.Label();
            this.txtdaliyprice = new System.Windows.Forms.TextBox();
            this.lbldaliyprice = new System.Windows.Forms.Label();
            this.comboBoxcarcatgerory = new System.Windows.Forms.ComboBox();
            this.btncarmanDELETE = new System.Windows.Forms.Button();
            this.btncarmanUPDATE = new System.Windows.Forms.Button();
            this.btncarmanCLEAR = new System.Windows.Forms.Button();
            this.btncarmanADD = new System.Windows.Forms.Button();
            this.txtcarname = new System.Windows.Forms.TextBox();
            this.lblcarcatgerory = new System.Windows.Forms.Label();
            this.lblcarname = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.dgvcarmangement = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarmangement)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.comboavailable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblrs);
            this.panel1.Controls.Add(this.txtcarid);
            this.panel1.Controls.Add(this.lblid);
            this.panel1.Controls.Add(this.txtcolour);
            this.panel1.Controls.Add(this.lblcolour);
            this.panel1.Controls.Add(this.txtengcap);
            this.panel1.Controls.Add(this.lblengcap);
            this.panel1.Controls.Add(this.txtcarno);
            this.panel1.Controls.Add(this.lblcarno);
            this.panel1.Controls.Add(this.txtinsuranceno);
            this.panel1.Controls.Add(this.lblinsuranceno);
            this.panel1.Controls.Add(this.txtdaliyprice);
            this.panel1.Controls.Add(this.lbldaliyprice);
            this.panel1.Controls.Add(this.comboBoxcarcatgerory);
            this.panel1.Controls.Add(this.btncarmanDELETE);
            this.panel1.Controls.Add(this.btncarmanUPDATE);
            this.panel1.Controls.Add(this.btncarmanCLEAR);
            this.panel1.Controls.Add(this.btncarmanADD);
            this.panel1.Controls.Add(this.txtcarname);
            this.panel1.Controls.Add(this.lblcarcatgerory);
            this.panel1.Controls.Add(this.lblcarname);
            this.panel1.Controls.Add(this.lbl8);
            this.panel1.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 445);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboavailable
            // 
            this.comboavailable.FormattingEnabled = true;
            this.comboavailable.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.comboavailable.Location = new System.Drawing.Point(766, 29);
            this.comboavailable.Name = "comboavailable";
            this.comboavailable.Size = new System.Drawing.Size(126, 39);
            this.comboavailable.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(626, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Available";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblrs
            // 
            this.lblrs.AutoSize = true;
            this.lblrs.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrs.Location = new System.Drawing.Point(229, 228);
            this.lblrs.Name = "lblrs";
            this.lblrs.Size = new System.Drawing.Size(49, 36);
            this.lblrs.TabIndex = 21;
            this.lblrs.Text = "Rs .";
            // 
            // txtcarid
            // 
            this.txtcarid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcarid.Location = new System.Drawing.Point(235, 109);
            this.txtcarid.Multiline = true;
            this.txtcarid.Name = "txtcarid";
            this.txtcarid.Size = new System.Drawing.Size(277, 38);
            this.txtcarid.TabIndex = 20;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(22, 109);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(77, 36);
            this.lblid.TabIndex = 19;
            this.lblid.Text = "Car ID";
            // 
            // txtcolour
            // 
            this.txtcolour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcolour.Location = new System.Drawing.Point(782, 285);
            this.txtcolour.Multiline = true;
            this.txtcolour.Name = "txtcolour";
            this.txtcolour.Size = new System.Drawing.Size(277, 38);
            this.txtcolour.TabIndex = 18;
            // 
            // lblcolour
            // 
            this.lblcolour.AutoSize = true;
            this.lblcolour.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcolour.Location = new System.Drawing.Point(569, 285);
            this.lblcolour.Name = "lblcolour";
            this.lblcolour.Size = new System.Drawing.Size(83, 36);
            this.lblcolour.TabIndex = 17;
            this.lblcolour.Text = "Colour";
            // 
            // txtengcap
            // 
            this.txtengcap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtengcap.Location = new System.Drawing.Point(782, 228);
            this.txtengcap.Multiline = true;
            this.txtengcap.Name = "txtengcap";
            this.txtengcap.Size = new System.Drawing.Size(277, 38);
            this.txtengcap.TabIndex = 16;
            // 
            // lblengcap
            // 
            this.lblengcap.AutoSize = true;
            this.lblengcap.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblengcap.Location = new System.Drawing.Point(569, 228);
            this.lblengcap.Name = "lblengcap";
            this.lblengcap.Size = new System.Drawing.Size(184, 36);
            this.lblengcap.TabIndex = 15;
            this.lblengcap.Text = "Engine Capacity";
            // 
            // txtcarno
            // 
            this.txtcarno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcarno.Location = new System.Drawing.Point(782, 170);
            this.txtcarno.Multiline = true;
            this.txtcarno.Name = "txtcarno";
            this.txtcarno.Size = new System.Drawing.Size(277, 38);
            this.txtcarno.TabIndex = 14;
            // 
            // lblcarno
            // 
            this.lblcarno.AutoSize = true;
            this.lblcarno.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarno.Location = new System.Drawing.Point(569, 170);
            this.lblcarno.Name = "lblcarno";
            this.lblcarno.Size = new System.Drawing.Size(140, 36);
            this.lblcarno.TabIndex = 13;
            this.lblcarno.Text = "Car Number";
            // 
            // txtinsuranceno
            // 
            this.txtinsuranceno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtinsuranceno.Location = new System.Drawing.Point(235, 282);
            this.txtinsuranceno.Multiline = true;
            this.txtinsuranceno.Name = "txtinsuranceno";
            this.txtinsuranceno.Size = new System.Drawing.Size(277, 38);
            this.txtinsuranceno.TabIndex = 12;
            // 
            // lblinsuranceno
            // 
            this.lblinsuranceno.AutoSize = true;
            this.lblinsuranceno.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinsuranceno.Location = new System.Drawing.Point(22, 282);
            this.lblinsuranceno.Name = "lblinsuranceno";
            this.lblinsuranceno.Size = new System.Drawing.Size(158, 36);
            this.lblinsuranceno.TabIndex = 11;
            this.lblinsuranceno.Text = "Insurance  NO";
            // 
            // txtdaliyprice
            // 
            this.txtdaliyprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdaliyprice.Location = new System.Drawing.Point(284, 223);
            this.txtdaliyprice.Multiline = true;
            this.txtdaliyprice.Name = "txtdaliyprice";
            this.txtdaliyprice.Size = new System.Drawing.Size(228, 38);
            this.txtdaliyprice.TabIndex = 10;
            // 
            // lbldaliyprice
            // 
            this.lbldaliyprice.AutoSize = true;
            this.lbldaliyprice.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldaliyprice.Location = new System.Drawing.Point(22, 225);
            this.lbldaliyprice.Name = "lbldaliyprice";
            this.lbldaliyprice.Size = new System.Drawing.Size(122, 36);
            this.lbldaliyprice.TabIndex = 9;
            this.lbldaliyprice.Text = "Daliy Price";
            // 
            // comboBoxcarcatgerory
            // 
            this.comboBoxcarcatgerory.FormattingEnabled = true;
            this.comboBoxcarcatgerory.Location = new System.Drawing.Point(234, 168);
            this.comboBoxcarcatgerory.Name = "comboBoxcarcatgerory";
            this.comboBoxcarcatgerory.Size = new System.Drawing.Size(278, 39);
            this.comboBoxcarcatgerory.TabIndex = 8;
            this.comboBoxcarcatgerory.SelectedIndexChanged += new System.EventHandler(this.comboBoxcarcatgerory_SelectedIndexChanged);
            // 
            // btncarmanDELETE
            // 
            this.btncarmanDELETE.BackColor = System.Drawing.Color.Red;
            this.btncarmanDELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncarmanDELETE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncarmanDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncarmanDELETE.ForeColor = System.Drawing.Color.Black;
            this.btncarmanDELETE.Location = new System.Drawing.Point(654, 366);
            this.btncarmanDELETE.Name = "btncarmanDELETE";
            this.btncarmanDELETE.Size = new System.Drawing.Size(176, 46);
            this.btncarmanDELETE.TabIndex = 7;
            this.btncarmanDELETE.Text = "DELETE";
            this.btncarmanDELETE.UseVisualStyleBackColor = false;
            this.btncarmanDELETE.Click += new System.EventHandler(this.btncarmanDELETE_Click);
            // 
            // btncarmanUPDATE
            // 
            this.btncarmanUPDATE.BackColor = System.Drawing.Color.Lime;
            this.btncarmanUPDATE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncarmanUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncarmanUPDATE.ForeColor = System.Drawing.Color.Black;
            this.btncarmanUPDATE.Location = new System.Drawing.Point(444, 366);
            this.btncarmanUPDATE.Name = "btncarmanUPDATE";
            this.btncarmanUPDATE.Size = new System.Drawing.Size(176, 46);
            this.btncarmanUPDATE.TabIndex = 7;
            this.btncarmanUPDATE.Text = "UPDATE";
            this.btncarmanUPDATE.UseVisualStyleBackColor = false;
            this.btncarmanUPDATE.Click += new System.EventHandler(this.btncarmanUPDATE_Click);
            // 
            // btncarmanCLEAR
            // 
            this.btncarmanCLEAR.BackColor = System.Drawing.Color.Blue;
            this.btncarmanCLEAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncarmanCLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncarmanCLEAR.ForeColor = System.Drawing.Color.Black;
            this.btncarmanCLEAR.Location = new System.Drawing.Point(234, 366);
            this.btncarmanCLEAR.Name = "btncarmanCLEAR";
            this.btncarmanCLEAR.Size = new System.Drawing.Size(176, 46);
            this.btncarmanCLEAR.TabIndex = 7;
            this.btncarmanCLEAR.Text = "CLEAR";
            this.btncarmanCLEAR.UseVisualStyleBackColor = false;
            this.btncarmanCLEAR.Click += new System.EventHandler(this.btncarmanCLEAR_Click);
            // 
            // btncarmanADD
            // 
            this.btncarmanADD.BackColor = System.Drawing.Color.Cyan;
            this.btncarmanADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncarmanADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncarmanADD.ForeColor = System.Drawing.Color.Black;
            this.btncarmanADD.Location = new System.Drawing.Point(27, 366);
            this.btncarmanADD.Name = "btncarmanADD";
            this.btncarmanADD.Size = new System.Drawing.Size(176, 46);
            this.btncarmanADD.TabIndex = 7;
            this.btncarmanADD.Text = "ADD";
            this.btncarmanADD.UseVisualStyleBackColor = false;
            this.btncarmanADD.Click += new System.EventHandler(this.btncarmanADD_Click);
            // 
            // txtcarname
            // 
            this.txtcarname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcarname.Location = new System.Drawing.Point(782, 111);
            this.txtcarname.Multiline = true;
            this.txtcarname.Name = "txtcarname";
            this.txtcarname.Size = new System.Drawing.Size(277, 38);
            this.txtcarname.TabIndex = 6;
            // 
            // lblcarcatgerory
            // 
            this.lblcarcatgerory.AutoSize = true;
            this.lblcarcatgerory.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarcatgerory.Location = new System.Drawing.Point(21, 171);
            this.lblcarcatgerory.Name = "lblcarcatgerory";
            this.lblcarcatgerory.Size = new System.Drawing.Size(153, 36);
            this.lblcarcatgerory.TabIndex = 5;
            this.lblcarcatgerory.Text = "Car Category";
            this.lblcarcatgerory.Click += new System.EventHandler(this.lbl7_Click);
            // 
            // lblcarname
            // 
            this.lblcarname.AutoSize = true;
            this.lblcarname.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarname.Location = new System.Drawing.Point(569, 111);
            this.lblcarname.Name = "lblcarname";
            this.lblcarname.Size = new System.Drawing.Size(119, 36);
            this.lblcarname.TabIndex = 5;
            this.lblcarname.Text = "Car Name";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.Black;
            this.lbl8.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.ForeColor = System.Drawing.Color.White;
            this.lbl8.Location = new System.Drawing.Point(18, 18);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(290, 50);
            this.lbl8.TabIndex = 4;
            this.lbl8.Text = "Cars Management";
            // 
            // dgvcarmangement
            // 
            this.dgvcarmangement.BackgroundColor = System.Drawing.Color.Black;
            this.dgvcarmangement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvcarmangement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvcarmangement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcarmangement.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcarmangement.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcarmangement.GridColor = System.Drawing.Color.Black;
            this.dgvcarmangement.Location = new System.Drawing.Point(61, 465);
            this.dgvcarmangement.Name = "dgvcarmangement";
            this.dgvcarmangement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcarmangement.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcarmangement.RowHeadersWidth = 51;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcarmangement.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcarmangement.RowTemplate.Height = 24;
            this.dgvcarmangement.Size = new System.Drawing.Size(1130, 408);
            this.dgvcarmangement.TabIndex = 7;
            // 
            // Cars_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvcarmangement);
            this.Controls.Add(this.panel1);
            this.Name = "Cars_Management";
            this.Size = new System.Drawing.Size(1256, 886);
            this.Load += new System.EventHandler(this.Cars_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarmangement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncarmanDELETE;
        private System.Windows.Forms.Button btncarmanUPDATE;
        private System.Windows.Forms.Button btncarmanCLEAR;
        private System.Windows.Forms.Button btncarmanADD;
        private System.Windows.Forms.TextBox txtcarname;
        private System.Windows.Forms.Label lblcarcatgerory;
        private System.Windows.Forms.Label lblcarname;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.ComboBox comboBoxcarcatgerory;
        private System.Windows.Forms.TextBox txtcolour;
        private System.Windows.Forms.Label lblcolour;
        private System.Windows.Forms.TextBox txtengcap;
        private System.Windows.Forms.Label lblengcap;
        private System.Windows.Forms.TextBox txtcarno;
        private System.Windows.Forms.Label lblcarno;
        private System.Windows.Forms.TextBox txtinsuranceno;
        private System.Windows.Forms.Label lblinsuranceno;
        private System.Windows.Forms.TextBox txtdaliyprice;
        private System.Windows.Forms.Label lbldaliyprice;
        private System.Windows.Forms.TextBox txtcarid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DataGridView dgvcarmangement;
        private System.Windows.Forms.Label lblrs;
        private System.Windows.Forms.ComboBox comboavailable;
        private System.Windows.Forms.Label label1;
    }
}
