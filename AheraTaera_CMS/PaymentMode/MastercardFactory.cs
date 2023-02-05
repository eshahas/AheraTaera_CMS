using System;
using System.Collections.Generic;
using System.Text;

namespace AheraTaera_CMS.PaymentMode
{

    public class MastercardFactory : PaymentFactory
    {
        protected override iPayment MakePayment()
        {
            iPayment payment = new Mastercard();
            return payment;
        }
    }
}
