namespace CarRentalSystem.Admin
{
    partial class Cars_Category_Management
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblcashID = new System.Windows.Forms.Label();
            this.btncarctgDELETE = new System.Windows.Forms.Button();
            this.btncarctgUPDATE = new System.Windows.Forms.Button();
            this.btncarctgCLEAR = new System.Windows.Forms.Button();
            this.btncarctgADD = new System.Windows.Forms.Button();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtctg = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.dgvcarctg = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarctg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblcashID);
            this.panel1.Controls.Add(this.btncarctgDELETE);
            this.panel1.Controls.Add(this.btncarctgUPDATE);
            this.panel1.Controls.Add(this.btncarctgCLEAR);
            this.panel1.Controls.Add(this.btncarctgADD);
            this.panel1.Controls.Add(this.txtdesc);
            this.panel1.Controls.Add(this.txtctg);
            this.panel1.Controls.Add(this.lbl7);
            this.panel1.Controls.Add(this.lbl6);
            this.panel1.Controls.Add(this.lbl5);
            this.panel1.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 362);
            this.panel1.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Location = new System.Drawing.Point(200, 76);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(294, 31);
            this.txtID.TabIndex = 9;
            // 
            // lblcashID
            // 
            this.lblcashID.AutoSize = true;
            this.lblcashID.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcashID.Location = new System.Drawing.Point(16, 78);
            this.lblcashID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcashID.Name = "lblcashID";
            this.lblcashID.Size = new System.Drawing.Size(107, 28);
            this.lblcashID.TabIndex = 8;
            this.lblcashID.Text = "Category ID";
            // 
            // btncarctgDELETE
            // 
            this.btncarctgDELETE.BackColor = System.Drawing.Color.Red;
            this.btncarctgDELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncarctgDELETE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncarctgDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncarctgDELETE.ForeColor = System.Drawing.Color.Black;
            this.btncarctgDELETE.Location = new System.Drawing.Point(490, 297);
            this.btncarctgDELETE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncarctgDELETE.Name = "btncarctgDELETE";
            this.btncarctgDELETE.Size = new System.Drawing.Size(132, 37);
            this.btncarctgDELETE.TabIndex = 7;
            this.btncarctgDELETE.Text = "DELETE";
            this.btncarctgDELETE.UseVisualStyleBackColor = false;
            this.btncarctgDELETE.Click += new System.EventHandler(this.btncarctgDELETE_Click);
            // 
            // btncarctgUPDATE
            // 
            this.btncarctgUPDATE.BackColor = System.Drawing.Color.Lime;
            this.btncarctgUPDATE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncarctgUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncarctgUPDATE.ForeColor = System.Drawing.Color.Black;
            this.btncarctgUPDATE.Location = new System.Drawing.Point(333, 297);
            this.btncarctgUPDATE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncarctgUPDATE.Name = "btncarctgUPDATE";
            this.btncarctgUPDATE.Size = new System.Drawing.Size(132, 37);
            this.btncarctgUPDATE.TabIndex = 7;
            this.btncarctgUPDATE.Text = "UPDATE";
            this.btncarctgUPDATE.UseVisualStyleBackColor = false;
            this.btncarctgUPDATE.Click += new System.EventHandler(this.btncarctgUPDATE_Click);
            // 
            // btncarctgCLEAR
            // 
            this.btncarctgCLEAR.BackColor = System.Drawing.Color.Blue;
            this.btncarctgCLEAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncarctgCLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncarctgCLEAR.ForeColor = System.Drawing.Color.Black;
            this.btncarctgCLEAR.Location = new System.Drawing.Point(176, 297);
            this.btncarctgCLEAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncarctgCLEAR.Name = "btncarctgCLEAR";
            this.btncarctgCLEAR.Size = new System.Drawing.Size(132, 37);
            this.btncarctgCLEAR.TabIndex = 7;
            this.btncarctgCLEAR.Text = "CLEAR";
            this.btncarctgCLEAR.UseVisualStyleBackColor = false;
            this.btncarctgCLEAR.Click += new System.EventHandler(this.btncarctgCLEAR_Click);
            // 
            // btncarctgADD
            // 
            this.btncarctgADD.BackColor = System.Drawing.Color.Cyan;
            this.btncarctgADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncarctgADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncarctgADD.ForeColor = System.Drawing.Color.Black;
            this.btncarctgADD.Location = new System.Drawing.Point(20, 297);
            this.btncarctgADD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncarctgADD.Name = "btncarctgADD";
            this.btncarctgADD.Size = new System.Drawing.Size(132, 37);
            this.btncarctgADD.TabIndex = 7;
            this.btncarctgADD.Text = "ADD";
            this.btncarctgADD.UseVisualStyleBackColor = false;
            this.btncarctgADD.Click += new System.EventHandler(this.btncarctgADD_Click);
            // 
            // txtdesc
            // 
            this.txtdesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdesc.Location = new System.Drawing.Point(200, 190);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(294, 54);
            this.txtdesc.TabIndex = 6;
            // 
            // txtctg
            // 
            this.txtctg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtctg.Location = new System.Drawing.Point(200, 131);
            this.txtctg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtctg.Multiline = true;
            this.txtctg.Name = "txtctg";
            this.txtctg.Size = new System.Drawing.Size(294, 33);
            this.txtctg.TabIndex = 6;
            this.txtctg.TextChanged += new System.EventHandler(this.txtctg_TextChanged);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(16, 190);
            this.lbl7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(104, 28);
            this.lbl7.TabIndex = 5;
            this.lbl7.Text = "Description";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(16, 131);
            this.lbl6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(164, 28);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "Name (Catergory)";
            this.lbl6.Click += new System.EventHandler(this.lbl6_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.Black;
            this.lbl5.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(14, 15);
            this.lbl5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(341, 39);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Cars Category Management";
            // 
            // dgvcarctg
            // 
            this.dgvcarctg.BackgroundColor = System.Drawing.Color.Black;
            this.dgvcarctg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvcarctg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvcarctg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcarctg.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcarctg.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcarctg.GridColor = System.Drawing.Color.Black;
            this.dgvcarctg.Location = new System.Drawing.Point(92, 377);
            this.dgvcarctg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvcarctg.Name = "dgvcarctg";
            this.dgvcarctg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcarctg.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcarctg.RowHeadersWidth = 51;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcarctg.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcarctg.RowTemplate.Height = 24;
            this.dgvcarctg.Size = new System.Drawing.Size(752, 332);
            this.dgvcarctg.TabIndex = 7;
            this.dgvcarctg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcarctg_CellContentClick);
            // 
            // Cars_Category_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvcarctg);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cars_Category_Management";
            this.Size = new System.Drawing.Size(942, 720);
            this.Load += new System.EventHandler(this.Cars_Category_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarctg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncarctgDELETE;
        private System.Windows.Forms.Button btncarctgUPDATE;
        private System.Windows.Forms.Button btncarctgCLEAR;
        private System.Windows.Forms.Button btncarctgADD;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtctg;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblcashID;
        private System.Windows.Forms.DataGridView dgvcarctg;
    }
}
