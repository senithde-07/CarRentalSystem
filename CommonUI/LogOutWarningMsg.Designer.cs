
namespace CarRentalSystem.CommonUI
{
    partial class LogOutWarningMsg
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogOutWarningMsg));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogOut_No = new System.Windows.Forms.Button();
            this.btnLogOut_Yes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLogOut_No);
            this.panel1.Controls.Add(this.btnLogOut_Yes);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 417);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Do you really want to exit the system..?";
            // 
            // btnLogOut_No
            // 
            this.btnLogOut_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut_No.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(230)))));
            this.btnLogOut_No.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut_No.Image")));
            this.btnLogOut_No.Location = new System.Drawing.Point(433, 328);
            this.btnLogOut_No.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut_No.Name = "btnLogOut_No";
            this.btnLogOut_No.Size = new System.Drawing.Size(223, 54);
            this.btnLogOut_No.TabIndex = 7;
            this.btnLogOut_No.Text = "No";
            this.btnLogOut_No.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut_No.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut_No.UseVisualStyleBackColor = true;
            this.btnLogOut_No.Click += new System.EventHandler(this.btnLogOut_No_Click_1);
            // 
            // btnLogOut_Yes
            // 
            this.btnLogOut_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut_Yes.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut_Yes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogOut_Yes.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut_Yes.Image")));
            this.btnLogOut_Yes.Location = new System.Drawing.Point(58, 328);
            this.btnLogOut_Yes.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut_Yes.Name = "btnLogOut_Yes";
            this.btnLogOut_Yes.Size = new System.Drawing.Size(223, 54);
            this.btnLogOut_Yes.TabIndex = 6;
            this.btnLogOut_Yes.Text = "Yes";
            this.btnLogOut_Yes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut_Yes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut_Yes.UseVisualStyleBackColor = true;
            this.btnLogOut_Yes.Click += new System.EventHandler(this.btnLogOut_Yes_Click_1);
            // 
            // LogOutWarningMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(739, 441);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogOutWarningMsg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogOutWarningMsg";
            this.Load += new System.EventHandler(this.LogOutWarningMsg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogOut_No;
        private System.Windows.Forms.Button btnLogOut_Yes;
    }
}