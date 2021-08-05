using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
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
    public partial class frmOrderCustomer : Form
    {

        string CON = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Supermarket.mdf;Integrated Security=True;Connect Timeout=30"; //Data Connection String of the Database
        string sqlStr = "SELECT * FROM Product";//Sql query to view all data in table Product
        string sqlStr1 = "SELECT * FROM Customer";//Sql query to view all data in table Customer
        string sqlStr2 = "SELECT * FROM [Order]"; //Sql query to view all data in table Order
        DataTable dt = new DataTable();  //create a DataTable for Order
        DataTable dt1 = new DataTable();//create a DataTable for Product
        List<string> items = new List<string>(); //create 2 list
        List<string> prices = new List<string>();

        int inc = 0, error = 0;                                          //initialize a index
        double subtotal = 0, vat = 0, total = 0;  
        
        public frmOrderCustomer()
        {
            InitializeComponent();
        }

        private void UpdateToBox() //Function to set textboxes the data of the table Customer at row inc(index)
        {
            txtCustUsername.Text = dt1.Rows[inc]["CustUsername"].ToString();
            txtFirstName.Text = dt1.Rows[inc]["FirstName"].ToString();
            txtLastName.Text = dt1.Rows[inc]["LastName"].ToString();
            txtAddress.Text = dt1.Rows[inc]["Address"].ToString();
            txtNIC.Text = dt1.Rows[inc]["NIC"].ToString();
            txtContactNumber.Text = dt1.Rows[inc]["PhoneNumber"].ToString();
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)//button to find if Customer is found in the table Customer
        {
            string CustUsername = txtCustUsername.Text;                   //initialize CustUsername
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr1, CON);        //setup the connection
            sda.Fill(dt1);
            bool found = false;

            for (int i = 0; i <= dt1.Rows.Count - 1; i++)                //loop through the table Customer to find Customer Username is equal to the textbox CustUsername
            {
                if (dt1.Rows[i]["CustUsername"].Equals(CustUsername))     //set found to true and call function UpToBox to set up the textboxes
                {
                    found = true;
                    inc = i;
                    UpdateToBox();
                }
            }
            if (!found)                                                //display error message if not found
                MessageBox.Show($"Invalid Username {CustUsername}, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void UpdateToBox2() //Function to set textboxes the data of the table Product at row inc(index)
        {
            txtProductID.Text = dt.Rows[inc]["ProductID"].ToString();
            txtPName.Text = dt.Rows[inc]["ProductName"].ToString();
            txtUnit.Text = dt.Rows[inc]["Price"].ToString();
        }
        private void PopulateListBox(string category)  //function to add item in Product table by their Product Name in listbox lstProduct
        {
            DataTable dt = new DataTable();            //create DataTable
            string query = $"SELECT ProductName FROM Product WHERE Category='{category}'"; //SQL query to search Product Name with category = cmbCategory
            SqlDataAdapter sda = new SqlDataAdapter(query, CON);  //setup connection
            sda.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)                                //loop through Product table and add to listbox lstProduct
            {
                lstProduct.Items.Add(dt.Rows[i]["ProductName"].ToString());

            }
        }
        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)  //Select Item in listbox lstProduct 
        {
            string productname = lstProduct.Text;
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, CON); //setup connection
            sda.Fill(dt);

            for (int i = 0; i <= dt.Rows.Count - 1; i++)   //loop through the table Customer to find Customer Username is equal to the textbox CustUsername
            {
                if (dt.Rows[i]["ProductName"].Equals(productname))   //all function UpToBox2 to set up the textboxes
                {
                    inc = i;
                    UpdateToBox2();
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e) //button to add to datagridview dvgCart
        {
            int quantity = int.Parse(txtQuantity.Text);  //initialize quantity
            try
            {
                txtQuantity.Text = quantity.ToString();  //allow quantity
            }
            catch
            {
                if (quantity == 0) //quantity equal zero set to 1
                {
                    MessageBox.Show("Quantity has been set to 1");
                    quantity = 1;
                }
            }
            double total1;

            if (!string.IsNullOrWhiteSpace(txtTotalPrice.Text)) //check if textbox txtTotalPrice is not empty
            {
                double.TryParse(txtTotalPrice.Text, out total1); 
                subtotal += total1;                               //add the price of the product
                txtSubTotal.Text = $"Rs {subtotal}";
                dvgCart.Rows.Add(txtPName.Text, txtQuantity.Text, txtTotalPrice.Text); //add to datagridview Cart
                items.Add($"{txtQuantity.Text}x{txtPName.Text}");
                prices.Add($"{txtTotalPrice.Text}");
            }
            else
            {
                MessageBox.Show("An unexpected error happened, please contact Winners!"); //display error message 
            }
            Quantity(); //call function Quantity to check quantity
            labelQuantity(); //call function labelQuantity to calculate total quantity brought
        }

        private void btnGenerateBilling_Click(object sender, EventArgs e)//button generate billing and insert data in Order table
        {
            try
            {
                error = 0;
                CheckOrderID(); //call function CheckOrderID to check duplication in OrderID 

                if (error == 0)//process if no error found
                {

                    SqlConnection con = new SqlConnection(CON); //set up connection
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into [Order] values (@OrderID,@FirstName,@LastName,@Address,@NIC,@PhoneNumber,@Payment,@Delivery,@Total,@Completed)", con);//SQL query to insert data in Order table

                    cmd.Parameters.AddWithValue("@OrderID", txtOrder.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtContactNumber.Text);
                    cmd.Parameters.AddWithValue("@Payment", cmbPayment.Text);
                    cmd.Parameters.AddWithValue("@Delivery", cmbMethod.Text);
                    cmd.Parameters.AddWithValue("@Total", txtTotal.Text);
                    cmd.Parameters.AddWithValue("@Completed", "No");


                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Sucessfully Saved");//message to confirm the insert

                    Pdf(); //call function Pdf to create a pdf for Receipt
                }
            }
            catch
            {
                MessageBox.Show("An unexpected error happened, please contact Winners!");
            }
        }
        private void labelQuantity()
        {
            int totalproduct = 0;
            for (int i = 0; i < dvgCart.Rows.Count - 1; i++)//loop through table Product to count number of quantity
                totalproduct += Convert.ToInt32(dvgCart.Rows[i].Cells[1].Value);

            totalproductid.Text = ($"Total Quantity: {totalproduct}");//display on label
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)//when textbox txtQuantity change value calculate price of product
        {
            try
            {
                int quantity = int.Parse(txtQuantity.Text);
                double unitprice = Convert.ToDouble(txtUnit.Text.Trim());         //convert txtUnit to double
                double total;
                total = unitprice * quantity;              //calculate price of product with unit price and quantity
                txtTotalPrice.Text = total.ToString();
                if (quantity < 1)  //display error message if quantity less than 1
                    MessageBox.Show("Invalid quantity number");

            }
            catch (Exception) //catch a exception display error message
            {
                MessageBox.Show("Invalid quantity number");
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)//when combolist cmbCategory change value the listbox lstProduct changes items 
        {
            lstProduct.Items.Clear();                            //clear listbox from previous items
            PopulateListBox((string)cmbCategory.SelectedItem);   //call function PopulateLstBox with arguement cmbCategory to add items in listbox lstProduct
        }

        private void btnDelete_Click(object sender, EventArgs e)  //Delete selected row in datagridview dvgCart
        {
            if (this.dvgCart.SelectedRows.Count > 0)    //Check whether selected row index is greater than 0
            {
                dvgCart.Rows.RemoveAt(this.dvgCart.SelectedRows[0].Index);
            }
            double TotalPrice = double.Parse(txtTotalPrice.Text); //decrease the totalprice due to removal of item
            subtotal = -TotalPrice;
        }
        private void btnCalculate_Click(object sender, EventArgs e) //button to calculate the VAT and Grand Total in the Cart
        {
            vat = subtotal * 0.15;
            total = subtotal + vat;

            txtVAT.Text = $"Rs {vat}";
            txtTotal.Text = $"Rs {total}";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmOrderCustomer_Load(object sender, EventArgs e)
        {
            dt1.Clear();
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr2, CON); //setup connection
            sda.Fill(dt1);
            int num = dt1.Rows.Count;
           int order = num + 1;
            txtOrder.Text = $"O{order}";
        }

        private void txtPName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantity() //function to decrease quantity in the table Product or in form Stock
        {
            string id = txtProductID.Text;
            int quantity = int.Parse(txtQuantity.Text);
            int num = 0;
            for (int i = 0; i < dt.Rows.Count - 1; i++) //loop through the table Product in the database
            {
                if (dt.Rows[i]["ProductID"].ToString() == id)  //check if ProductID is equal to added item
                {
                    num = ((int.Parse(dt.Rows[i]["Quantity"].ToString()) - quantity)); //decrease the quantity order in table Product

                    SqlConnection con = new SqlConnection(CON); //set up connection
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Product set ProductName=@ProductName,Quantity=@Quantity,Price=@Price where ProductID=@ProductID", con); //SQL query to update the new quantity in table Product

                    cmd.Parameters.AddWithValue("ProductID", txtProductID.Text);
                    cmd.Parameters.AddWithValue("@ProductName", txtPName.Text);
                    cmd.Parameters.AddWithValue("@Quantity", num);
                    cmd.Parameters.AddWithValue("@Price", txtUnit.Text);


                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
        }
        private void CheckOrderID()//function to check OrderID duplication
        {
            string sqlquery2 = "SELECT * From [Order] WHERE OrderID = '" + txtOrder.Text + "'"; //sql query to search OrderID is equal in the table Order
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery2, CON);   //setup Connection
            dt.Clear(); //clear dt
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("OrderID Already Exist, Retry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOrder.SelectAll();
                dt.Clear();
                error++;
                return;  
            }
        }
        private void Pdf()
        {
            PdfWriter writer = new PdfWriter($"C:\\Receipt{txtOrder.Text}.pdf"); //here we are creating a new pdf file
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            iText.Kernel.Colors.Color fontColor = new DeviceRgb(132, 132, 130);
            PdfFont fontTitle = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Paragraph title = new Paragraph("Winners")
               .SetFontColor(fontColor)
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(15).SetFont(fontTitle).SetMarginBottom(5);


            LineSeparator ls = new LineSeparator(new SolidLine()); //line separators for formatting
            ls.SetMarginLeft(202);
            ls.SetMaxWidth(120);
            ls.SetMarginBottom(25);

            Paragraph thankmsg = new Paragraph("Thank you for choosing us !").SetFontColor(fontColor).SetTextAlignment(TextAlignment.CENTER).SetFontSize(18).SetFont(font).SetMarginBottom(20);
            Paragraph thankmsg2 = new Paragraph($"Dear {txtFirstName.Text} {txtLastName.Text}, your order has successfully been processed. Below are the necessary details of your order. Thank you for buying with us, we hope to see you again !").SetFontColor(fontColor).SetTextAlignment(TextAlignment.LEFT).SetFontSize(11).SetFont(font).SetMarginBottom(20);

            Paragraph order = new Paragraph($"Order ID: {txtOrder.Text}").SetFontColor(ColorConstants.DARK_GRAY).SetTextAlignment(TextAlignment.RIGHT).SetFontSize(10).SetFont(fontTitle);
            Paragraph shippingAddress = new Paragraph($"Shipping Address: {txtAddress.Text}").SetFontColor(ColorConstants.DARK_GRAY).SetTextAlignment(TextAlignment.RIGHT).SetFontSize(10).SetFont(fontTitle);
            Paragraph number = new Paragraph($"Phone Number: {txtContactNumber.Text}").SetFontColor(ColorConstants.DARK_GRAY).SetTextAlignment(TextAlignment.RIGHT).SetFontSize(10).SetFont(fontTitle).SetMarginBottom(20);
            Paragraph summary = new Paragraph("Summary").SetFontColor(fontColor).SetTextAlignment(TextAlignment.CENTER).SetFontSize(18).SetFont(font).SetMarginBottom(40);


            document.Add(title); //Elements are not added in the pdf until the .Add function is called with the particular element as argument
            document.Add(ls);
            document.Add(thankmsg);
            document.Add(thankmsg2);
            document.Add(order);
            document.Add(shippingAddress);
            document.Add(number);
            document.Add(new LineSeparator(new SolidLine()).SetMarginBottom(20));
            document.Add(summary);

            for (int i = 0; i < items.Count; i++) //Here we stored the items and prices in a list and we are looping through the list to write all items ordered and their respective prices to the pdf
            {
                Paragraph price = new Paragraph($"{prices[i]}").SetFontColor(fontColor).SetTextAlignment(TextAlignment.CENTER).SetFontSize(12).SetFont(font).SetMarginLeft(20);
                Paragraph item = new Paragraph($"{items[i]}").SetFontColor(fontColor).SetTextAlignment(TextAlignment.CENTER).SetFontSize(12).SetFont(font).SetMarginBottom(10);
                item.Add(new Tab());
                item.AddTabStops(new TabStop(1000, iText.Layout.Properties.TabAlignment.RIGHT));
                item.Add(price);
                document.Add(item);
            }



            Paragraph vat = new Paragraph($"15% vat").SetFontColor(fontColor).SetTextAlignment(TextAlignment.LEFT).SetFontSize(12).SetFont(font);
            Paragraph vatPrice = new Paragraph($"{txtVAT.Text}").SetFontColor(fontColor).SetTextAlignment(TextAlignment.RIGHT).SetFontSize(12).SetFont(font);
            vat.Add(new Tab());
            vat.AddTabStops(new TabStop(1000, iText.Layout.Properties.TabAlignment.RIGHT)); //Tabs are used if we have two paragraphs but we want it on the same line
            vat.Add(vatPrice);
            document.Add(vat);

            document.Add(new LineSeparator(new SolidLine()).SetMarginBottom(20).SetMarginTop(20));

            Paragraph totalLabel = new Paragraph($"Total").SetFontColor(fontColor).SetTextAlignment(TextAlignment.LEFT).SetFontSize(12).SetFont(font);
            Paragraph totalPrice = new Paragraph($"{txtTotal.Text}").SetFontColor(fontColor).SetTextAlignment(TextAlignment.RIGHT).SetFontSize(12).SetFont(font);
            totalLabel.Add(new Tab());
            totalLabel.AddTabStops(new TabStop(1000, iText.Layout.Properties.TabAlignment.RIGHT));
            totalLabel.Add(totalPrice);
            document.Add(totalLabel);


            document.Close();

            MessageBox.Show("Receipt Generated");
        }
    }
}

