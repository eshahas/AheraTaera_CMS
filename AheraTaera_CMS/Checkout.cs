using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AheraTaera_CMS
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congradulations, Payment successfully Done!");
        }
    }
}
