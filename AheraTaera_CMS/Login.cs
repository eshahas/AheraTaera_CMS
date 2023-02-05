
using AheraTaera_CMS.UserValidation;
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
        private Business.Singleton DBReader;
        public Login()
        {
            InitializeComponent();
            DBReader = Business.Singleton.GetInstance;
        }


        private void loginBotton_Click(object sender, EventArgs e)
        {

            iCustomers reg_customer = new RegisteredCustomerFactory().CreateCustomer(null, null, null, null, null, null, null, null, null, passwordTextBox.Text, userTextBox.Text);

            string ID = reg_customer.Login();
            if (ID != null) 
            {
                this.Hide();

//                Home form = new Home(reg_customer.CustomerID, reg_customer.FName + " " + reg_customer.LName);
                Home form = new Home(ID, userTextBox.Text);
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

                  if (reg_customer.Login(userTextBox.Text, passwordTextBox.Text)) { 
                        this.Hide();

                        Home form = new Home(reg_customer.CustomerID, reg_customer.FName + " " + reg_customer.LName);
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
