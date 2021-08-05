using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class frmDashboardCustomer : Form
    {
        string[] quotes = { "It’s hard to beat a person who never gives up.", "The secret of getting ahead is getting started.", "Do one thing every day that scares you.", "Whatever you are, be a good one.", "Impossible is just an opinion.", "Hold the vision, trust the process.", "One day or day one. You decide.", "Invest in your dreams. Grind now. Shine later.", "The hard days are what make you stronger.", "If opportunity doesn’t knock, build a door.", "Wherever you go, go with all your heart", "Dreams don’t work unless you do.", "I can and I will. Watch me." };
        public frmDashboardCustomer()
        {
            InitializeComponent();
        }
        public frmDashboardCustomer(string username)
        {
            InitializeComponent();
            frmLoginCustomer.Customer customer = new frmLoginCustomer.Customer();
            username = char.ToUpper(username[0]) + username.Substring(1);
            label1.Text = username;
        }
        private void clearControls()
        {
            screenform.Controls.Clear();
        }

        static void dashboardForm()
        {
            frmDashboardCustomer dashboardCustomer = (frmDashboardCustomer)Application.OpenForms["Dashboard"];
            dashboardCustomer = new frmDashboardCustomer();
            Panel screenform = (Panel)dashboardCustomer.Controls["screenform"];
        }

        private void btnLogOut_Click(object sender, EventArgs e)
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

        private void timelbl_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();//set real Date in label
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            labelHeader.Text = "Orders";

            clearControls();

            frmOrderCustomer order = new frmOrderCustomer();
            order.TopMost = true;
            order.TopLevel = false;
            dashboardForm();
            screenform.Controls.Add(order);
            order.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            labelHeader.Text = "Product";

            clearControls();

            frmProduct product = new frmProduct();
            product.TopMost = true;
            product.TopLevel = false;
            dashboardForm();
            screenform.Controls.Add(product);
            product.Show();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            labelHeader.Text = "Calculator";

            clearControls();
            frmCalculator calculator = new frmCalculator
            {
                TopMost = true,
                TopLevel = false
            };
            dashboardForm();
            screenform.Controls.Add(calculator);
            calculator.Show();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            labelHeader.Text = "Notepad";

            clearControls();
            Notepad notepad = new Notepad
            {
                TopMost = true,
                TopLevel = false
            };
            dashboardForm();
            screenform.Controls.Add(notepad);
            notepad.Show();
     
        }

        private void frmDashboardCustomer_Load(object sender, EventArgs e)
        {
            labelHeader.Text = "Product";

            clearControls();

            frmProduct product = new frmProduct();
            product.TopMost = true;
            product.TopLevel = false;
            dashboardForm();
            screenform.Controls.Add(product);
            product.Show();

            Random random = new Random();
            int quoteNo = random.Next(0, quotes.Length);
            quote.Text = quotes[quoteNo];
            quote.MaximumSize = new Size(100, 0);
            quote.AutoSize = true;
        }
    }
}
