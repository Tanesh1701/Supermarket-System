namespace Assignment
{
    partial class frmDashboardCustomer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboardCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnNotepad = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Timer(this.components);
            this.screenform = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.quote = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.quote);
            this.panel1.Controls.Add(this.btnCalculator);
            this.panel1.Controls.Add(this.btnNotepad);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 650);
            this.panel1.TabIndex = 14;
            // 
            // btnCalculator
            // 
            this.btnCalculator.FlatAppearance.BorderSize = 0;
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculator.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnCalculator.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculator.Image")));
            this.btnCalculator.Location = new System.Drawing.Point(-5, 270);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(186, 42);
            this.btnCalculator.TabIndex = 18;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnNotepad
            // 
            this.btnNotepad.FlatAppearance.BorderSize = 0;
            this.btnNotepad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotepad.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotepad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnNotepad.Image = ((System.Drawing.Image)(resources.GetObject("btnNotepad.Image")));
            this.btnNotepad.Location = new System.Drawing.Point(-4, 336);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(186, 42);
            this.btnNotepad.TabIndex = 18;
            this.btnNotepad.Text = "Notepad";
            this.btnNotepad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNotepad.UseVisualStyleBackColor = true;
            this.btnNotepad.Click += new System.EventHandler(this.btnNotepad_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.btnOrders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.btnOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.Location = new System.Drawing.Point(0, 203);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(186, 42);
            this.btnOrders.TabIndex = 20;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.Location = new System.Drawing.Point(0, 144);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(186, 42);
            this.btnProducts.TabIndex = 19;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(3, 476);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 42);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(0, 407);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(186, 42);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(59, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.lblTime.Location = new System.Drawing.Point(1247, 24);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(51, 24);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "Time";
            // 
            // timelbl
            // 
            this.timelbl.Enabled = true;
            this.timelbl.Tick += new System.EventHandler(this.timelbl_Tick);
            // 
            // screenform
            // 
            this.screenform.Location = new System.Drawing.Point(189, 86);
            this.screenform.Name = "screenform";
            this.screenform.Size = new System.Drawing.Size(1216, 552);
            this.screenform.TabIndex = 16;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.labelHeader.Location = new System.Drawing.Point(202, 13);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(142, 35);
            this.labelHeader.TabIndex = 17;
            this.labelHeader.Text = "Dashboard";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.lblDate.Location = new System.Drawing.Point(675, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 24);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Date";
            // 
            // quote
            // 
            this.quote.AutoSize = true;
            this.quote.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quote.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.quote.Location = new System.Drawing.Point(12, 560);
            this.quote.Name = "quote";
            this.quote.Size = new System.Drawing.Size(51, 21);
            this.quote.TabIndex = 16;
            this.quote.Text = "quote";
            // 
            // frmDashboardCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1417, 650);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.screenform);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboardCustomer";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboardCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timelbl;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel screenform;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button btnNotepad;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label quote;
    }
}