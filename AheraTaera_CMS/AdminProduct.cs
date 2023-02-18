using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AheraTaera_CMS
{
    public partial class AdminProduct : Form
    {
        public AdminProduct()
        {
            InitializeComponent();

            dataGridView1.DataSource = new ProductList().getProductList();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminDashboard form = new AdminDashboard();
            form.Show();
        }

        private void AdminProduct_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            NewProduct form = new NewProduct();
            form.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selctedRow = dataGridView1.SelectedRows[0];
                string productID = selctedRow.Cells[0].Value.ToString();

                ProductList products = new ProductList();  // new ProductList().DeleteProduct(productID);
                products.DeleteProduct(productID);


                dataGridView1.DataSource = new ProductList().getProductList();

                MessageBox.Show(productID + " deleted from the product List...");
            }
            else
            {
                MessageBox.Show("Please select a product in the list to delete!");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selctedRow = dataGridView1.SelectedRows[0];
                Business.Product product = new Business.Product();
                
                product.ProductID = selctedRow.Cells[0].Value.ToString();
                product.ProductName = selctedRow.Cells[1].Value.ToString();
                product.ProductDescription = selctedRow.Cells[2].Value.ToString();
                product.unitPrice = selctedRow.Cells[3].Value.ToString();
                product.ProductCategory = selctedRow.Cells[4].Value.ToString();

                ProductList products = new ProductList();  
                products.UpdateProduct(product);

                dataGridView1.DataSource = new ProductList().getProductList();

                MessageBox.Show(product.ProductID + " Updated in the product List...");
            }
            else
            {
                MessageBox.Show("Please select a product in the list to update!");
            }
        }
    }
}
