using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace AheraTaera_CMS.UserValidation
{
    public class Staff : iCustomers
    {
        public string StaffID = null;
        public string Password;

        public string username;
        public string Login()
        {

            Business.Singleton DBReader = Business.Singleton.GetInstance;
            String sql = String.Format("SELECT Email, Password, Role FROM staff WHERE Email='{0}' AND Password='{1}'", username, Password);

            MySqlDataReader rdr = DBReader.SQLReaderOpen(sql);

            if (rdr.HasRows)
            {
                rdr.Read();
                StaffID = rdr[2].ToString();
            }
/*          
            else
            {
                MessageBox.Show("Wrong Username and/or Password!");
            }
*/
            DBReader.SQLReaderClose();

            return StaffID;
        }

        public bool Register()
        {
            return false;
        }

        public void setparam(string CustomerID,
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

