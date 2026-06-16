namespace Cars4Us.Services.Pricing
{
    public interface IFinancingStrategy
    {
        FinancingCalculationResult Calculate(decimal currentPrice);
    }
}
