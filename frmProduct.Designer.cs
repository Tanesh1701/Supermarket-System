namespace Assignment
{
    partial class frmProduct
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Soft Drinks");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Others");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Beverages", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Foods");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Frozen", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Can & Packets");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Sugar, Flour & Rice");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Pasta & Noodle");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Breakfast");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Groceries", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Bathroom");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Laundry");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Household", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Hygiene");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Personal Hygiene Care", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.screenform = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Orderslbl = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.screenform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(31, 62);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "11";
            treeNode1.Text = "Soft Drinks";
            treeNode2.Name = "12";
            treeNode2.Text = "Others";
            treeNode3.Name = "1";
            treeNode3.Text = "Beverages";
            treeNode4.Name = "21";
            treeNode4.Text = "Foods";
            treeNode5.Name = "3";
            treeNode5.Text = "Frozen";
            treeNode6.Name = "34";
            treeNode6.Text = "Can & Packets";
            treeNode7.Name = "31";
            treeNode7.Text = "Sugar, Flour & Rice";
            treeNode8.Name = "32";
            treeNode8.Text = "Pasta & Noodle";
            treeNode9.Name = "33";
            treeNode9.Text = "Breakfast";
            treeNode10.Name = "2";
            treeNode10.Text = "Groceries";
            treeNode11.Name = "41";
            treeNode11.Text = "Bathroom";
            treeNode12.Name = "42";
            treeNode12.Text = "Laundry";
            treeNode13.Name = "4";
            treeNode13.Text = "Household";
            treeNode14.Name = "51";
            treeNode14.Text = "Hygiene";
            treeNode15.Name = "5";
            treeNode15.Text = "Personal Hygiene Care";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5,
            treeNode10,
            treeNode13,
            treeNode15});
            this.treeView1.Size = new System.Drawing.Size(235, 459);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // screenform
            // 
            this.screenform.BackColor = System.Drawing.Color.White;
            this.screenform.Controls.Add(this.chart1);
            this.screenform.Controls.Add(this.panel6);
            this.screenform.Location = new System.Drawing.Point(272, 62);
            this.screenform.Name = "screenform";
            this.screenform.Size = new System.Drawing.Size(615, 473);
            this.screenform.TabIndex = 13;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(636, 250);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(309, 283);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
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
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.labelHeader.Location = new System.Drawing.Point(266, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(107, 35);
            this.labelHeader.TabIndex = 14;
            this.labelHeader.Text = "Product";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 547);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.screenform);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmProduct";
            this.screenform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel screenform;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label Orderslbl;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label labelHeader;
    }
}