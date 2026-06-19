namespace Cars4Us.Models
{
    /// <summary>
    /// Represents a customer in the dealership.
    /// Maps to the 'customers' table in the database.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Unique identifier for the customer.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Customer's first name.
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Customer's last name.
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Customer's phone number.
        /// </summary>
        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// Customer's email address.
        /// </summary>
        public string Email { get; set; } = string.Empty;
    }
}
