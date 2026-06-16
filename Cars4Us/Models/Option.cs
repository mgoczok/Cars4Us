namespace Cars4Us.Models
{
    /// <summary>
    /// Represents a car option or accessory that can be added to vehicles.
    /// Part of the catalog system and pricing pipeline.
    /// </summary>
    public class Option
    {
        /// <summary>
        /// Unique identifier for the option.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the option/accessory (e.g., "Leather Seats", "Sunroof").
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Category of the option (e.g., "Interior", "Exterior", "Electronics", "Safety").
        /// </summary>
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// Price of the option in currency units.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Indicates whether the option is available for selection.
        /// </summary>
        public bool IsActive { get; set; }
    }
}
