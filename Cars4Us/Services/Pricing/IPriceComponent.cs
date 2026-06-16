namespace Cars4Us.Services.Pricing
{
    public interface IPriceComponent
    {
        decimal GetPrice();
        string GetBreakdown();
    }
}
