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

    public partial class Register : Form
    {
       // public Business.Singleton DBReader;
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createProfileButton_Click(object sender, EventArgs e)

        {
            string CustomerID = "1";
            int i = 1;

            if (PasswordTextBox.Text == RePasswordTextBox.Text)
            {

                iCustomers reg_customer = new newCustomerFactory().CreateProduct( 
                                             CustomerID,
                                             FNameTextBox.Text,
                                             LNameTextBox.Text,
                                             DoBMaskedBox.Text,
                                             PhoneMaskedBox.Text,
                                             EmailTextBox.Text,
                                             AddLine1TextBox.Text,
                                             AddLine2TextBox.Text,
                                             CityTextBox.Text,
                                             PasswordTextBox.Text, 
                                             null);

                if (reg_customer.Register())
                {
                    MessageBox.Show("Congradulations, Account created succsessfully...");

                    this.Hide();
                    Login form = new Login();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Try again, Passwords do not match");
                }

            }
        }

        /*
               private void createProfileButton_Click(object sender, EventArgs e)

                {
                    string CustomerID = "1";
                    int i = 1;

                    if (PasswordTextBox.Text == RePasswordTextBox.Text)
                    {

                        newCustomer new_customer = new newCustomer();

                        if (new_customer.Register(CustomerID,
                                                     FNameTextBox.Text,
                                                     LNameTextBox.Text,
                                                     DoBMaskedBox.Text,
                                                     PhoneMaskedBox.Text,
                                                     EmailTextBox.Text,
                                                     AddLine1TextBox.Text,
                                                     AddLine2TextBox.Text,
                                                     CityTextBox.Text,
                                                     PasswordTextBox.Text))

                        {
                            MessageBox.Show("Congradulations, Account created succsessfully...");

                            this.Hide();
                            Login form = new Login();
                            form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Try again, Passwords do not match");
                        }

                    }
                }
        */
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();


            Login form = new Login();
            form.Show();

        }

        private void CreateProfile_Load(object sender, EventArgs e)
        {

        }
    }
}


/*                
                sql = "INSERT INTO customers VALUES(" +
                                               "'" + CustomerID + "', " +
                                               "'" + FNameTextBox.Text + "', " +
                                               "'" + LNameTextBox.Text + "', " +
                                              "'" + DoBMaskedBox.Text + "', " +
                                              "'" + PhoneMaskedBox.Text + "', " +
                                              "'" + EmailTextBox.Text + "', " +
                                              "'" + AddLine1TextBox.Text + "', " +
                                              "'" + AddLine2TextBox.Text + "', " +
                                              "'" + CityTextBox.Text + "', " +
                                              "'" + PasswordTextBox.Text + "');";
                */
