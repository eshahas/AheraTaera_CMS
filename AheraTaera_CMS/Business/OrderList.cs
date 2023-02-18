using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Windows.Forms;


namespace AheraTaera_CMS
{
    class OrderList
    {
        private List<Business.Order> orderList = new List<Business.Order>();
        public Business.Singleton DBReader;

        public OrderList()
        {

            DBReader = Business.Singleton.GetInstance;

            String sql = String.Format("SELECT * FROM orders");

            MySqlDataReader rdr = DBReader.SQLReaderOpen(sql);

            while (rdr.Read())
            {
                orderList.Add(new Business.Order
                {
                    OrderID = rdr.GetString("OrderID"),
                    CustomerID = rdr.GetString("CustomerID"),
                    Date = rdr.GetString("Date"),
                    Value = rdr.GetString("Value"),
                    GST = rdr.GetString("GST"),
                    Discount = rdr.GetString("Discount"),
                    Total = rdr.GetString("Total"),
                });
            }

            DBReader.SQLReaderClose();
        }

        public List<Business.Order> getOrderList()
        {
            return orderList;
        }

        public bool DeleteOrder(string OrderID)
        {
            DBReader = Business.Singleton.GetInstance;

            string sql = String.Format("DELETE FROM orders WHERE OrderID = {0}", OrderID);

            if (DBReader.SQLQuery(sql) == -1) return false; ;
            return true;
        }

        public bool UpdateOrder(Business.Order order)
        {
            DBReader = Business.Singleton.GetInstance;
           // MessageBox.Show("Discount = " + order.Discount + " : " + order.OrderID + "xx");
            string sql = String.Format("UPDATE orders SET Date = '{0}', Value = '{1}', GST = {2} , Discount = '{3}', Total = '{4}' WHERE OrderID = {5}", order.Date, (float)Convert.ToDouble(order.Value), (float)Convert.ToDouble(order.GST), (float)Convert.ToDouble(order.Discount), (float)Convert.ToDouble(order.Total), Int32.Parse(order.OrderID));

            if (DBReader.SQLQuery(sql) == -1) return false; ;
            return true;
        }


    }
}