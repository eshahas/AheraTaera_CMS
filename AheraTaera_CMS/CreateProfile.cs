using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AheraTaera_CMS
{
    public partial class CreateProfile : Form
    {
        public CreateProfile()
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

            Customer customer = new Customer();
            customer.FirstName = FNameTextBox.Text;
            customer.LastName = LNameTextBox.Text;
            customer.Email = EmailTextBox.Text;

            if (PasswordTextBox.Text == RePasswordTextBox.Text)
                {


                string connectionString = "Data Source=localhost;Initial Catalog=aherataera_cms;User ID=root;Password='1234567'";
                string sql = "SELECT COUNT(*) FROM customers";
                try
                {
                    MySqlConnection con = new MySqlConnection(connectionString);
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        rdr.Read();
                        i = Int32.Parse(rdr[0].ToString()) +1;      
                    }

                    rdr.Close();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error:\n" + ex.ToString());
                }

                CustomerID = i.ToString();
                //MessageBox.Show(sql);
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
                  //  MessageBox.Show(sql);

                    try
                    {
                        MySqlConnection con = new MySqlConnection(connectionString);
                        con.Open();

                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        int returnVal = cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error:\n" + ex.ToString());
                    }

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
