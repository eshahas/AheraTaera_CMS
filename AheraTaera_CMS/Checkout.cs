using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AheraTaera_CMS
{

    public partial class Checkout : Form
    {
        double total;
        double GST;
        double price;
        public Checkout(string user, float value)
        {
            InitializeComponent();

            price = value;

            CustomerLabel.Text = user;
            DateLabel.Text = DateTime.Now.ToString();

            PriceLabel.Text = price.ToString();

            double discountvalue = 0;

            GST = 0.15 * (price - discountvalue);

            total = (price - discountvalue) + GST;
            DiscountLabel.Text = discountvalue.ToString();
            GSTLabel.Text = GST.ToString();
            TotalLabel.Text = total.ToString();

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congradulations, Payment successfully Done!");
        }

        private void DiscountButton_Click(object sender, EventArgs e)
        {
            Utility uti = new Utility();


            double discountvalue = price * uti.GetDiscount(72, "Auckland", WeekendDeliveryCheckBox.Checked) / 100;

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
