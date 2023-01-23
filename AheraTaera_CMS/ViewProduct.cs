using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AheraTaera_CMS
{
    public partial class ViewProduct : Form
    {
        private string username;
        private string product;
        private string customerID;
        private List<string[]> productList;
        public ViewProduct(string customer, string loginName)
        {
            InitializeComponent();
            userLabel.Text = "Welcome " + loginName;

            username = loginName;
            customerID = customer;

            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.AutoResizeColumns( ColumnHeaderAutoResizeStyle.HeaderSize);
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            productList = new ProductList().getProductList();
            listView1.BeginUpdate();
            foreach (string[] product in productList)
            {
                ListViewItem item = new ListViewItem(product);
                listView1.Items.Add(item);
            }
            listView1.EndUpdate();
        }

        private void LogoutBotton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddtoCartButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (listView1.SelectedItems.Count > 0)
            {
                product = listView1.SelectedItems[0].Text;
                AddtoCart form = new AddtoCart(product);
                form.Show();
            }
            else
            {
                MessageBox.Show("Please select an employee in the list to see his/her details!");
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
            this.Hide();

            ShoppingCard form = new ShoppingCard(customerID, username, product, AddtoCart.Qty);
            form.Show();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard form = new Dashboard(customerID, username);
            form.Show();
        }
    }
}
