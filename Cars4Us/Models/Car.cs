namespace Cars4Us.Models
{
    /// <summary>
    /// Represents a car in the dealership inventory.
    /// Maps to the 'cars' table in the database.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Unique identifier for the car.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Vehicle Identification Number.
        /// </summary>
        public string VIN { get; set; } = string.Empty;

        /// <summary>
        /// Car brand/make (e.g., "Toyota", "BMW").
        /// </summary>
        public string Brand { get; set; } = string.Empty;

        /// <summary>
        /// Car model (e.g., "Corolla", "X5").
        /// </summary>
        public string Model { get; set; } = string.Empty;

        /// <summary>
        /// Engine type (e.g., "Benzyna", "Diesel", "Elektryczny", "Hybryda").
        /// </summary>
        public string EngineType { get; set; } = string.Empty;

        /// <summary>
        /// Mileage in kilometers.
        /// </summary>
        public int Mileage { get; set; }

        /// <summary>
        /// Base price of the car before options and financing.
        /// </summary>
        public decimal BasePrice { get; set; }

        /// <summary>
        /// Current status of the car (e.g., "Available", "Sold", "Reserved").
        /// </summary>
        public string Status { get; set; } = string.Empty;
    }
}
