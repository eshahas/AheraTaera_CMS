using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AheraTaera_CMS.UserValidation
{

    public class newCustomer : iCustomers
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

        public string Login()  
        {
            return null;
        }

        public bool Register()
        {
            int i = 1;

            Business.Singleton DBReader = Business.Singleton.GetInstance;

            string sql = "SELECT COUNT(*) FROM customers";
            MySqlDataReader rdr = DBReader.SQLReaderOpen(sql);

            if (rdr.HasRows)
            {
                rdr.Read();
                i = Int32.Parse(rdr[0].ToString()) + 1;
            }

            DBReader.SQLReaderClose();

            CustomerID = i.ToString();

            sql = String.Format("INSERT INTO customers VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}', '{9}')",
                                        CustomerID,
                                        FName,
                                        LName,
                                        DoB,
                                        Phone,
                                        Email,
                                        AddLine1,
                                        AddLine2,
                                        City,
                                        Password);


            DBReader.SQLQuery(sql);

            return true;
        }

        public void setparam(string _CustomerID,
                      string _FName,
                      string _LName,
                      string _DoB,
                      string _Phone,
                      string _Email,
                      string _AddLine1,
                      string _AddLine2,
                      string _City,
                      string _Password,
                      string _username)
        {
            CustomerID = _CustomerID;
            FName = _FName;
            LName = _LName;
            DoB = _DoB;
            Phone = _Phone;
            Email = _Email;
            AddLine1 = _AddLine1;
            AddLine2 = _AddLine2;
            City = _City;
            Password = _Password;
        }
    }

}
