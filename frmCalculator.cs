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
    public partial class frmCalculator : Form
    {
        float num1, ans;
        int count;
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e) //add 1 to calculator textbox
        {
            Zero();
            txtCalculator.Text = txtCalculator.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)//add 2 to calculator textbox
        {
            Zero();
            txtCalculator.Text = txtCalculator.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)//add 3 to calculator textbox
        {
            Zero();
            txtCalculator.Text = txtCalculator.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)//add 4 to calculator textbox
        {
            Zero();
            txtCalculator.Text = txtCalculator.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)//add 5 to calculator textbox
        {
            Zero();
            txtCalculator.Text = txtCalculator.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)//add 6 to calculator textbox
        {
            Zero();
            txtCalculator.Text = txtCalculator.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)//add 7 to calculator textbox
        {
            Zero();
            txtCalculator.Text = txtCalculator.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)//add 8 to calculator textbox
        {
            Zero();
            txtCalculator.Text = txtCalculator.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)//add 9 to calculator textbox
        {
            Zero();
            txtCalculator.Text = txtCalculator.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)//add 0 to calculator textbox
        {
            txtCalculator.Text = txtCalculator.Text + 0;
        }

        private void btn00_Click(object sender, EventArgs e)//add 00 to calculator textbox
        {
            Zero();
            txtCalculator.Text = txtCalculator.Text + 0 + 0;
        }
        private void btnAddition_Click(object sender, EventArgs e)//addition button
        {
            num1 = float.Parse(txtCalculator.Text);
            txtCalculator.Clear();
            txtCalculator.Focus();
            count = 1;//set count to 1 to call in switch case
        }
        private void btnSubstraction_Click(object sender, EventArgs e)//substraction button
        {
            if (txtCalculator.Text != "")
            {
                num1 = float.Parse(txtCalculator.Text);
                txtCalculator.Clear();
                txtCalculator.Focus();
                count = 2;//set count to 2 to call in switch case
            }
        }
        private void btnMultiplication_Click(object sender, EventArgs e)//multiplication button
        {
            num1 = float.Parse(txtCalculator.Text);
            txtCalculator.Clear();
            txtCalculator.Focus();
            count = 3;//set count to 3 to call in switch case
        }
        private void btnDivision_Click(object sender, EventArgs e)//division button
        {
            num1 = float.Parse(txtCalculator.Text);
            txtCalculator.Clear();
            txtCalculator.Focus();
            count = 4;//set count to 4 to call in switch case
        }
        private void btnEqual_Click(object sender, EventArgs e)//equal to button
        {
            Compute(count);//cakk function Compute
        }
        public void Compute(int count)//function Compute to call operator
        {
            switch (count)//switch case
            {
                case 1:
                    ans = num1 + float.Parse(txtCalculator.Text);//addition
                    txtCalculator.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 - float.Parse(txtCalculator.Text);//substaction
                    txtCalculator.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(txtCalculator.Text);//multiplication
                    txtCalculator.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(txtCalculator.Text);//division
                    txtCalculator.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnDot_Click(object sender, EventArgs e)//set dot to do decimal calculation
        {
            int c = txtCalculator.TextLength;
            int flag = 0;
            string text = txtCalculator.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                txtCalculator.Text = txtCalculator.Text + ".";
            }
        }

        private void btnC_Click(object sender, EventArgs e)//Clear calculator textbox
        {
            txtCalculator.Clear();
            count = 0;
        }
        public void Zero()//clear calculator textbox if textbox start with zero
        {
            if (txtCalculator.Text == "0")
                txtCalculator.Clear();
        }
    }
}
