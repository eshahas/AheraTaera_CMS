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
        private string ID;

        public ShoppingCard(string customerID, string user, string product, int qty)
        {
            InitializeComponent();
            customer = customerID;
            username = user;
            ID = customerID;

            dataGridView1.DataSource =  AddtoCart.shoppingList;

            totalPriceUpdate();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Checkout form = new Checkout(ID,username, totalprice);
            form.Show();
        }

        private void ViewProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home form = new Home(customer, username);
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


            foreach (ProductItem item in AddtoCart.shoppingList)
            {
                price = float.Parse(item.unitPrice);
                quantity = Int32.Parse(item.ProductQty);

                total += price * quantity;

                index++;
            }
  
            TotalLabel.Text = total.ToString();
            totalprice = total;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {


            int recordNo = dataGridView1.SelectedRows.Count;


            if (recordNo > 0 && AddtoCart.shoppingList.Count>1)
            {

                AddtoCart.shoppingList.RemoveAt(dataGridView1.SelectedRows[0].Index);
                dataGridView1.DataSource = null;
                 dataGridView1.DataSource = AddtoCart.shoppingList;

                 totalPriceUpdate();

                Home.Qty_in_Shoppingcard--;
            }
            else
            {
                MessageBox.Show("Not able to delete the product!");
            }
        }
    }
}
