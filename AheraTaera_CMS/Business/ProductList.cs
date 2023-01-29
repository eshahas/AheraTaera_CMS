
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
        private List<Business.Product> productList = new List<Business.Product>();


        public ProductList()
        {

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
                    productList.Add(new Business.Product
                    {
                        ProductID = rdr.GetString("ProductID"),
                        ProductName = rdr.GetString("ProductName"),
                        ProductDescription = rdr.GetString("ProductDescription"),
                        unitPrice = rdr.GetString("Price"),
                        ProductCategory = rdr.GetString("ProductCategory")
                    }); ;
                }
                rdr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        public List<Business.Product> getProductList()
        {
            return productList;
        }
    }
}