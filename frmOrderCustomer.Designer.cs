namespace Assignment
{
    partial class frmOrderCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderCustomer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFindCustomer = new System.Windows.Forms.PictureBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.txtCustUsername = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.PictureBox();
            this.btnGenerateBilling = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.totalproductid = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dvgCart = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalculate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerateBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFindCustomer);
            this.groupBox1.Controls.Add(this.txtOrder);
            this.groupBox1.Controls.Add(this.txtCustUsername);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtNIC);
            this.groupBox1.Controls.Add(this.txtContactNumber);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 529);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnFindCustomer.Image")));
            this.btnFindCustomer.Location = new System.Drawing.Point(43, 482);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(81, 31);
            this.btnFindCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFindCustomer.TabIndex = 0;
            this.btnFindCustomer.TabStop = false;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // txtOrder
            // 
            this.txtOrder.ForeColor = System.Drawing.Color.DimGray;
            this.txtOrder.Location = new System.Drawing.Point(10, 48);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(153, 28);
            this.txtOrder.TabIndex = 1;
            // 
            // txtCustUsername
            // 
            this.txtCustUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtCustUsername.Location = new System.Drawing.Point(10, 108);
            this.txtCustUsername.Name = "txtCustUsername";
            this.txtCustUsername.Size = new System.Drawing.Size(153, 28);
            this.txtCustUsername.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.txtFirstName.Location = new System.Drawing.Point(10, 177);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(153, 28);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Control;
            this.txtLastName.ForeColor = System.Drawing.Color.DimGray;
            this.txtLastName.Location = new System.Drawing.Point(10, 238);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(153, 28);
            this.txtLastName.TabIndex = 9;
            // 
            // txtNIC
            // 
            this.txtNIC.BackColor = System.Drawing.SystemColors.Control;
            this.txtNIC.ForeColor = System.Drawing.Color.DimGray;
            this.txtNIC.Location = new System.Drawing.Point(10, 304);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.ReadOnly = true;
            this.txtNIC.Size = new System.Drawing.Size(153, 28);
            this.txtNIC.TabIndex = 8;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtContactNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtContactNumber.Location = new System.Drawing.Point(10, 435);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.ReadOnly = true;
            this.txtContactNumber.Size = new System.Drawing.Size(153, 28);
            this.txtContactNumber.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddress.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddress.Location = new System.Drawing.Point(10, 359);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(153, 28);
            this.txtAddress.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(6, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contact Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(6, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(6, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "NIC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(6, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "OrderID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Controls.Add(this.btnGenerateBilling);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.cmbMethod);
            this.groupBox2.Controls.Add(this.cmbPayment);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtTotalPrice);
            this.groupBox2.Controls.Add(this.txtSubTotal);
            this.groupBox2.Controls.Add(this.txtUnit);
            this.groupBox2.Controls.Add(this.txtVAT);
            this.groupBox2.Controls.Add(this.txtPName);
            this.groupBox2.Controls.Add(this.txtProductID);
            this.groupBox2.Controls.Add(this.totalproductid);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.dvgCart);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lstProduct);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbCategory);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(228, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(977, 529);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(253, 219);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(129, 28);
            this.txtQuantity.TabIndex = 37;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(528, 498);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 21);
            this.label24.TabIndex = 36;
            this.label24.Text = "Calculate";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(453, 498);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 21);
            this.label23.TabIndex = 35;
            this.label23.Text = "Billing";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(348, 498);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 21);
            this.label22.TabIndex = 34;
            this.label22.Text = "Delete";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(270, 498);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 21);
            this.label21.TabIndex = 33;
            this.label21.Text = "Add";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculate.Image")));
            this.btnCalculate.Location = new System.Drawing.Point(532, 445);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(66, 50);
            this.btnCalculate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCalculate.TabIndex = 32;
            this.btnCalculate.TabStop = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnGenerateBilling
            // 
            this.btnGenerateBilling.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateBilling.Image")));
            this.btnGenerateBilling.Location = new System.Drawing.Point(440, 445);
            this.btnGenerateBilling.Name = "btnGenerateBilling";
            this.btnGenerateBilling.Size = new System.Drawing.Size(66, 50);
            this.btnGenerateBilling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnGenerateBilling.TabIndex = 31;
            this.btnGenerateBilling.TabStop = false;
            this.btnGenerateBilling.Click += new System.EventHandler(this.btnGenerateBilling_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(340, 445);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 50);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnDelete.TabIndex = 30;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(253, 445);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 50);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAdd.TabIndex = 29;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbMethod
            // 
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "Delivery",
            "Pick-Up"});
            this.cmbMethod.Location = new System.Drawing.Point(465, 146);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(133, 29);
            this.cmbMethod.TabIndex = 28;
            // 
            // cmbPayment
            // 
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Items.AddRange(new object[] {
            "On-delivery",
            "Pick-up",
            "Online Payment"});
            this.cmbPayment.Location = new System.Drawing.Point(457, 76);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(133, 29);
            this.cmbPayment.TabIndex = 27;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.ForeColor = System.Drawing.Color.DimGray;
            this.txtTotal.Location = new System.Drawing.Point(465, 386);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(133, 28);
            this.txtTotal.TabIndex = 26;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalPrice.ForeColor = System.Drawing.Color.DimGray;
            this.txtTotalPrice.Location = new System.Drawing.Point(253, 386);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(133, 28);
            this.txtTotalPrice.TabIndex = 25;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtSubTotal.ForeColor = System.Drawing.Color.DimGray;
            this.txtSubTotal.Location = new System.Drawing.Point(465, 309);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(133, 28);
            this.txtSubTotal.TabIndex = 24;
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.SystemColors.Control;
            this.txtUnit.ForeColor = System.Drawing.Color.DimGray;
            this.txtUnit.Location = new System.Drawing.Point(253, 304);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(133, 28);
            this.txtUnit.TabIndex = 23;
            // 
            // txtVAT
            // 
            this.txtVAT.BackColor = System.Drawing.SystemColors.Control;
            this.txtVAT.ForeColor = System.Drawing.Color.DimGray;
            this.txtVAT.Location = new System.Drawing.Point(465, 208);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(133, 28);
            this.txtVAT.TabIndex = 22;
            // 
            // txtPName
            // 
            this.txtPName.BackColor = System.Drawing.SystemColors.Control;
            this.txtPName.ForeColor = System.Drawing.Color.DimGray;
            this.txtPName.Location = new System.Drawing.Point(249, 147);
            this.txtPName.Name = "txtPName";
            this.txtPName.ReadOnly = true;
            this.txtPName.Size = new System.Drawing.Size(179, 28);
            this.txtPName.TabIndex = 20;
            this.txtPName.TextChanged += new System.EventHandler(this.txtPName_TextChanged);
            // 
            // txtProductID
            // 
            this.txtProductID.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductID.ForeColor = System.Drawing.Color.DimGray;
            this.txtProductID.Location = new System.Drawing.Point(249, 76);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(133, 28);
            this.txtProductID.TabIndex = 17;
            // 
            // totalproductid
            // 
            this.totalproductid.AutoSize = true;
            this.totalproductid.Location = new System.Drawing.Point(722, 498);
            this.totalproductid.Name = "totalproductid";
            this.totalproductid.Size = new System.Drawing.Size(128, 21);
            this.totalproductid.TabIndex = 16;
            this.totalproductid.Text = "Total Quantity: 0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(612, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 21);
            this.label20.TabIndex = 15;
            this.label20.Text = "Cart:";
            // 
            // dvgCart
            // 
            this.dvgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Price});
            this.dvgCart.Location = new System.Drawing.Point(616, 48);
            this.dvgCart.Name = "dvgCart";
            this.dvgCart.ReadOnly = true;
            this.dvgCart.RowHeadersWidth = 51;
            this.dvgCart.RowTemplate.Height = 24;
            this.dvgCart.Size = new System.Drawing.Size(323, 447);
            this.dvgCart.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 77;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantity";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 63;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 50;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label19.Location = new System.Drawing.Point(461, 362);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 21);
            this.label19.TabIndex = 13;
            this.label19.Text = "Total:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label18.Location = new System.Drawing.Point(461, 285);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 21);
            this.label18.TabIndex = 12;
            this.label18.Text = "Sub-Total:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label17.Location = new System.Drawing.Point(461, 184);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 21);
            this.label17.TabIndex = 11;
            this.label17.Text = "VAT:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label16.Location = new System.Drawing.Point(453, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 21);
            this.label16.TabIndex = 10;
            this.label16.Text = "Method Of Delivery:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label15.Location = new System.Drawing.Point(249, 359);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 21);
            this.label15.TabIndex = 9;
            this.label15.Text = "Total Price:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label14.Location = new System.Drawing.Point(249, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 21);
            this.label14.TabIndex = 8;
            this.label14.Text = "Unit Price:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label13.Location = new System.Drawing.Point(249, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 21);
            this.label13.TabIndex = 7;
            this.label13.Text = "Quantity:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label12.Location = new System.Drawing.Point(245, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "Product Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label11.Location = new System.Drawing.Point(453, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Payment:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(245, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "Product ID:";
            // 
            // lstProduct
            // 
            this.lstProduct.ForeColor = System.Drawing.Color.DimGray;
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.ItemHeight = 21;
            this.lstProduct.Location = new System.Drawing.Point(15, 170);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(205, 340);
            this.lstProduct.TabIndex = 3;
            this.lstProduct.SelectedIndexChanged += new System.EventHandler(this.lstProduct_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Product List:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(11, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Beverage",
            "Frozen",
            "Groceries",
            "Household",
            "Personal Hygiene Care "});
            this.cmbCategory.Location = new System.Drawing.Point(15, 64);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(148, 29);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // frmOrderCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrderCustomer";
            this.Text = "frmOrderCustomer";
            this.Load += new System.EventHandler(this.frmOrderCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalculate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerateBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnFindCustomer;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.TextBox txtCustUsername;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label totalproductid;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dvgCart;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox btnCalculate;
        private System.Windows.Forms.PictureBox btnGenerateBilling;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}