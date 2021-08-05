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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }
        string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Supermarket.mdf;Integrated Security=True;Connect Timeout=30";//Data Connection String of the Database
        string sqlStr = "Select LastName,FirstName,StaffID,PhoneNumber,Post,Gender From Admin Order By StaffID ASC";//Sql query to view some data in table Admin in order
        DataTable dt = new DataTable();  //create a DataTable

        private void GoToAddEmployeeBtn_Click(object sender, EventArgs e) //button to go frmAddEmployee form add employee
        {
            Panel panel = this.Parent as Panel; //access parent panel 

            if (panel != null)
            {
                frmAddEmployee newEmployee = new frmAddEmployee();
                newEmployee.TopMost = true;
                newEmployee.TopLevel = false;
                panel.Controls.Add(newEmployee);
                newEmployee.Show();
                this.Close();
            }
        }

        private void noemployeeslbl_Click(object sender, EventArgs e)
        {
          
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr); //setup connection
            sda.Fill(dt);
            dgvStaff.DataSource = dt; //load database in datagridview dvgStaff
            sda.Dispose();
            dgvStaff.ClearSelection();
            int num = dt.Rows.Count;       //count the number of employees
            noemployeeslbl.Text = ($"Total: {num} Employees"); //display on label
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e) //button to go frmUpdateEmployee form update employee
        {
            Panel panel = this.Parent as Panel; //access parent panel 

            if (panel != null)
            {
                frmUpdateEmployee updateEmployee = new frmUpdateEmployee();
                updateEmployee.TopMost = true;
                updateEmployee.TopLevel = false;
                panel.Controls.Add(updateEmployee);
                updateEmployee.Show();
                this.Close();
            }
        }

        private void btnFindCustomer_Click(object sender, EventArgs e) //button to search employee
        {
            if (dt.Rows.Count > 0) //check if database contain the search employee
            {
                if (!string.IsNullOrEmpty(txtFirstName.Text))//check if textbox first name is empty
                    UpdateGrid("SELECT  LastName,FirstName,StaffID,PhoneNumber,Post,Gender From Admin WHERE FirstName like '%" + txtFirstName.Text.ToString() + "%'");//SQL Query to display data where first name is equal to textbox by calling function updategrid

                if (!string.IsNullOrEmpty(txtLastName.Text))//check if textbox last name is empty
                    UpdateGrid("SELECT  LastName,FirstName,StaffID,PhoneNumber,Post,Gender From Admin WHERE LastName like '%" + txtLastName.Text.ToString() + "%'");//SQL Query to display data where last name is equal to textbox by calling function updategrid

                if (!string.IsNullOrEmpty(txtPost.Text))//check if textbox post is empty
                    UpdateGrid("SELECT LastName,FirstName,StaffID,PhoneNumber,Post,Gender From Admin WHERE Post like '%" + txtPost.Text.ToString() + "%'");//SQL Query to display data where post is equal to textbox by calling function updategrid
            }

        }
        private void UpdateGrid(string sqlStr)//function updategrib with parameter SQL query
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);//setup connection
            DataTable dt = new DataTable();//create Datatable
            sda.Fill(dt);
            if (dt.Rows.Count == 0)//not found on the database display error message
                MessageBox.Show("Staff not found");
            else
                dgvStaff.DataSource = dt;
            sda.Dispose();
        }

    }
}
