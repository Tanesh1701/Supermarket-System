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

namespace Assignment
{ 
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true; //set passowrd in invisible char
            txtConPassword.UseSystemPasswordChar = true;
        }

        string CON = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Supermarket.mdf;Integrated Security=True;Connect Timeout=30";//Data Connection String of the Database
        DataTable dt = new DataTable();//create a Datatable

        int error = 0;      //initialize variable error to check error through the program
        int numLetter = 0;
        int num1Digit = 0;
        int num2Digit = 0;
        int num3Digit = 0;
        int num5Digit = 0;
        string gender = "";

        private void CheckBasicSalary()
        {
            try
            {
              
            }
            catch (Exception)//Invalid string format
            {
                MessageBox.Show("Invalid Basic Salary, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error++;
            }
        }
        private void CheckAge()
        {
            try
            {
                num5Digit = 0;
                foreach (char ch in txtAge.Text)//count the length of Age
                {
                    if (char.IsLetterOrDigit(ch))
                    {
                        num5Digit++;
                    }
                }
                if (!(num5Digit == 2) || (num5Digit ==1))//less than 2 display error message
                {
                    MessageBox.Show("Invalid Age, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error++;
                }
            }
            catch (Exception)//Invalid string format
            {
                MessageBox.Show("Invalid Age, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error++;
            }
        }
        private void CheckPassword()//function to check password
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
                        MessageBox.Show("Weak Password(No Digit or Letter), Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Invalid Password, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error++;
            }
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
                    else //contain a letter display error message
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

        private void CheckAccountNo()//function to check Account Number
        {
            try
            {
                num2Digit = 0;
                foreach (char ch in txtAccountNo.Text)//count the length of Account Number
                {
                    if (char.IsLetterOrDigit(ch))
                    {
                        num2Digit++;
                    }
                }
                if (!(num2Digit == 12))//less than 12 display error message
                {
                    MessageBox.Show("Invalid Account Number, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error++;
                }
            }
            catch (Exception)//Invalid string format
            {
                MessageBox.Show("Invalid Account Number, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error++;
            }
        }
        private void Gender()//function to set Gender
        { 
            if (radioButton1.Checked)
                gender = "Female";
            if (radioButton2.Checked)
                gender = "Male";
        }
        private void CheckUsername()//function to check Username duplication
        {
            string sqlquery = "SELECT AdminUsername From Admin WHERE AdminUsername = '" + txtUsername.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, CON);
            dt.Clear(); //clear dt
            sda.Fill(dt);

            if (dt.Rows.Count > 0) //display error message if found
            {
                MessageBox.Show("Username Already Exist, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.SelectAll();
                error++;
                dt.Clear();
                return;
            }

            sda.Dispose();
        }
        private void CheckStaffID()//function to check StaffID duplication
        {
            num3Digit = 0;
            foreach (char ch in txtStaffID.Text)//count the length of Account Number
            {
                if (char.IsLetterOrDigit(ch))
                {
                    num3Digit++;
                }
            }
            if (!(num3Digit == 4))//less than 4 display error message
            {
                MessageBox.Show("Invalid Staff ID, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error++;
            }
            string sqlquery2 = "SELECT * From Admin WHERE StaffID = '" + txtStaffID.Text + "'"; //sql query to check StaffID is found in table Admin
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery2, CON);
            dt.Clear(); //clear dt
            sda.Fill(dt);

            if (dt.Rows.Count > 0)//display error message if found
            {
                MessageBox.Show("StaffID Already Exist, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStaffID.SelectAll();
                error++;
                dt.Clear();
                return;
            }
        }

        private void pboxShowPassoword1_MouseDown(object sender, MouseEventArgs e)//Click on picturebox Password set to visible
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pboxShowPassoword1_MouseUp(object sender, MouseEventArgs e)//Set back Password to invisible
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        private void pboxShowPassoword2_MouseDown(object sender, MouseEventArgs e)
        {
            txtConPassword.UseSystemPasswordChar = false;
        }

        private void pboxShowPassoword2_MouseUp(object sender, MouseEventArgs e)
        {
            txtConPassword.UseSystemPasswordChar = true;
        }

        private void BtnAddEmployee_MouseHover(object sender, EventArgs e)//Change color when mouse pass through button
        {
            BtnAddEmployee.BackColor = Color.FromArgb(71, 57, 200);
        }


        private void btnBack_MouseHover(object sender, EventArgs e)//Change color when mouse pass through button
        {
            btnBack.BackColor = Color.FromArgb(71, 57, 200);
        }

        private void btnBack_Click(object sender, EventArgs e)//goes back to Staff form
        {
            Panel panel = this.Parent as Panel; //access parent panel 

            if (panel != null) //if condition to ensure that the panel exists
            {
                frmStaff staff = new frmStaff();
                staff.TopMost = true;
                staff.TopLevel = false;
                panel.Controls.Add(staff);
                staff.Show();
                this.Close();
            }
        }

        private void BtnAddEmployee_Click_1(object sender, EventArgs e)
        {
          
            if (!string.IsNullOrWhiteSpace(txtAccountNo.Text) && !string.IsNullOrWhiteSpace(txtFirstName.Text) && !string.IsNullOrWhiteSpace(txtLastName.Text)
                  && !string.IsNullOrWhiteSpace(txtAddress.Text) && !string.IsNullOrWhiteSpace(txtJob.Text) && !string.IsNullOrWhiteSpace(txtAge.Text)
                 && !string.IsNullOrWhiteSpace(txtPhoneNumber.Text) && !string.IsNullOrWhiteSpace(txtBasicSalary.Text) && !string.IsNullOrWhiteSpace(txtStaffID.Text)
                  && !string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text) && !string.IsNullOrWhiteSpace(txtConPassword.Text))
            {//Check condition if textboxes is not empty
                error = 0;
                CheckAccountNo();//call all functions to check for errors
                CheckPassword();
                CheckPhoneNumber();
                CheckUsername();
                CheckStaffID();
                CheckBasicSalary();
                CheckAge();
                Gender();
                try
                {
                    if (error == 0) //process if no error found
                    {
                        SqlConnection con = new SqlConnection(CON);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Admin values (@StaffID,@FirstName,@LastName,@Address,@AccountNo,@PhoneNumber,@Post,@BasicSalary,@AdminUsername,@AdminPassword,@Gender,@Age)", con);
                        //Code to add value on the Database in table Admin
                        cmd.Parameters.AddWithValue("@StaffID", txtStaffID.Text);
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@AccountNo", txtAccountNo.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@Post", txtJob.Text);
                        cmd.Parameters.AddWithValue("@BasicSalary", txtBasicSalary.Text);
                        cmd.Parameters.AddWithValue("@AdminUsername", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@AdminPassword", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Age", txtAge.Text);

                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Sucessfully Saved");//Show that the insertion is saved

                        //Clear all textboxes
                        txtStaffID.Clear();
                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtAddress.Clear();
                        txtAge.Clear();
                        txtAccountNo.Clear();
                        txtPhoneNumber.Clear();
                        txtJob.Clear();
                        txtBasicSalary.Clear();
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtConPassword.Clear();

                        Panel panel = this.Parent as Panel; //access parent panel 

                        if (panel != null) //if condition to ensure that the panel exists
                        {
                            frmStaff staff = new frmStaff();
                            staff.TopMost = true;
                            staff.TopLevel = false;
                            panel.Controls.Add(staff);
                            staff.Show();
                            this.Close();
                        }
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("An error has occured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (string.IsNullOrWhiteSpace(txtAccountNo.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text)
                || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtJob.Text) || string.IsNullOrWhiteSpace(txtAge.Text)
                || string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(txtBasicSalary.Text) || string.IsNullOrWhiteSpace(txtStaffID.Text)
                || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtConPassword.Text))
            {//Condition not met display error message
                MessageBox.Show("Please Complete Registration", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
