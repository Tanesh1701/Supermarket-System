using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Assignment
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        private void clearControls()
        {
            screenform.Controls.Clear();
        }
        static void productForms()//setup Panel to view Product
        {
            frmProduct product = (frmProduct)Application.OpenForms["Product"];
            product = new frmProduct();
            Panel screenform = (Panel)product.Controls["screenform"];
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) //when click on node in treeView to display form to view product
        {
            string nodes = treeView1.SelectedNode.Text;

            if (nodes == "Soft Drinks") //check if node equal Soft Drinks
            {
                labelHeader.Text = "Soft Drinks"; //change label text

                clearControls();

                frmProductSoftDrinks productSoftDrinks = new frmProductSoftDrinks(); //access frmProductSoftDrinks to display products
                productSoftDrinks.TopMost = true;
                productSoftDrinks.TopLevel = false;
                productForms();
                screenform.Controls.Add(productSoftDrinks);
                productSoftDrinks.Show();
            }
            else if (nodes == "Others")
            {
                labelHeader.Text = "Others"; //change label text

                clearControls();

                frmProductOthers productOthers = new frmProductOthers(); //access frmProducOthers to display products
                productOthers.TopMost = true;
                productOthers.TopLevel = false;
                productForms();
                screenform.Controls.Add(productOthers);
                productOthers.Show();
            }
            else if (nodes == "Foods")
            {
                labelHeader.Text = "Foods"; //change label text

                clearControls();

                frmProductFoods productFoods = new frmProductFoods();  //access frmProductFoods to display products
                productFoods.TopMost = true;
                productFoods.TopLevel = false;
                productForms();
                screenform.Controls.Add(productFoods);
                productFoods.Show();
            }
            else if (nodes == "Can & Packets")
            {
                labelHeader.Text = "Can and Packets"; //change label text

                clearControls();

                frmProductCan productCan = new frmProductCan();  //access frmProductCan to display products
                productCan.TopMost = true;
                productCan.TopLevel = false;
                productForms();
                screenform.Controls.Add(productCan);
                productCan.Show();
            }
            else if (nodes == "Sugar, Flour & Rice")
            {
                labelHeader.Text = "Sugar, Flour and Rice";//change label text

                clearControls();

                frmProductSFR productSFR = new frmProductSFR();    //access frmProductSFR to display products
                productSFR.TopMost = true;
                productSFR.TopLevel = false;
                productForms();
                screenform.Controls.Add(productSFR);
                productSFR.Show();
            }
            else if (nodes == "Pasta & Noodle")
            {
                labelHeader.Text = "Pasta & Noodle";        //change label text

                clearControls();

                frmProductPN productPN = new frmProductPN();     //access frmProductPN to display products
                productPN.TopMost = true;
                productPN.TopLevel = false;
                productForms();
                screenform.Controls.Add(productPN);
                productPN.Show();
            }
            else if (nodes == "Breakfast")
            {
                labelHeader.Text = "Breakfast";//change label text

                clearControls();

                frmProductBreakfast productBf = new frmProductBreakfast();     //access frmProductBreakfast to display products
                productBf.TopMost = true;
                productBf.TopLevel = false;
                productForms();
                screenform.Controls.Add(productBf);
                productBf.Show();
            }
            else if (nodes == "Bathroom")
            {
                labelHeader.Text = "Bathroom";//change label text

                clearControls();

                frmProductBathroom productBR = new frmProductBathroom();    //access frmProductBathroom to display products
                productBR.TopMost = true;
                productBR.TopLevel = false;
                productForms();
                screenform.Controls.Add(productBR);
                productBR.Show();
            }
            else if (nodes == "Laundry")
            {
                labelHeader.Text = "Laundry";//change label text

                clearControls();

                frmProductLaundry productL = new frmProductLaundry();      //access frmProductto display products
                productL.TopMost = true;
                productL.TopLevel = false;
                productForms();
                screenform.Controls.Add(productL);
                productL.Show();
            }
            else if (nodes == "Hygiene")
            {
                labelHeader.Text = "Hygiene";                     //change label text          

                clearControls();

                frmProductCleaning productH = new frmProductCleaning();       //access frmProductCleaning to display products
                productH.TopMost = true;
                productH.TopLevel = false;
                productForms();
                screenform.Controls.Add(productH);
                productH.Show();
            }
        }
    }
}
