using MySql.Data.MySqlClient;
using System;

namespace Keszobranie
{
    class DBConnection
    {
        private static DBConnection INSTANCE = null;
        public static DBConnection getInstance()
        {
            if(INSTANCE is null)
            {
                INSTANCE = new DBConnection();
            }
            return INSTANCE;
        }
        private DBConnection() { }

        public void ExecuteCommand(uint port, string server, string user, string password, string database)
        {
            MySqlConnectionStringBuilder connectionBuilder = new MySqlConnectionStringBuilder();

            connectionBuilder.Port = port;
            connectionBuilder.Server = server;
            connectionBuilder.UserID = user;
            connectionBuilder.Password = password;
            connectionBuilder.Database = database;

            using (MySqlConnection conn = new MySqlConnection(connectionBuilder.ToString()))
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
                                var x = dataReader["fname"];
                                Console.WriteLine(x);
                            }
                        }
                    }
                    conn.Close();
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine("W zrodlach brak jest hasla - nalezy podac takie jak na zajeciach lab");
                }
            }
            Console.WriteLine("SIngleton");

        }

    }
}
