namespace Assignment
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.GoToAddEmployeeBtn = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.PictureBox();
            this.btnReport = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbltotalquantity = new System.Windows.Forms.Label();
            this.lbltotalproduct = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnFindCustomer = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToAddEmployeeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(111, 160);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.Size = new System.Drawing.Size(652, 331);
            this.dgvStock.TabIndex = 0;
            // 
            // GoToAddEmployeeBtn
            // 
            this.GoToAddEmployeeBtn.Image = ((System.Drawing.Image)(resources.GetObject("GoToAddEmployeeBtn.Image")));
            this.GoToAddEmployeeBtn.Location = new System.Drawing.Point(907, 228);
            this.GoToAddEmployeeBtn.Name = "GoToAddEmployeeBtn";
            this.GoToAddEmployeeBtn.Size = new System.Drawing.Size(100, 50);
            this.GoToAddEmployeeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.GoToAddEmployeeBtn.TabIndex = 1;
            this.GoToAddEmployeeBtn.TabStop = false;
            this.GoToAddEmployeeBtn.Click += new System.EventHandler(this.GoToAddEmployeeBtn_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(907, 305);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 50);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(907, 382);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 50);
            this.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClear.TabIndex = 3;
            this.btnClear.TabStop = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReport
            // 
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.Location = new System.Drawing.Point(907, 459);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 50);
            this.btnReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnReport.TabIndex = 4;
            this.btnReport.TabStop = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(287, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(595, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(41, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(313, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(585, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Supplier Name:";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(111, 40);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(145, 22);
            this.txtProduct.TabIndex = 11;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(409, 40);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(145, 22);
            this.txtProductName.TabIndex = 13;
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(409, 111);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(145, 22);
            this.txtQuan.TabIndex = 14;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(710, 39);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(145, 22);
            this.txtPrice.TabIndex = 15;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(710, 111);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(145, 22);
            this.txtSupplierName.TabIndex = 16;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(111, 109);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(145, 24);
            this.cmbStatus.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(932, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Add";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(926, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Modify";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(932, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Clear";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(935, 512);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Report";
            // 
            // lbltotalquantity
            // 
            this.lbltotalquantity.AutoSize = true;
            this.lbltotalquantity.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalquantity.ForeColor = System.Drawing.Color.Gray;
            this.lbltotalquantity.Location = new System.Drawing.Point(585, 494);
            this.lbltotalquantity.Name = "lbltotalquantity";
            this.lbltotalquantity.Size = new System.Drawing.Size(112, 21);
            this.lbltotalquantity.TabIndex = 22;
            this.lbltotalquantity.Text = "Total Quantity:";
            // 
            // lbltotalproduct
            // 
            this.lbltotalproduct.AutoSize = true;
            this.lbltotalproduct.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalproduct.ForeColor = System.Drawing.Color.Gray;
            this.lbltotalproduct.Location = new System.Drawing.Point(156, 494);
            this.lbltotalproduct.Name = "lbltotalproduct";
            this.lbltotalproduct.Size = new System.Drawing.Size(193, 21);
            this.lbltotalproduct.TabIndex = 23;
            this.lbltotalproduct.Text = "Total Number of Products:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label11.Location = new System.Drawing.Point(903, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 21);
            this.label11.TabIndex = 25;
            this.label11.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Beverages",
            "Frozen",
            "Groceries",
            "Household",
            "Personal Hygiene Care "});
            this.cmbCategory.Location = new System.Drawing.Point(907, 72);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(145, 24);
            this.cmbCategory.TabIndex = 26;
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnFindCustomer.Image")));
            this.btnFindCustomer.Location = new System.Drawing.Point(907, 151);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(100, 50);
            this.btnFindCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFindCustomer.TabIndex = 27;
            this.btnFindCustomer.TabStop = false;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label12.Location = new System.Drawing.Point(928, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 21);
            this.label12.TabIndex = 28;
            this.label12.Text = "Search";
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 594);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnFindCustomer);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbltotalproduct);
            this.Controls.Add(this.lbltotalquantity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.GoToAddEmployeeBtn);
            this.Controls.Add(this.dgvStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToAddEmployeeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.PictureBox GoToAddEmployeeBtn;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnClear;
        private System.Windows.Forms.PictureBox btnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbltotalquantity;
        private System.Windows.Forms.Label lbltotalproduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.PictureBox btnFindCustomer;
        private System.Windows.Forms.Label label12;
    }
}