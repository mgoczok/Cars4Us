using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Cars4Us.Models;

namespace Cars4Us.Repositories
{
    public class EmployeeRepository
    {
        public List<Employee> GetAllActive()
        {
            var employees = new List<Employee>();
            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id, FirstName, LastName, Role, Email, Phone, IsActive FROM employees WHERE IsActive = 1 ORDER BY LastName ASC, FirstName ASC";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(MapToEmployee(reader));
                    }
                }
            }

            return employees;
        }

        public Employee? GetById(int id)
        {
            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id, FirstName, LastName, Role, Email, Phone, IsActive FROM employees WHERE Id = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapToEmployee(reader);
                        }
                    }
                }
            }

            return null;
        }

        public void Add(Employee employee)
        {
            ValidateEmployee(employee);

            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO employees (FirstName, LastName, Role, Email, Phone, IsActive) 
                                 VALUES (@firstName, @lastName, @role, @email, @phone, @isActive)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", employee.FirstName.Trim());
                    cmd.Parameters.AddWithValue("@lastName", employee.LastName.Trim());
                    cmd.Parameters.AddWithValue("@role", employee.Role.Trim());
                    cmd.Parameters.AddWithValue("@email", string.IsNullOrWhiteSpace(employee.Email) ? DBNull.Value : (object)employee.Email.Trim());
                    cmd.Parameters.AddWithValue("@phone", string.IsNullOrWhiteSpace(employee.Phone) ? DBNull.Value : (object)employee.Phone.Trim());
                    cmd.Parameters.AddWithValue("@isActive", employee.IsActive ? 1 : 0);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Employee employee)
        {
            ValidateEmployee(employee);

            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE employees 
                                 SET FirstName = @firstName, LastName = @lastName, Role = @role, 
                                     Email = @email, Phone = @phone, IsActive = @isActive 
                                 WHERE Id = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", employee.FirstName.Trim());
                    cmd.Parameters.AddWithValue("@lastName", employee.LastName.Trim());
                    cmd.Parameters.AddWithValue("@role", employee.Role.Trim());
                    cmd.Parameters.AddWithValue("@email", string.IsNullOrWhiteSpace(employee.Email) ? DBNull.Value : (object)employee.Email.Trim());
                    cmd.Parameters.AddWithValue("@phone", string.IsNullOrWhiteSpace(employee.Phone) ? DBNull.Value : (object)employee.Phone.Trim());
                    cmd.Parameters.AddWithValue("@isActive", employee.IsActive ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id", employee.Id);

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
                string query = "UPDATE employees SET IsActive = 0 WHERE Id = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Employee> GetActiveSalespeople()
        {
            var employees = new List<Employee>();
            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id, FirstName, LastName, Role, Email, Phone, IsActive FROM employees WHERE IsActive = 1 AND Role = 'Salesperson' ORDER BY LastName ASC, FirstName ASC";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(MapToEmployee(reader));
                    }
                }
            }

            return employees;
        }

        private Employee MapToEmployee(MySqlDataReader reader)
        {
            return new Employee
            {
                Id = reader.GetInt32("Id"),
                FirstName = reader.GetString("FirstName"),
                LastName = reader.GetString("LastName"),
                Role = reader.GetString("Role"),
                Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString("Email"),
                Phone = reader.IsDBNull(reader.GetOrdinal("Phone")) ? null : reader.GetString("Phone"),
                IsActive = reader.GetBoolean("IsActive")
            };
        }

        private void ValidateEmployee(Employee employee)
        {
            if (string.IsNullOrWhiteSpace(employee.FirstName))
                throw new ArgumentException("First Name cannot be empty or whitespace.", nameof(employee.FirstName));

            if (string.IsNullOrWhiteSpace(employee.LastName))
                throw new ArgumentException("Last Name cannot be empty or whitespace.", nameof(employee.LastName));

            if (string.IsNullOrWhiteSpace(employee.Role))
                throw new ArgumentException("Role cannot be empty or whitespace.", nameof(employee.Role));

            string trimmedRole = employee.Role.Trim();
            if (trimmedRole != "Salesperson" && trimmedRole != "Manager" && trimmedRole != "ServiceTechnician")
            {
                throw new ArgumentException("Role must be one of the following: Salesperson, Manager, ServiceTechnician.", nameof(employee.Role));
            }
        }
    }
}
