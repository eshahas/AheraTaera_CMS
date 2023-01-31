using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AheraTaera_CMS
{
    public partial class AddtoCart : Form
    {
        //private string username;
        private string productID;
        public static int Qty;
        private string productName;
        private Business.Singleton DBReader;

        public static List<ProductItem> shoppingList = new List<ProductItem>();
 //       public static List<string[]> shoppingList = new List<string[]>();
        public AddtoCart(string product)
        {
            InitializeComponent();
            productID = product;

            DBReader = Business.Singleton.GetInstance;

//            string sql = "SELECT ProductID, ProductName, ProductDescription, Price, ProductCategory FROM products WHERE ProductID='" + productID + "'";
            String sql = String.Format("SELECT ProductID, ProductName, ProductDescription, Price, ProductCategory FROM products WHERE ProductID='{0}'", productID);

            MySqlDataReader rdr = DBReader.SQLReaderOpen(sql);

                if (rdr.HasRows)
                {
                    rdr.Read();

                    productName = rdr[1].ToString();

                    ProductIDLabel.Text = rdr[0].ToString();
                    ProductNameLabel.Text = rdr[1].ToString();
                    ProductDescriptionLabel.Text = rdr[2].ToString();
                    PriceLabel.Text = rdr[3].ToString(); // + "NZD";
                    CategoryLabel.Text = rdr[4].ToString();
                }
                else
                {
                    MessageBox.Show("Empty Record!");
                }

            DBReader.SQLReaderClose();
        }


        private void AdditemButton_Click(object sender, EventArgs e)
        {

            if (ProductQtyTextBox.Text.Length > 0) {
                    float price = Single.Parse(PriceLabel.Text);
                    Qty = Int32.Parse(ProductQtyTextBox.Text);

                    float total = Qty * price;
                    TotalPriceLabel.Text = total.ToString("0.00");
                    MessageBox.Show("Product successfully added to the cart...");

                 //   string[] product = new string[] { productID, productName, PriceLabel.Text, ProductQtyTextBox.Text };
                //shoppingList.Add(product);                  

                shoppingList.Add(new ProductItem
                    {
                        
                        ProductID = productID,
                        ProductName = productName,
                        
                        unitPrice = PriceLabel.Text,
                        ProductQty = ProductQtyTextBox.Text
                    }); 


                    this.Hide();
            }
             else
            {
                MessageBox.Show("Qty field could not be left blank!");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();

           // ViewProduct form = new ViewProduct(username);
           // form.Show();
        }

        private void ProductQtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            }

        private void K(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void QtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void c(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
