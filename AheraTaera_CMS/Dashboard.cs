using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AheraTaera_CMS
{
    public partial class Dashboard : Form
    {
        private string username;
        private string customer;
        //private string[] product;

            public Dashboard(string customerID, string user)
        {
            InitializeComponent();
            customer = customerID;
            username = user;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewProduct form = new ViewProduct(customer, username);
            form.Show();
        }
    }
}
