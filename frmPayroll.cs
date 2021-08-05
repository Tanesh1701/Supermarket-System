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
using OfficeOpenXml;
using System.IO;

namespace Assignment
{
    public partial class frmPayroll : Form
    {
        string fmtStr = "{0,-5}{1,-25}{2,-20}{3,-15}{4,-20}"; //string format for listbox lstPayroll
        int inc = 0, error = 0;
        public frmPayroll()
        {
            InitializeComponent();
            lstSalary.Items.Add(String.Format(fmtStr, "ID", "Staff Name", "Total Net Pay", "Basic Salary", "Absences")); //initializa header for listbox lstPayroll
        }
        string CON = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Supermarket.mdf;Integrated Security=True;Connect Timeout=30";//Data Connection String of the Database
        string sqlStr = "SELECT * FROM Payroll";//Sql query to view all data in table Payroll
        string sqlStr1 = "SELECT * FROM Admin";//Sql query to view all data in table Admin
        DataTable dt1 = new DataTable(); //create a DataTable for Admin
        DataTable dt = new DataTable(); //create a DataTable for Payroll
        class Payroll //create class Payroll
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string StaffID { get; set; }
            public string Date { get; set; }
            public int Absences { get; set; }
            public double Transport { get; set; }
            public double BasicSalary { get; set; }
            public double Bonus { get; set; }

            public double TotalNetPay() //calculate the total net pay of employee
            {
                double total = ((BasicSalary + Transport + Bonus) - (Absences * 200));
                return total;
            }
        }
        List<Payroll> allPayroll = new List<Payroll>(); //create a List

