using MySql.Data.MySqlClient;

namespace Cars4Us
{
    public class DbConnection
    {
        private string connectionString =
            "server=localhost;database=cars4us;uid=root;pwd=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}