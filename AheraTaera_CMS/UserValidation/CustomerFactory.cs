using System;
using System.Collections.Generic;
using System.Text;

namespace AheraTaera_CMS.UserValidation
{
    public abstract class CustomerFactory
    {
        protected abstract iCustomers MakeProduct(
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
                       string username);
        public iCustomers CreateProduct(
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
            return this.MakeProduct(
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
        }
    }

}
