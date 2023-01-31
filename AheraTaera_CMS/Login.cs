
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using MySql.Data;
//using MySql.Data.MySqlClient;



namespace AheraTaera_CMS
{
    public partial class Login : Form
    {
        private string customerID;
        private Business.Singleton DBReader;
        public Login()
        {
            InitializeComponent();
            DBReader = Business.Singleton.GetInstance;
        }

        private void loginBotton_Click(object sender, EventArgs e)
        {

            RegCustomer reg_customer = new RegCustomer();

            if (reg_customer.Login(userTextBox.Text, passwordTextBox.Text)) { 
                  this.Hide();

                  string username = reg_customer.FName + " " + reg_customer.LName;
                  Home form = new Home(customerID, username);
                  form.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username and/or Password!");
            }

            DBReader.SQLReaderClose();
        }
        /*
                private void loginBotton_Click(object sender, EventArgs e)
                {

                    RegCustomer reg_customer = new RegCustomer();
                    reg_customer.Login(userTextBox.Text, passwordTextBox.Text);

                   // string sql = "SELECT CustomerID, FName, LName, Email, Password FROM customers WHERE Email='" + userTextBox.Text + "' AND Password='" + passwordTextBox.Text + "'";
                    String sql = String.Format("SELECT CustomerID, FName, LName, Email, Password FROM customers WHERE Email='{0}' AND Password='{1}'", userTextBox.Text, passwordTextBox.Text);

                    MySqlDataReader rdr = DBReader.SQLReaderOpen(sql);

                    if (rdr.HasRows)
                    {
                        rdr.Read();
                        customerID = rdr[0].ToString();
                        string username = rdr[1].ToString() + " " + rdr[2].ToString();

                        this.Hide();

                        Home form = new Home(customerID, username);
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username and/or Password!");
                    }

                    DBReader.SQLReaderClose();
                }
        */
        private void profileButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Register form = new Register();
            form.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
