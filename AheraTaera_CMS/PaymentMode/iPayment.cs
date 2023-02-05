using System;
using System.Collections.Generic;
using System.Text;

namespace AheraTaera_CMS.PaymentMode
{

    public interface iPayment
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
        bool Payment(double value);
    }
}
