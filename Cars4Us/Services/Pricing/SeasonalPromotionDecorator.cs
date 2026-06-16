namespace Cars4Us.Services.Pricing
{
    public class SeasonalPromotionDecorator : PriceDecorator
    {
        public SeasonalPromotionDecorator(IPriceComponent component) : base(component) { }

        public override decimal GetPrice()
        {
            return base.GetPrice() * 0.97m; // -3%
        }

        public override string GetBreakdown()
        {
            decimal discount = base.GetPrice() * 0.03m;
            return base.GetBreakdown() + $"Promocja sezonowa (3%): -{discount:C}\n";
        }
    }
}
