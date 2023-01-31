using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AheraTaera_CMS
{

    public abstract class iCustomer
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

        public bool VerifyPassword()
        {
            MessageBox.Show("VerifyPassword");
            return true;
        }

        public abstract bool Login(string username, string password);
        public abstract bool Register(string CustomerID,
                                      string FName,
                                      string LName,
                                      string DoB,
                                      string Phone,
                                      string Email,
                                      string AddLine1,
                                      string AddLine2,
                                      string City,
                                      string Password);
    }

    public class RegCustomer : iCustomer
    {
        public RegCustomer()
        {

        }
        public override bool Login(string username, string password)
        {

            Business.Singleton DBReader = Business.Singleton.GetInstance;
            String sql = String.Format("SELECT * FROM customers WHERE Email='{0}' AND Password='{1}'", username, password);

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

        public override bool Register(string CustomerID,
                                      string FName,
                                      string LName,
                                      string DoB,
                                      string Phone,
                                      string Email,
                                      string AddLine1,
                                      string AddLine2,
                                      string City,
                                      string Password)
        {
            return false;
        }
    }
    public class newCustomer : iCustomer
    {
        public override bool Login(string username, string password)
        {
            return false;
        }
        public override bool Register(string CustomerID,
                                      string FName,
                                      string LName,
                                      string DoB,
                                      string Phone,
                                      string Email,
                                      string AddLine1,
                                      string AddLine2,
                                      string City,
                                      string Password)
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

    }
}
