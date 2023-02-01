using System;
using System.Collections.Generic;
using System.Text;

namespace AheraTaera_CMS.UserValidation
{
    public interface iCustomers
    {
        bool Login(); 
        bool Register(); 

        void setparam(string CustomerID,
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
     //   bool validation();

    }

}