        private void GoToAddEmployeeBtn_Click(object sender, EventArgs e)//button add Payroll of employee in Database and listBox lstSalary
        {
            try
            {
                error = 0;
                CheckPayID();        //call function CheckOrderID to check duplication in OrderID 

                if (error == 0)       //process if no error found
                {
                    Payroll pay = new Payroll();                             //access class Payroll
                    pay.StaffID = txtStaffID.Text;
                    pay.FirstName = txtFirstName.Text;
                    pay.LastName = txtLastName.Text;
                    pay.Transport = double.Parse(txtTransport.Text);
                    pay.Bonus = double.Parse(txtBonus.Text);
                    pay.BasicSalary = double.Parse(txtSalary.Text);
                    pay.Absences = int.Parse(txtAbsences.Text);
                    pay.Date = txtDate.Text;

                    allPayroll.Add(pay);                                      //add to List allPayroll

                    int index = dt.Rows.Count + 1;

                    txtTotal.Text = pay.TotalNetPay().ToString();             //call function to calculate totaln net pay 
                    decimal total = decimal.Parse(txtTotal.Text);

                    SqlConnection con = new SqlConnection(CON);       //setup connection
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Payroll values (@PayID,@StaffID,@Date,@Bonus,@TotalNetPay,@Abscence,@Transport,@BasicSalary)", con);//SQL query to insert data in table Payroll

                    cmd.Parameters.AddWithValue("@PayID", txtPayID.Text);
                    cmd.Parameters.AddWithValue("@StaffID", txtStaffID.Text);
                    cmd.Parameters.AddWithValue("@Date", txtDate.Text);
                    cmd.Parameters.AddWithValue("@Bonus", txtBonus.Text);
                    cmd.Parameters.AddWithValue("@TotalNetPay", total);
                    cmd.Parameters.AddWithValue("@Abscence", txtAbsences.Text);
                    cmd.Parameters.AddWithValue("@Transport", txtTransport.Text);
                    cmd.Parameters.AddWithValue("@BasicSalary", txtSalary.Text);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Sucessfully Saved");//messagebox to confirm data is saved in database

                    string name = pay.FirstName + " " + pay.LastName;  //setup full name
                    lstSalary.Items.Add(String.Format(fmtStr, pay.StaffID, name, total, pay.BasicSalary, pay.Absences));//add items in listbox lstSalary
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Payroll, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         
        }

      private void UpdateToBox() //Function to set textboxes the data of the table Staff at row inc(index)
        {
            txtStaffID.Text = dt1.Rows[inc]["StaffID"].ToString();
            txtFirstName.Text = dt1.Rows[inc]["FirstName"].ToString();  
            txtLastName.Text = dt1.Rows[inc]["LastName"].ToString();
            txtSalary.Text = dt1.Rows[inc]["BasicSalaary"].ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)//button to find if StaffID is found in the table staff
        {
            Payroll pay = new Payroll();                              ///access class Payroll
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr1, CON);  // setup connection
            sda.Fill(dt1);

            pay.StaffID = txtStaffID.Text;                            //access staffID in List
            bool found = false;

            for (int i = 0; i <= dt1.Rows.Count - 1; i++)          //loop through the table Staff to find Customer StaffID is equal to the textbox staffID
            {
                if (dt1.Rows[i]["StaffID"].Equals(pay.StaffID))     //set found to true and call function UpToBox to set up the textboxes
                {
                    found = true;
                    inc = i;
                    UpdateToBox();
                }
            }
            if (!found)                                             //display error message if not found
                MessageBox.Show($"Invalid StaffID {pay.StaffID}, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void lstSalary_SelectedIndexChanged(object sender, EventArgs e) //show the selected item in the listbox lstSalary on textboxes
        {
            int position = lstSalary.SelectedIndex;  //intialize the selected index in variable position

            if (position > 0) //check if selected index is greater than zero
            {
                Payroll pay = allPayroll[position - 1];
                txtStaffID.Text = pay.StaffID;
                txtFirstName.Text = pay.FirstName;
                txtLastName.Text = pay.LastName;
                txtTransport.Text = pay.Transport.ToString();
                txtBonus.Text= pay.Bonus.ToString();
                txtSalary.Text = pay.BasicSalary.ToString();
                txtAbsences.Text = pay.Absences.ToString();
                txtTotal.Text = pay.TotalNetPay().ToString();
                txtDate.Text = pay.Date.ToString();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)//button to clear all textboxes
        {
            txtStaffID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAbsences.Clear();
            txtSalary.Clear();
            txtBonus.Clear();
            txtTransport.Clear();
            txtDate.Clear();
            txtTotal.Clear();
            txtPayID.Clear();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Payroll pay = new Payroll(); //access class Payroll

            int position = lstSalary.SelectedIndex;  //
            allPayroll.RemoveAt(position - 1);       //delete in List
            lstSalary.Items.RemoveAt(position);      //remove in listbox lstSalary

            txtStaffID.Clear();                //clear all textboxes
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAbsences.Clear();
            txtSalary.Clear();
            txtBonus.Clear();
            txtTransport.Clear();
            txtDate.Clear();
            txtTotal.Clear();
            txtPayID.Clear();

            txtTotal.Text = pay.TotalNetPay().ToString();  //calculate totalnetpay
            decimal total = decimal.Parse(txtTotal.Text);

            SqlConnection con = new SqlConnection(CON);  //setup connection
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Payroll where PayID=@PayID", con); //SQL query to delete row in table Payroll
            cmd.Parameters.AddWithValue("@PayID", txtPayID.Text);
            cmd.Parameters.AddWithValue("@StaffID", txtStaffID.Text);
            cmd.Parameters.AddWithValue("@Date", txtDate.Text);
            cmd.Parameters.AddWithValue("@Bonus", txtBonus.Text);
            cmd.Parameters.AddWithValue("@TotalNetPay", total);
            cmd.Parameters.AddWithValue("@Abscence", txtAbsences.Text);
            cmd.Parameters.AddWithValue("@Transport", txtTransport.Text);
            cmd.Parameters.AddWithValue("@BasicSalary", txtSalary.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sucessfully Deleted");//messagebox to confirm delete
        }
        private void CheckPayID()//function to check PayID duplication
        {
            string sqlquery2 = "SELECT * From Payroll WHERE PayID = '" + txtPayID.Text + "'"; //sql query to search PayID is equal in the table Product
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery2, CON);   //setup Connection
            dt.Clear(); //clear dt
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Transaction Reference Already Exist, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPayID.SelectAll();
                dt.Clear();
                error++;
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, CON); 
            sda.Fill(dt);
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; //here we are specifying that we are not making any profit from the application, hence the non commercial status
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                //Defining some basic properties of the excel file
                excelPackage.Workbook.Properties.Title = "Payroll Of Employees";     
                excelPackage.Workbook.Properties.Subject = "Payroll for employees";
                excelPackage.Workbook.Properties.Created = DateTime.Now;             


                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");

                worksheet.Cells["A1"].LoadFromDataTable(dt, true); // Adding the values of the datatable to the excel file starting from the top left cell(1,1)


                //Saving the excel file
                FileInfo file = new FileInfo($@"C:\Payroll{txtPayID.Text}.xlsx");
                excelPackage.SaveAs(file); 
                MessageBox.Show("Successfully Export to Excel");
            }
        }
    }   
}
   

