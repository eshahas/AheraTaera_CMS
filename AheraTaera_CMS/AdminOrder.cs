using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AheraTaera_CMS
{
    public partial class AdminOrder : Form
    {
        public AdminOrder()
        {
            InitializeComponent();

            dataGridView1.DataSource = new OrderList().getOrderList();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminDashboard form = new AdminDashboard();
            form.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selctedRow = dataGridView1.SelectedRows[0];
                string OrderID = selctedRow.Cells[0].Value.ToString();

                OrderList orders = new OrderList(); 
                orders.DeleteOrder(OrderID);


                dataGridView1.DataSource = new OrderList().getOrderList();

                MessageBox.Show(OrderID + " deleted from the order List...");
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
                Business.Order order = new Business.Order();

                order.OrderID = selctedRow.Cells[0].Value.ToString();
                order.CustomerID = selctedRow.Cells[1].Value.ToString();
                order.Date = selctedRow.Cells[2].Value.ToString();
                order.Value = selctedRow.Cells[3].Value.ToString();
                order.GST = selctedRow.Cells[4].Value.ToString();
                order.Discount = selctedRow.Cells[5].Value.ToString();
                order.Total = selctedRow.Cells[6].Value.ToString();

                OrderList orders = new OrderList();
                orders.UpdateOrder(order);

                dataGridView1.DataSource = new OrderList().getOrderList();

                MessageBox.Show(order.OrderID + " Updated in the order List...");
            }
            else
            {
                MessageBox.Show("Please select an order in the list to update!");
            }
        }

        private void AdminOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
