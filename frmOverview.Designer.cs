namespace Assignment
{
    partial class frmOverview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOverview));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Purchaseslbl = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customerslbl = new System.Windows.Forms.Label();
            this.employeeslbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Productlbl = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Orderslbl = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Purchaseslbl);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Location = new System.Drawing.Point(27, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 122);
            this.panel1.TabIndex = 0;
            // 
            // Purchaseslbl
            // 
            this.Purchaseslbl.AutoSize = true;
            this.Purchaseslbl.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchaseslbl.ForeColor = System.Drawing.Color.Gray;
            this.Purchaseslbl.Location = new System.Drawing.Point(3, 0);
            this.Purchaseslbl.Name = "Purchaseslbl";
            this.Purchaseslbl.Size = new System.Drawing.Size(72, 21);
            this.Purchaseslbl.TabIndex = 2;
            this.Purchaseslbl.Text = "Quantity";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQuantity.Location = new System.Drawing.Point(70, 49);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(71, 32);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "1500";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.customerslbl);
            this.panel3.Controls.Add(this.employeeslbl);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(27, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 283);
            this.panel3.TabIndex = 3;
            // 
            // customerslbl
            // 
            this.customerslbl.AutoSize = true;
            this.customerslbl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerslbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.customerslbl.Location = new System.Drawing.Point(93, 225);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(4, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(345, 228);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            series1.Legend = "Legend1";
            series1.Name = "Quantity %";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(669, 287);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.Productlbl);
            this.panel4.Controls.Add(this.lblProduct);
            this.panel4.Location = new System.Drawing.Point(366, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 122);
            this.panel4.TabIndex = 5;
            // 
            // Productlbl
            // 
            this.Productlbl.AutoSize = true;
            this.Productlbl.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productlbl.ForeColor = System.Drawing.Color.Gray;
            this.Productlbl.Location = new System.Drawing.Point(3, 0);
            this.Productlbl.Name = "Productlbl";
            this.Productlbl.Size = new System.Drawing.Size(72, 21);
            this.Productlbl.TabIndex = 2;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.Orderslbl);
            this.panel5.Controls.Add(this.lblOrders);
            this.panel5.Location = new System.Drawing.Point(705, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 122);
            this.panel5.TabIndex = 6;
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
            // frmOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1216, 552);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOverview";
            this.Text = "frmOverview";
            this.Load += new System.EventHandler(this.frmOverview_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Purchaseslbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Productlbl;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Orderslbl;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label customerslbl;
        private System.Windows.Forms.Label employeeslbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}