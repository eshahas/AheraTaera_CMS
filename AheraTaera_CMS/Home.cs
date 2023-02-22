using AheraTaera_CMS.ProductCategory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AheraTaera_CMS
{
    public partial class Home : Form
    {
        private string username;
        private string product;
        private string customerID;

        public static int Qty_in_Shoppingcard = 0;

        public Home(string customer, string loginName)
        {
            InitializeComponent();
            userLabel.Text = "Welcome " + loginName;

            username = loginName;
            customerID = customer;

            iProduct product = new SouvenirsFactory().CreateProduct();
            product.GetProductType();

            dataGridView1.DataSource = new ProductList().getProductList();

        }

        private void LogoutBotton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddtoCartButton_Click(object sender, EventArgs e)
        {

          //  if (listView1.SelectedItems.Count > 0)
             if(dataGridView1.SelectedRows.Count > 0)
            {
 //                product = listView1.SelectedItems[0].Text;

                DataGridViewRow selctedRow = dataGridView1.SelectedRows[0];
                product = selctedRow.Cells[0].Value.ToString();

                AddtoCart form = new AddtoCart(product);
                form.Show();
            }
            else
            {
                MessageBox.Show("Please select a product in the list to see his/her details!");
            }

        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
           // this.Hide();

            //Checkout form = new Checkout(username);
            //form.Show();
        }

        private void ShoppingCardButton_Click(object sender, EventArgs e)
        {
            if (Qty_in_Shoppingcard > 0)
            {
                this.Hide();

                ShoppingCard form = new ShoppingCard(customerID, username, product, AddtoCart.Qty);
                form.Show();
            }
             else MessageBox.Show("There should be at least one product in the shopping card...");
        }
    }
}
