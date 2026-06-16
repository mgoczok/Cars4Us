namespace Cars4Us.Models
{
    /// <summary>
    /// Represents a dealership/showroom employee.
    /// Used for staff management system.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Unique identifier for the employee.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Employee's first name.
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Employee's last name.
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Job role/position (e.g., "Sales Manager", "Sales Representative", "Service Advisor").
        /// </summary>
        public string Role { get; set; } = string.Empty;

        /// <summary>
        /// Employee's email address (optional).
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Employee's phone number (optional).
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// Indicates whether the employee is currently active in the system.
        /// </summary>
        public bool IsActive { get; set; }
    }
}
