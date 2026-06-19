using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Cars4Us.Models;

namespace Cars4Us.Repositories
{
    /// <summary>
    /// Repository for reading customer data from the database.
    /// </summary>
    public class CustomerRepository
    {
        /// <summary>
        /// Retrieves all customers from the database.
        /// </summary>
        public List<Customer> GetAll()
        {
            var customers = new List<Customer>();
            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"SELECT Id, FirstName, LastName, Phone, Email 
                                 FROM customers 
                                 ORDER BY LastName ASC, FirstName ASC";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new Customer
                        {
                            Id = reader.GetInt32("Id"),
                            FirstName = reader.GetString("FirstName"),
                            LastName = reader.GetString("LastName"),
                            Phone = reader.IsDBNull(reader.GetOrdinal("Phone")) ? string.Empty : reader.GetString("Phone"),
                            Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? string.Empty : reader.GetString("Email")
                        });
                    }
                }
            }

            return customers;
        }
    }
}
