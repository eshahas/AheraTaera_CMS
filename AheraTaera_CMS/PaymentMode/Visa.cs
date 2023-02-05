using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace AheraTaera_CMS.PaymentMode
{

    public class Visa : iPayment
    {

        public string GetCardType()
        {
            return "Visa";
        }
        public int GetCreditLimit()
        {
            return 35000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
        public bool Payment(double value)
        {

            MessageBox.Show("Congradulations, Payment of $" +  value.ToString() + " successfully Done through your Visa card!...");
            return true;
        }
    }
}
