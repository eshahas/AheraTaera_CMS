using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace AheraTaera_CMS.UserValidation
{
    public class RegisteredCustomer : iCustomers
    {
        public string CustomerID;
        public string FName;
        public string LName;
        public string DoB;
        public string Phone;
        public string Email;
        public string AddLine1;
        public string AddLine2;
        public string City;
        public string Password;

        public string username;

        public bool Login() 
        {

            Business.Singleton DBReader = Business.Singleton.GetInstance;
            String sql = String.Format("SELECT * FROM customers WHERE Email='{0}' AND Password='{1}'", username, Password);

            MySqlDataReader rdr = DBReader.SQLReaderOpen(sql);

            if (rdr.HasRows)
            {
                rdr.Read();
                CustomerID = rdr[0].ToString();
                FName = rdr[1].ToString();
                LName = rdr[2].ToString();
                DoB = rdr[3].ToString();
                Phone = rdr[4].ToString();
                Email = rdr[5].ToString();
                AddLine1 = rdr[6].ToString();
                AddLine2 = rdr[7].ToString();
                City = rdr[8].ToString();
                Password = rdr[9].ToString();
            }
            else
            {
                MessageBox.Show("Wrong Username and/or Password!");
            }

            DBReader.SQLReaderClose();

            return true;
        }

        public bool Register()
        {
            return false;
        }

        public  void setparam(string CustomerID,
                      string FName,
                      string LName,
                      string DoB,
                      string Phone,
                      string Email,
                      string AddLine1,
                      string AddLine2,
                      string City,
                      string _Password,
                      string _username)
        {
            username = _username;
            Password = _Password;
        }
    }
}
