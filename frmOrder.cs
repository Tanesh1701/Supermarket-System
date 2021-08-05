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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }
        string CON = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Supermarket.mdf;Integrated Security=True;Connect Timeout=30"; //Data Connection String of the Database
        string sqlStr = "SELECT * FROM [dbo].[Order]";   //Sql query to view all data in table Order
        DataTable dt = new DataTable();  //create a DataTable
        int inc = 0;  //initialize a index
        List<string> items = new List<string>();  //create 2 list
        List<string> prices = new List<string>();
        private void NavigateRecords() //Function to set textboxes the data of the table Order at row inc(index)
        {
            txtOrderId.Text = dt.Rows[inc]["OrderID"].ToString();
            txtNIC.Text = dt.Rows[inc]["NIC"].ToString();
            txtFirstName.Text = dt.Rows[inc]["FirstName"].ToString();
            txtLastName.Text = dt.Rows[inc]["LastName"].ToString();
            txtAddress.Text = dt.Rows[inc]["Address"].ToString();
            txtPhoneNumber.Text = dt.Rows[inc]["PhoneNumber"].ToString();
            txtPrice.Text = dt.Rows[inc]["Total"].ToString();
            txtMethod.Text = dt.Rows[inc]["Delivery"].ToString();
            txtPayment.Text = dt.Rows[inc]["Payment"].ToString();
        }
        private void btnDeleteDetails_Click(object sender, EventArgs e) //Delete record from table Order
        {
            SqlConnection con = new SqlConnection(CON); //setup the connection
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete [Order] where OrderID=@OrderID", con); //the SQL query to delete row
            cmd.Parameters.AddWithValue("@OrderID", txtOrderId.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@Payment", txtPayment.Text);
            cmd.Parameters.AddWithValue("@Delivery", txtMethod.Text);
            cmd.Parameters.AddWithValue("@Total", txtPrice.Text);
            cmd.Parameters.AddWithValue("@Completed", cmbCompleted.Text);
            cmd.ExecuteNonQuery(); 
            con.Close();
            MessageBox.Show("Sucessfully Deleted");  //message to confirm the delete
          
            Refresh(); //call function refresh to clear textboxes

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
        private void btnGenerateApproval_Click(object sender, EventArgs e)//button to generate approval with update in table Order
        {
            try
            {
                SqlConnection con = new SqlConnection(CON);//setup connection
                con.Open();
                SqlCommand cmd = new SqlCommand("Update [Order] set Completed=@Completed where OrderID=@OrderID", con);//SQL query to update Order table
                cmd.Parameters.AddWithValue("@OrderID", txtOrderId.Text);
                cmd.Parameters.AddWithValue("@Completed", cmbCompleted.Text);

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Sucessfully Updated");//message to confirm update

                Pdf();      //call function Pdf to create a pdf file
                refresh();  //call function refresh to clear all textboxes
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Approval");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)//Clear all textboxes
        {
            txtOrderId.Clear();
            txtNIC.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPrice.Clear();
            txtMethod.Clear();
            txtPayment.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, CON); //call the sql string and database connection string
            sda.Fill(dt);
            sda.Dispose();
            NavigateRecords();                                    //call function NavigateRecords
;
            int totalOrder = dt.Rows.Count; //count the number of product
            lblOrders.Text = totalOrder.ToString();//display on label

        }

        private void Pdf()
        {
            try
            {
                PdfWriter writer = new PdfWriter($"C:\\ApprovalBilling {txtOrderId.Text}.pdf");
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                iText.Kernel.Colors.Color fontColor = new DeviceRgb(132, 132, 130);
                PdfFont fontTitle = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                Paragraph title = new Paragraph("Winners")
                   .SetFontColor(fontColor)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetFontSize(15).SetFont(fontTitle).SetMarginBottom(5);


                LineSeparator ls = new LineSeparator(new SolidLine());
                ls.SetMarginLeft(202);
                ls.SetMaxWidth(120);
                ls.SetMarginBottom(25);

                Paragraph thankmsg = new Paragraph("Invoice Approval").SetFontColor(fontColor).SetTextAlignment(TextAlignment.CENTER).SetFontSize(18).SetFont(font).SetMarginBottom(20);
                Paragraph thankmsg2 = new Paragraph($"The order {txtOrderId.Text} has successfully been checkout. Below are the necessary details of the order {txtOrderId.Text}.").SetFontColor(fontColor).SetTextAlignment(TextAlignment.LEFT).SetFontSize(11).SetFont(font).SetMarginBottom(20);

                Paragraph order = new Paragraph($"Order ID: {txtOrderId.Text}").SetFontColor(ColorConstants.DARK_GRAY).SetTextAlignment(TextAlignment.RIGHT).SetFontSize(10).SetFont(fontTitle);
                Paragraph shippingMethod = new Paragraph($"Shipping Method: {txtMethod.Text}").SetFontColor(ColorConstants.DARK_GRAY).SetTextAlignment(TextAlignment.RIGHT).SetFontSize(10).SetFont(fontTitle);
                Paragraph payment = new Paragraph($"Payment: {txtPayment.Text}").SetFontColor(ColorConstants.DARK_GRAY).SetTextAlignment(TextAlignment.RIGHT).SetFontSize(10).SetFont(fontTitle).SetMarginBottom(20);
                Paragraph summary = new Paragraph("Summary").SetFontColor(fontColor).SetTextAlignment(TextAlignment.CENTER).SetFontSize(18).SetFont(font).SetMarginBottom(40);


                document.Add(title);
                document.Add(ls);
                document.Add(thankmsg);
                document.Add(thankmsg2);
                document.Add(order);
                document.Add(shippingMethod);
                document.Add(payment);
                document.Add(new LineSeparator(new SolidLine()).SetMarginBottom(20));
                document.Add(summary);

                Paragraph firstname = new Paragraph($"First Name: {txtFirstName.Text}").SetFontColor(fontColor).SetTextAlignment(TextAlignment.LEFT).SetFontSize(12).SetFont(font);
                Paragraph lastname = new Paragraph($"Last Name: {txtLastName.Text}").SetFontColor(fontColor).SetTextAlignment(TextAlignment.LEFT).SetFontSize(12).SetFont(font);
                Paragraph nic = new Paragraph($"NIC: {txtNIC.Text}").SetFontColor(fontColor).SetTextAlignment(TextAlignment.LEFT).SetFontSize(12).SetFont(font);
                Paragraph address = new Paragraph($"Customer Address: {txtAddress.Text}").SetFontColor(fontColor).SetTextAlignment(TextAlignment.LEFT).SetFontSize(12).SetFont(font);
                Paragraph number = new Paragraph($"Contact Number: {txtPhoneNumber.Text}").SetFontColor(fontColor).SetTextAlignment(TextAlignment.LEFT).SetFontSize(12).SetFont(font);

                document.Add(firstname);
                document.Add(lastname);
                document.Add(nic);
                document.Add(address);
                document.Add(number);

                document.Add(new LineSeparator(new SolidLine()).SetMarginBottom(20).SetMarginTop(20));

                Paragraph totalLabel = new Paragraph($"Total").SetFontColor(fontColor).SetTextAlignment(TextAlignment.LEFT).SetFontSize(12).SetFont(font);
                Paragraph totalPrice = new Paragraph($"{txtPrice.Text}").SetFontColor(fontColor).SetTextAlignment(TextAlignment.RIGHT).SetFontSize(12).SetFont(font);
                totalLabel.Add(new Tab());
                totalLabel.AddTabStops(new TabStop(1000, iText.Layout.Properties.TabAlignment.RIGHT));
                totalLabel.Add(totalPrice);
                document.Add(totalLabel);


                document.Close();

                MessageBox.Show("Invoice Approval Generated");
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid OrderID");
            }
        }
        private void refresh() //function to clear all textboxes
        {
            txtOrderId.Clear();
            txtNIC.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPrice.Clear();
            txtMethod.Clear();
            txtPayment.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
        }
    }
}
