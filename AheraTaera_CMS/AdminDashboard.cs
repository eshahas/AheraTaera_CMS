using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AheraTaera_CMS
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminProduct form = new AdminProduct();
            form.Show();
        }

        private void AdminPaymentButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminOrder form = new AdminOrder();
            form.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login form = new Login();
            form.Show();
        }
    }
}
