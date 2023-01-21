using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AheraTaera_CMS
{
    public partial class AddtoCart : Form
    {
        //private string username;
        private string product; 
        public AddtoCart(string productID)
        {
            InitializeComponent();
            product = productID;
//            MessageBox.Show(productID);
            string connectionString = "Data Source=localhost;Initial Catalog=aherataera_cms;User ID=root;Password='1234567'";
            string sql = "SELECT FName, LName, Email, Password FROM customers WHERE CustomerID='" + productID + "'";

//                      MessageBox.Show(sql);

            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    rdr.Read();

                    ProductNameLabel.Text = rdr[1].ToString();
                    ProductDescriptionLabel.Text = rdr[2].ToString();
                }
                else
                {
                    MessageBox.Show("Empty Record!");
                }

                rdr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:\n" + ex.ToString());
            }

        }

        private void AdditemButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Product successfully added to the cart...");
            this.Hide();

           // ViewProduct form = new ViewProduct(username);
           // form.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();

           // ViewProduct form = new ViewProduct(username);
           // form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
