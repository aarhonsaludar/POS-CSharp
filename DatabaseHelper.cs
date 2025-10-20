using System;
using MySqlConnector;

namespace POS
{
    public class DatabaseHelper
    {
        private static string connectionString = "Server=localhost;Database=pos_db;Uid=root;Pwd=admin";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
