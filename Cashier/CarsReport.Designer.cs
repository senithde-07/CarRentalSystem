namespace CarRentalSystem.Cashier
{
    partial class Cars_Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvcarmangement = new System.Windows.Forms.DataGridView();
            this.lbl11 = new System.Windows.Forms.Label();
            this.txtseach = new System.Windows.Forms.TextBox();
            this.txtseachcarname = new System.Windows.Forms.TextBox();
            this.lblcarcatgerory = new System.Windows.Forms.Label();
            this.lblcarname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarmangement)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblcarname);
            this.panel1.Controls.Add(this.lblcarcatgerory);
            this.panel1.Controls.Add(this.txtseachcarname);
            this.panel1.Controls.Add(this.txtseach);
            this.panel1.Controls.Add(this.dgvcarmangement);
            this.panel1.Controls.Add(this.lbl11);
            this.panel1.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 886);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvcarmangement
            // 
            this.dgvcarmangement.BackgroundColor = System.Drawing.Color.Black;
            this.dgvcarmangement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvcarmangement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvcarmangement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcarmangement.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcarmangement.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvcarmangement.GridColor = System.Drawing.Color.Black;
            this.dgvcarmangement.Location = new System.Drawing.Point(27, 176);
            this.dgvcarmangement.Name = "dgvcarmangement";
            this.dgvcarmangement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcarmangement.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvcarmangement.RowHeadersWidth = 51;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcarmangement.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvcarmangement.RowTemplate.Height = 24;
            this.dgvcarmangement.Size = new System.Drawing.Size(1205, 682);
            this.dgvcarmangement.TabIndex = 41;
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.BackColor = System.Drawing.Color.Black;
            this.lbl11.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.ForeColor = System.Drawing.Color.White;
            this.lbl11.Location = new System.Drawing.Point(18, 18);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(175, 50);
            this.lbl11.TabIndex = 4;
            this.lbl11.Text = "Car Report";
            // 
            // txtseach
            // 
            this.txtseach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtseach.Location = new System.Drawing.Point(297, 106);
            this.txtseach.Multiline = true;
            this.txtseach.Name = "txtseach";
            this.txtseach.Size = new System.Drawing.Size(300, 38);
            this.txtseach.TabIndex = 45;
            this.txtseach.TextChanged += new System.EventHandler(this.txtseach_TextChanged);
            // 
            // txtseachcarname
            // 
            this.txtseachcarname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtseachcarname.Location = new System.Drawing.Point(835, 106);
            this.txtseachcarname.Multiline = true;
            this.txtseachcarname.Name = "txtseachcarname";
            this.txtseachcarname.Size = new System.Drawing.Size(300, 38);
            this.txtseachcarname.TabIndex = 46;
            this.txtseachcarname.TextChanged += new System.EventHandler(this.txtseachcarname_TextChanged);
            // 
            // lblcarcatgerory
            // 
            this.lblcarcatgerory.AutoSize = true;
            this.lblcarcatgerory.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarcatgerory.Location = new System.Drawing.Point(128, 108);
            this.lblcarcatgerory.Name = "lblcarcatgerory";
            this.lblcarcatgerory.Size = new System.Drawing.Size(153, 36);
            this.lblcarcatgerory.TabIndex = 47;
            this.lblcarcatgerory.Text = "Car Category";
            // 
            // lblcarname
            // 
            this.lblcarname.AutoSize = true;
            this.lblcarname.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarname.Location = new System.Drawing.Point(696, 108);
            this.lblcarname.Name = "lblcarname";
            this.lblcarname.Size = new System.Drawing.Size(119, 36);
            this.lblcarname.TabIndex = 48;
            this.lblcarname.Text = "Car Name";
            // 
            // Cars_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "Cars_Report";
            this.Size = new System.Drawing.Size(1256, 886);
            this.Load += new System.EventHandler(this.Cars_Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarmangement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.DataGridView dgvcarmangement;
        private System.Windows.Forms.TextBox txtseach;
        private System.Windows.Forms.TextBox txtseachcarname;
        private System.Windows.Forms.Label lblcarcatgerory;
        private System.Windows.Forms.Label lblcarname;
    }
}
