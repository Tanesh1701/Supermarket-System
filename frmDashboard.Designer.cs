namespace Assignment
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPayroll = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.screenform = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel8 = new System.Windows.Forms.Panel();
            this.customerslbl = new System.Windows.Forms.Label();
            this.employeeslbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Orderslbl = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Productlbl = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPurchases = new System.Windows.Forms.Label();
            this.BtnOverview = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.screenform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.labelHeader.Location = new System.Drawing.Point(209, 11);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(142, 35);
            this.labelHeader.TabIndex = 3;
            this.labelHeader.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 144);
            this.panel1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.ID.Location = new System.Drawing.Point(12, 118);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(24, 21);
            this.ID.TabIndex = 4;
            this.ID.Text = "ID";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.Username.Location = new System.Drawing.Point(53, 89);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(81, 21);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnPayroll
            // 
            this.btnPayroll.FlatAppearance.BorderSize = 0;
            this.btnPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayroll.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.btnPayroll.Image = ((System.Drawing.Image)(resources.GetObject("btnPayroll.Image")));
            this.btnPayroll.Location = new System.Drawing.Point(0, 205);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Size = new System.Drawing.Size(186, 42);
            this.btnPayroll.TabIndex = 4;
            this.btnPayroll.Text = "Payroll";
            this.btnPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPayroll.UseVisualStyleBackColor = true;
            // 
            // btnStaff
            // 
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.Location = new System.Drawing.Point(0, 266);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(186, 42);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.Location = new System.Drawing.Point(0, 393);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(186, 42);
            this.btnOrders.TabIndex = 7;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnInvoice
            // 
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.btnInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoice.Image")));
            this.btnInvoice.Location = new System.Drawing.Point(0, 452);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(186, 42);
            this.btnInvoice.TabIndex = 8;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInvoice.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(0, 523);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(186, 42);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.Location = new System.Drawing.Point(0, 329);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(186, 42);
            this.btnStock.TabIndex = 10;
            this.btnStock.Text = "Stock";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 582);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 42);
            this.button2.TabIndex = 11;
            this.button2.Text = "Exit       ";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // screenform
            // 
            this.screenform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.screenform.Controls.Add(this.chart1);
            this.screenform.Controls.Add(this.panel8);
            this.screenform.Controls.Add(this.panel6);
            this.screenform.Controls.Add(this.panel5);
            this.screenform.Controls.Add(this.panel4);
            this.screenform.Location = new System.Drawing.Point(186, 58);
            this.screenform.Name = "screenform";
            this.screenform.Size = new System.Drawing.Size(965, 567);
            this.screenform.TabIndex = 12;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(344, 250);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(601, 283);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.customerslbl);
            this.panel8.Controls.Add(this.employeeslbl);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(56, 250);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(242, 283);
            this.panel8.TabIndex = 9;
            // 
            // customerslbl
            // 
            this.customerslbl.AutoSize = true;
            this.customerslbl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerslbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.customerslbl.Location = new System.Drawing.Point(80, 223);
            this.customerslbl.Name = "customerslbl";
            this.customerslbl.Size = new System.Drawing.Size(71, 32);
            this.customerslbl.TabIndex = 3;
            this.customerslbl.Text = "1000";
            // 
            // employeeslbl
            // 
            this.employeeslbl.AutoSize = true;
            this.employeeslbl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeslbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.employeeslbl.Location = new System.Drawing.Point(93, 63);
            this.employeeslbl.Name = "employeeslbl";
            this.employeeslbl.Size = new System.Drawing.Size(43, 32);
            this.employeeslbl.TabIndex = 2;
            this.employeeslbl.Text = "40";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(4, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Employees";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.Orderslbl);
            this.panel6.Controls.Add(this.lblOrders);
            this.panel6.Location = new System.Drawing.Point(636, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(242, 122);
            this.panel6.TabIndex = 7;
            // 
            // Orderslbl
            // 
            this.Orderslbl.AutoSize = true;
            this.Orderslbl.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orderslbl.ForeColor = System.Drawing.Color.Gray;
            this.Orderslbl.Location = new System.Drawing.Point(3, 0);
            this.Orderslbl.Name = "Orderslbl";
            this.Orderslbl.Size = new System.Drawing.Size(59, 21);
            this.Orderslbl.TabIndex = 2;
            this.Orderslbl.Text = "Orders";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOrders.Location = new System.Drawing.Point(102, 49);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(71, 32);
            this.lblOrders.TabIndex = 5;
            this.lblOrders.Text = "1276";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.Productlbl);
            this.panel5.Controls.Add(this.lblProduct);
            this.panel5.Location = new System.Drawing.Point(344, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 122);
            this.panel5.TabIndex = 6;
            // 
            // Productlbl
            // 
            this.Productlbl.AutoSize = true;
            this.Productlbl.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productlbl.ForeColor = System.Drawing.Color.Gray;
            this.Productlbl.Location = new System.Drawing.Point(-4, 0);
            this.Productlbl.Name = "Productlbl";
            this.Productlbl.Size = new System.Drawing.Size(72, 21);
            this.Productlbl.TabIndex = 7;
            this.Productlbl.Text = "Products";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProduct.Location = new System.Drawing.Point(93, 49);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(71, 32);
            this.lblProduct.TabIndex = 5;
            this.lblProduct.Text = "1750";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lblPurchases);
            this.panel4.Location = new System.Drawing.Point(49, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 122);
            this.panel4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quantity";
            // 
            // lblPurchases
            // 
            this.lblPurchases.AutoSize = true;
            this.lblPurchases.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchases.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPurchases.Location = new System.Drawing.Point(74, 49);
            this.lblPurchases.Name = "lblPurchases";
            this.lblPurchases.Size = new System.Drawing.Size(71, 32);
            this.lblPurchases.TabIndex = 5;
            this.lblPurchases.Text = "1500";
            // 
            // BtnOverview
            // 
            this.BtnOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.BtnOverview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.BtnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOverview.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.BtnOverview.Image = ((System.Drawing.Image)(resources.GetObject("BtnOverview.Image")));
            this.BtnOverview.Location = new System.Drawing.Point(-3, 142);
            this.BtnOverview.Name = "BtnOverview";
            this.BtnOverview.Size = new System.Drawing.Size(186, 42);
            this.BtnOverview.TabIndex = 5;
            this.BtnOverview.Text = "Overview";
            this.BtnOverview.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnOverview.UseVisualStyleBackColor = false;
            this.BtnOverview.Click += new System.EventHandler(this.BtnOverview_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.lblTime.Location = new System.Drawing.Point(992, 18);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(51, 24);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "Time";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.BtnOverview);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 625);
            this.panel2.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(3, 511);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 42);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Stock";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStock_Click);
            this.button1.Leave += new System.EventHandler(this.btnStock_Leave);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(0, 452);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 42);
            this.button4.TabIndex = 6;
            this.button4.Text = "Log Out";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.Leave += new System.EventHandler(this.btnLogOut_Leave);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(0, 393);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 42);
            this.button5.TabIndex = 5;
            this.button5.Text = "Orders";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnOrders_Click);
            this.button5.Leave += new System.EventHandler(this.btnOrders_Leave);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(3, 266);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 42);
            this.button6.TabIndex = 3;
            this.button6.Text = "Staff";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnStaff_Click);
            this.button6.Leave += new System.EventHandler(this.btnStaff_Leave);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(0, 205);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(186, 42);
            this.button7.TabIndex = 2;
            this.button7.Text = "Payroll";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnPayroll_Click);
            this.button7.Leave += new System.EventHandler(this.btnPayroll_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 144);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(65, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 56);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timertime_Tick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.lblDate.Location = new System.Drawing.Point(605, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 24);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Date";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 625);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.screenform);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnPayroll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.screenform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPayroll;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel screenform;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button BtnOverview;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPurchases;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label Orderslbl;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label customerslbl;
        private System.Windows.Forms.Label employeeslbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label Productlbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDate;
    }
}