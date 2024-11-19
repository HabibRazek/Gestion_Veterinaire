using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Gestion_Veterinaire.Helpers
{
    public static class DatabaseHelper
    {
        private static readonly string ConnectionString;

        static DatabaseHelper()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString;

            if (string.IsNullOrEmpty(ConnectionString))
            {
                throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            }
        }

       
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
