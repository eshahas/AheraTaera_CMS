
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Windows.Forms;


namespace AheraTaera_CMS
{
    class ProductList
    {
        private List<string[]> productList = new List<string[]>();


        public ProductList()
        {
           // string sql = "SELECT CustomerID, LName, DoB, Phone, Email FROM customers";
            string sql = "SELECT ProductID, ProductName, ProductDescription, Price, ProductCategory FROM products";

            string connectionString = "Data Source=localhost;Initial Catalog=aherataera_cms;User ID=root;Password='1234567'";


            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string[] product = new string[] { rdr.GetString("ProductID"), rdr.GetString("ProductName"), rdr.GetString("ProductDescription"), rdr.GetString("Price"), rdr.GetString("ProductCategory") };
                    productList.Add(product);
                  //  MessageBox.Show(product[0]);
                }
                rdr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        public List<string[]> getProductList()
        {
            return productList;
        }
    }
}