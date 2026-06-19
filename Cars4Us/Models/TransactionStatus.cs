namespace Cars4Us.Models
{
    /// <summary>
    /// Defines the allowed status values for a sales transaction.
    /// </summary>
    public static class TransactionStatus
    {
        public const string Created = "Created";
        public const string Reserved = "Reserved";
        public const string CreditVerification = "CreditVerification";
        public const string Insurance = "Insurance";
        public const string ReadyForRelease = "ReadyForRelease";
        public const string Completed = "Completed";
        public const string Cancelled = "Cancelled";

        /// <summary>
        /// All allowed status values.
        /// </summary>
        public static readonly string[] AllStatuses = new[]
        {
            Created,
            Reserved,
            CreditVerification,
            Insurance,
            ReadyForRelease,
            Completed,
            Cancelled
        };

        /// <summary>
        /// Checks whether the given status string is a valid transaction status.
        /// </summary>
        public static bool IsValid(string status)
        {
            return Array.Exists(AllStatuses, s => s == status);
        }
    }
}
