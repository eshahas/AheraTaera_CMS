using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AheraTaera_CMS
{
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminProduct form = new AdminProduct();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Business.Product product = new Business.Product();

            product.ProductID = null;
            product.ProductName = NameTextBox.Text;
            product.ProductDescription = DescriptionTextBox.Text;
            product.unitPrice = PriceTextBox.Text;
            product.ProductCategory = CategoryTextBox.Text;

            ProductList products = new ProductList();
            if (products.CreateProduct(product)) MessageBox.Show("Product successfully added to the database...");
                else MessageBox.Show("Unable to create the new product...");

            this.Hide();

            AdminProduct form = new AdminProduct();
            form.Show();
        }
    }
}
