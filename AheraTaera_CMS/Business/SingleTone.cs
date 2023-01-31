using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AheraTaera_CMS.Business
{
    public sealed class Singleton
    {
        private static Singleton instance = null;

        private MySqlConnection con;
        private MySqlDataReader rdr;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        private Singleton()
        {
        }
        public MySqlDataReader SQLReaderOpen(string sql)
        {

            string connectionString = "Data Source=localhost;Initial Catalog=aherataera_cms;User ID=root;Password='1234567'";

            try
            {
                con = new MySqlConnection(connectionString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);
                rdr = cmd.ExecuteReader();

                return rdr;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:\n" + ex.ToString());
                return null;
            }
        }


        public int SQLQuery(string sql)
        {

            string connectionString = "Data Source=localhost;Initial Catalog=aherataera_cms;User ID=root;Password='1234567'";
            int returnVal = -1;
            try
            {
                con = new MySqlConnection(connectionString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                returnVal = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:\n" + ex.ToString()); 
            }
            
            return returnVal;
       }

        public void SQLReaderClose()
        {

            try
            {
                rdr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:\n" + ex.ToString());
            }
        }
    }
}