namespace Cars4Us.Services.Pricing
{
    public class PricingResult
    {
        public decimal BasePrice { get; set; }
        public decimal OptionsCost { get; set; }
        public decimal MarginCost { get; set; }
        public decimal FleetDiscountAmount { get; set; }
        public decimal SeasonalDiscountAmount { get; set; }
        public decimal FinancingCost { get; set; }
        public decimal InsuranceCost { get; set; }
        public decimal FinalPrice { get; set; }
        public FinancingType FinancingType { get; set; }
        public string Breakdown { get; set; } = string.Empty;
    }
}
