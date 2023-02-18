
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


        public bool DeleteProduct(string ProductID)
        {
            DBReader = Business.Singleton.GetInstance;

            string sql = String.Format("DELETE FROM products WHERE productID = {0}", ProductID);

            if (DBReader.SQLQuery(sql) == -1) return false; ;
            return true;
        }

        public bool UpdateProduct(Business.Product product)
        {
            DBReader = Business.Singleton.GetInstance;

            string sql = String.Format("UPDATE products SET ProductName = '{0}', ProductDescription = '{1}', Price = {2} , ProductCategory = '{3}' WHERE ProductID = {4}", product.ProductName, product.ProductDescription, (float)Convert.ToDouble(product.unitPrice), product.ProductCategory, Int32.Parse(product.ProductID)); // );

            if (DBReader.SQLQuery(sql) == -1) return false; ;
            return true;
        }

        public bool CreateProduct(Business.Product product)
        {
            int i = 1;

            Business.Singleton DBReader = Business.Singleton.GetInstance;

            string sql = "SELECT MAX(ProductID) FROM products"; // "SELECT COUNT(*) FROM products";
            MySqlDataReader rdr = DBReader.SQLReaderOpen(sql);

            if (rdr.HasRows)
            {
                rdr.Read();
                i = Int32.Parse(rdr[0].ToString()) + 1;
            }

            DBReader.SQLReaderClose();

            product.ProductID = i.ToString();

            sql = String.Format("INSERT INTO products VALUES('{0}','{1}','{2}','{3}','{4}')",
                                        product.ProductID,
                                        product.ProductName,
                                        product.ProductDescription, 
                                        product.unitPrice, 
                                        product.ProductCategory);

            if (DBReader.SQLQuery(sql) == -1) return false;

            return true;
        }
    }        
}

