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
        public ShoppingCard(string loginName)
        {
            InitializeComponent();
            username = loginName;
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Checkout form = new Checkout();
            form.Show();
        }

        private void ViewProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewProduct form = new ViewProduct(username);
            form.Show();
        }
    }
}
