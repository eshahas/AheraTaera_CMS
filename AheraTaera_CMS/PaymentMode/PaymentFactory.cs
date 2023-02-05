using System;
using System.Collections.Generic;
using System.Text;

namespace AheraTaera_CMS.PaymentMode
{

    public abstract class PaymentFactory
    {
        protected abstract iPayment MakePayment();
        public iPayment CreatePayment()
        {
            return this.MakePayment();
        }
    }
}
