namespace Cars4Us.Models
{
    /// <summary>
    /// Represents a car sales transaction.
    /// Maps to the 'transactions' table in the database.
    /// Named SalesTransaction to avoid conflict with System.Transactions.Transaction.
    /// </summary>
    public class SalesTransaction
    {
        /// <summary>
        /// Unique identifier for the transaction.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Foreign key to the car being sold.
        /// </summary>
        public int CarId { get; set; }

        /// <summary>
        /// Foreign key to the customer buying the car.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Foreign key to the employee handling the transaction.
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Final calculated price including options, financing, and discounts.
        /// </summary>
        public decimal FinalPrice { get; set; }

        /// <summary>
        /// Type of financing (e.g., "Cash", "Leasing", "Credit").
        /// </summary>
        public string FinancingType { get; set; } = string.Empty;

        /// <summary>
        /// Current status of the transaction (see TransactionStatus for allowed values).
        /// </summary>
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Date and time when the transaction was created.
        /// </summary>
        public DateTime TransactionDate { get; set; }
    }
}
