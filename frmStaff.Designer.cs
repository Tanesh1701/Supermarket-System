namespace Assignment
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.noemployeeslbl = new System.Windows.Forms.Label();
            this.GoToAddEmployeeBtn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateDetails = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindCustomer = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToAddEmployeeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.GridColor = System.Drawing.Color.Silver;
            this.dgvStaff.Location = new System.Drawing.Point(32, 139);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersWidth = 50;
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.Size = new System.Drawing.Size(651, 395);
            this.dgvStaff.TabIndex = 1;
            // 
            // noemployeeslbl
            // 
            this.noemployeeslbl.AutoSize = true;
            this.noemployeeslbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noemployeeslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.noemployeeslbl.Location = new System.Drawing.Point(28, 28);
            this.noemployeeslbl.Name = "noemployeeslbl";
            this.noemployeeslbl.Size = new System.Drawing.Size(61, 24);
            this.noemployeeslbl.TabIndex = 3;
            this.noemployeeslbl.Text = "label1";
            this.noemployeeslbl.Click += new System.EventHandler(this.noemployeeslbl_Click);
            // 
            // GoToAddEmployeeBtn
            // 
            this.GoToAddEmployeeBtn.Image = ((System.Drawing.Image)(resources.GetObject("GoToAddEmployeeBtn.Image")));
            this.GoToAddEmployeeBtn.Location = new System.Drawing.Point(741, 296);
            this.GoToAddEmployeeBtn.Name = "GoToAddEmployeeBtn";
            this.GoToAddEmployeeBtn.Size = new System.Drawing.Size(100, 50);
            this.GoToAddEmployeeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.GoToAddEmployeeBtn.TabIndex = 4;
            this.GoToAddEmployeeBtn.TabStop = false;
            this.GoToAddEmployeeBtn.Click += new System.EventHandler(this.GoToAddEmployeeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(737, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add an Employee";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateDetails.Image")));
            this.btnUpdateDetails.Location = new System.Drawing.Point(741, 421);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(100, 50);
            this.btnUpdateDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnUpdateDetails.TabIndex = 8;
            this.btnUpdateDetails.TabStop = false;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(741, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Modify details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnFindCustomer.Image")));
            this.btnFindCustomer.Location = new System.Drawing.Point(741, 182);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(100, 50);
            this.btnFindCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFindCustomer.TabIndex = 10;
            this.btnFindCustomer.TabStop = false;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label12.Location = new System.Drawing.Point(763, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 21);
            this.label12.TabIndex = 29;
            this.label12.Text = "Search";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(122, 75);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(145, 28);
            this.txtFirstName.TabIndex = 30;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(398, 75);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(145, 28);
            this.txtLastName.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(28, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(304, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(576, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Post:";
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(628, 79);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(145, 28);
            this.txtPost.TabIndex = 37;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 558);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnFindCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GoToAddEmployeeBtn);
            this.Controls.Add(this.noemployeeslbl);
            this.Controls.Add(this.dgvStaff);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStaff";
            this.Text = "frmStaff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToAddEmployeeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Label noemployeeslbl;
        private System.Windows.Forms.PictureBox GoToAddEmployeeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnUpdateDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnFindCustomer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPost;
    }
}