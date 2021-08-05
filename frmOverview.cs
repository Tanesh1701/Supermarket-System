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
    public partial class frmOverview : Form
    {
        public frmOverview()
        {
            InitializeComponent();
        }
        string CON = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Supermarket.mdf;Integrated Security=True;Connect Timeout=30";//Data Connection String of the Database
        string sqlStr = "SELECT * FROM Product";//Sql query to view all data in table Product
        string sqlStr1 = "SELECT * FROM Admin";//Sql query to view all data in table Admin
        string sqlStr2 = "SELECT * FROM Customer";//Sql query to view all data in table Customer
        string sqlStr3 = "SELECT * FROM [Order]";//Sql query to view all data in table Order
        DataTable dt = new DataTable();//create a DataTable
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        private void frmOverview_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, CON);//setup connection
            sda.Fill(dt); 
            int totalproduct = dt.Rows.Count; //count the number of product
            lblProduct.Text = totalproduct.ToString();//display on label

            SqlDataAdapter sdb = new SqlDataAdapter(sqlStr1, CON);//setup connection
            sdb.Fill(dt1); 
            int totalEmployee = dt1.Rows.Count; //count the number of employee
            employeeslbl.Text = totalEmployee.ToString();//display on label

            SqlDataAdapter sdc = new SqlDataAdapter(sqlStr2, CON);//setup connection
            sdc.Fill(dt2); 
            int totalCustomer = dt2.Rows.Count; //count the number of product
            customerslbl.Text = totalCustomer.ToString();//display on label

            SqlDataAdapter sdd = new SqlDataAdapter(sqlStr3, CON);//setup connection
            sdd.Fill(dt3); 
            int totalOrder = dt3.Rows.Count; //count the number of product
            lblOrders.Text = totalOrder.ToString();//display on label

            Chart();
            Quantity();
        }
        private void Chart()//Display Bar Chart for Quantity less than 100
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, CON);//setup connection
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count-1; i++)
            {
                if (int.Parse(dt.Rows[i]["Quantity"].ToString()) < 100)
                {
                    string productname = dt.Rows[i]["ProductName"].ToString();
                    int quantity = int.Parse(dt.Rows[i]["Quantity"].ToString());

                    this.chart1.Series["Quantity %"].Points.AddXY(productname, quantity);
                }
            }
        }
        private void Quantity()//Count the quantity of products in table Product
        {
            dt.Clear();
            int num = 0;
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, CON);//setup connection
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {

                int quantity = int.Parse(dt.Rows[i]["Quantity"].ToString());
                num += quantity;

            }
            lblQuantity.Text = num.ToString();
        }
    }
}
