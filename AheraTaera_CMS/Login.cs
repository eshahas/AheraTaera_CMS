
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.Data;
//using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace AheraTaera_CMS
{
    public partial class Login : Form
    {
        private string customerID;
        public Login()
        {
            InitializeComponent();
        }

        private void loginBotton_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=localhost;Initial Catalog=aherataera_cms;User ID=root;Password='1234567'";
            string sql = "SELECT CustomerID, FName, LName, Email, Password FROM customers WHERE Email='" + userTextBox.Text + "' AND Password='" + passwordTextBox.Text + "'";

//            MessageBox.Show(connectionString);
//            MessageBox.Show(sql);

            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    rdr.Read();
                    customerID = rdr[0].ToString();
                    string username = rdr[1].ToString() + " " + rdr[2].ToString();

                    this.Hide();

                    ViewProduct form = new ViewProduct(customerID, username);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Username and/or Password!");
                }

                rdr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:\n" + ex.ToString());
            }







        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            CreateProfile form = new CreateProfile();
            form.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
