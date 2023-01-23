using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AheraTaera_CMS
{
    public partial class ShoppingCard : Form
    {
        private string username;
        private string customer;
        private float totalprice;
        //private string[] product;
        public ShoppingCard(string customerID, string user, string product, int qty)
        {
            InitializeComponent();
            customer = customerID;
            username = user;

        //    MessageBox.Show("Qty : " + customer + "   " + product + "  " + qty.ToString() );


            ShoppingListView.GridLines = true;
            ShoppingListView.View = View.Details;
            ShoppingListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
           // productList = new ProductList().getProductList();
            ShoppingListView.BeginUpdate();


            foreach (string[] record in AddtoCart.shoppingList)
            {
                ListViewItem item = new ListViewItem(record);
                ShoppingListView.Items.Add(item);
            }
            ShoppingListView.EndUpdate();

            totalPriceUpdate();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Checkout form = new Checkout(username, totalprice);
            form.Show();
        }

        private void ViewProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewProduct form = new ViewProduct(customer, username);
            form.Show();
        }

        private void ShoppingCard_Load(object sender, EventArgs e)
        {

        }

        private void totalPriceUpdate()
        {
            float total = 0;
            int index = 0;
            float price;
            int quantity;
            foreach (string[] record in AddtoCart.shoppingList)
            {

                price = float.Parse(AddtoCart.shoppingList[index][2]);
                quantity = Int32.Parse(AddtoCart.shoppingList[index][3]);
                total += price * quantity;

                index++;
            }
            TotalLabel.Text = total.ToString();
            totalprice = total;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
     
            int recordNo = ShoppingListView.SelectedItems.Count;
         //   MessageBox.Show("RecordNo = " + AddtoCart.shoppingList.Count.ToString());
            if (recordNo > 0 && AddtoCart.shoppingList.Count>1)
            {
                AddtoCart.shoppingList.RemoveAt(recordNo);
                ShoppingListView.Items.RemoveAt(recordNo);

                totalPriceUpdate();
            }
            else
            {
                MessageBox.Show("Not able to delete the product!");
            }
        }
    }
}
