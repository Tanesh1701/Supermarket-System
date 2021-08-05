using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Assignment
{
    public partial class frmRegisterCustomer : Form
    {
        public frmRegisterCustomer()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;   //set passowrd in invisible char
            txtConPassword.UseSystemPasswordChar = true;
        }
        string CON = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Supermarket.mdf;Integrated Security=True;Connect Timeout=30";   //Data Connection String of the Database
        DataTable dt = new DataTable(); //create a Datatable

        int error = 0;     //initialize variable error to check error through the program
        int numLetter = 0;
        int num1Digit = 0;
        int num2Digit = 0;
        int num1 = 0;
       
        private void CheckPassword() 
        {
            try
            {
                numLetter = 0;
                foreach (char ch in txtConPassword.Text)//count the length Password
                {
                    if (char.IsLetterOrDigit(ch))//See whether it contains letter or digit
                    {
                        numLetter++;
                    }
                    else
                    {
                        error++;
                    }
                }
                if (numLetter < 8)//Passowrd less than 8 display error message
                {
                    MessageBox.Show("Weak Password, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error++;
                }
                if (txtPassword.Text != txtConPassword.Text)//Password is not equal to Confirm Passowrd display error message
                {
                    MessageBox.Show("Incorrect Password, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error++;
                }
            }
            catch (Exception) //Invalid string format
            {
                MessageBox.Show("Invalid Account Number, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error++;
            }
        }
        private void CheckEmail() //function to check Email
        {
            string email = txtEmail.Text; 
            foreach (char ch in email) //loop to check if email contain @
            {
                if ((email.Contains("@gmail.com")))
                {
                    num1++;
                }
                else
                {
                    error++;
                }    
            }
            if (num1 <= 0) //less than zero display error message
                MessageBox.Show("Invalid Email Address, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void CheckPhoneNumber() //function to check Phone Number
        {
            try
            {
                num1Digit = 0;
                foreach (char ch in txtPhoneNumber.Text) //count the length of Phone Number
                {
                    if (char.IsDigit(ch))
                    {
                        num1Digit++;
                    }
                    if (char.IsLetter(ch)) //contain a letter display error message
                    {
                        error++;
                    }
                }
                if (num1Digit < 8)//less than 8 display error message
                {
                    MessageBox.Show("Invalid Phone Number, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error++;
                }
            }
            catch (Exception)//Invalid string format
            {
                MessageBox.Show("Invalid Phone Number, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error++;
            }
        }

        private void CheckNIC()//function to check length of NIC and duplication of NIC
        {
            num2Digit = 0;
            foreach (char ch in txtNIC.Text)//count the length of NIC
            {
                if (char.IsLetterOrDigit(ch))
                {
                    num2Digit++;
                }
            }
            if (!(num2Digit == 14)) //if not equal display error message
            {
                MessageBox.Show("Invalid NIC, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error++;
            }
            else //check duplication of NIC
            {
                string sqlquery2 = "SELECT * From Customer WHERE NIC = '" + txtNIC.Text + "'"; //SQL query to search for NIC is equal in table Customer
                SqlDataAdapter sda = new SqlDataAdapter(sqlquery2, CON);
                dt.Clear(); //clear dt
                sda.Fill(dt);

                if (dt.Rows.Count > 0) //display error message if found
                {
                    MessageBox.Show("NIC Already Exist, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNIC.SelectAll();
                    error++;
                    dt.Clear(); //clear dt
                    return;
                }
                sda.Dispose();
            }
        }

        private void CheckZipCode() //function to check if ZipCode contains fully digit
        {
            try
            {
                int error1 = 0;
                foreach (char ch in txtZipCode.Text) //loop through Zip Code
                {
                    if (!char.IsDigit(ch))//display error message if not digit
                    {
                        error1++;
                        error++;
                    }
                }
                if (error1 != 0)
                { MessageBox.Show("Invalid Zip Code / Postal Code, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Zip Code / Postal Code, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void CheckUsername()//function to check duplication of Username
        {
            string sqlquery = "SELECT CustUsername From Customer WHERE CustUsername = '" + txtUsername.Text + "'";//SQL query to search for Username is equal in table Customer
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, CON);
            dt.Clear();//clear dt
            sda.Fill(dt);

            if (dt.Rows.Count > 0)//display error message if found
            {
                MessageBox.Show("Username Already Exist, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.SelectAll();
                error++;
                dt.Clear();//clear dt
                return;
            }

            sda.Dispose();
        }


        private void btnQuit_Click(object sender, EventArgs e)//button to close program
        {
            Application.Exit();
        }

        private void BtnBack_MouseHover(object sender, EventArgs e)//Change color when mouse pass through button
        {
            BtnBack.BackColor = Color.FromArgb(71, 57, 200);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) //Click on picturebox Password set to visible
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)//Set back Password to invisible
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtConPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtConPassword.UseSystemPasswordChar = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)//goes back to Login Customer form frmLoginCustomer
        {
            frmLoginCustomer fLC = new frmLoginCustomer();
            fLC.Show();
            this.Hide();
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNIC.Text) && !string.IsNullOrWhiteSpace(txtFirstName.Text) && !string.IsNullOrWhiteSpace(txtLastName.Text)
                  && !string.IsNullOrWhiteSpace(txtAddress.Text) && !string.IsNullOrWhiteSpace(txtDistrict.Text) && !string.IsNullOrWhiteSpace(txtZipCode.Text)
                 && !string.IsNullOrWhiteSpace(txtPhoneNumber.Text) && !string.IsNullOrWhiteSpace(txtUsername.Text)
                  && !string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text) && !string.IsNullOrWhiteSpace(txtConPassword.Text))
            {//Check condition if textboxes is not empty
                error = 0;
                CheckNIC(); //call all functions to check for errors
                CheckPassword();
                CheckZipCode();
                CheckPhoneNumber();
                CheckEmail();
                CheckUsername();

                if (error == 0)
                {
                    SqlConnection con = new SqlConnection(CON);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Customer values (@NIC,@FirstName,@LastName,@Address,@District,@ZipCode,@PhoneNumber,@Email,@CustUsername,@CustPassword)", con);
                    //SQL query to insert values on the Database in table Admin
                    cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@District", txtDistrict.Text);
                    cmd.Parameters.AddWithValue("@ZipCode", txtZipCode.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@CustUsername", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@CustPassword", txtConPassword.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Sucessfully Register");//Show that the insertion is saved

                    Email();

                    frmLoginCustomer fLC = new frmLoginCustomer();//Go back to Login Customer frmLoginCustomer
                    fLC.Show();
                    this.Hide();
                }
            }
            else if (string.IsNullOrWhiteSpace(txtNIC.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text)
                || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtDistrict.Text) || string.IsNullOrWhiteSpace(txtZipCode.Text)
                || string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(txtUsername.Text)
                || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtConPassword.Text))
            {//Condition not met display error message
                MessageBox.Show("Please Complete Registration", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFinish_MouseHover(object sender, EventArgs e)//Change color when mouse pass through button
        {
            BtnFinish.BackColor = Color.FromArgb(71, 57, 200);
        }
        private void Email()
        {
            string name = txtFirstName.Text + " " + txtLastName.Text;
            try
            {
                MailMessage mail = new MailMessage();//Using c# mail service
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("supermarketwinners73@gmail.com");//mail from which message will be sent
                mail.To.Add(txtEmail.Text);
                mail.Subject = "Register as Customer of Winners Supermarket";
                mail.Body = $"Dear {name}, thank you for registering to Winners Supermarket. Here, customer satisfaction is our top priority and we hope that we'll be able to please as well as establish a positive relationship.";

                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Host = "smtp.gmail.com";//Here we are using gmail as the host
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("supermarketwinners73@gmail.com", "winners1234");
                SmtpServer.EnableSsl = true;
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;//we are using simple mail transfer protocol as delivery method

                SmtpServer.Send(mail);
                MessageBox.Show("Mail Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show("");
            }

        }
    }
}
