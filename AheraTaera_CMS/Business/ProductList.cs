
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
        public Business.Singleton DBReader;

        public ProductList()
        {

            DBReader = Business.Singleton.GetInstance;

        //    string sql = "SELECT ProductID, ProductName, ProductDescription, Price, ProductCategory FROM products";
            String sql = String.Format("SELECT ProductID, ProductName, ProductDescription, Price, ProductCategory FROM products");

            MySqlDataReader rdr = DBReader.SQLReaderOpen(sql);

                while (rdr.Read())
                {
                    productList.Add(new Business.Product
                    {
                        ProductID = rdr.GetString("ProductID"),
                        ProductName = rdr.GetString("ProductName"),
                        ProductDescription = rdr.GetString("ProductDescription"),
                        unitPrice = rdr.GetString("Price"),
                        ProductCategory = rdr.GetString("ProductCategory")
                    });
                }

            DBReader.SQLReaderClose();
        }

        public List<Business.Product> getProductList()
        {
            return productList;
        }
    }
}