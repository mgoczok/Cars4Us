using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Cars4Us.Models;

namespace Cars4Us.Repositories
{
    /// <summary>
    /// Repository for managing sales transactions in the database.
    /// Uses parameterized queries and DbConnection for all database access.
    /// </summary>
    public class TransactionRepository
    {
        /// <summary>
        /// Retrieves all transactions from the database.
        /// </summary>
        public List<SalesTransaction> GetAll()
        {
            var transactions = new List<SalesTransaction>();
            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"SELECT Id, CarId, CustomerId, EmployeeId, FinalPrice, 
                                        FinancingType, Status, TransactionDate 
                                 FROM transactions 
                                 ORDER BY TransactionDate DESC";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        transactions.Add(MapTransaction(reader));
                    }
                }
            }

            return transactions;
        }

        /// <summary>
        /// Retrieves a single transaction by its Id. Returns null if not found.
        /// </summary>
        public SalesTransaction? GetById(int id)
        {
            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"SELECT Id, CarId, CustomerId, EmployeeId, FinalPrice, 
                                        FinancingType, Status, TransactionDate 
                                 FROM transactions 
                                 WHERE Id = @Id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapTransaction(reader);
                        }
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Adds a new transaction to the database.
        /// Validates all required fields before inserting.
        /// Returns the Id of the newly created transaction.
        /// </summary>
        public int Add(SalesTransaction transaction)
        {
            ValidateTransaction(transaction);

            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO transactions (CarId, CustomerId, EmployeeId, FinalPrice, FinancingType, Status)
                                 VALUES (@CarId, @CustomerId, @EmployeeId, @FinalPrice, @FinancingType, @Status);
                                 SELECT LAST_INSERT_ID();";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CarId", transaction.CarId);
                    cmd.Parameters.AddWithValue("@CustomerId", transaction.CustomerId);
                    cmd.Parameters.AddWithValue("@EmployeeId", transaction.EmployeeId);
                    cmd.Parameters.AddWithValue("@FinalPrice", transaction.FinalPrice);
                    cmd.Parameters.AddWithValue("@FinancingType", transaction.FinancingType);
                    cmd.Parameters.AddWithValue("@Status", string.IsNullOrWhiteSpace(transaction.Status)
                        ? TransactionStatus.Created
                        : transaction.Status);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        /// <summary>
        /// Updates all fields of an existing transaction.
        /// Validates all required fields before updating.
        /// </summary>
        public void Update(SalesTransaction transaction)
        {
            ValidateTransaction(transaction);

            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE transactions 
                                 SET CarId = @CarId, 
                                     CustomerId = @CustomerId, 
                                     EmployeeId = @EmployeeId, 
                                     FinalPrice = @FinalPrice, 
                                     FinancingType = @FinancingType, 
                                     Status = @Status
                                 WHERE Id = @Id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", transaction.Id);
                    cmd.Parameters.AddWithValue("@CarId", transaction.CarId);
                    cmd.Parameters.AddWithValue("@CustomerId", transaction.CustomerId);
                    cmd.Parameters.AddWithValue("@EmployeeId", transaction.EmployeeId);
                    cmd.Parameters.AddWithValue("@FinalPrice", transaction.FinalPrice);
                    cmd.Parameters.AddWithValue("@FinancingType", transaction.FinancingType);
                    cmd.Parameters.AddWithValue("@Status", transaction.Status);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Updates only the status of a transaction.
        /// The new status must be one of the allowed TransactionStatus values.
        /// </summary>
        public void UpdateStatus(int id, string status)
        {
            if (!TransactionStatus.IsValid(status))
                throw new ArgumentException($"Invalid transaction status: '{status}'.");

            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE transactions SET Status = @Status WHERE Id = @Id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Status", status);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Assigns a different employee to an existing transaction.
        /// </summary>
        public void AssignEmployee(int transactionId, int employeeId)
        {
            if (employeeId <= 0)
                throw new ArgumentException("EmployeeId must be greater than 0.");

            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE transactions SET EmployeeId = @EmployeeId WHERE Id = @Id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", transactionId);
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Soft-cancels a transaction by setting its status to 'Cancelled'.
        /// Does not physically delete the record.
        /// </summary>
        public void Cancel(int id)
        {
            UpdateStatus(id, TransactionStatus.Cancelled);
        }

        // ---- Private helpers ----

        /// <summary>
        /// Maps a database row to a SalesTransaction object.
        /// </summary>
        private SalesTransaction MapTransaction(MySqlDataReader reader)
        {
            return new SalesTransaction
            {
                Id = reader.GetInt32("Id"),
                CarId = reader.GetInt32("CarId"),
                CustomerId = reader.GetInt32("CustomerId"),
                EmployeeId = reader.GetInt32("EmployeeId"),
                FinalPrice = reader.GetDecimal("FinalPrice"),
                FinancingType = reader.GetString("FinancingType"),
                Status = reader.GetString("Status"),
                TransactionDate = reader.GetDateTime("TransactionDate")
            };
        }

        /// <summary>
        /// Validates required fields of a SalesTransaction before insert or update.
        /// </summary>
        private void ValidateTransaction(SalesTransaction transaction)
        {
            if (transaction.CarId <= 0)
                throw new ArgumentException("CarId must be greater than 0.");
            if (transaction.CustomerId <= 0)
                throw new ArgumentException("CustomerId must be greater than 0.");
            if (transaction.EmployeeId <= 0)
                throw new ArgumentException("EmployeeId must be greater than 0.");
            if (transaction.FinalPrice <= 0)
                throw new ArgumentException("FinalPrice must be greater than 0.");
            if (string.IsNullOrWhiteSpace(transaction.FinancingType))
                throw new ArgumentException("FinancingType cannot be empty.");
            if (!string.IsNullOrWhiteSpace(transaction.Status) && !TransactionStatus.IsValid(transaction.Status))
                throw new ArgumentException($"Invalid transaction status: '{transaction.Status}'.");
        }
    }
}
