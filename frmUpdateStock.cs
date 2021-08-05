using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class frmUpdateStock : Form
    {
        public frmUpdateStock()
        {
            InitializeComponent();
        }
        string CON = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Supermarket.mdf;Integrated Security=True;Connect Timeout=30";//Data Connection String of the Database
        string sqlStr = "SELECT * FROM Product";//Sql query to view all data in table Product
        DataTable dt = new DataTable();//create Datatable
        int inc = 0; //initialize a index

        int error = 0; //initialize variable error to check error through the program
        private void CheckPrice()//function to check price
        {
            try
            {
                double price = double.Parse(txtPrice.Text);
                if (price < 0)//display error message when price less than zero
                {
                    MessageBox.Show("Invalid Amount Enter, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error++;
                }
            }
            catch (Exception)//Invalid string format
            {
                MessageBox.Show("Invalid Amount Enter, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error++;
            }
        }
        private void CheckQuantity()//function to check quantity
        {
            try
            {
                double quantity = double.Parse(txtQuan.Text);
                if (quantity < 0)//display error message when quantity less than zero
                {
                    MessageBox.Show("Invalid Quantity Enter, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error++;
                }
            }
            catch (Exception)//Invalid string format
            {
                MessageBox.Show("Invalid Quantity Enter, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error++;
            }
        }
        private void NavigateRecords()//Function to set textboxes the data of the table Product at row inc(index)
        {
            txtProduct.Text = dt.Rows[inc]["ProductID"].ToString();
            txtProductName.Text = dt.Rows[inc]["ProductName"].ToString();
            txtQuan.Text = dt.Rows[inc]["Quantity"].ToString();
            txtPrice.Text = dt.Rows[inc]["Price"].ToString();
            txtSupplierName.Text = dt.Rows[inc]["SupplierName"].ToString();
            txtStatus.Text = dt.Rows[inc]["Status"].ToString();
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)//button update in table Product
        {
            if (!string.IsNullOrWhiteSpace(txtProduct.Text) && !string.IsNullOrWhiteSpace(txtProductName.Text) && !string.IsNullOrWhiteSpace(txtQuan.Text)
                && !string.IsNullOrWhiteSpace(txtPrice.Text) && !string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {//Check condition if textboxes is not empty
                error = 0;
                CheckPrice();//call all functions to check for errors
                CheckQuantity();

                if (error == 0)
                {
                    SqlConnection con = new SqlConnection(CON);//setup connection
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Product set ProductName=@ProductName,Quantity=@Quantity,Price=@Price,SupplierName=@SupplierName,Status=@Status where ProductID=@ProductID", con);
                    //SQL query to update Product table
                    cmd.Parameters.AddWithValue("ProductID", txtProduct.Text);
                    cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@Quantity", txtQuan.Text);
                    cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
                    cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@SupplierName", txtSupplierName.Text);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Sucessfully Updated");//message to confirm update

                }
                Panel panel = this.Parent as Panel; //access parent panel 

                if (panel != null)
                {
                    frmStock stock = new frmStock();
                    stock.TopMost = true;
                    stock.TopLevel = false;
                    panel.Controls.Add(stock);
                    stock.Show();
                    this.Close();
                }
            }
            else if (string.IsNullOrWhiteSpace(txtProduct.Text) || string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(txtQuan.Text)
                || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {//Condition not met display error message
                MessageBox.Show("Please Complete  Modification", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnBackStaff_Click(object sender, EventArgs e) //goes back Stock form
        {
            Panel panel = this.Parent as Panel; //access parent panel 

            if (panel != null)
            {
                frmStock stock = new frmStock();
                stock.TopMost = true;
                stock.TopLevel = false;
                panel.Controls.Add(stock);
                stock.Show();
                this.Close();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)//button to clear all textboxes
        {
            txtProduct.Clear();
            txtProductName.Clear();
            txtQuan.Clear();
            txtPrice.Clear();
            txtSupplierName.Clear();
        }

        private void btnDeleteDetails_Click(object sender, EventArgs e)//Delete record from table Product
        {
            SqlConnection con = new SqlConnection(CON);//setup the connection
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Product where ProductID=@ProductID", con);//the SQL query to delete row
            cmd.Parameters.AddWithValue("ProductID", txtProduct.Text);
            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtQuan.Text);
            cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@SupplierName", txtSupplierName.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sucessfully Deleted"); //message to confirm the delete

            Panel panel = this.Parent as Panel; //access parent panel 

            if (panel != null)
            {
                frmStock stock = new frmStock();
                stock.TopMost = true;
                stock.TopLevel = false;
                panel.Controls.Add(stock);
                stock.Show();
                this.Close();
            }
        }

        private void frmUpdateStock_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, CON);//call the sql string and database connection string
            sda.Fill(dt);
            sda.Dispose();
            NavigateRecords();                                    //call function NavigateRecords
        }
    }
}
