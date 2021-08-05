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

namespace Assignment
{
    public partial class frmUpdateEmployee : Form
    {
        public frmUpdateEmployee()
        {
            InitializeComponent();
        }
        string CON = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Supermarket.mdf;Integrated Security=True;Connect Timeout=30";//Data Connection String of the Database
        string sqlStr = "SELECT * FROM Admin";//Sql query to view all data in table Admin
        DataTable dt = new DataTable();//create Datatable
        int inc = 0; //initialize a index

        int error = 0;  //initialize variable error to check error through the program
        int num1Digit = 0;
        int num2Digit = 0;
        int num3Digit = 0;

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
                num3Digit = 0;
                foreach (char ch in txtAge.Text)//count the length of Age
                {
                    if (char.IsLetterOrDigit(ch))
                    {
                        num3Digit++;
                    }
                }
                if (!(num3Digit == 2) || (num3Digit == 1))//less than 2 display error message
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
        private void CheckPhoneNumber()//function to check Phone Number
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
        private void NavigateRecords()//Function to set textboxes the data of the table Admin at row inc(index)
        {
            txtStaffID.Text = dt.Rows[inc]["StaffID"].ToString();
            txtFirstName.Text = dt.Rows[inc]["FirstName"].ToString();
            txtLastName.Text = dt.Rows[inc]["LastName"].ToString();
            txtAddress.Text = dt.Rows[inc]["Address"].ToString();
            txtPhoneNumber.Text = dt.Rows[inc]["PhoneNumber"].ToString();
            txtAccountNo.Text = dt.Rows[inc]["AccountNo"].ToString();
            txtJob.Text = dt.Rows[inc]["Post"].ToString();
            txtBasicSalary.Text = dt.Rows[inc]["BasicSalaary"].ToString();
            txtAge.Text = dt.Rows[inc]["Age"].ToString();
        }

        private void frmUpdateEmployee_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, CON);   //call the sql string and database connection string
            sda.Fill(dt);
            sda.Dispose();
            NavigateRecords();                                      //call function NavigateRecords
        }

        private void ClearBtn_Click(object sender, EventArgs e)  //button to clear all textboxes
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtStaffID.Clear();
            txtPhoneNumber.Clear();
            txtJob.Clear();
            txtBasicSalary.Clear();
            txtAge.Clear();
            txtAccountNo.Clear();
        }

        private void btnBackStaff_Click(object sender, EventArgs e) //goes back to Staff form
        {
            Panel panel = this.Parent as Panel; //access parent panel 

            if (panel != null)
            {
                frmStaff staff = new frmStaff();
                staff.TopMost = true;
                staff.TopLevel = false;
                panel.Controls.Add(staff);
                staff.Show();
                this.Close();
            }
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)//button update in table Admin
        {
            if (!string.IsNullOrWhiteSpace(txtAccountNo.Text) && !string.IsNullOrWhiteSpace(txtFirstName.Text) && !string.IsNullOrWhiteSpace(txtLastName.Text)
                  && !string.IsNullOrWhiteSpace(txtAddress.Text) && !string.IsNullOrWhiteSpace(txtJob.Text) && !string.IsNullOrWhiteSpace(txtAge.Text)
                 && !string.IsNullOrWhiteSpace(txtPhoneNumber.Text) && !string.IsNullOrWhiteSpace(txtBasicSalary.Text) && !string.IsNullOrWhiteSpace(txtStaffID.Text))
            { //Check condition if textboxes is not empty
                    error = 0;
                    CheckAccountNo();//call all functions to check for errors
                    CheckPhoneNumber();
                CheckAge();
                CheckBasicSalary();

                if (error == 0)//process if no error found
                {
                    SqlConnection con = new SqlConnection(CON);//setup connection
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Admin set FirstName=@FirstName,LastName=@LastName,Address=@Address,AccountNo=@AccountNo,PhoneNumber=@PhoneNumber,Post=@Post,BasicSalaary=@BasicSaalary,Age=@Age where StaffID=@StaffID", con);
                    //SQL query to update Admin table
                    cmd.Parameters.AddWithValue("@StaffID", txtStaffID.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@AccountNo", txtAccountNo.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Post", txtJob.Text);
                    cmd.Parameters.AddWithValue("@BasicSaalary", txtBasicSalary.Text);
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Sucessfully Updated");//message to confirm update
                }
            }
            else if (string.IsNullOrWhiteSpace(txtAccountNo.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text)
                || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtJob.Text) || string.IsNullOrWhiteSpace(txtAge.Text)
                || string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(txtBasicSalary.Text) || string.IsNullOrWhiteSpace(txtStaffID.Text))
                 {//Condition not met display error message
                MessageBox.Show("Please Complete Registration", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
        }

        private void btnDeleteDetails_Click(object sender, EventArgs e) //Delete record from table Admin
        {
            SqlConnection con = new SqlConnection(CON); //setup the connection
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Admin where StaffID=@StaffID", con); //the SQL query to delete row
            cmd.Parameters.AddWithValue("@StaffID", txtStaffID.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@AccountNo", txtAccountNo.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@Post", txtJob.Text);
            cmd.Parameters.AddWithValue("@BasicSaalary", txtBasicSalary.Text);
            cmd.Parameters.AddWithValue("@Age", txtAge.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sucessfully Deleted"); //message to confirm the delete

            txtStaffID.Clear();//clear all textboxes
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtAccountNo.Clear();
            txtPhoneNumber.Clear();
            txtJob.Clear();
            txtBasicSalary.Clear();
            txtAge.Clear();
        }

        private void FirstButton_Click(object sender, EventArgs e)//navigate through records (go to the first record)
        {
            inc = 0;
            NavigateRecords();
        }

        private void PreviousButton_Click(object sender, EventArgs e)//navigate through records (go to the previous record)
        {
            if (inc > 0)
                inc--;
            NavigateRecords();
        }

        private void NextButton_Click(object sender, EventArgs e)//navigate through records (go to the next record)
        {
            if (inc < dt.Rows.Count - 1)
                inc++;
            NavigateRecords();
        }

        private void LastButton_Click(object sender, EventArgs e)//navigate through records (go to the last record)
        {
            inc = dt.Rows.Count - 1;
            NavigateRecords();
        }
    }
}
