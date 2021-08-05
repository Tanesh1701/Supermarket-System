using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace Assignment
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        public frmDashboard(string username, string id)
        {
            InitializeComponent();
            frmLoginAE.Employee employee = new frmLoginAE.Employee();
            username = char.ToUpper(username[0]) + username.Substring(1); //Capitalising the first letter of the username
            label1.Text = username;
            label2.Text = id;
        }
        private void timertime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();//set real Date in label
            lblTime.Text = DateTime.Now.ToLongTimeString(); //Date is displayed and state keeps updating
        }
        private void clearControls()
        {
            screenform.Controls.Clear(); //A function to clear all the other elements found on the panel, essentially making it a blank container
        }
        static void dashboardForms()
        {
           
            frmDashboard dashboard = (frmDashboard)Application.OpenForms["Dashboard"]; //here we are accessing the form Dashboard from its form
            dashboard = new frmDashboard();
            Panel screenform = (Panel)dashboard.Controls["screenform"]; //Then we are accessing a control called screenform which is a panel in the form Dashboard
        }
        private void frmDashboard_Load(object sender, EventArgs e)//Calling the form Overview
        {
            labelHeader.Text = "Overview";

            clearControls();

            frmOverview overview = new frmOverview();
            overview.TopMost = true;
            overview.TopLevel = false;
            dashboardForms();
            screenform.Controls.Add(overview);
            overview.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            btnStock.BackColor = Color.FromArgb(46, 51, 73);
            labelHeader.Text = "Stock"; //Each time the user clicks on a respective button, the label header should change accordingly

            clearControls();  //clearing the panel
            screenform.BackColor = Color.FromArgb(255, 255, 255);

            frmStock stock = new frmStock(); //initialising a new instance of the form allows us to call it onto the dashboard
            stock.TopMost = true; //Ensures that the form stock will overlap all the other forms on the z-axis
            stock.TopLevel = false; //Since top level is always used for the main application and one that has no parent form, we need to set its property to false
            dashboardForms();
            screenform.Controls.Add(stock); //Here we are adding the form stock as a control to the panel screenform
            stock.Show();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            btnPayroll.BackColor = Color.FromArgb(46, 51, 73);
            labelHeader.Text = "Payroll";

            clearControls();
            screenform.BackColor = Color.FromArgb(255, 255, 255);
            frmPayroll payroll = new frmPayroll();
            payroll.TopMost = true;
            payroll.TopLevel = false;
            dashboardForms();
            screenform.Controls.Add(payroll);
            payroll.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
           
            btnStaff.BackColor = Color.FromArgb(46, 51, 73);
            labelHeader.Text = "Staff";

            clearControls();
            screenform.BackColor = Color.FromArgb(255, 255, 255);

            frmStaff staff = new frmStaff();
            staff.TopMost = true;
            staff.TopLevel = false;
            dashboardForms();
            screenform.Controls.Add(staff);
            staff.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            
            btnOrders.BackColor = Color.FromArgb(46, 51, 73);
            labelHeader.Text = "Orders";

            clearControls();
            screenform.BackColor = Color.FromArgb(255, 255, 255);

            frmOrder order = new frmOrder();
            order.TopMost = true;
            order.TopLevel = false;
            dashboardForms();
            screenform.Controls.Add(order);
            order.Show();
        }

        private void btnStock_Leave(object sender, EventArgs e)
        {
            btnStock.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPayroll_Leave(object sender, EventArgs e)
        {
            btnPayroll.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnStaff_Leave(object sender, EventArgs e)
        {
            btnStaff.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnOrders_Leave(object sender, EventArgs e)
        {
            btnOrders.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnInvoice_Leave(object sender, EventArgs e)
        {
            btnInvoice.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLogOut_Leave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.FromArgb(24, 30, 54);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                frmLoginCustomer fLC = new frmLoginCustomer();
                fLC.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnOverview_Click(object sender, EventArgs e)
        {
            if (BtnOverview.BackColor == Color.FromArgb(85, 67, 255))
                BtnOverview.BackColor = Color.FromArgb(85, 67, 255);

            labelHeader.Text = "Overview";

            clearControls();

            frmOverview overview = new frmOverview();
            overview.TopMost = true;
            overview.TopLevel = false;
            dashboardForms();
            screenform.Controls.Add(overview);
            overview.Show();
        }
    }
}
