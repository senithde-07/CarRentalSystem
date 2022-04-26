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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars_Report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvcarmangement = new System.Windows.Forms.DataGridView();
            this.lbl11 = new System.Windows.Forms.Label();
            this.comboBoxcarsearch = new System.Windows.Forms.ComboBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarmangement)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnrefresh);
            this.panel1.Controls.Add(this.comboBoxcarsearch);
            this.panel1.Controls.Add(this.dgvcarmangement);
            this.panel1.Controls.Add(this.lbl11);
            this.panel1.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 865);
            this.panel1.TabIndex = 3;
            // 
            // dgvcarmangement
            // 
            this.dgvcarmangement.BackgroundColor = System.Drawing.Color.Black;
            this.dgvcarmangement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvcarmangement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvcarmangement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcarmangement.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.NullValue = null;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcarmangement.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvcarmangement.GridColor = System.Drawing.Color.Black;
            this.dgvcarmangement.Location = new System.Drawing.Point(27, 176);
            this.dgvcarmangement.Name = "dgvcarmangement";
            this.dgvcarmangement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcarmangement.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvcarmangement.RowHeadersWidth = 51;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcarmangement.RowsDefaultCellStyle = dataGridViewCellStyle15;
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
            // comboBoxcarsearch
            // 
            this.comboBoxcarsearch.FormattingEnabled = true;
            this.comboBoxcarsearch.Location = new System.Drawing.Point(560, 102);
            this.comboBoxcarsearch.Name = "comboBoxcarsearch";
            this.comboBoxcarsearch.Size = new System.Drawing.Size(278, 39);
            this.comboBoxcarsearch.TabIndex = 43;
            this.comboBoxcarsearch.SelectionChangeCommitted += new System.EventHandler(this.comboBoxcarsearch_SelectionChangeCommitted);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.White;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.Black;
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.Location = new System.Drawing.Point(878, 102);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(198, 39);
            this.btnrefresh.TabIndex = 44;
            this.btnrefresh.Text = "Search";
            this.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
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
        private System.Windows.Forms.ComboBox comboBoxcarsearch;
        private System.Windows.Forms.Button btnrefresh;
    }
}
