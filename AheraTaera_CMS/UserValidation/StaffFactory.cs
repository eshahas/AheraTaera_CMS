using System;
using System.Collections.Generic;
using System.Text;

namespace AheraTaera_CMS.UserValidation
{

    public class StaffFactory : CustomerFactory
    {
        protected override iCustomers MakeCustomer(
                    string CustomerID,
                       string FName,
                       string LName,
                       string DoB,
                       string Phone,
                       string Email,
                       string AddLine1,
                       string AddLine2,
                       string City,
                       string Password,
                       string username)
        {
            iCustomers product = new Staff();
            product.setparam(
                         CustomerID,
                        FName,
                         LName,
                        DoB,
                        Phone,
                       Email,
                        AddLine1,
                        AddLine2,
                        City,
                        Password,
                        username);

            return product;
        }
    }
}
