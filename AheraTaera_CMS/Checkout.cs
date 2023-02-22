using AheraTaera_CMS.PaymentMode;
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

    public partial class Checkout : Form
    {
        private  double total;
        private double GST;
        private double price;
        private double discountvalue;
        public string CustomerID;
        private int OrderNo;
        private string username;
        public Checkout(string ID, string user, float value)
        {
            InitializeComponent();

            CustomerID = ID;
            username = user;

            price = value;

            CustomerLabel.Text = user;
            DateLabel.Text = DateTime.Now.ToString();

            PriceLabel.Text = price.ToString();

            discountvalue = 0;

            GST = 0.15 * (price - discountvalue);

            total = (price - discountvalue) + GST;
            DiscountLabel.Text = discountvalue.ToString();
            GSTLabel.Text = GST.ToString();
            TotalLabel.Text = total.ToString();

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();

            Home form = new Home(CustomerID, username);
            form.Show();

        }

        private void Order_DBUpdate()
        {
            OrderNo = 1;

            Business.Singleton DBReader = Business.Singleton.GetInstance;

            string sql = "SELECT COUNT(*) FROM orders";
            MySqlDataReader rdr = DBReader.SQLReaderOpen(sql);

            if (rdr.HasRows)
            {
                rdr.Read();
                OrderNo  = Int32.Parse(rdr[0].ToString()) + 1;
            }

            DBReader.SQLReaderClose();

            string OrderID = OrderNo.ToString();

            sql = String.Format("INSERT INTO orders VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                                        OrderID,
                                        int.Parse(CustomerID),
                                        DateTime.Now.ToShortDateString(),
                                        price,
                                        GST,
                                        discountvalue,
                                        total);

            DBReader.SQLQuery(sql);

        }

        private void OrderItem_DBUpdate()
        {
            int i = 1;

            Business.Singleton DBReader = Business.Singleton.GetInstance;

            string sql = "SELECT COUNT(*) FROM orderitem";
            MySqlDataReader rdr = DBReader.SQLReaderOpen(sql);

            if (rdr.HasRows)
            {
                rdr.Read();
                i = Int32.Parse(rdr[0].ToString()) + 1;
            }

            DBReader.SQLReaderClose();


            int index = i + 1;
            foreach (ProductItem item in AddtoCart.shoppingList)
            {
                index++;

                sql = String.Format("INSERT INTO orderitem VALUES('{0}','{1}','{2}','{3}')",
                                     index.ToString(),
                                     OrderNo.ToString(),
                                     item.ProductID,
                                     item.ProductQty);
                /*
                sql = String.Format("INSERT INTO orders VALUES('{0}','{1}','{2}','{3}')",
                                 index,
                                 OrderNo,
                                 Int32.Parse(item.ProductID),
                                 Int32.Parse(item.ProductQty));
                 */              

                DBReader.SQLQuery(sql);
            }


        }
        private void PaymentButton_Click(object sender, EventArgs e)
        {
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            iPayment card;

            if (PaymentVisa.Checked) card = new VisaFactory().CreatePayment();
                else card = new MastercardFactory().CreatePayment();

            card.Payment(total);

            /*
                        if (PaymentVisa.Checked)  MessageBox.Show("Congradulations, Payment successfully Done through your Visa card!");
                          else MessageBox.Show("Congradulations, Payment successfully Done through your Master card!");
            */

           Order_DBUpdate();
           OrderItem_DBUpdate();
            
            Application.Exit();
        }

        private void DiscountButton_Click(object sender, EventArgs e)
        {
            Discount uti = new Discount();


            discountvalue = price * uti.GetDiscount(72, "Auckland", WeekendDeliveryCheckBox.Checked) / 100;

            double shipmentcost = uti.GetShipmentCharge(HomeDeliveryCheckBox.Checked);

            GST = 0.15 * ( price - discountvalue + shipmentcost);
            
            total = (price - discountvalue + shipmentcost) + GST;
            ShipmentCostLabel.Text = shipmentcost.ToString();
            DiscountLabel.Text = discountvalue.ToString();
            GSTLabel.Text = GST.ToString();
            TotalLabel.Text = total.ToString();
        }
    }
}
