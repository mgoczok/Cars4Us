namespace Cars4Us.Services.Pricing
{
    public class LeasingFinancingStrategy : IFinancingStrategy
    {
        public FinancingCalculationResult Calculate(decimal currentPrice)
        {
            return new FinancingCalculationResult
            {
                FinancingCost = currentPrice * 0.03m, // 3%
                InsuranceCost = currentPrice * 0.04m, // 4%
                FinancingType = FinancingType.Leasing
            };
        }
    }
}
