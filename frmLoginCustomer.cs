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
using Tulpep.NotificationWindow;

namespace Assignment
{
    public partial class frmLoginCustomer : Form
    {
        int attempts = 3;//initialize attempt for login

        public frmLoginCustomer()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;//set passowrd in invisible char
        }
        public class Customer
        {
            public string Username { get; set; }//class for fetch Username
        }

        private void btnQuit_Click(object sender, EventArgs e)//Exit button
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();//set real TIme in label
            lblDate.Text = DateTime.Now.ToShortDateString();//set real Date in label
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)//Click on picturebox Password set to visible
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)//Set Password set back to invisible
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void BtnRegister_Click(object sender, EventArgs e)//button to open form frmRegister to register as customer
        {
            frmRegisterCustomer customer = new frmRegisterCustomer();
            customer.Show();
            this.Hide();
        }

        private void btnLoginEmployee_Click(object sender, EventArgs e)//button to open form frmLoginEmployee to login as Employee
        {
            frmLoginAE employee = new frmLoginAE();
            employee.Show();
            this.Hide();
        }

        private void btnLoginCustomer_Click(object sender, EventArgs e)
        {
            if (attempts > 0 && (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text)))//Condition to check whether textboxes are empty
                {
                string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Supermarket.mdf;Integrated Security=True;Connect Timeout=30";  //Data Connection String of the Database
                string query = "Select * from Customer Where CustUsername='" + txtUsername.Text.Trim() + "'and CustPassword='" + txtPassword.Text.Trim() + "'";  //SQL Query to search for Username and Password in table Admin
                SqlDataAdapter sda = new SqlDataAdapter(query, connStr); //call sql query and connection string of the database
                DataTable dt = new DataTable();//create a Datatable
                sda.Fill(dt);
                if (dt.Rows.Count == 1)//username and password are found
                {
                    Customer customer = new Customer();                                      //call Class to set the Username to use in form frmDashboardCustomer
                    customer.Username = dt.Rows[0]["CustUsername"].ToString();
                    frmDashboardCustomer fDC = new frmDashboardCustomer(customer.Username);    //call form frmDashboard
                    fDC.Show();
                    this.Hide();

                    Popup();   //Call function Popup
                   
                }
                else  //if username and password not found in database
                {
                    attempts = attempts - 1;
                    MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtResult.Text = ($"Number of attempts: {attempts} Left!");
                }
                sda.Dispose();
            }
            else  //if textboxes are empty
            {
                attempts = attempts - 1;
                MessageBox.Show("Enter Username and Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtResult.Text = ($"Number of attempts: {attempts} Left!");

            }

            if (attempts == 0)   //reach limited attempt
            {
                MessageBox.Show("Try Again Later", "Reach Attempt Limits", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void BtnRegister_MouseHover(object sender, EventArgs e)//Change Color when mouse hover button Register
        {
            BtnRegister.BackColor = Color.FromArgb(53, 35, 221);
        }

        private void btnLoginEmployee_MouseHover(object sender, EventArgs e)//Change Color when mouse hover button Login
        {
            btnLoginEmployee.BackColor = Color.FromArgb(53, 35, 221);
        }

        private void btnLoginCustomer_MouseHover(object sender, EventArgs e)//Change Color when mouse hover button LoginCustomer
        {
            btnLoginCustomer.BackColor = Color.FromArgb(53, 35, 221);
        }

        private void BtnRegister_MouseLeave(object sender, EventArgs e) //Change Color when mouse leave button Register as new customer
        {
            BtnRegister.BackColor = Color.FromArgb(85, 67, 255);
        }

        private void btnLoginEmployee_MouseLeave(object sender, EventArgs e) //Change Color when mouse leave button Login as Employee
        {
            btnLoginEmployee.BackColor = Color.FromArgb(85, 67, 255);
        }

        private void btnLoginCustomer_MouseLeave(object sender, EventArgs e)  //Change Color when mouse leave button Login as customer
        {
            btnLoginCustomer.BackColor = Color.FromArgb(85, 67, 255);
        }
        private void Popup()   //function to popup a notification
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Winners";
            popup.TitleColor = System.Drawing.Color.FromArgb(255, 255, 255);
            popup.TitleFont = new System.Drawing.Font("Roboto", 9F);
            popup.ContentText = "Login Successful, Welcome to Winners!";
            popup.BodyColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.ContentColor = System.Drawing.Color.FromArgb(255, 255, 255);
            popup.ContentFont = new System.Drawing.Font("Roboto", 10F);
            popup.ContentHoverColor = System.Drawing.Color.FromArgb(255, 255, 255);
            popup.ContentPadding = new Padding(5);
            popup.TitlePadding = new Padding(5);
            popup.HeaderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Image = Properties.Resources.Verified;
            popup.Popup();
        }
    }
    
}
