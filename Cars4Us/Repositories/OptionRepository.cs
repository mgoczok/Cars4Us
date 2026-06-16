using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Cars4Us.Models;

namespace Cars4Us.Repositories
{
    public class OptionRepository
    {
        public List<Option> GetAllActive()
        {
            var options = new List<Option>();
            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id, Name, Category, Price, IsActive FROM options WHERE IsActive = 1 ORDER BY Name ASC";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        options.Add(new Option
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Category = reader.GetString("Category"),
                            Price = reader.GetDecimal("Price"),
                            IsActive = reader.GetBoolean("IsActive")
                        });
                    }
                }
            }

            return options;
        }

        public Option? GetById(int id)
        {
            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id, Name, Category, Price, IsActive FROM options WHERE Id = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Option
                            {
                                Id = reader.GetInt32("Id"),
                                Name = reader.GetString("Name"),
                                Category = reader.GetString("Category"),
                                Price = reader.GetDecimal("Price"),
                                IsActive = reader.GetBoolean("IsActive")
                            };
                        }
                    }
                }
            }

            return null;
        }

        public void Add(Option option)
        {
            ValidateOption(option);

            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO options (Name, Category, Price, IsActive) 
                                 VALUES (@name, @category, @price, @isActive)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", option.Name);
                    cmd.Parameters.AddWithValue("@category", option.Category);
                    cmd.Parameters.AddWithValue("@price", option.Price);
                    cmd.Parameters.AddWithValue("@isActive", option.IsActive ? 1 : 0);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Option option)
        {
            ValidateOption(option);

            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE options 
                                 SET Name = @name, Category = @category, Price = @price, IsActive = @isActive 
                                 WHERE Id = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", option.Name);
                    cmd.Parameters.AddWithValue("@category", option.Category);
                    cmd.Parameters.AddWithValue("@price", option.Price);
                    cmd.Parameters.AddWithValue("@isActive", option.IsActive ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id", option.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deactivate(int id)
        {
            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE options SET IsActive = 0 WHERE Id = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void ValidateOption(Option option)
        {
            if (string.IsNullOrWhiteSpace(option.Name))
                throw new ArgumentException("Option Name cannot be empty or whitespace.", nameof(option.Name));

            if (string.IsNullOrWhiteSpace(option.Category))
                throw new ArgumentException("Option Category cannot be empty or whitespace.", nameof(option.Category));

            if (option.Price < 0)
                throw new ArgumentException("Option Price cannot be negative.", nameof(option.Price));
        }
    }
}
