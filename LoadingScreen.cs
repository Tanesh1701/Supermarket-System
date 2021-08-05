using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Assignment
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
           
        }

        private void loadingScreenTimer_Tick(object sender, EventArgs e)
        {
            loadingPanel.Width += 10;

            if (loadingPanel.Width >= flowLayoutPanel.Width)
            {
                loadingScreenTimer.Stop();
                frmLoginCustomer fLC = new frmLoginCustomer();
                fLC.Show();
                this.Hide();
            }
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
