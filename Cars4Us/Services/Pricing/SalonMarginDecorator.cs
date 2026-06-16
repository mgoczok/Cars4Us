namespace Cars4Us.Services.Pricing
{
    public class SalonMarginDecorator : PriceDecorator
    {
        public SalonMarginDecorator(IPriceComponent component) : base(component) { }

        public override decimal GetPrice()
        {
            return base.GetPrice() * 1.08m; // +8%
        }

        public override string GetBreakdown()
        {
            decimal margin = base.GetPrice() * 0.08m;
            return base.GetBreakdown() + $"Marża salonu (8%): +{margin:C}\n";
        }
    }
}
