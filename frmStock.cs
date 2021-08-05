using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Assignment
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();

        }
        string CON = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Supermarket.mdf;Integrated Security=True;Connect Timeout=30";//Data Connection String of the Database
        string sqlStr = "SELECT ProductID,ProductName,Quantity,Price,SupplierName FROM Product";//Sql query to view all data in table Product
        DataTable dt = new DataTable();//create a DataTable
        int error = 0;  //initialize variable error to check error through the program
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
        private void CheckProductID()//function to check ProductID duplication
        {
            string sqlquery1 = "SELECT * From Product WHERE ProductID = '" + txtProduct.Text + "'"; //sql query to check StaffID is found in table Admin
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery1, CON);
            dt.Clear(); //clear dt
            sda.Fill(dt);

            if (dt.Rows.Count > 0)//display error message if found
            {
                MessageBox.Show("ProductID Already Exist, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProduct.SelectAll();
                error++;
                dt.Clear();
                return;
            }
        }

        private void GoToAddEmployeeBtn_Click(object sender, EventArgs e)
        {
            this.dgvStock.DataSource = null;
            this.dgvStock.Rows.Clear();
            dt.Clear();                        //clear datagridvieew dvgStock

            if (!string.IsNullOrWhiteSpace(txtProduct.Text) && !string.IsNullOrWhiteSpace(txtProductName.Text) && !string.IsNullOrWhiteSpace(txtQuan.Text)
                && !string.IsNullOrWhiteSpace(txtPrice.Text) && !string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {//Check condition if textboxes is not empty
                error = 0;
                CheckPrice();//call all functions to check for errors
                CheckQuantity();
                CheckProductID();
                if (error == 0) //does not contain error insert information on textboxes
                {
                    SqlConnection con = new SqlConnection(CON);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Product values (@ProductID,@ProductName,@Price,@Quantity,@Status,@SupplierName,@Category)", con);
                    //Sql query to insert value on the Database in table Product
                    cmd.Parameters.AddWithValue("ProductID", txtProduct.Text);
                    cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@Quantity", txtQuan.Text);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@SupplierName", txtSupplierName.Text);
                    cmd.Parameters.AddWithValue("@Category", cmbCategory.Text);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Sucessfully Added");//Show that the insertion is saved

                    this.dgvStock.DataSource = null;
                    this.dgvStock.Rows.Clear();        //clear datagridvieew dvgStock

                    SqlDataAdapter sda = new SqlDataAdapter(sqlStr, CON);//setup connection
                    sda.Fill(dt);
                    dgvStock.DataSource = dt;       //load database in datagridview dvgStock

                    int totalproduct = dt.Rows.Count; //count the number of employees
                    lbltotalproduct.Text = ($"Total Number of Products: {totalproduct}");//display on label

                    int totalquantity = 0;
                    for (int i = 0; i < dgvStock.Rows.Count-2; i++) //loop through table Product to count number of quantity
                        totalquantity += Convert.ToInt32(dgvStock.Rows[i].Cells[2].Value); //count the number of employees

                    lbltotalquantity.Text = ($"Total Quantity: {totalquantity}"); //display on label

                    sda.Dispose();

                }
                else if (string.IsNullOrWhiteSpace(txtProduct.Text) || string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(txtQuan.Text)
               || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtSupplierName.Text))
                {//Condition not met display error message
                    MessageBox.Show("Please Complete  Modification", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)//button to clear textboxes and datagridview
        {
            this.dgvStock.DataSource = null;
            this.dgvStock.Rows.Clear();
            dt.Clear();                         //clear datagridview dgvStock

            txtSupplierName.Clear();            //clear textboxes
            txtProduct.Clear();
            txtProductName.Clear();
            txtQuan.Clear();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            this.dgvStock.DataSource = null;
            this.dgvStock.Rows.Clear();
            dt.Clear();                       //clear datagridview dvgStock

            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, CON);//setup connection
            sda.Fill(dt);
            dgvStock.DataSource = dt;  //load database in datagridview dvgStock
            int totalproduct = dt.Rows.Count; //count the number of product
            lbltotalproduct.Text = ($"Total Number of Products: {totalproduct}");//display on label

            int totalquantity = 0;
            for (int i = 0; i < dgvStock.Rows.Count-2; i++)//loop through table Product to count number of quantity
                totalquantity += Convert.ToInt32(dgvStock.Rows[i].Cells[2].Value);

            lbltotalquantity.Text = ($"Total Quantity: {totalquantity}");//display on label
            sda.Dispose();

            Popup();//call function Popup to display notification
        }

        private void btnEdit_Click(object sender, EventArgs e) //button to go frmUpdateStock form update stock
        {
            Panel panel = this.Parent as Panel; //access parent panel 

            if (panel != null)
            {
                frmUpdateStock updateStock = new frmUpdateStock();
                updateStock.TopMost = true;
                updateStock.TopLevel = false;
                panel.Controls.Add(updateStock);
                updateStock.Show();
                this.Close();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, CON);
            sda.Fill(dt);
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; //here we are specifying that we are not making any profit from the application, hence the non commercial status
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                //Defining some basic properties of the excel file
                excelPackage.Workbook.Properties.Title = "Stock for products";
                excelPackage.Workbook.Properties.Subject = "Stock for products";
                excelPackage.Workbook.Properties.Created = DateTime.Now;


                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");

                worksheet.Cells["A1"].LoadFromDataTable(dt, true); // Adding the values of the datatable to the excel file starting from the top left cell(1,1)


                //Saving the excel file
                FileInfo file = new FileInfo(@"C:\Stock.xlsx");
                excelPackage.SaveAs(file);
            }
            MessageBox.Show("Data Successfully Exported");
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)//button to search stock
        {
            if (dt.Rows.Count > 0)//check if database contain the search stock
            {
                if (!string.IsNullOrEmpty(txtProduct.Text))//check if textbox product id is empty
                    UpdateGrid("SELECT ProductID,ProductName,Quantity,Price,SupplierName FROM Product WHERE ProductID = '" + txtProduct.Text.ToString() + "'");//SQL Query to display data where product id is equal to textbox by calling function updategrid

                if (!string.IsNullOrEmpty(txtProductName.Text))//check if textbox product name is empty
                    UpdateGrid("SELECT ProductID,ProductName,Quantity,Price,SupplierName FROM Product WHERE ProductName like '%" + txtProductName.Text.ToString() + "%'");//SQL Query to display data where product name is equal to textbox by calling function updategrid

                if (!string.IsNullOrEmpty(txtPrice.Text))//check if textbox price is empty
                    UpdateGrid("SELECT ProductID,ProductName,Quantity,Price,SupplierName FROM Product WHERE Price = '" + txtPrice.Text.ToString() + "'");//SQL Query to display data where price is equal to textbox by calling function updategrid

                if (!string.IsNullOrEmpty(txtQuan.Text))//check if textbox quantity is empty
                    UpdateGrid("SELECT ProductID,ProductName,Quantity,Price,SupplierName FROM Product WHERE Quantity = '" + txtQuan.Text.ToString() + "'");//SQL Query to display data where quantity is equal to textbox by calling function updategrid

                if (!string.IsNullOrEmpty(txtSupplierName.Text))//check if textbox supplier name is empty
                    UpdateGrid("SELECT ProductID,ProductName,Quantity,Price,SupplierName FROM Product WHERE SupplierName like '%" + txtSupplierName.Text.ToString() + "%'");//SQL Query to display data where supplier name is equal to textbox by calling function updategrid
            }

        }
        private void UpdateGrid(string sqlStr)//function updategrib with parameter SQL query
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, CON);//setup connection
            DataTable dt = new DataTable();//create Datatable
            sda.Fill(dt);
            if (dt.Rows.Count == 0)//not found on the database display error message
                MessageBox.Show("Product not found in Stock");
            else
                dgvStock.DataSource = dt;
            sda.Dispose();
        }
        private void Popup()//function popup notification if low or out of stock
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (int.Parse(dt.Rows[i]["Quantity"].ToString()) <= 20 && int.Parse(dt.Rows[i]["Quantity"].ToString()) > 1)
                {
                    string name = dt.Rows[i]["ProductName"].ToString();
                    PopupNotifier popup = new PopupNotifier();
                    popup.TitleText = "Warning";
                    popup.TitleColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    popup.TitleFont = new System.Drawing.Font("Roboto", 9F);
                    popup.ContentText = $"Product {name} running low on stock!";
                    popup.BodyColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    popup.ContentColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    popup.ContentFont = new System.Drawing.Font("Roboto", 10F);
                    popup.ContentHoverColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    popup.ContentPadding = new Padding(5);
                    popup.TitlePadding = new Padding(5);
                    popup.HeaderColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    popup.Image = Properties.Resources.warning;
                    popup.Popup();
                }
                else if (int.Parse(dt.Rows[i]["Quantity"].ToString()) < 1)
                {
                    string name = dt.Rows[i]["ProductName"].ToString();
                    PopupNotifier popup = new PopupNotifier();
                    popup.TitleText = "Warning";
                    popup.TitleColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    popup.TitleFont = new System.Drawing.Font("Roboto", 9F);
                    popup.ContentText = $"Product {name} is Out Of Stock!";
                    popup.BodyColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    popup.ContentColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    popup.ContentFont = new System.Drawing.Font("Roboto", 10F);
                    popup.ContentHoverColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    popup.ContentPadding = new Padding(5);
                    popup.TitlePadding = new Padding(5);
                    popup.HeaderColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    popup.Image = Properties.Resources.warning;
                    popup.Popup();
                }
            }
        }
    }

}

