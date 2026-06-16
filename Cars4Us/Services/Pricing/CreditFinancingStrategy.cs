namespace Cars4Us.Services.Pricing
{
    public class CreditFinancingStrategy : IFinancingStrategy
    {
        public FinancingCalculationResult Calculate(decimal currentPrice)
        {
            return new FinancingCalculationResult
            {
                FinancingCost = currentPrice * 0.05m, // 5%
                InsuranceCost = currentPrice * 0.03m, // 3%
                FinancingType = FinancingType.Credit
            };
        }
    }
}
