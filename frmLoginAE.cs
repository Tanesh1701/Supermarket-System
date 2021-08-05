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
    public partial class frmLoginAE : Form
    {
        int attempts = 3;//initialize attempt for login
        public frmLoginAE()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;//set passowrd in invisible char
        }

        public class Employee //class for fetch Username and StaffID
        {
            public string Username { get; set; }
            public string Id { get; set; }
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

        private void btnLogin_MouseHover(object sender, EventArgs e)//Change Color when mouse hover button Login
        {
            btnLogin.BackColor = Color.FromArgb(53, 35, 221);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)//Click on picturebox Password set to visible
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)//Set Password set back to invisible
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        private void btnLoginCustomer_MouseHover(object sender, EventArgs e) //Change Color when mouse hover button Login as customer
        {
            btnLoginCustomer.ForeColor = Color.FromArgb(53, 35, 221);
        }

        private void btnLoginCus_MouseLeave(object sender, EventArgs e)//Change Color when mouse leave button Login as customer
        {
           btnLoginCustomer.BackColor = Color.FromArgb(53, 35, 221);
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (attempts > 0 && (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text)))//Condition to check whether textboxes are empty
            {
                string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Supermarket.mdf;Integrated Security=True;Connect Timeout=30"; //Data Connection String of the Database
                string query = "Select * from Admin Where AdminUsername='" + txtUsername.Text.Trim() + "'and AdminPassword='" + txtPassword.Text.Trim() + "'"; //SQL Query to search for Username and Password in table Admin
                SqlDataAdapter sda = new SqlDataAdapter(query, connStr);//call sql query and connection string of the database
                DataTable dt = new DataTable();//create a Datatable
                sda.Fill(dt);
                
                if (dt.Rows.Count == 1)//username and password are found
                {
                    Employee employee = new Employee();                                          //call Class to set the Username and StaffID to use in form frmDashboard
                    employee.Username = dt.Rows[0]["AdminUsername"].ToString();
                    employee.Id = dt.Rows[0]["StaffID"].ToString();
                    frmDashboard fD = new frmDashboard(employee.Username, employee.Id);           //call form frmDashboard
                    fD.Show();
                    this.Hide();

                    PopupNotifier popup = new PopupNotifier                                            //Popup a notification
                    {
                        TitleText = "Winners",
                        TitleColor = System.Drawing.Color.FromArgb(255, 255, 255),
                        TitleFont = new System.Drawing.Font("Roboto", 9F),
                        ContentText = $"Login Successful, Welcome, {employee.Username}!",
                        BodyColor = System.Drawing.Color.FromArgb(0, 0, 0),
                        BorderColor = System.Drawing.Color.FromArgb(0, 0, 0),
                        ContentColor = System.Drawing.Color.FromArgb(255, 255, 255),
                        ContentFont = new System.Drawing.Font("Roboto", 10F),
                        ContentHoverColor = System.Drawing.Color.FromArgb(255, 255, 255),
                        ContentPadding = new Padding(5),
                        TitlePadding = new Padding(5),
                        HeaderColor = System.Drawing.Color.FromArgb(0, 0, 0),
                        Image = Properties.Resources.Verified
                    };
                    popup.Popup();
                }
                else  //if username and password not found in database
                {
                    attempts = attempts - 1;
                    MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtResult.Text = ($"Number of attempts: {attempts} Left");
                }
                sda.Dispose();
            }
            else //if textboxes are empty
            {
                attempts = attempts - 1;
                MessageBox.Show("Enter Username and Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtResult.Text = ($"Number of attempts: {attempts}");

            }

            if (attempts == 0) //reach limited attempt
            {
                MessageBox.Show("Try Again Later", "Reach Attempt Limits", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnLoginCustomer_Click(object sender, EventArgs e)//button to open form frmLoginCustomer
        {
            frmLoginCustomer fC = new frmLoginCustomer();
            fC.Show();
            this.Hide();
        }
    }
}
