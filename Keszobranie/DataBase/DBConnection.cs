using MySql.Data.MySqlClient;
using System;

namespace Keszobranie
{
    class DBConnection
    {
        private static DBConnection INSTANCE = null;
        private DBConnection() { }
        public static DBConnection getInstance()
        {
            if(INSTANCE is null)
            {
                INSTANCE = new DBConnection();
            }
            return INSTANCE;
        }
        

        public void ExecuteCommand(uint port, string server, string user, string password, string database, string query)
        {
            MySqlConnectionStringBuilder connectionBuilder = new MySqlConnectionStringBuilder();

            connectionBuilder.Port = port;
            connectionBuilder.Server = server;
            connectionBuilder.UserID = user;
            connectionBuilder.Password = password;
            connectionBuilder.Database = database;

            // albo 

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=geocache;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", conn))
                    {
                        using (var dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                var x = dataReader["email"];
                                Console.WriteLine(x);
                            }
                        }
                    }
                    conn.Close();
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }

    }
}
