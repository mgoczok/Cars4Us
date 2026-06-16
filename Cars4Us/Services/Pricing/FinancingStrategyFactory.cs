using System;

namespace Cars4Us.Services.Pricing
{
    public class FinancingStrategyFactory
    {
        public IFinancingStrategy CreateStrategy(FinancingType financingType)
        {
            return financingType switch
            {
                FinancingType.Cash => new CashFinancingStrategy(),
                FinancingType.Leasing => new LeasingFinancingStrategy(),
                FinancingType.Credit => new CreditFinancingStrategy(),
                _ => throw new ArgumentOutOfRangeException(nameof(financingType), $"Brak obsługi wybranego typu finansowania: {financingType}")
            };
        }
    }
}
