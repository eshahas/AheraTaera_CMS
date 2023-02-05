using System;
using System.Collections.Generic;
using System.Text;

namespace AheraTaera_CMS.PaymentMode
{


    public class VisaFactory : PaymentFactory
    {
        protected override iPayment MakePayment()
        {
            iPayment payment = new Visa();
            return payment;
        }
    }
}
