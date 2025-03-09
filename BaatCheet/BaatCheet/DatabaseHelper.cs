using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BaatCheet
{
    public static class DatabaseHelper 
    {
        private static string connectionString = "server=localhost;database=BaatCheetDB;user=root;password=\"balaaj2135$$\";";

        public static MySqlConnection Connection { get; private set; }
        public static void InitializeConnection() 
        {
            try 
            {
                Connection = new MySqlConnection(connectionString);
                Connection.Open();
                MessageBox.Show("Database Connection Established!");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
