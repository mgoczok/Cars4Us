namespace Cars4Us.Services.Pricing
{
    public class CashFinancingStrategy : IFinancingStrategy
    {
        public FinancingCalculationResult Calculate(decimal currentPrice)
        {
            return new FinancingCalculationResult
            {
                FinancingCost = 0m,
                InsuranceCost = currentPrice * 0.02m, // 2%
                FinancingType = FinancingType.Cash
            };
        }
    }
}
