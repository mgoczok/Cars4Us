namespace Cars4Us.Services.Pricing
{
    public class BaseCarPriceComponent : IPriceComponent
    {
        private readonly decimal _basePrice;

        public BaseCarPriceComponent(decimal basePrice)
        {
            _basePrice = basePrice;
        }

        public decimal GetPrice() => _basePrice;

        public string GetBreakdown() => $"Cena bazowa: {_basePrice:C}\n";
    }
}
